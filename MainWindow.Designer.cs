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
            this.label1 = new System.Windows.Forms.Label();
            this.minutesRemaining = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEnable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDisable = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.simulateEnabled.Checked = true;
            this.simulateEnabled.Location = new System.Drawing.Point(79, 12);
            this.simulateEnabled.Margin = new System.Windows.Forms.Padding(2);
            this.simulateEnabled.Name = "simulateEnabled";
            this.simulateEnabled.Size = new System.Drawing.Size(146, 21);
            this.simulateEnabled.TabIndex = 1;
            this.simulateEnabled.TabStop = true;
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
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.minutesRemaining);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 6);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(558, 77);
            this.flowLayoutPanel1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "For another (minutes)";
            // 
            // minutesRemaining
            // 
            this.minutesRemaining.Location = new System.Drawing.Point(469, 13);
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
            this.toolStripSettings,
            this.toolStripSeparator1,
            this.toolStripQuit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 114);
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(210, 24);
            this.toolStripSettings.Text = "&Settings";
            this.toolStripSettings.Click += new System.EventHandler(this.toolStripSettings_Click);
            // 
            // toolStripEnable
            // 
            this.toolStripEnable.Checked = true;
            this.toolStripEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripEnable.Name = "toolStripEnable";
            this.toolStripEnable.Size = new System.Drawing.Size(210, 24);
            this.toolStripEnable.Text = "&Enabled";
            this.toolStripEnable.Click += new System.EventHandler(this.toolStripEnable_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // toolStripQuit
            // 
            this.toolStripQuit.Name = "toolStripQuit";
            this.toolStripQuit.Size = new System.Drawing.Size(210, 24);
            this.toolStripQuit.Text = "&Quit";
            this.toolStripQuit.Click += new System.EventHandler(this.toolStripQuit_Click);
            // 
            // toolStripDisable
            // 
            this.toolStripDisable.Name = "toolStripDisable";
            this.toolStripDisable.Size = new System.Drawing.Size(210, 24);
            this.toolStripDisable.Text = "&Disabled";
            this.toolStripDisable.Click += new System.EventHandler(this.toolStripDisable_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mario_star_icon.ico");
            this.imageList1.Images.SetKeyName(1, "mario_shell_icon.ico");
            this.imageList1.Images.SetKeyName(2, "mushroom_icon.ico");
            // 
            // IamHere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 89);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown minutesRemaining;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripEnable;
        private System.Windows.Forms.ToolStripMenuItem toolStripDisable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripQuit;
        private System.Windows.Forms.ImageList imageList1;
    }
}

