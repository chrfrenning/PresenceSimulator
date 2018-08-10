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
            this.keyPresser = new System.Windows.Forms.Timer(this.components);
            this.simulateEnabled = new System.Windows.Forms.RadioButton();
            this.disabled = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.simulateEnabled.Location = new System.Drawing.Point(13, 14);
            this.simulateEnabled.Margin = new System.Windows.Forms.Padding(2);
            this.simulateEnabled.Name = "simulateEnabled";
            this.simulateEnabled.Size = new System.Drawing.Size(166, 24);
            this.simulateEnabled.TabIndex = 1;
            this.simulateEnabled.TabStop = true;
            this.simulateEnabled.Text = "Simulate presence";
            this.simulateEnabled.UseVisualStyleBackColor = true;
            // 
            // disabled
            // 
            this.disabled.AutoSize = true;
            this.disabled.Location = new System.Drawing.Point(183, 14);
            this.disabled.Margin = new System.Windows.Forms.Padding(2);
            this.disabled.Name = "disabled";
            this.disabled.Size = new System.Drawing.Size(96, 24);
            this.disabled.TabIndex = 1;
            this.disabled.Text = "Disabled";
            this.disabled.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.simulateEnabled);
            this.flowLayoutPanel1.Controls.Add(this.disabled);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(351, 54);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 104);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBox1.Text = "Enabled";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 30);
            this.toolStripMenuItem1.Text = "Enabled itm";
            // 
            // IamHere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 70);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IamHere";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "I\'m Here";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

