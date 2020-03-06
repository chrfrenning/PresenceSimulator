using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresenceSimulator
{
	public partial class IamHere : Form
	{
		[DllImport("USER32.DLL", CharSet = CharSet.Unicode)] public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
		[DllImport("USER32.DLL")] public static extern bool SetForegroundWindow(IntPtr hWnd);
		[DllImport("USER32.DLL")] public static extern IntPtr GetForegroundWindow();
		[DllImport("USER32.DLL")] public static extern IntPtr GetDesktopWindow();

		public int DefaultTimerMinutes = 60;
		public DateTime startedTime;
		Image animationImage;
		Image stillImage;
		bool isQuittingForReal = false;
		public bool simulatorModeKeyboadPress = false; // if true, use keypress, if false use sysExecState

        public IamHere()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			minutesRemaining.Value = DefaultTimerMinutes = Properties.Settings.Default.DefaultTimeoutMinutes;
			animationImage = pictureBox1.Image;
			simulateEnabled.Checked = true;
			ConditionChangeEventHandler(null, null);

			timeoutEnabled.CheckedChanged += ConditionChangeEventHandler;
			minutesRemaining.ValueChanged += ConditionChangeEventHandler;
			simulateEnabled.CheckedChanged += ConditionChangeEventHandler;
		}

		private void ConditionChangeEventHandler(object sender, EventArgs e)
		{
			toolStripEnableIndefinite.Checked = false;
			toolStripEnable1h.Checked = false;
			toolStripEnable3h.Checked = false;
			toolStrip6hours.Checked = false;
			toolStripEnable12h.Checked = false;

			if (simulateEnabled.Checked)
			{
				if ( timeoutEnabled.Checked == false )
				{
					// indefinite
					toolStripEnableIndefinite.Checked = true;
				}
				else if ( minutesRemaining.Value == 60 )
				{
					toolStripEnable1h.Checked = true;
				}
				else if ( minutesRemaining.Value == 60 * 3 )
				{
					toolStripEnable3h.Checked = true;
				}
				else if ( minutesRemaining.Value == 60 * 6 )
				{
					toolStrip6hours.Checked = true;
				}
				else if  (minutesRemaining.Value == 60 * 12 )
				{
					toolStripEnable12h.Checked = true;
				}
			}
			else
			{
				// disabled
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (simulateEnabled.Checked)
			{
				if (toolStripSimModeKeyPress.Checked)
				{
					IntPtr currentWindowSaved = GetForegroundWindow();

					//this.Focus();
					KeyboardSend.KeyPress(Keys.F24);

					SetForegroundWindow(currentWindowSaved);
				}
				else
				{
					PowerMonitorControl.KeepSystemAwake();
				}

				if ( timeoutEnabled.Checked )
				{
					if (DateTime.Now.Subtract(startedTime).TotalMinutes > (double) minutesRemaining.Value)
						disabled.Checked = true;
				}
			}
		}

		private void simulateEnabled_CheckedChanged(object sender, EventArgs e)
		{
			if (simulateEnabled.Checked)
			{
				startedTime = DateTime.Now;
				pictureBox1.Image = animationImage;
				notifyIcon1.Icon = new Icon(Path.Combine(Application.StartupPath, "mario_star_icon.ico"));

				if (toolStripSimModeVideo.Checked)
				{
					PowerMonitorControl.KeepSystemAwake();
				}
			}
			else
			{
				//pictureBox1.Image.SelectActiveFrame(new FrameDimension(pictureBox1.Image.FrameDimensionsList[0]), 0);
				stillImage = pictureBox1.Image.GetThumbnailImage(animationImage.Width, animationImage.Height, null, IntPtr.Zero);
				pictureBox1.Image = stillImage;
				notifyIcon1.Icon = new Icon(Path.Combine(Application.StartupPath, "mushroom_icon.ico"));

				//if (!simulatorModeKeyboardPress)
				{
					PowerMonitorControl.AllowSystemSleep();
				}
			}

			toolStripEnable.Checked = simulateEnabled.Checked;
			toolStripDisable.Checked = !simulateEnabled.Checked;
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{

		}

		private void IamHere_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!isQuittingForReal)
			{
				this.Hide();
				e.Cancel = true;
			}
		}

		private void toolStripDisable_Click(object sender, EventArgs e)
		{
			disabled.Checked = true;
		}

		private void toolStripEnable_Click(object sender, EventArgs e)
		{
		}

		private void toolStripSettings_Click(object sender, EventArgs e)
		{
			this.Show();
		}

		private void toolStripQuit_Click(object sender, EventArgs e)
		{
			isQuittingForReal = true;
			Close();

			Application.Exit();
		}

		private void toolStripEnable1h_Click(object sender, EventArgs e)
		{
			timeoutEnabled.Checked = true;
			minutesRemaining.Value = 1 * 60;

			if (!simulateEnabled.Checked)
				simulateEnabled.Checked = true;
		}

		private void toolStripEnable3h_Click(object sender, EventArgs e)
		{
			timeoutEnabled.Checked = true;
			minutesRemaining.Value = 3 * 60;

			if (!simulateEnabled.Checked)
				simulateEnabled.Checked = true;
		}

		private void toolStripEnable12h_Click(object sender, EventArgs e)
		{
			timeoutEnabled.Checked = true;
			minutesRemaining.Value = 12 * 60;

			if (!simulateEnabled.Checked)
				simulateEnabled.Checked = true;
		}

		private void toolStrip6hours_Click(object sender, EventArgs e)
		{
			timeoutEnabled.Checked = true;
			minutesRemaining.Value = 6 * 60;

			if (!simulateEnabled.Checked)
				simulateEnabled.Checked = true;
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void toolStripEnableIndefinite_Click(object sender, EventArgs e)
		{
			timeoutEnabled.Checked = false;
			simulateEnabled.Checked = true;
		}

		private void toolStripSimModeKeyPress_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void toolStripSimModeVideo_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void toolTipUpdater_Tick(object sender, EventArgs e)
		{
			if (simulateEnabled.Checked)
			{
				string activity = toolStripSimModeVideo.Checked ? "video playing" : "user activity";

				if (!timeoutEnabled.Checked)
				{
					notifyIcon1.Text = $"Enabled, simulating {activity}";
				}
				else
				{
					notifyIcon1.Text = $"Enabled, simulating {activity}, {startedTime.AddMinutes((double)minutesRemaining.Value).Subtract(DateTime.Now).ToString()} remaining.";
				}
			}
			else
			{
				notifyIcon1.Text = "Disabled.";
			}
		}

		private void toolStripSimModeKeyPress_Click(object sender, EventArgs e)
		{
			toolStripSimModeVideo.Checked = false;
			toolStripSimModeKeyPress.Checked = true;
		}

		private void toolStripSimModeVideo_Click(object sender, EventArgs e)
		{
			toolStripSimModeVideo.Checked = true;
			toolStripSimModeKeyPress.Checked = false;
		}
	}
}
