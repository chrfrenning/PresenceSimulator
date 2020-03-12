namespace PresenceSimulator
{
    partial class IamHere
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IamHere));
			this.keyPresser = new System.Windows.Forms.Timer(this.components);
			this.simulateEnabled = new System.Windows.Forms.RadioButton();
			this.disabled = new System.Windows.Forms.RadioButton();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timeoutEnabled = new System.Windows.Forms.CheckBox();
			this.minutesRemaining = new System.Windows.Forms.NumericUpDown();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripEnable = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripEnable1h = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripEnable3h = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip6hours = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip8hours = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripEnable12h = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripEnableIndefinite = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDisable = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMode = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSimModeKeyPress = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSimModeVideo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripQuit = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolTipUpdater = new System.Windows.Forms.Timer(this.components);
			this.toolStrip18hours = new System.Windows.Forms.ToolStripMenuItem();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minutesRemaining)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// keyPresser
			// 
			this.keyPresser.Enabled = true;
			this.keyPresser.Interval = 30000;
			this.keyPresser.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// simulateEnabled
			// 
			this.simulateEnabled.AutoSize = true;
			this.simulateEnabled.Location = new System.Drawing.Point(79, 12);
			this.simulateEnabled.Margin = new System.Windows.Forms.Padding(2);
			this.simulateEnabled.Name = "simulateEnabled";
			this.simulateEnabled.Size = new System.Drawing.Size(146, 21);
			this.simulateEnabled.TabIndex = 1;
			this.simulateEnabled.Text = "Simulate presence";
			this.simulateEnabled.UseVisualStyleBackColor = true;
			this.simulateEnabled.CheckedChanged += new System.EventHandler(this.simulateEnabled_CheckedChanged);
			// 
			// disabled
			// 
			this.disabled.AutoSize = true;
			this.disabled.Location = new System.Drawing.Point(229, 12);
			this.disabled.Margin = new System.Windows.Forms.Padding(2);
			this.disabled.Name = "disabled";
			this.disabled.Size = new System.Drawing.Size(84, 21);
			this.disabled.TabIndex = 1;
			this.disabled.Text = "Disabled";
			this.disabled.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
			this.flowLayoutPanel1.Controls.Add(this.simulateEnabled);
			this.flowLayoutPanel1.Controls.Add(this.disabled);
			this.flowLayoutPanel1.Controls.Add(this.timeoutEnabled);
			this.flowLayoutPanel1.Controls.Add(this.minutesRemaining);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 6);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(783, 77);
			this.flowLayoutPanel1.TabIndex = 2;
			this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(13, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(61, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// timeoutEnabled
			// 
			this.timeoutEnabled.AutoSize = true;
			this.timeoutEnabled.Location = new System.Drawing.Point(318, 13);
			this.timeoutEnabled.Name = "timeoutEnabled";
			this.timeoutEnabled.Size = new System.Drawing.Size(181, 21);
			this.timeoutEnabled.TabIndex = 5;
			this.timeoutEnabled.Text = "Time out after (minutes)";
			this.timeoutEnabled.UseVisualStyleBackColor = true;
			// 
			// minutesRemaining
			// 
			this.minutesRemaining.Location = new System.Drawing.Point(505, 13);
			this.minutesRemaining.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.minutesRemaining.Name = "minutesRemaining";
			this.minutesRemaining.Size = new System.Drawing.Size(69, 22);
			this.minutesRemaining.TabIndex = 2;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "I\'m here";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEnable,
            this.toolStripDisable,
            this.toolStripMode,
            this.toolStripSettings,
            this.toolStripSeparator1,
            this.toolStripQuit});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(211, 168);
			// 
			// toolStripEnable
			// 
			this.toolStripEnable.Checked = true;
			this.toolStripEnable.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripEnable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEnable1h,
            this.toolStripEnable3h,
            this.toolStrip6hours,
            this.toolStrip8hours,
            this.toolStripEnable12h,
            this.toolStrip18hours,
            this.toolStripEnableIndefinite});
			this.toolStripEnable.Name = "toolStripEnable";
			this.toolStripEnable.Size = new System.Drawing.Size(210, 26);
			this.toolStripEnable.Text = "&Enabled";
			this.toolStripEnable.Click += new System.EventHandler(this.toolStripEnable_Click);
			// 
			// toolStripEnable1h
			// 
			this.toolStripEnable1h.Name = "toolStripEnable1h";
			this.toolStripEnable1h.Size = new System.Drawing.Size(224, 26);
			this.toolStripEnable1h.Text = "1 hour";
			this.toolStripEnable1h.Click += new System.EventHandler(this.toolStripEnable1h_Click);
			// 
			// toolStripEnable3h
			// 
			this.toolStripEnable3h.Name = "toolStripEnable3h";
			this.toolStripEnable3h.Size = new System.Drawing.Size(224, 26);
			this.toolStripEnable3h.Text = "3 hours";
			this.toolStripEnable3h.Click += new System.EventHandler(this.toolStripEnable3h_Click);
			// 
			// toolStrip6hours
			// 
			this.toolStrip6hours.Name = "toolStrip6hours";
			this.toolStrip6hours.Size = new System.Drawing.Size(224, 26);
			this.toolStrip6hours.Text = "6 hours";
			this.toolStrip6hours.Click += new System.EventHandler(this.toolStrip6hours_Click);
			// 
			// toolStrip8hours
			// 
			this.toolStrip8hours.Name = "toolStrip8hours";
			this.toolStrip8hours.Size = new System.Drawing.Size(224, 26);
			this.toolStrip8hours.Text = "8 hours";
			this.toolStrip8hours.Click += new System.EventHandler(this.toolStrip8hours_Click);
			// 
			// toolStripEnable12h
			// 
			this.toolStripEnable12h.Name = "toolStripEnable12h";
			this.toolStripEnable12h.Size = new System.Drawing.Size(224, 26);
			this.toolStripEnable12h.Text = "12 hours";
			this.toolStripEnable12h.Click += new System.EventHandler(this.toolStripEnable12h_Click);
			// 
			// toolStripEnableIndefinite
			// 
			this.toolStripEnableIndefinite.Name = "toolStripEnableIndefinite";
			this.toolStripEnableIndefinite.Size = new System.Drawing.Size(224, 26);
			this.toolStripEnableIndefinite.Text = "Indefinite";
			this.toolStripEnableIndefinite.Click += new System.EventHandler(this.toolStripEnableIndefinite_Click);
			// 
			// toolStripDisable
			// 
			this.toolStripDisable.Name = "toolStripDisable";
			this.toolStripDisable.Size = new System.Drawing.Size(210, 26);
			this.toolStripDisable.Text = "&Disabled";
			this.toolStripDisable.Click += new System.EventHandler(this.toolStripDisable_Click);
			// 
			// toolStripMode
			// 
			this.toolStripMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSimModeKeyPress,
            this.toolStripSimModeVideo});
			this.toolStripMode.Name = "toolStripMode";
			this.toolStripMode.Size = new System.Drawing.Size(210, 26);
			this.toolStripMode.Text = "Mode";
			// 
			// toolStripSimModeKeyPress
			// 
			this.toolStripSimModeKeyPress.Name = "toolStripSimModeKeyPress";
			this.toolStripSimModeKeyPress.Size = new System.Drawing.Size(250, 26);
			this.toolStripSimModeKeyPress.Text = "Key Press Simulation";
			this.toolStripSimModeKeyPress.CheckedChanged += new System.EventHandler(this.toolStripSimModeKeyPress_CheckedChanged);
			this.toolStripSimModeKeyPress.Click += new System.EventHandler(this.toolStripSimModeKeyPress_Click);
			// 
			// toolStripSimModeVideo
			// 
			this.toolStripSimModeVideo.Checked = true;
			this.toolStripSimModeVideo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripSimModeVideo.Name = "toolStripSimModeVideo";
			this.toolStripSimModeVideo.Size = new System.Drawing.Size(250, 26);
			this.toolStripSimModeVideo.Text = "Video Player Simulation";
			this.toolStripSimModeVideo.CheckedChanged += new System.EventHandler(this.toolStripSimModeVideo_CheckedChanged);
			this.toolStripSimModeVideo.Click += new System.EventHandler(this.toolStripSimModeVideo_Click);
			// 
			// toolStripSettings
			// 
			this.toolStripSettings.Name = "toolStripSettings";
			this.toolStripSettings.Size = new System.Drawing.Size(210, 26);
			this.toolStripSettings.Text = "&Settings";
			this.toolStripSettings.Visible = false;
			this.toolStripSettings.Click += new System.EventHandler(this.toolStripSettings_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
			// 
			// toolStripQuit
			// 
			this.toolStripQuit.Name = "toolStripQuit";
			this.toolStripQuit.Size = new System.Drawing.Size(210, 26);
			this.toolStripQuit.Text = "&Quit";
			this.toolStripQuit.Click += new System.EventHandler(this.toolStripQuit_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "mario_star_icon.ico");
			this.imageList1.Images.SetKeyName(1, "mario_shell_icon.ico");
			this.imageList1.Images.SetKeyName(2, "mushroom_icon.ico");
			// 
			// toolTipUpdater
			// 
			this.toolTipUpdater.Enabled = true;
			this.toolTipUpdater.Interval = 500;
			this.toolTipUpdater.Tick += new System.EventHandler(this.toolTipUpdater_Tick);
			// 
			// toolStrip18hours
			// 
			this.toolStrip18hours.Name = "toolStrip18hours";
			this.toolStrip18hours.Size = new System.Drawing.Size(224, 26);
			this.toolStrip18hours.Text = "18 hours";
			this.toolStrip18hours.Click += new System.EventHandler(this.toolStrip18hours_Click);
			// 
			// IamHere
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(797, 89);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "IamHere";
			this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.Text = "I\'m Here";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IamHere_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minutesRemaining)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer keyPresser;
        private System.Windows.Forms.RadioButton simulateEnabled;
        private System.Windows.Forms.RadioButton disabled;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NumericUpDown minutesRemaining;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox timeoutEnabled;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripEnable;
		private System.Windows.Forms.ToolStripMenuItem toolStripEnable1h;
		private System.Windows.Forms.ToolStripMenuItem toolStripEnable3h;
		private System.Windows.Forms.ToolStripMenuItem toolStrip6hours;
		private System.Windows.Forms.ToolStripMenuItem toolStripEnable12h;
		private System.Windows.Forms.ToolStripMenuItem toolStripEnableIndefinite;
		private System.Windows.Forms.ToolStripMenuItem toolStripDisable;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripQuit;
		private System.Windows.Forms.ToolStripMenuItem toolStripMode;
		private System.Windows.Forms.ToolStripMenuItem toolStripSimModeKeyPress;
		private System.Windows.Forms.ToolStripMenuItem toolStripSimModeVideo;
		private System.Windows.Forms.ToolStripMenuItem toolStripSettings;
		private System.Windows.Forms.Timer toolTipUpdater;
		private System.Windows.Forms.ToolStripMenuItem toolStrip8hours;
		private System.Windows.Forms.ToolStripMenuItem toolStrip18hours;
	}
}

