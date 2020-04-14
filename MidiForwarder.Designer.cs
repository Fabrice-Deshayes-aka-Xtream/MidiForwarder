namespace MidiForwarder
{
    partial class MidiForwarderForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MidiForwarderForm));
            this.InputDevicesComboBox = new System.Windows.Forms.ComboBox();
            this.OutputDevicesComboBox = new System.Windows.Forms.ComboBox();
            this.MidiEventListenerWorker = new System.ComponentModel.BackgroundWorker();
            this.SlowRefreshUITimer = new System.Windows.Forms.Timer(this.components);
            this.FastRefreshUITimer = new System.Windows.Forms.Timer(this.components);
            this.labelForwarder = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.IpLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.ConnectingLabel = new System.Windows.Forms.Label();
            this.ConnectedLabel = new System.Windows.Forms.Label();
            this.ListeningLabel = new System.Windows.Forms.Label();
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.TabbedPanels = new System.Windows.Forms.TabControl();
            this.MidiMonitorTab = new System.Windows.Forms.TabPage();
            this.EventsListBox = new System.Windows.Forms.ListBox();
            this.NetworkConfigTab = new System.Windows.Forms.TabPage();
            this.ApplyNetworkConfigButton = new System.Windows.Forms.Button();
            this.SendGroupBox = new System.Windows.Forms.GroupBox();
            this.SendToPortLabel = new System.Windows.Forms.Label();
            this.SendToPortTextBox = new System.Windows.Forms.TextBox();
            this.SendToIpLabel = new System.Windows.Forms.Label();
            this.SendToIpTextBox = new System.Windows.Forms.TextBox();
            this.ReceiveGroupBox = new System.Windows.Forms.GroupBox();
            this.ReceivePortLabel = new System.Windows.Forms.Label();
            this.ReceivePortTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EventFilterTab = new System.Windows.Forms.TabPage();
            this.SongPositionPointerCheckBox = new System.Windows.Forms.CheckBox();
            this.SongSelectCheckBox = new System.Windows.Forms.CheckBox();
            this.TuneRequestCheckBox = new System.Windows.Forms.CheckBox();
            this.ContinueCheckBox = new System.Windows.Forms.CheckBox();
            this.MidiTimeCodeCheckBox = new System.Windows.Forms.CheckBox();
            this.ResetCheckBox = new System.Windows.Forms.CheckBox();
            this.ActiveSensingCheckBox = new System.Windows.Forms.CheckBox();
            this.StopCheckBox = new System.Windows.Forms.CheckBox();
            this.StartCheckBox = new System.Windows.Forms.CheckBox();
            this.TimingClockCheckBox = new System.Windows.Forms.CheckBox();
            this.ProgramChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.CustomMetaCheckBox = new System.Windows.Forms.CheckBox();
            this.NoteAftertouchCheckBox = new System.Windows.Forms.CheckBox();
            this.KeySignatureCheckBox = new System.Windows.Forms.CheckBox();
            this.SequencerSpecificCheckBox = new System.Windows.Forms.CheckBox();
            this.UnknownMetaCheckBox = new System.Windows.Forms.CheckBox();
            this.PortPrefixCheckBox = new System.Windows.Forms.CheckBox();
            this.TimeSignatureCheckBox = new System.Windows.Forms.CheckBox();
            this.SmpteOffsetCheckBox = new System.Windows.Forms.CheckBox();
            this.SetTempoCheckBox = new System.Windows.Forms.CheckBox();
            this.EndOfTrackCheckBox = new System.Windows.Forms.CheckBox();
            this.ChannelPrefixCheckBox = new System.Windows.Forms.CheckBox();
            this.DeviceNameCheckBox = new System.Windows.Forms.CheckBox();
            this.ProgramNameCheckBox = new System.Windows.Forms.CheckBox();
            this.MarkerCheckBox = new System.Windows.Forms.CheckBox();
            this.CuePointCheckBox = new System.Windows.Forms.CheckBox();
            this.TextCheckBox = new System.Windows.Forms.CheckBox();
            this.InstrumentNameCheckBox = new System.Windows.Forms.CheckBox();
            this.LyricCheckBox = new System.Windows.Forms.CheckBox();
            this.CopyrightNoticeCheckBox = new System.Windows.Forms.CheckBox();
            this.SequenceTrackNameCheckBox = new System.Windows.Forms.CheckBox();
            this.SequenceNumberCheckBox = new System.Windows.Forms.CheckBox();
            this.EscapeSysExCheckBox = new System.Windows.Forms.CheckBox();
            this.NormalSysExCheckBox = new System.Windows.Forms.CheckBox();
            this.ControlChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.PitchBendCheckBox = new System.Windows.Forms.CheckBox();
            this.ChannelAftertouchCheckBox = new System.Windows.Forms.CheckBox();
            this.NoteOnCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterEventsLabel = new System.Windows.Forms.Label();
            this.NoteOffCheckBox = new System.Windows.Forms.CheckBox();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DisplayChangelogButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NoteOffButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            this.upperPanel.SuspendLayout();
            this.lowerPanel.SuspendLayout();
            this.TabbedPanels.SuspendLayout();
            this.MidiMonitorTab.SuspendLayout();
            this.NetworkConfigTab.SuspendLayout();
            this.SendGroupBox.SuspendLayout();
            this.ReceiveGroupBox.SuspendLayout();
            this.EventFilterTab.SuspendLayout();
            this.AboutTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // InputDevicesComboBox
            // 
            this.InputDevicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputDevicesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDevicesComboBox.FormattingEnabled = true;
            this.InputDevicesComboBox.Location = new System.Drawing.Point(14, 118);
            this.InputDevicesComboBox.Name = "InputDevicesComboBox";
            this.InputDevicesComboBox.Size = new System.Drawing.Size(385, 28);
            this.InputDevicesComboBox.TabIndex = 0;
            this.InputDevicesComboBox.SelectedIndexChanged += new System.EventHandler(this.InputDevicesComboBox_SelectedIndexChanged);
            // 
            // OutputDevicesComboBox
            // 
            this.OutputDevicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OutputDevicesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputDevicesComboBox.FormattingEnabled = true;
            this.OutputDevicesComboBox.Location = new System.Drawing.Point(14, 156);
            this.OutputDevicesComboBox.Name = "OutputDevicesComboBox";
            this.OutputDevicesComboBox.Size = new System.Drawing.Size(385, 28);
            this.OutputDevicesComboBox.TabIndex = 1;
            this.OutputDevicesComboBox.SelectedIndexChanged += new System.EventHandler(this.OutputDevicesComboBox_SelectedIndexChanged);
            // 
            // MidiEventListenerWorker
            // 
            this.MidiEventListenerWorker.WorkerSupportsCancellation = true;
            this.MidiEventListenerWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MidiEventListener_DoWork);
            // 
            // SlowRefreshUITimer
            // 
            this.SlowRefreshUITimer.Enabled = true;
            this.SlowRefreshUITimer.Interval = 500;
            this.SlowRefreshUITimer.Tick += new System.EventHandler(this.SlowRefreshUITimer_Tick);
            // 
            // FastRefreshUITimer
            // 
            this.FastRefreshUITimer.Enabled = true;
            this.FastRefreshUITimer.Interval = 10;
            this.FastRefreshUITimer.Tick += new System.EventHandler(this.FastRefreshUITimer_Tick);
            // 
            // labelForwarder
            // 
            this.labelForwarder.AutoSize = true;
            this.labelForwarder.BackColor = System.Drawing.Color.Transparent;
            this.labelForwarder.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForwarder.Location = new System.Drawing.Point(320, 51);
            this.labelForwarder.Name = "labelForwarder";
            this.labelForwarder.Size = new System.Drawing.Size(187, 33);
            this.labelForwarder.TabIndex = 5;
            this.labelForwarder.Text = "FORWARDER";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IpLabel});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 571);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(508, 20);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip";
            // 
            // IpLabel
            // 
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(45, 15);
            this.IpLabel.Text = "IpLabel";
            this.IpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // upperPanel
            // 
            this.upperPanel.Controls.Add(this.ConnectingLabel);
            this.upperPanel.Controls.Add(this.ConnectedLabel);
            this.upperPanel.Controls.Add(this.ListeningLabel);
            this.upperPanel.Controls.Add(this.pictureBox1);
            this.upperPanel.Controls.Add(this.labelForwarder);
            this.upperPanel.Controls.Add(this.InputDevicesComboBox);
            this.upperPanel.Controls.Add(this.OutputDevicesComboBox);
            this.upperPanel.Controls.Add(this.NoteOffButton);
            this.upperPanel.Controls.Add(this.pictureBox2);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(508, 198);
            this.upperPanel.TabIndex = 9;
            // 
            // ConnectingLabel
            // 
            this.ConnectingLabel.AutoSize = true;
            this.ConnectingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ConnectingLabel.Location = new System.Drawing.Point(405, 164);
            this.ConnectingLabel.Name = "ConnectingLabel";
            this.ConnectingLabel.Size = new System.Drawing.Size(69, 13);
            this.ConnectingLabel.TabIndex = 9;
            this.ConnectingLabel.Text = "connecting...";
            this.ConnectingLabel.Visible = false;
            // 
            // ConnectedLabel
            // 
            this.ConnectedLabel.AutoSize = true;
            this.ConnectedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ConnectedLabel.Location = new System.Drawing.Point(405, 164);
            this.ConnectedLabel.Name = "ConnectedLabel";
            this.ConnectedLabel.Size = new System.Drawing.Size(58, 13);
            this.ConnectedLabel.TabIndex = 8;
            this.ConnectedLabel.Text = "connected";
            this.ConnectedLabel.Visible = false;
            // 
            // ListeningLabel
            // 
            this.ListeningLabel.AutoSize = true;
            this.ListeningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ListeningLabel.Location = new System.Drawing.Point(405, 127);
            this.ListeningLabel.Name = "ListeningLabel";
            this.ListeningLabel.Size = new System.Drawing.Size(54, 13);
            this.ListeningLabel.TabIndex = 7;
            this.ListeningLabel.Text = "listening...";
            this.ListeningLabel.Visible = false;
            // 
            // lowerPanel
            // 
            this.lowerPanel.Controls.Add(this.TabbedPanels);
            this.lowerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerPanel.Location = new System.Drawing.Point(0, 198);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(508, 373);
            this.lowerPanel.TabIndex = 10;
            // 
            // TabbedPanels
            // 
            this.TabbedPanels.Controls.Add(this.MidiMonitorTab);
            this.TabbedPanels.Controls.Add(this.NetworkConfigTab);
            this.TabbedPanels.Controls.Add(this.EventFilterTab);
            this.TabbedPanels.Controls.Add(this.AboutTab);
            this.TabbedPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabbedPanels.Location = new System.Drawing.Point(0, 0);
            this.TabbedPanels.Name = "TabbedPanels";
            this.TabbedPanels.SelectedIndex = 0;
            this.TabbedPanels.Size = new System.Drawing.Size(508, 373);
            this.TabbedPanels.TabIndex = 7;
            // 
            // MidiMonitorTab
            // 
            this.MidiMonitorTab.Controls.Add(this.EventsListBox);
            this.MidiMonitorTab.Location = new System.Drawing.Point(4, 22);
            this.MidiMonitorTab.Name = "MidiMonitorTab";
            this.MidiMonitorTab.Padding = new System.Windows.Forms.Padding(3);
            this.MidiMonitorTab.Size = new System.Drawing.Size(500, 347);
            this.MidiMonitorTab.TabIndex = 0;
            this.MidiMonitorTab.Text = "Midi monitor";
            this.MidiMonitorTab.UseVisualStyleBackColor = true;
            // 
            // EventsListBox
            // 
            this.EventsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.Location = new System.Drawing.Point(3, 3);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.Size = new System.Drawing.Size(494, 341);
            this.EventsListBox.TabIndex = 9;
            // 
            // NetworkConfigTab
            // 
            this.NetworkConfigTab.Controls.Add(this.ApplyNetworkConfigButton);
            this.NetworkConfigTab.Controls.Add(this.SendGroupBox);
            this.NetworkConfigTab.Controls.Add(this.ReceiveGroupBox);
            this.NetworkConfigTab.Controls.Add(this.label1);
            this.NetworkConfigTab.Location = new System.Drawing.Point(4, 22);
            this.NetworkConfigTab.Name = "NetworkConfigTab";
            this.NetworkConfigTab.Padding = new System.Windows.Forms.Padding(3);
            this.NetworkConfigTab.Size = new System.Drawing.Size(500, 347);
            this.NetworkConfigTab.TabIndex = 1;
            this.NetworkConfigTab.Text = "Network config";
            this.NetworkConfigTab.UseVisualStyleBackColor = true;
            // 
            // ApplyNetworkConfigButton
            // 
            this.ApplyNetworkConfigButton.Location = new System.Drawing.Point(13, 247);
            this.ApplyNetworkConfigButton.Name = "ApplyNetworkConfigButton";
            this.ApplyNetworkConfigButton.Size = new System.Drawing.Size(479, 23);
            this.ApplyNetworkConfigButton.TabIndex = 5;
            this.ApplyNetworkConfigButton.Text = "apply";
            this.ApplyNetworkConfigButton.UseVisualStyleBackColor = true;
            this.ApplyNetworkConfigButton.Click += new System.EventHandler(this.ApplyNetworkConfigButton_Click);
            // 
            // SendGroupBox
            // 
            this.SendGroupBox.Controls.Add(this.SendToPortLabel);
            this.SendGroupBox.Controls.Add(this.SendToPortTextBox);
            this.SendGroupBox.Controls.Add(this.SendToIpLabel);
            this.SendGroupBox.Controls.Add(this.SendToIpTextBox);
            this.SendGroupBox.Location = new System.Drawing.Point(253, 140);
            this.SendGroupBox.Name = "SendGroupBox";
            this.SendGroupBox.Size = new System.Drawing.Size(239, 100);
            this.SendGroupBox.TabIndex = 4;
            this.SendGroupBox.TabStop = false;
            this.SendGroupBox.Text = "To send midi events";
            // 
            // SendToPortLabel
            // 
            this.SendToPortLabel.AutoSize = true;
            this.SendToPortLabel.Location = new System.Drawing.Point(6, 52);
            this.SendToPortLabel.Name = "SendToPortLabel";
            this.SendToPortLabel.Size = new System.Drawing.Size(65, 13);
            this.SendToPortLabel.TabIndex = 6;
            this.SendToPortLabel.Text = "Send to port";
            // 
            // SendToPortTextBox
            // 
            this.SendToPortTextBox.Location = new System.Drawing.Point(77, 49);
            this.SendToPortTextBox.Name = "SendToPortTextBox";
            this.SendToPortTextBox.Size = new System.Drawing.Size(50, 20);
            this.SendToPortTextBox.TabIndex = 5;
            this.SendToPortTextBox.Text = "1666";
            // 
            // SendToIpLabel
            // 
            this.SendToIpLabel.AutoSize = true;
            this.SendToIpLabel.Location = new System.Drawing.Point(6, 26);
            this.SendToIpLabel.Name = "SendToIpLabel";
            this.SendToIpLabel.Size = new System.Drawing.Size(57, 13);
            this.SendToIpLabel.TabIndex = 4;
            this.SendToIpLabel.Text = "Send to IP";
            // 
            // SendToIpTextBox
            // 
            this.SendToIpTextBox.Location = new System.Drawing.Point(77, 23);
            this.SendToIpTextBox.Name = "SendToIpTextBox";
            this.SendToIpTextBox.Size = new System.Drawing.Size(100, 20);
            this.SendToIpTextBox.TabIndex = 3;
            this.SendToIpTextBox.Text = "x.x.x.x";
            // 
            // ReceiveGroupBox
            // 
            this.ReceiveGroupBox.Controls.Add(this.ReceivePortLabel);
            this.ReceiveGroupBox.Controls.Add(this.ReceivePortTextBox);
            this.ReceiveGroupBox.Location = new System.Drawing.Point(10, 140);
            this.ReceiveGroupBox.Name = "ReceiveGroupBox";
            this.ReceiveGroupBox.Size = new System.Drawing.Size(239, 100);
            this.ReceiveGroupBox.TabIndex = 3;
            this.ReceiveGroupBox.TabStop = false;
            this.ReceiveGroupBox.Text = "To receive midi events";
            // 
            // ReceivePortLabel
            // 
            this.ReceivePortLabel.AutoSize = true;
            this.ReceivePortLabel.Location = new System.Drawing.Point(6, 26);
            this.ReceivePortLabel.Name = "ReceivePortLabel";
            this.ReceivePortLabel.Size = new System.Drawing.Size(68, 13);
            this.ReceivePortLabel.TabIndex = 4;
            this.ReceivePortLabel.Text = "Receive port";
            // 
            // ReceivePortTextBox
            // 
            this.ReceivePortTextBox.Location = new System.Drawing.Point(80, 23);
            this.ReceivePortTextBox.Name = "ReceivePortTextBox";
            this.ReceivePortTextBox.Size = new System.Drawing.Size(50, 20);
            this.ReceivePortTextBox.TabIndex = 3;
            this.ReceivePortTextBox.Text = "1666";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 130);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // EventFilterTab
            // 
            this.EventFilterTab.Controls.Add(this.SongPositionPointerCheckBox);
            this.EventFilterTab.Controls.Add(this.SongSelectCheckBox);
            this.EventFilterTab.Controls.Add(this.TuneRequestCheckBox);
            this.EventFilterTab.Controls.Add(this.ContinueCheckBox);
            this.EventFilterTab.Controls.Add(this.MidiTimeCodeCheckBox);
            this.EventFilterTab.Controls.Add(this.ResetCheckBox);
            this.EventFilterTab.Controls.Add(this.ActiveSensingCheckBox);
            this.EventFilterTab.Controls.Add(this.StopCheckBox);
            this.EventFilterTab.Controls.Add(this.StartCheckBox);
            this.EventFilterTab.Controls.Add(this.TimingClockCheckBox);
            this.EventFilterTab.Controls.Add(this.ProgramChangeCheckBox);
            this.EventFilterTab.Controls.Add(this.CustomMetaCheckBox);
            this.EventFilterTab.Controls.Add(this.NoteAftertouchCheckBox);
            this.EventFilterTab.Controls.Add(this.KeySignatureCheckBox);
            this.EventFilterTab.Controls.Add(this.SequencerSpecificCheckBox);
            this.EventFilterTab.Controls.Add(this.UnknownMetaCheckBox);
            this.EventFilterTab.Controls.Add(this.PortPrefixCheckBox);
            this.EventFilterTab.Controls.Add(this.TimeSignatureCheckBox);
            this.EventFilterTab.Controls.Add(this.SmpteOffsetCheckBox);
            this.EventFilterTab.Controls.Add(this.SetTempoCheckBox);
            this.EventFilterTab.Controls.Add(this.EndOfTrackCheckBox);
            this.EventFilterTab.Controls.Add(this.ChannelPrefixCheckBox);
            this.EventFilterTab.Controls.Add(this.DeviceNameCheckBox);
            this.EventFilterTab.Controls.Add(this.ProgramNameCheckBox);
            this.EventFilterTab.Controls.Add(this.MarkerCheckBox);
            this.EventFilterTab.Controls.Add(this.CuePointCheckBox);
            this.EventFilterTab.Controls.Add(this.TextCheckBox);
            this.EventFilterTab.Controls.Add(this.InstrumentNameCheckBox);
            this.EventFilterTab.Controls.Add(this.LyricCheckBox);
            this.EventFilterTab.Controls.Add(this.CopyrightNoticeCheckBox);
            this.EventFilterTab.Controls.Add(this.SequenceTrackNameCheckBox);
            this.EventFilterTab.Controls.Add(this.SequenceNumberCheckBox);
            this.EventFilterTab.Controls.Add(this.EscapeSysExCheckBox);
            this.EventFilterTab.Controls.Add(this.NormalSysExCheckBox);
            this.EventFilterTab.Controls.Add(this.ControlChangeCheckBox);
            this.EventFilterTab.Controls.Add(this.PitchBendCheckBox);
            this.EventFilterTab.Controls.Add(this.ChannelAftertouchCheckBox);
            this.EventFilterTab.Controls.Add(this.NoteOnCheckBox);
            this.EventFilterTab.Controls.Add(this.FilterEventsLabel);
            this.EventFilterTab.Controls.Add(this.NoteOffCheckBox);
            this.EventFilterTab.Location = new System.Drawing.Point(4, 22);
            this.EventFilterTab.Name = "EventFilterTab";
            this.EventFilterTab.Padding = new System.Windows.Forms.Padding(3);
            this.EventFilterTab.Size = new System.Drawing.Size(500, 347);
            this.EventFilterTab.TabIndex = 3;
            this.EventFilterTab.Text = "Events filter";
            this.EventFilterTab.UseVisualStyleBackColor = true;
            // 
            // SongPositionPointerCheckBox
            // 
            this.SongPositionPointerCheckBox.AutoSize = true;
            this.SongPositionPointerCheckBox.Location = new System.Drawing.Point(339, 271);
            this.SongPositionPointerCheckBox.Name = "SongPositionPointerCheckBox";
            this.SongPositionPointerCheckBox.Size = new System.Drawing.Size(121, 17);
            this.SongPositionPointerCheckBox.TabIndex = 45;
            this.SongPositionPointerCheckBox.Text = "SongPositionPointer";
            this.SongPositionPointerCheckBox.UseVisualStyleBackColor = true;
            this.SongPositionPointerCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // SongSelectCheckBox
            // 
            this.SongSelectCheckBox.AutoSize = true;
            this.SongSelectCheckBox.Location = new System.Drawing.Point(339, 294);
            this.SongSelectCheckBox.Name = "SongSelectCheckBox";
            this.SongSelectCheckBox.Size = new System.Drawing.Size(81, 17);
            this.SongSelectCheckBox.TabIndex = 44;
            this.SongSelectCheckBox.Text = "SongSelect";
            this.SongSelectCheckBox.UseVisualStyleBackColor = true;
            this.SongSelectCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // TuneRequestCheckBox
            // 
            this.TuneRequestCheckBox.AutoSize = true;
            this.TuneRequestCheckBox.Location = new System.Drawing.Point(339, 317);
            this.TuneRequestCheckBox.Name = "TuneRequestCheckBox";
            this.TuneRequestCheckBox.Size = new System.Drawing.Size(91, 17);
            this.TuneRequestCheckBox.TabIndex = 43;
            this.TuneRequestCheckBox.Text = "TuneRequest";
            this.TuneRequestCheckBox.UseVisualStyleBackColor = true;
            this.TuneRequestCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // ContinueCheckBox
            // 
            this.ContinueCheckBox.AutoSize = true;
            this.ContinueCheckBox.Location = new System.Drawing.Point(169, 64);
            this.ContinueCheckBox.Name = "ContinueCheckBox";
            this.ContinueCheckBox.Size = new System.Drawing.Size(68, 17);
            this.ContinueCheckBox.TabIndex = 42;
            this.ContinueCheckBox.Text = "Continue";
            this.ContinueCheckBox.UseVisualStyleBackColor = true;
            this.ContinueCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // MidiTimeCodeCheckBox
            // 
            this.MidiTimeCodeCheckBox.AutoSize = true;
            this.MidiTimeCodeCheckBox.Location = new System.Drawing.Point(339, 248);
            this.MidiTimeCodeCheckBox.Name = "MidiTimeCodeCheckBox";
            this.MidiTimeCodeCheckBox.Size = new System.Drawing.Size(93, 17);
            this.MidiTimeCodeCheckBox.TabIndex = 41;
            this.MidiTimeCodeCheckBox.Text = "MidiTimeCode";
            this.MidiTimeCodeCheckBox.UseVisualStyleBackColor = true;
            this.MidiTimeCodeCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // ResetCheckBox
            // 
            this.ResetCheckBox.AutoSize = true;
            this.ResetCheckBox.Location = new System.Drawing.Point(10, 294);
            this.ResetCheckBox.Name = "ResetCheckBox";
            this.ResetCheckBox.Size = new System.Drawing.Size(54, 17);
            this.ResetCheckBox.TabIndex = 40;
            this.ResetCheckBox.Text = "Reset";
            this.ResetCheckBox.UseVisualStyleBackColor = true;
            this.ResetCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // ActiveSensingCheckBox
            // 
            this.ActiveSensingCheckBox.AutoSize = true;
            this.ActiveSensingCheckBox.Location = new System.Drawing.Point(10, 317);
            this.ActiveSensingCheckBox.Name = "ActiveSensingCheckBox";
            this.ActiveSensingCheckBox.Size = new System.Drawing.Size(94, 17);
            this.ActiveSensingCheckBox.TabIndex = 39;
            this.ActiveSensingCheckBox.Text = "ActiveSensing";
            this.ActiveSensingCheckBox.UseVisualStyleBackColor = true;
            this.ActiveSensingCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // StopCheckBox
            // 
            this.StopCheckBox.AutoSize = true;
            this.StopCheckBox.Location = new System.Drawing.Point(169, 87);
            this.StopCheckBox.Name = "StopCheckBox";
            this.StopCheckBox.Size = new System.Drawing.Size(48, 17);
            this.StopCheckBox.TabIndex = 38;
            this.StopCheckBox.Text = "Stop";
            this.StopCheckBox.UseVisualStyleBackColor = true;
            this.StopCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // StartCheckBox
            // 
            this.StartCheckBox.AutoSize = true;
            this.StartCheckBox.Location = new System.Drawing.Point(169, 41);
            this.StartCheckBox.Name = "StartCheckBox";
            this.StartCheckBox.Size = new System.Drawing.Size(48, 17);
            this.StartCheckBox.TabIndex = 37;
            this.StartCheckBox.Text = "Start";
            this.StartCheckBox.UseVisualStyleBackColor = true;
            this.StartCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // TimingClockCheckBox
            // 
            this.TimingClockCheckBox.AutoSize = true;
            this.TimingClockCheckBox.Location = new System.Drawing.Point(10, 271);
            this.TimingClockCheckBox.Name = "TimingClockCheckBox";
            this.TimingClockCheckBox.Size = new System.Drawing.Size(84, 17);
            this.TimingClockCheckBox.TabIndex = 36;
            this.TimingClockCheckBox.Text = "TimingClock";
            this.TimingClockCheckBox.UseVisualStyleBackColor = true;
            this.TimingClockCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // ProgramChangeCheckBox
            // 
            this.ProgramChangeCheckBox.AutoSize = true;
            this.ProgramChangeCheckBox.Location = new System.Drawing.Point(10, 179);
            this.ProgramChangeCheckBox.Name = "ProgramChangeCheckBox";
            this.ProgramChangeCheckBox.Size = new System.Drawing.Size(102, 17);
            this.ProgramChangeCheckBox.TabIndex = 35;
            this.ProgramChangeCheckBox.Text = "ProgramChange";
            this.ProgramChangeCheckBox.UseVisualStyleBackColor = true;
            this.ProgramChangeCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // CustomMetaCheckBox
            // 
            this.CustomMetaCheckBox.AutoSize = true;
            this.CustomMetaCheckBox.Location = new System.Drawing.Point(339, 41);
            this.CustomMetaCheckBox.Name = "CustomMetaCheckBox";
            this.CustomMetaCheckBox.Size = new System.Drawing.Size(85, 17);
            this.CustomMetaCheckBox.TabIndex = 34;
            this.CustomMetaCheckBox.Text = "CustomMeta";
            this.CustomMetaCheckBox.UseVisualStyleBackColor = true;
            this.CustomMetaCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // NoteAftertouchCheckBox
            // 
            this.NoteAftertouchCheckBox.AutoSize = true;
            this.NoteAftertouchCheckBox.Location = new System.Drawing.Point(10, 133);
            this.NoteAftertouchCheckBox.Name = "NoteAftertouchCheckBox";
            this.NoteAftertouchCheckBox.Size = new System.Drawing.Size(98, 17);
            this.NoteAftertouchCheckBox.TabIndex = 33;
            this.NoteAftertouchCheckBox.Text = "NoteAftertouch";
            this.NoteAftertouchCheckBox.UseVisualStyleBackColor = true;
            this.NoteAftertouchCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // KeySignatureCheckBox
            // 
            this.KeySignatureCheckBox.AutoSize = true;
            this.KeySignatureCheckBox.Location = new System.Drawing.Point(9, 248);
            this.KeySignatureCheckBox.Name = "KeySignatureCheckBox";
            this.KeySignatureCheckBox.Size = new System.Drawing.Size(89, 17);
            this.KeySignatureCheckBox.TabIndex = 32;
            this.KeySignatureCheckBox.Text = "KeySignature";
            this.KeySignatureCheckBox.UseVisualStyleBackColor = true;
            this.KeySignatureCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // SequencerSpecificCheckBox
            // 
            this.SequencerSpecificCheckBox.AutoSize = true;
            this.SequencerSpecificCheckBox.Location = new System.Drawing.Point(169, 294);
            this.SequencerSpecificCheckBox.Name = "SequencerSpecificCheckBox";
            this.SequencerSpecificCheckBox.Size = new System.Drawing.Size(116, 17);
            this.SequencerSpecificCheckBox.TabIndex = 31;
            this.SequencerSpecificCheckBox.Text = "SequencerSpecific";
            this.SequencerSpecificCheckBox.UseVisualStyleBackColor = true;
            this.SequencerSpecificCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // UnknownMetaCheckBox
            // 
            this.UnknownMetaCheckBox.AutoSize = true;
            this.UnknownMetaCheckBox.Location = new System.Drawing.Point(169, 317);
            this.UnknownMetaCheckBox.Name = "UnknownMetaCheckBox";
            this.UnknownMetaCheckBox.Size = new System.Drawing.Size(96, 17);
            this.UnknownMetaCheckBox.TabIndex = 30;
            this.UnknownMetaCheckBox.Text = "UnknownMeta";
            this.UnknownMetaCheckBox.UseVisualStyleBackColor = true;
            this.UnknownMetaCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // PortPrefixCheckBox
            // 
            this.PortPrefixCheckBox.AutoSize = true;
            this.PortPrefixCheckBox.Location = new System.Drawing.Point(169, 156);
            this.PortPrefixCheckBox.Name = "PortPrefixCheckBox";
            this.PortPrefixCheckBox.Size = new System.Drawing.Size(71, 17);
            this.PortPrefixCheckBox.TabIndex = 29;
            this.PortPrefixCheckBox.Text = "PortPrefix";
            this.PortPrefixCheckBox.UseVisualStyleBackColor = true;
            this.PortPrefixCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // TimeSignatureCheckBox
            // 
            this.TimeSignatureCheckBox.AutoSize = true;
            this.TimeSignatureCheckBox.Location = new System.Drawing.Point(9, 225);
            this.TimeSignatureCheckBox.Name = "TimeSignatureCheckBox";
            this.TimeSignatureCheckBox.Size = new System.Drawing.Size(94, 17);
            this.TimeSignatureCheckBox.TabIndex = 28;
            this.TimeSignatureCheckBox.Text = "TimeSignature";
            this.TimeSignatureCheckBox.UseVisualStyleBackColor = true;
            this.TimeSignatureCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // SmpteOffsetCheckBox
            // 
            this.SmpteOffsetCheckBox.AutoSize = true;
            this.SmpteOffsetCheckBox.Location = new System.Drawing.Point(169, 225);
            this.SmpteOffsetCheckBox.Name = "SmpteOffsetCheckBox";
            this.SmpteOffsetCheckBox.Size = new System.Drawing.Size(84, 17);
            this.SmpteOffsetCheckBox.TabIndex = 27;
            this.SmpteOffsetCheckBox.Text = "SmpteOffset";
            this.SmpteOffsetCheckBox.UseVisualStyleBackColor = true;
            this.SmpteOffsetCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // SetTempoCheckBox
            // 
            this.SetTempoCheckBox.AutoSize = true;
            this.SetTempoCheckBox.Location = new System.Drawing.Point(10, 202);
            this.SetTempoCheckBox.Name = "SetTempoCheckBox";
            this.SetTempoCheckBox.Size = new System.Drawing.Size(75, 17);
            this.SetTempoCheckBox.TabIndex = 26;
            this.SetTempoCheckBox.Text = "SetTempo";
            this.SetTempoCheckBox.UseVisualStyleBackColor = true;
            this.SetTempoCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // EndOfTrackCheckBox
            // 
            this.EndOfTrackCheckBox.AutoSize = true;
            this.EndOfTrackCheckBox.Location = new System.Drawing.Point(169, 179);
            this.EndOfTrackCheckBox.Name = "EndOfTrackCheckBox";
            this.EndOfTrackCheckBox.Size = new System.Drawing.Size(84, 17);
            this.EndOfTrackCheckBox.TabIndex = 25;
            this.EndOfTrackCheckBox.Text = "EndOfTrack";
            this.EndOfTrackCheckBox.UseVisualStyleBackColor = true;
            this.EndOfTrackCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // ChannelPrefixCheckBox
            // 
            this.ChannelPrefixCheckBox.AutoSize = true;
            this.ChannelPrefixCheckBox.Location = new System.Drawing.Point(169, 133);
            this.ChannelPrefixCheckBox.Name = "ChannelPrefixCheckBox";
            this.ChannelPrefixCheckBox.Size = new System.Drawing.Size(91, 17);
            this.ChannelPrefixCheckBox.TabIndex = 24;
            this.ChannelPrefixCheckBox.Text = "ChannelPrefix";
            this.ChannelPrefixCheckBox.UseVisualStyleBackColor = true;
            this.ChannelPrefixCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // DeviceNameCheckBox
            // 
            this.DeviceNameCheckBox.AutoSize = true;
            this.DeviceNameCheckBox.Location = new System.Drawing.Point(169, 110);
            this.DeviceNameCheckBox.Name = "DeviceNameCheckBox";
            this.DeviceNameCheckBox.Size = new System.Drawing.Size(88, 17);
            this.DeviceNameCheckBox.TabIndex = 23;
            this.DeviceNameCheckBox.Text = "DeviceName";
            this.DeviceNameCheckBox.UseVisualStyleBackColor = true;
            this.DeviceNameCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // ProgramNameCheckBox
            // 
            this.ProgramNameCheckBox.AutoSize = true;
            this.ProgramNameCheckBox.Location = new System.Drawing.Point(339, 133);
            this.ProgramNameCheckBox.Name = "ProgramNameCheckBox";
            this.ProgramNameCheckBox.Size = new System.Drawing.Size(93, 17);
            this.ProgramNameCheckBox.TabIndex = 22;
            this.ProgramNameCheckBox.Text = "ProgramName";
            this.ProgramNameCheckBox.UseVisualStyleBackColor = true;
            this.ProgramNameCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // MarkerCheckBox
            // 
            this.MarkerCheckBox.AutoSize = true;
            this.MarkerCheckBox.Location = new System.Drawing.Point(339, 87);
            this.MarkerCheckBox.Name = "MarkerCheckBox";
            this.MarkerCheckBox.Size = new System.Drawing.Size(59, 17);
            this.MarkerCheckBox.TabIndex = 21;
            this.MarkerCheckBox.Text = "Marker";
            this.MarkerCheckBox.UseVisualStyleBackColor = true;
            this.MarkerCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // CuePointCheckBox
            // 
            this.CuePointCheckBox.AutoSize = true;
            this.CuePointCheckBox.Location = new System.Drawing.Point(339, 110);
            this.CuePointCheckBox.Name = "CuePointCheckBox";
            this.CuePointCheckBox.Size = new System.Drawing.Size(69, 17);
            this.CuePointCheckBox.TabIndex = 20;
            this.CuePointCheckBox.Text = "CuePoint";
            this.CuePointCheckBox.UseVisualStyleBackColor = true;
            this.CuePointCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // TextCheckBox
            // 
            this.TextCheckBox.AutoSize = true;
            this.TextCheckBox.Location = new System.Drawing.Point(339, 225);
            this.TextCheckBox.Name = "TextCheckBox";
            this.TextCheckBox.Size = new System.Drawing.Size(47, 17);
            this.TextCheckBox.TabIndex = 19;
            this.TextCheckBox.Text = "Text";
            this.TextCheckBox.UseVisualStyleBackColor = true;
            this.TextCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // InstrumentNameCheckBox
            // 
            this.InstrumentNameCheckBox.AutoSize = true;
            this.InstrumentNameCheckBox.Location = new System.Drawing.Point(169, 271);
            this.InstrumentNameCheckBox.Name = "InstrumentNameCheckBox";
            this.InstrumentNameCheckBox.Size = new System.Drawing.Size(103, 17);
            this.InstrumentNameCheckBox.TabIndex = 18;
            this.InstrumentNameCheckBox.Text = "InstrumentName";
            this.InstrumentNameCheckBox.UseVisualStyleBackColor = true;
            this.InstrumentNameCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // LyricCheckBox
            // 
            this.LyricCheckBox.AutoSize = true;
            this.LyricCheckBox.Location = new System.Drawing.Point(169, 202);
            this.LyricCheckBox.Name = "LyricCheckBox";
            this.LyricCheckBox.Size = new System.Drawing.Size(48, 17);
            this.LyricCheckBox.TabIndex = 17;
            this.LyricCheckBox.Text = "Lyric";
            this.LyricCheckBox.UseVisualStyleBackColor = true;
            this.LyricCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // CopyrightNoticeCheckBox
            // 
            this.CopyrightNoticeCheckBox.AutoSize = true;
            this.CopyrightNoticeCheckBox.Location = new System.Drawing.Point(339, 202);
            this.CopyrightNoticeCheckBox.Name = "CopyrightNoticeCheckBox";
            this.CopyrightNoticeCheckBox.Size = new System.Drawing.Size(101, 17);
            this.CopyrightNoticeCheckBox.TabIndex = 16;
            this.CopyrightNoticeCheckBox.Text = "CopyrightNotice";
            this.CopyrightNoticeCheckBox.UseVisualStyleBackColor = true;
            this.CopyrightNoticeCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // SequenceTrackNameCheckBox
            // 
            this.SequenceTrackNameCheckBox.AutoSize = true;
            this.SequenceTrackNameCheckBox.Location = new System.Drawing.Point(169, 248);
            this.SequenceTrackNameCheckBox.Name = "SequenceTrackNameCheckBox";
            this.SequenceTrackNameCheckBox.Size = new System.Drawing.Size(131, 17);
            this.SequenceTrackNameCheckBox.TabIndex = 15;
            this.SequenceTrackNameCheckBox.Text = "SequenceTrackName";
            this.SequenceTrackNameCheckBox.UseVisualStyleBackColor = true;
            this.SequenceTrackNameCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // SequenceNumberCheckBox
            // 
            this.SequenceNumberCheckBox.AutoSize = true;
            this.SequenceNumberCheckBox.Location = new System.Drawing.Point(339, 64);
            this.SequenceNumberCheckBox.Name = "SequenceNumberCheckBox";
            this.SequenceNumberCheckBox.Size = new System.Drawing.Size(112, 17);
            this.SequenceNumberCheckBox.TabIndex = 14;
            this.SequenceNumberCheckBox.Text = "SequenceNumber";
            this.SequenceNumberCheckBox.UseVisualStyleBackColor = true;
            this.SequenceNumberCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // EscapeSysExCheckBox
            // 
            this.EscapeSysExCheckBox.AutoSize = true;
            this.EscapeSysExCheckBox.Location = new System.Drawing.Point(339, 179);
            this.EscapeSysExCheckBox.Name = "EscapeSysExCheckBox";
            this.EscapeSysExCheckBox.Size = new System.Drawing.Size(91, 17);
            this.EscapeSysExCheckBox.TabIndex = 13;
            this.EscapeSysExCheckBox.Text = "EscapeSysEx";
            this.EscapeSysExCheckBox.UseVisualStyleBackColor = true;
            this.EscapeSysExCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // NormalSysExCheckBox
            // 
            this.NormalSysExCheckBox.AutoSize = true;
            this.NormalSysExCheckBox.Location = new System.Drawing.Point(339, 156);
            this.NormalSysExCheckBox.Name = "NormalSysExCheckBox";
            this.NormalSysExCheckBox.Size = new System.Drawing.Size(88, 17);
            this.NormalSysExCheckBox.TabIndex = 12;
            this.NormalSysExCheckBox.Text = "NormalSysEx";
            this.NormalSysExCheckBox.UseVisualStyleBackColor = true;
            this.NormalSysExCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // ControlChangeCheckBox
            // 
            this.ControlChangeCheckBox.AutoSize = true;
            this.ControlChangeCheckBox.Location = new System.Drawing.Point(10, 156);
            this.ControlChangeCheckBox.Name = "ControlChangeCheckBox";
            this.ControlChangeCheckBox.Size = new System.Drawing.Size(96, 17);
            this.ControlChangeCheckBox.TabIndex = 11;
            this.ControlChangeCheckBox.Text = "ControlChange";
            this.ControlChangeCheckBox.UseVisualStyleBackColor = true;
            this.ControlChangeCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // PitchBendCheckBox
            // 
            this.PitchBendCheckBox.AutoSize = true;
            this.PitchBendCheckBox.Location = new System.Drawing.Point(10, 87);
            this.PitchBendCheckBox.Name = "PitchBendCheckBox";
            this.PitchBendCheckBox.Size = new System.Drawing.Size(75, 17);
            this.PitchBendCheckBox.TabIndex = 10;
            this.PitchBendCheckBox.Text = "PitchBend";
            this.PitchBendCheckBox.UseVisualStyleBackColor = true;
            this.PitchBendCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // ChannelAftertouchCheckBox
            // 
            this.ChannelAftertouchCheckBox.AutoSize = true;
            this.ChannelAftertouchCheckBox.Location = new System.Drawing.Point(10, 110);
            this.ChannelAftertouchCheckBox.Name = "ChannelAftertouchCheckBox";
            this.ChannelAftertouchCheckBox.Size = new System.Drawing.Size(114, 17);
            this.ChannelAftertouchCheckBox.TabIndex = 9;
            this.ChannelAftertouchCheckBox.Text = "ChannelAftertouch";
            this.ChannelAftertouchCheckBox.UseVisualStyleBackColor = true;
            this.ChannelAftertouchCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // NoteOnCheckBox
            // 
            this.NoteOnCheckBox.AutoSize = true;
            this.NoteOnCheckBox.Location = new System.Drawing.Point(10, 41);
            this.NoteOnCheckBox.Name = "NoteOnCheckBox";
            this.NoteOnCheckBox.Size = new System.Drawing.Size(63, 17);
            this.NoteOnCheckBox.TabIndex = 8;
            this.NoteOnCheckBox.Text = "NoteOn";
            this.NoteOnCheckBox.UseVisualStyleBackColor = true;
            this.NoteOnCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // FilterEventsLabel
            // 
            this.FilterEventsLabel.AutoSize = true;
            this.FilterEventsLabel.Location = new System.Drawing.Point(6, 15);
            this.FilterEventsLabel.Name = "FilterEventsLabel";
            this.FilterEventsLabel.Size = new System.Drawing.Size(449, 13);
            this.FilterEventsLabel.TabIndex = 7;
            this.FilterEventsLabel.Text = "Checked midi event types will be ignored (not displayed in monitor and not send t" +
    "o destination)";
            // 
            // NoteOffCheckBox
            // 
            this.NoteOffCheckBox.AutoSize = true;
            this.NoteOffCheckBox.Location = new System.Drawing.Point(10, 64);
            this.NoteOffCheckBox.Name = "NoteOffCheckBox";
            this.NoteOffCheckBox.Size = new System.Drawing.Size(63, 17);
            this.NoteOffCheckBox.TabIndex = 6;
            this.NoteOffCheckBox.Text = "NoteOff";
            this.NoteOffCheckBox.UseVisualStyleBackColor = true;
            this.NoteOffCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.DisplayChangelogButton);
            this.AboutTab.Controls.Add(this.label9);
            this.AboutTab.Controls.Add(this.linkLabel3);
            this.AboutTab.Controls.Add(this.label8);
            this.AboutTab.Controls.Add(this.label7);
            this.AboutTab.Controls.Add(this.linkLabel2);
            this.AboutTab.Controls.Add(this.linkLabel1);
            this.AboutTab.Controls.Add(this.label6);
            this.AboutTab.Controls.Add(this.label5);
            this.AboutTab.Controls.Add(this.label4);
            this.AboutTab.Controls.Add(this.label3);
            this.AboutTab.Controls.Add(this.label2);
            this.AboutTab.Location = new System.Drawing.Point(4, 22);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Size = new System.Drawing.Size(500, 347);
            this.AboutTab.TabIndex = 2;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(315, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "special thanks to Didier Martini for beta testing and music advices";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(162, 128);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(164, 13);
            this.linkLabel3.TabIndex = 14;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "https://www.networkcomms.net/";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "using networkcomms library";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "using melanchall / drywetmidi library";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(88, 54);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(313, 13);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://github.com/Fabrice-Deshayes-aka-Xtream/MidiForwarder";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(142, 91);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(204, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/melanchall/drywetmidi";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Xtream logo by Spoofle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fabrice Deshayes aka Xtream";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "CODE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "DESIGN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fabrice Deshayes aka Xtream";
            // 
            // DisplayChangelogButton
            // 
            this.DisplayChangelogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayChangelogButton.Image = global::MidiForwarder.Properties.Resources.Octocat;
            this.DisplayChangelogButton.Location = new System.Drawing.Point(123, 257);
            this.DisplayChangelogButton.Name = "DisplayChangelogButton";
            this.DisplayChangelogButton.Size = new System.Drawing.Size(242, 50);
            this.DisplayChangelogButton.TabIndex = 16;
            this.DisplayChangelogButton.Text = "Display CHANGELOG\r\non github";
            this.DisplayChangelogButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DisplayChangelogButton.UseVisualStyleBackColor = true;
            this.DisplayChangelogButton.Click += new System.EventHandler(this.DisplayChangelogButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MidiForwarder.Properties.Resources.Logo_Xtream;
            this.pictureBox1.Location = new System.Drawing.Point(14, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // NoteOffButton
            // 
            this.NoteOffButton.Image = ((System.Drawing.Image)(resources.GetObject("NoteOffButton.Image")));
            this.NoteOffButton.Location = new System.Drawing.Point(326, 85);
            this.NoteOffButton.Name = "NoteOffButton";
            this.NoteOffButton.Size = new System.Drawing.Size(170, 28);
            this.NoteOffButton.TabIndex = 2;
            this.NoteOffButton.Text = "Midi reset / all notes off";
            this.NoteOffButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NoteOffButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NoteOffButton.UseVisualStyleBackColor = true;
            this.NoteOffButton.Click += new System.EventHandler(this.NoteOffButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MidiForwarder.Properties.Resources.midi;
            this.pictureBox2.Location = new System.Drawing.Point(343, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // MidiForwarderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 591);
            this.Controls.Add(this.lowerPanel);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(524, 4096);
            this.MinimumSize = new System.Drawing.Size(524, 630);
            this.Name = "MidiForwarderForm";
            this.Text = "Xtream Midi Forwarder v2020.04.14";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MidiForwarderForm_FormClosed);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.upperPanel.ResumeLayout(false);
            this.upperPanel.PerformLayout();
            this.lowerPanel.ResumeLayout(false);
            this.TabbedPanels.ResumeLayout(false);
            this.MidiMonitorTab.ResumeLayout(false);
            this.NetworkConfigTab.ResumeLayout(false);
            this.NetworkConfigTab.PerformLayout();
            this.SendGroupBox.ResumeLayout(false);
            this.SendGroupBox.PerformLayout();
            this.ReceiveGroupBox.ResumeLayout(false);
            this.ReceiveGroupBox.PerformLayout();
            this.EventFilterTab.ResumeLayout(false);
            this.EventFilterTab.PerformLayout();
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox InputDevicesComboBox;
        private System.Windows.Forms.ComboBox OutputDevicesComboBox;
        private System.ComponentModel.BackgroundWorker MidiEventListenerWorker;
        private System.Windows.Forms.Timer SlowRefreshUITimer;
        private System.Windows.Forms.Timer FastRefreshUITimer;
        private System.Windows.Forms.Button NoteOffButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelForwarder;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel IpLabel;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Panel lowerPanel;
        private System.Windows.Forms.TabControl TabbedPanels;
        private System.Windows.Forms.TabPage MidiMonitorTab;
        private System.Windows.Forms.ListBox EventsListBox;
        private System.Windows.Forms.TabPage NetworkConfigTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage AboutTab;
        private System.Windows.Forms.GroupBox SendGroupBox;
        private System.Windows.Forms.Label SendToPortLabel;
        private System.Windows.Forms.TextBox SendToPortTextBox;
        private System.Windows.Forms.Label SendToIpLabel;
        private System.Windows.Forms.TextBox SendToIpTextBox;
        private System.Windows.Forms.GroupBox ReceiveGroupBox;
        private System.Windows.Forms.Label ReceivePortLabel;
        private System.Windows.Forms.TextBox ReceivePortTextBox;
        private System.Windows.Forms.Button ApplyNetworkConfigButton;
        private System.Windows.Forms.Label ListeningLabel;
        private System.Windows.Forms.Label ConnectingLabel;
        private System.Windows.Forms.Label ConnectedLabel;
        private System.Windows.Forms.TabPage EventFilterTab;
        private System.Windows.Forms.CheckBox ControlChangeCheckBox;
        private System.Windows.Forms.CheckBox PitchBendCheckBox;
        private System.Windows.Forms.CheckBox ChannelAftertouchCheckBox;
        private System.Windows.Forms.CheckBox NoteOnCheckBox;
        private System.Windows.Forms.Label FilterEventsLabel;
        private System.Windows.Forms.CheckBox NoteOffCheckBox;
        private System.Windows.Forms.CheckBox SongPositionPointerCheckBox;
        private System.Windows.Forms.CheckBox SongSelectCheckBox;
        private System.Windows.Forms.CheckBox TuneRequestCheckBox;
        private System.Windows.Forms.CheckBox ContinueCheckBox;
        private System.Windows.Forms.CheckBox MidiTimeCodeCheckBox;
        private System.Windows.Forms.CheckBox ResetCheckBox;
        private System.Windows.Forms.CheckBox ActiveSensingCheckBox;
        private System.Windows.Forms.CheckBox StopCheckBox;
        private System.Windows.Forms.CheckBox StartCheckBox;
        private System.Windows.Forms.CheckBox TimingClockCheckBox;
        private System.Windows.Forms.CheckBox ProgramChangeCheckBox;
        private System.Windows.Forms.CheckBox CustomMetaCheckBox;
        private System.Windows.Forms.CheckBox NoteAftertouchCheckBox;
        private System.Windows.Forms.CheckBox KeySignatureCheckBox;
        private System.Windows.Forms.CheckBox SequencerSpecificCheckBox;
        private System.Windows.Forms.CheckBox UnknownMetaCheckBox;
        private System.Windows.Forms.CheckBox PortPrefixCheckBox;
        private System.Windows.Forms.CheckBox TimeSignatureCheckBox;
        private System.Windows.Forms.CheckBox SmpteOffsetCheckBox;
        private System.Windows.Forms.CheckBox SetTempoCheckBox;
        private System.Windows.Forms.CheckBox EndOfTrackCheckBox;
        private System.Windows.Forms.CheckBox ChannelPrefixCheckBox;
        private System.Windows.Forms.CheckBox DeviceNameCheckBox;
        private System.Windows.Forms.CheckBox ProgramNameCheckBox;
        private System.Windows.Forms.CheckBox MarkerCheckBox;
        private System.Windows.Forms.CheckBox CuePointCheckBox;
        private System.Windows.Forms.CheckBox TextCheckBox;
        private System.Windows.Forms.CheckBox InstrumentNameCheckBox;
        private System.Windows.Forms.CheckBox LyricCheckBox;
        private System.Windows.Forms.CheckBox CopyrightNoticeCheckBox;
        private System.Windows.Forms.CheckBox SequenceTrackNameCheckBox;
        private System.Windows.Forms.CheckBox SequenceNumberCheckBox;
        private System.Windows.Forms.CheckBox EscapeSysExCheckBox;
        private System.Windows.Forms.CheckBox NormalSysExCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DisplayChangelogButton;
    }
}

