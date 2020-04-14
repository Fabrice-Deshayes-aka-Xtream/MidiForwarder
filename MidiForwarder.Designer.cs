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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NoteOffButton = new System.Windows.Forms.Button();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.TabbedPanels = new System.Windows.Forms.TabControl();
            this.MidiMonitorTab = new System.Windows.Forms.TabPage();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.ControlChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.PitchbendCheckBox = new System.Windows.Forms.CheckBox();
            this.AftertouchCheckBox = new System.Windows.Forms.CheckBox();
            this.NoteOnCheckBox = new System.Windows.Forms.CheckBox();
            this.eventFilterLabel = new System.Windows.Forms.Label();
            this.NoteOffCheckBox = new System.Windows.Forms.CheckBox();
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
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.ListeningLabel = new System.Windows.Forms.Label();
            this.ConnectedLabel = new System.Windows.Forms.Label();
            this.ConnectingLabel = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.upperPanel.SuspendLayout();
            this.lowerPanel.SuspendLayout();
            this.TabbedPanels.SuspendLayout();
            this.MidiMonitorTab.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.NetworkConfigTab.SuspendLayout();
            this.SendGroupBox.SuspendLayout();
            this.ReceiveGroupBox.SuspendLayout();
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
            this.labelForwarder.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForwarder.Location = new System.Drawing.Point(320, 54);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 541);
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
            this.NoteOffButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NoteOffButton.Location = new System.Drawing.Point(368, 87);
            this.NoteOffButton.Name = "NoteOffButton";
            this.NoteOffButton.Size = new System.Drawing.Size(91, 28);
            this.NoteOffButton.TabIndex = 2;
            this.NoteOffButton.Text = "All Notes Off";
            this.NoteOffButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NoteOffButton.UseVisualStyleBackColor = true;
            this.NoteOffButton.Click += new System.EventHandler(this.NoteOffButton_Click);
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
            // lowerPanel
            // 
            this.lowerPanel.Controls.Add(this.TabbedPanels);
            this.lowerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerPanel.Location = new System.Drawing.Point(0, 198);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(508, 343);
            this.lowerPanel.TabIndex = 10;
            // 
            // TabbedPanels
            // 
            this.TabbedPanels.Controls.Add(this.MidiMonitorTab);
            this.TabbedPanels.Controls.Add(this.NetworkConfigTab);
            this.TabbedPanels.Controls.Add(this.AboutTab);
            this.TabbedPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabbedPanels.Location = new System.Drawing.Point(0, 0);
            this.TabbedPanels.Name = "TabbedPanels";
            this.TabbedPanels.SelectedIndex = 0;
            this.TabbedPanels.Size = new System.Drawing.Size(508, 343);
            this.TabbedPanels.TabIndex = 7;
            // 
            // MidiMonitorTab
            // 
            this.MidiMonitorTab.Controls.Add(this.filterPanel);
            this.MidiMonitorTab.Controls.Add(this.EventsListBox);
            this.MidiMonitorTab.Location = new System.Drawing.Point(4, 22);
            this.MidiMonitorTab.Name = "MidiMonitorTab";
            this.MidiMonitorTab.Padding = new System.Windows.Forms.Padding(3);
            this.MidiMonitorTab.Size = new System.Drawing.Size(500, 317);
            this.MidiMonitorTab.TabIndex = 0;
            this.MidiMonitorTab.Text = "Midi monitor";
            this.MidiMonitorTab.UseVisualStyleBackColor = true;
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.ControlChangeCheckBox);
            this.filterPanel.Controls.Add(this.PitchbendCheckBox);
            this.filterPanel.Controls.Add(this.AftertouchCheckBox);
            this.filterPanel.Controls.Add(this.NoteOnCheckBox);
            this.filterPanel.Controls.Add(this.eventFilterLabel);
            this.filterPanel.Controls.Add(this.NoteOffCheckBox);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filterPanel.Location = new System.Drawing.Point(3, 291);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(494, 23);
            this.filterPanel.TabIndex = 10;
            // 
            // ControlChangeCheckBox
            // 
            this.ControlChangeCheckBox.AutoSize = true;
            this.ControlChangeCheckBox.Location = new System.Drawing.Point(395, 2);
            this.ControlChangeCheckBox.Name = "ControlChangeCheckBox";
            this.ControlChangeCheckBox.Size = new System.Drawing.Size(98, 17);
            this.ControlChangeCheckBox.TabIndex = 5;
            this.ControlChangeCheckBox.Text = "Control change";
            this.ControlChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // PitchbendCheckBox
            // 
            this.PitchbendCheckBox.AutoSize = true;
            this.PitchbendCheckBox.Location = new System.Drawing.Point(318, 2);
            this.PitchbendCheckBox.Name = "PitchbendCheckBox";
            this.PitchbendCheckBox.Size = new System.Drawing.Size(74, 17);
            this.PitchbendCheckBox.TabIndex = 4;
            this.PitchbendCheckBox.Text = "Pitchbend";
            this.PitchbendCheckBox.UseVisualStyleBackColor = true;
            // 
            // AftertouchCheckBox
            // 
            this.AftertouchCheckBox.AutoSize = true;
            this.AftertouchCheckBox.Location = new System.Drawing.Point(241, 2);
            this.AftertouchCheckBox.Name = "AftertouchCheckBox";
            this.AftertouchCheckBox.Size = new System.Drawing.Size(75, 17);
            this.AftertouchCheckBox.TabIndex = 3;
            this.AftertouchCheckBox.Text = "Aftertouch";
            this.AftertouchCheckBox.UseVisualStyleBackColor = true;
            // 
            // NoteOnCheckBox
            // 
            this.NoteOnCheckBox.AutoSize = true;
            this.NoteOnCheckBox.Location = new System.Drawing.Point(104, 2);
            this.NoteOnCheckBox.Name = "NoteOnCheckBox";
            this.NoteOnCheckBox.Size = new System.Drawing.Size(66, 17);
            this.NoteOnCheckBox.TabIndex = 2;
            this.NoteOnCheckBox.Text = "Note On";
            this.NoteOnCheckBox.UseVisualStyleBackColor = true;
            // 
            // eventFilterLabel
            // 
            this.eventFilterLabel.AutoSize = true;
            this.eventFilterLabel.Location = new System.Drawing.Point(3, 3);
            this.eventFilterLabel.Name = "eventFilterLabel";
            this.eventFilterLabel.Size = new System.Drawing.Size(97, 13);
            this.eventFilterLabel.TabIndex = 1;
            this.eventFilterLabel.Text = "Events display filter";
            // 
            // NoteOffCheckBox
            // 
            this.NoteOffCheckBox.AutoSize = true;
            this.NoteOffCheckBox.Location = new System.Drawing.Point(172, 2);
            this.NoteOffCheckBox.Name = "NoteOffCheckBox";
            this.NoteOffCheckBox.Size = new System.Drawing.Size(66, 17);
            this.NoteOffCheckBox.TabIndex = 0;
            this.NoteOffCheckBox.Text = "Note Off";
            this.NoteOffCheckBox.UseVisualStyleBackColor = true;
            // 
            // EventsListBox
            // 
            this.EventsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.Location = new System.Drawing.Point(3, 3);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.Size = new System.Drawing.Size(494, 311);
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
            this.NetworkConfigTab.Size = new System.Drawing.Size(500, 317);
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
            this.SendToIpTextBox.Text = "192.168.255.255";
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
            // AboutTab
            // 
            this.AboutTab.Location = new System.Drawing.Point(4, 22);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Size = new System.Drawing.Size(500, 317);
            this.AboutTab.TabIndex = 2;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
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
            // MidiForwarderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 561);
            this.Controls.Add(this.lowerPanel);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(524, 4096);
            this.MinimumSize = new System.Drawing.Size(524, 600);
            this.Name = "MidiForwarderForm";
            this.Text = "Xtream Midi Forwarder v2020.04.13";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MidiForwarderForm_FormClosed);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.upperPanel.ResumeLayout(false);
            this.upperPanel.PerformLayout();
            this.lowerPanel.ResumeLayout(false);
            this.TabbedPanels.ResumeLayout(false);
            this.MidiMonitorTab.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.NetworkConfigTab.ResumeLayout(false);
            this.NetworkConfigTab.PerformLayout();
            this.SendGroupBox.ResumeLayout(false);
            this.SendGroupBox.PerformLayout();
            this.ReceiveGroupBox.ResumeLayout(false);
            this.ReceiveGroupBox.PerformLayout();
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
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.CheckBox ControlChangeCheckBox;
        private System.Windows.Forms.CheckBox PitchbendCheckBox;
        private System.Windows.Forms.CheckBox AftertouchCheckBox;
        private System.Windows.Forms.CheckBox NoteOnCheckBox;
        private System.Windows.Forms.Label eventFilterLabel;
        private System.Windows.Forms.CheckBox NoteOffCheckBox;
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
    }
}

