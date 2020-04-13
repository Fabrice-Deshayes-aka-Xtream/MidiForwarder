namespace MidiRouter
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
            this.EventsListBox = new System.Windows.Forms.ListBox();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.ControlChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.PitchbendCheckBox = new System.Windows.Forms.CheckBox();
            this.AftertouchCheckBox = new System.Windows.Forms.CheckBox();
            this.NoteOnCheckBox = new System.Windows.Forms.CheckBox();
            this.eventFilterLabel = new System.Windows.Forms.Label();
            this.NoteOffCheckBox = new System.Windows.Forms.CheckBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.upperPanel.SuspendLayout();
            this.lowerPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
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
            this.labelForwarder.Location = new System.Drawing.Point(320, 61);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 465);
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
            this.pictureBox2.Location = new System.Drawing.Point(343, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 70);
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
            this.NoteOffButton.Location = new System.Drawing.Point(405, 156);
            this.NoteOffButton.Name = "NoteOffButton";
            this.NoteOffButton.Size = new System.Drawing.Size(91, 28);
            this.NoteOffButton.TabIndex = 2;
            this.NoteOffButton.Text = "All Notes Off";
            this.NoteOffButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NoteOffButton.UseVisualStyleBackColor = true;
            this.NoteOffButton.Click += new System.EventHandler(this.NoteOffButton_Click);
            // 
            // EventsListBox
            // 
            this.EventsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.Location = new System.Drawing.Point(0, 0);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.Size = new System.Drawing.Size(508, 267);
            this.EventsListBox.TabIndex = 8;
            // 
            // upperPanel
            // 
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
            this.lowerPanel.Controls.Add(this.filterPanel);
            this.lowerPanel.Controls.Add(this.EventsListBox);
            this.lowerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerPanel.Location = new System.Drawing.Point(0, 198);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(508, 267);
            this.lowerPanel.TabIndex = 10;
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
            this.filterPanel.Location = new System.Drawing.Point(0, 244);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(508, 23);
            this.filterPanel.TabIndex = 9;
            // 
            // ControlChangeCheckBox
            // 
            this.ControlChangeCheckBox.AutoSize = true;
            this.ControlChangeCheckBox.Location = new System.Drawing.Point(411, 2);
            this.ControlChangeCheckBox.Name = "ControlChangeCheckBox";
            this.ControlChangeCheckBox.Size = new System.Drawing.Size(98, 17);
            this.ControlChangeCheckBox.TabIndex = 5;
            this.ControlChangeCheckBox.Text = "Control change";
            this.ControlChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // PitchbendCheckBox
            // 
            this.PitchbendCheckBox.AutoSize = true;
            this.PitchbendCheckBox.Location = new System.Drawing.Point(331, 2);
            this.PitchbendCheckBox.Name = "PitchbendCheckBox";
            this.PitchbendCheckBox.Size = new System.Drawing.Size(74, 17);
            this.PitchbendCheckBox.TabIndex = 4;
            this.PitchbendCheckBox.Text = "Pitchbend";
            this.PitchbendCheckBox.UseVisualStyleBackColor = true;
            // 
            // AftertouchCheckBox
            // 
            this.AftertouchCheckBox.AutoSize = true;
            this.AftertouchCheckBox.Location = new System.Drawing.Point(250, 2);
            this.AftertouchCheckBox.Name = "AftertouchCheckBox";
            this.AftertouchCheckBox.Size = new System.Drawing.Size(75, 17);
            this.AftertouchCheckBox.TabIndex = 3;
            this.AftertouchCheckBox.Text = "Aftertouch";
            this.AftertouchCheckBox.UseVisualStyleBackColor = true;
            // 
            // NoteOnCheckBox
            // 
            this.NoteOnCheckBox.AutoSize = true;
            this.NoteOnCheckBox.Location = new System.Drawing.Point(106, 2);
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
            this.NoteOffCheckBox.Location = new System.Drawing.Point(178, 2);
            this.NoteOffCheckBox.Name = "NoteOffCheckBox";
            this.NoteOffCheckBox.Size = new System.Drawing.Size(66, 17);
            this.NoteOffCheckBox.TabIndex = 0;
            this.NoteOffCheckBox.Text = "Note Off";
            this.NoteOffCheckBox.UseVisualStyleBackColor = true;
            // 
            // MidiForwarderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 485);
            this.Controls.Add(this.lowerPanel);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(524, 4096);
            this.MinimumSize = new System.Drawing.Size(524, 400);
            this.Name = "MidiForwarderForm";
            this.Text = "Xtream Midi Forwarder v2020.03.29";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MidiForwarderForm_FormClosed);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.upperPanel.ResumeLayout(false);
            this.upperPanel.PerformLayout();
            this.lowerPanel.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
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
        private System.Windows.Forms.ListBox EventsListBox;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Panel lowerPanel;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Label eventFilterLabel;
        private System.Windows.Forms.CheckBox NoteOffCheckBox;
        private System.Windows.Forms.CheckBox AftertouchCheckBox;
        private System.Windows.Forms.CheckBox NoteOnCheckBox;
        private System.Windows.Forms.CheckBox ControlChangeCheckBox;
        private System.Windows.Forms.CheckBox PitchbendCheckBox;
    }
}

