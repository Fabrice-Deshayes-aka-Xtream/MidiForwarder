using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Devices;
using MidiForwarder.Properties;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
using NetworkCommsDotNet.Connections.TCP;

namespace MidiForwarder
{
    public partial class MidiForwarderForm : Form
    {
        // true if asyn worker is currently listening events from midi input
        static bool listeningMidiEvents = false;

        // selected input device name
        static String inputDeviceName = null;

        // nb of input devices in list (to manage first population and auto refresh when device is switched on/off)
        static int nbInputDevices = 0;

        // selected output device
        static String outputDeviceName = null;
        static OutputDevice outputDevice = null;

        // nb of output devices in list (to manage first population and auto refresh when device is switched on/off)
        static int nbOutputDevices = 0;

        // last midi event received from source device
        static MidiEvent lastEvent = null;
        static MidiEvent LastDisplayedEvent = null;

        // MidiEvent to/from binary converter for network transport
        static readonly MidiEventToBytesConverter metobc = new MidiEventToBytesConverter();
        static readonly BytesToMidiEventConverter btomec = new BytesToMidiEventConverter();

        // network connection to send midi events to another instance of Midi Forwarder
        static Connection cnx;

        // are we currently listening for midi events from network ?
        static bool listening = false;

        public MidiForwarderForm()
        {
            InitializeComponent();
            EventsListBox.Items.Add("");
            statusStrip.Items[0].Text = "Local IP: " + GetLocalIPAddress() + " / Public IP: " + GetPublicIP();
            ReceivePortTextBox.Text = Settings.Default.receivePort;
            SendToIpTextBox.Text = Settings.Default.sendIp;
            SendToPortTextBox.Text = Settings.Default.sendPort;
            FilterCheckBox_CheckedChanged(null, null); // init midi event types filter bool
        }

        private void InitOrRefreshDevicesList()
        {
            this.SuspendLayout();

            if (InputDevice.GetDevicesCount() != nbInputDevices)
            {
                nbInputDevices = InputDevice.GetDevicesCount();
                InputDevicesComboBox.Items.Clear();
                InputDevicesComboBox.Items.Add("Choose midi input source");
                InputDevicesComboBox.Items.Add("Midi events from network");
                InputDevice.GetAll().ToList().ForEach(inputDevice => InputDevicesComboBox.Items.Add(inputDevice.Name));
                if (inputDeviceName != null && InputDevicesComboBox.Items.Contains(inputDeviceName))
                {
                    InputDevicesComboBox.SelectedItem = inputDeviceName;
                }
                else
                {
                    InputDevicesComboBox.SelectedIndex = 0;
                }
            }

            if (OutputDevice.GetDevicesCount() != nbOutputDevices)
            {
                nbOutputDevices = OutputDevice.GetDevicesCount();
                OutputDevicesComboBox.Items.Clear();
                OutputDevicesComboBox.Items.Add("Choose midi output destination");
                OutputDevicesComboBox.Items.Add("Midi events to network");
                OutputDevice.GetAll().ToList().ForEach(outputDevice => OutputDevicesComboBox.Items.Add(outputDevice.Name));
                if (outputDeviceName != null && OutputDevicesComboBox.Items.Contains(outputDeviceName))
                {
                    OutputDevicesComboBox.SelectedItem = outputDeviceName;
                }
                else
                {
                    OutputDevicesComboBox.SelectedIndex = 0;
                }
            }
            this.ResumeLayout();
        }

        private void MidiEventListener_DoWork(object sender, DoWorkEventArgs e)
        {
            if ("Midi events from network".Equals(inputDeviceName, System.StringComparison.InvariantCulture))
            {
                try
                {
                    NetworkComms.AppendGlobalIncomingPacketHandler<byte[]>("midiEvent", OnNetworkEvent);
                    Connection.StartListening(ConnectionType.TCP, new System.Net.IPEndPoint(System.Net.IPAddress.Any, Int32.Parse(MidiForwarder.Properties.Settings.Default.receivePort)));
                    listening = true;
                    while (listeningMidiEvents)
                    {
                        System.Threading.Thread.Sleep(250);
                    }
                    NetworkComms.RemoveGlobalIncomingPacketHandler<byte[]>("midiEvent", OnNetworkEvent);
                }
                catch (CommsException ce)
                {
                    // set connection to red
                    MessageBox.Show("CommsException occurs : " + ce.Message);
                }
                finally
                {
                    try
                    {
                        NetworkComms.Shutdown();
                    }
                    catch (CommsException ce)
                    {
                        Console.WriteLine("CommsException occurs : " + ce.ToString());
                    }
                    finally
                    {
                        listening = false;
                    }
                }
            }
            else if (inputDeviceName != null)
            {
                using (var inputDevice = InputDevice.GetByName(inputDeviceName))
                {
                    inputDevice.EventReceived += OnEventReceived;
                    inputDevice.StartEventsListening();
                    while (listeningMidiEvents)
                    {
                        System.Threading.Thread.Sleep(250);
                    }
                    inputDevice.StopEventsListening();
                    inputDevice.EventReceived -= OnEventReceived;
                }
            }
        }

        private static void OnNetworkEvent(PacketHeader header, Connection connection, byte[] binaryMidiEvent)
        {
            MidiEvent midiEvent = btomec.Convert(binaryMidiEvent);
            ForwardEvent(midiEvent);
        }

        private void OnEventReceived(object sender, MidiEventReceivedEventArgs e)
        {
            ForwardEvent(e.Event);
        }

        private static void ForwardEvent(MidiEvent midiEvent)
        {
            if (MustFilterEvent(midiEvent)) return;

            lastEvent = midiEvent;
            if ("Midi events to network".Equals(outputDeviceName, System.StringComparison.InvariantCulture))
            {
                try
                {
                    if (cnx != null)
                    {
                        cnx.SendObject("midiEvent", metobc.Convert(midiEvent));
                    }
                    else
                    {
                        MessageBox.Show("connection to receiver is not etablished!");
                    }
                }
                catch (CommsException ce)
                {
                    // TODO when connection is lost, this message always occur and cnx is not closed
                    Console.WriteLine("CommsException occurs : " + ce.Message);
                }
            }
            else
            {
                if (outputDevice != null)
                {
                    outputDevice.SendEvent(midiEvent);
                }
            }
        }

        private void InputDevicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InputDevicesComboBox.SelectedIndex != 0)
            {
                inputDeviceName = InputDevicesComboBox.SelectedItem.ToString();
            }
            else
            {
                inputDeviceName = null;

            }

            if (MidiEventListenerWorker.IsBusy)
            {
                listeningMidiEvents = false;
                MidiEventListenerWorker.CancelAsync();
            }
        }

        private void OutputDevicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectedLabel.Visible = false;

            if (outputDevice != null)
            {
                outputDevice.Dispose();
            }

            if (cnx != null)
            {
                cnx.Dispose();
            }

            if (OutputDevicesComboBox.SelectedIndex == 0)
            {
                outputDeviceName = null;
            }
            else
            {
                outputDeviceName = OutputDevicesComboBox.SelectedItem.ToString();
            }

            if (OutputDevicesComboBox.SelectedIndex > 1)
            {
                outputDevice = OutputDevice.GetByName(outputDeviceName);
            }
            else if (OutputDevicesComboBox.SelectedIndex == 1)
            {
                // init connection to other instance of Midi Forwarder
                try
                {
                    ConnectingLabel.Visible = true;
                    ConnectionInfo connInfo = new ConnectionInfo(MidiForwarder.Properties.Settings.Default.sendIp, Int32.Parse(MidiForwarder.Properties.Settings.Default.sendPort));
                    cnx = TCPConnection.GetConnection(connInfo);
                    ConnectingLabel.Visible = false;
                    ConnectedLabel.Visible = true;
                }
                catch (CommsException ce)
                {
                    ConnectingLabel.Visible = false;
                    MessageBox.Show("CommsException occurs : " + ce.Message);
                }
            }
        }

        private void SlowRefreshUITimer_Tick(object sender, EventArgs e)
        {
            InitOrRefreshDevicesList();

            if (inputDeviceName != null && !MidiEventListenerWorker.IsBusy)
            {
                listeningMidiEvents = true;
                MidiEventListenerWorker.RunWorkerAsync();

            }

            if (listening)
            {
                ListeningLabel.Visible = !ListeningLabel.Visible;
            }
            else
            {
                ListeningLabel.Visible = false;
            }
        }

        private void FastRefreshUITimer_Tick(object sender, EventArgs e)
        {
            // do not add event to event log if there is no new one
            if (LastDisplayedEvent == lastEvent) return;

            string displayEvtStr;
            if (outputDeviceName == null)
            {
                displayEvtStr = $"{inputDeviceName}: {lastEvent}";

            }
            else
            {
                displayEvtStr = $"{inputDeviceName} -> {outputDeviceName}: {lastEvent}";
            }

            EventsListBox.Items.Insert(0, displayEvtStr);
            if (EventsListBox.Items.Count > 100) EventsListBox.Items.RemoveAt(EventsListBox.Items.Count - 1);

            LastDisplayedEvent = lastEvent;
        }

        private static bool MustFilterEvent(MidiEvent midiEvent)
        {
            if (midiEvent != null)
            {
                switch (midiEvent.EventType)
                {
                    case MidiEventType.NormalSysEx: if (Settings.Default.FilterNormalSysEx) return true; break;
                    case MidiEventType.EscapeSysEx: if (Settings.Default.FilterEscapeSysEx) return true; break;
                    case MidiEventType.SequenceNumber: if (Settings.Default.FilterSequenceNumber) return true; break;
                    case MidiEventType.Text: if (Settings.Default.FilterText) return true; break;
                    case MidiEventType.CopyrightNotice: if (Settings.Default.FilterCopyrightNotice) return true; break;
                    case MidiEventType.SequenceTrackName: if (Settings.Default.FilterSequenceTrackName) return true; break;
                    case MidiEventType.InstrumentName: if (Settings.Default.FilterInstrumentName) return true; break;
                    case MidiEventType.Lyric: if (Settings.Default.FilterLyric) return true; break;
                    case MidiEventType.Marker: if (Settings.Default.FilterMarker) return true; break;
                    case MidiEventType.CuePoint: if (Settings.Default.FilterCuePoint) return true; break;
                    case MidiEventType.ProgramName: if (Settings.Default.FilterProgramName) return true; break;
                    case MidiEventType.DeviceName: if (Settings.Default.FilterDeviceName) return true; break;
                    case MidiEventType.ChannelPrefix: if (Settings.Default.FilterChannelPrefix) return true; break;
                    case MidiEventType.PortPrefix: if (Settings.Default.FilterPortPrefix) return true; break;
                    case MidiEventType.EndOfTrack: if (Settings.Default.FilterEndOfTrack) return true; break;
                    case MidiEventType.SetTempo: if (Settings.Default.FilterSetTempo) return true; break;
                    case MidiEventType.SmpteOffset: if (Settings.Default.FilterSmpteOffset) return true; break;
                    case MidiEventType.TimeSignature: if (Settings.Default.FilterTimeSignature) return true; break;
                    case MidiEventType.KeySignature: if (Settings.Default.FilterKeySignature) return true; break;
                    case MidiEventType.SequencerSpecific: if (Settings.Default.FilterSequencerSpecific) return true; break;
                    case MidiEventType.UnknownMeta: if (Settings.Default.FilterUnknownMeta) return true; break;
                    case MidiEventType.CustomMeta: if (Settings.Default.FilterCustomMeta) return true; break;
                    case MidiEventType.NoteOff: if (Settings.Default.FilterNoteOff) return true; break;
                    case MidiEventType.NoteOn: if (Settings.Default.FilterNoteOn) return true; break;
                    case MidiEventType.NoteAftertouch: if (Settings.Default.FilterNoteAftertouch) return true; break;
                    case MidiEventType.ControlChange: if (Settings.Default.FilterControlChange) return true; break;
                    case MidiEventType.ProgramChange: if (Settings.Default.FilterProgramChange) return true; break;
                    case MidiEventType.ChannelAftertouch: if (Settings.Default.FilterChannelAftertouch) return true; break;
                    case MidiEventType.PitchBend: if (Settings.Default.FilterPitchBend) return true; break;
                    case MidiEventType.TimingClock: if (Settings.Default.FilterTimingClock) return true; break;
                    case MidiEventType.Start: if (Settings.Default.FilterStart) return true; break;
                    case MidiEventType.Continue: if (Settings.Default.FilterContinue) return true; break;
                    case MidiEventType.Stop: if (Settings.Default.FilterStop) return true; break;
                    case MidiEventType.ActiveSensing: if (Settings.Default.FilterActiveSensing) return true; break;
                    case MidiEventType.Reset: if (Settings.Default.FilterReset) return true; break;
                    case MidiEventType.MidiTimeCode: if (Settings.Default.FilterMidiTimeCode) return true; break;
                    case MidiEventType.SongPositionPointer: if (Settings.Default.FilterSongPositionPointer) return true; break;
                    case MidiEventType.SongSelect: if (Settings.Default.FilterSongSelect) return true; break;
                    case MidiEventType.TuneRequest: if (Settings.Default.FilterTuneRequest) return true; break;
                    default: return false;
                }
            }
            return false;
        }

        private void NoteOffButton_Click(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.SendEvent(new ResetEvent());
                for (Byte i = 0; i < 128; i++)
                {
                    outputDevice.SendEvent(new NoteOffEvent(new SevenBitNumber(i), new SevenBitNumber(0)));
                }
            }
        }

        private void MidiForwarderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
            NetworkComms.Shutdown();
        }

        private void ApplyNetworkConfigButton_Click(object sender, EventArgs e)
        {
            if (InputDevicesComboBox.SelectedIndex == 1) InputDevicesComboBox.SelectedIndex = 0;
            if (OutputDevicesComboBox.SelectedIndex == 1) OutputDevicesComboBox.SelectedIndex = 0;

            Settings.Default.receivePort = ReceivePortTextBox.Text;
            Settings.Default.sendIp = SendToIpTextBox.Text;
            Settings.Default.sendPort = SendToPortTextBox.Text;

        }

        // return ip adress of local machine
        private static string GetLocalIPAddress()
        {
            string localIP;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            return localIP;
        }

        private static string GetPublicIP()
        {
            try
            {
                String direction = "";
                WebRequest request = WebRequest.Create(new Uri("http://checkip.dyndns.org/"));
                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                    {
                        direction = stream.ReadToEnd();
                    }
                }

                //Search for the ip in the html
                int first = direction.IndexOf("Address: ", System.StringComparison.InvariantCulture) + 9;
                int last = direction.LastIndexOf("</body>", System.StringComparison.InvariantCulture);
                direction = direction.Substring(first, last - first);

                return direction;
            }
            catch (Exception)
            {
                return "not foud";
            }
        }

        private void FilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.FilterNormalSysEx = NormalSysExCheckBox.Checked;
            Settings.Default.FilterEscapeSysEx = EscapeSysExCheckBox.Checked;
            Settings.Default.FilterSequenceNumber = SequenceNumberCheckBox.Checked;
            Settings.Default.FilterText = TextCheckBox.Checked;
            Settings.Default.FilterCopyrightNotice = CopyrightNoticeCheckBox.Checked;
            Settings.Default.FilterSequenceTrackName = SequenceTrackNameCheckBox.Checked;
            Settings.Default.FilterInstrumentName = InstrumentNameCheckBox.Checked;
            Settings.Default.FilterLyric = LyricCheckBox.Checked;
            Settings.Default.FilterMarker = MarkerCheckBox.Checked;
            Settings.Default.FilterCuePoint = CuePointCheckBox.Checked;
            Settings.Default.FilterProgramName = ProgramNameCheckBox.Checked;
            Settings.Default.FilterDeviceName = DeviceNameCheckBox.Checked;
            Settings.Default.FilterChannelPrefix = ChannelPrefixCheckBox.Checked;
            Settings.Default.FilterPortPrefix = PortPrefixCheckBox.Checked;
            Settings.Default.FilterEndOfTrack = EndOfTrackCheckBox.Checked;
            Settings.Default.FilterSetTempo = SetTempoCheckBox.Checked;
            Settings.Default.FilterSmpteOffset = SmpteOffsetCheckBox.Checked;
            Settings.Default.FilterTimeSignature = TimeSignatureCheckBox.Checked;
            Settings.Default.FilterKeySignature = KeySignatureCheckBox.Checked;
            Settings.Default.FilterSequencerSpecific = SequencerSpecificCheckBox.Checked;
            Settings.Default.FilterUnknownMeta = UnknownMetaCheckBox.Checked;
            Settings.Default.FilterCustomMeta = CustomMetaCheckBox.Checked;
            Settings.Default.FilterNoteOff = NoteOffCheckBox.Checked;
            Settings.Default.FilterNoteOn = NoteOnCheckBox.Checked;
            Settings.Default.FilterNoteAftertouch = NoteAftertouchCheckBox.Checked;
            Settings.Default.FilterControlChange = ControlChangeCheckBox.Checked;
            Settings.Default.FilterProgramChange = ProgramChangeCheckBox.Checked;
            Settings.Default.FilterChannelAftertouch = ChannelAftertouchCheckBox.Checked;
            Settings.Default.FilterPitchBend = PitchBendCheckBox.Checked;
            Settings.Default.FilterTimingClock = TimingClockCheckBox.Checked;
            Settings.Default.FilterStart = StartCheckBox.Checked;
            Settings.Default.FilterContinue = ContinueCheckBox.Checked;
            Settings.Default.FilterStop = StopCheckBox.Checked;
            Settings.Default.FilterActiveSensing = ActiveSensingCheckBox.Checked;
            Settings.Default.FilterReset = ResetCheckBox.Checked;
            Settings.Default.FilterMidiTimeCode = MidiTimeCodeCheckBox.Checked;
            Settings.Default.FilterSongPositionPointer = SongPositionPointerCheckBox.Checked;
            Settings.Default.FilterSongSelect = SongSelectCheckBox.Checked;
            Settings.Default.FilterTuneRequest = TuneRequestCheckBox.Checked;
        }

        private void DisplayChangelogButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/Fabrice-Deshayes-aka-Xtream/MidiForwarder/blob/master/CHANGELOG.md");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error occured : " + exception.Message + ". You may not have defined a windows default web browser");
            }
        }
    }
}