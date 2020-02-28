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
        public int LastMinuteChecked;
        Image animationImage;
        Image stillImage;
        bool isQuittingForReal = false;

        public IamHere()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            minutesRemaining.Value = DefaultTimerMinutes = Properties.Settings.Default.DefaultTimeoutMinutes;
            animationImage = pictureBox1.Image;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (simulateEnabled.Checked)
            {
                IntPtr currentWindowSaved = GetForegroundWindow();

                //this.Focus();
                KeyboardSend.KeyPress(Keys.F24);
                
                SetForegroundWindow(currentWindowSaved);

                int nowMinute = DateTime.Now.Minute;
                if (LastMinuteChecked != nowMinute)
                    minutesRemaining.Value--;
                if (minutesRemaining.Value == 0)
                    disabled.Checked = true;
            }
        }

        private void simulateEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (simulateEnabled.Checked && minutesRemaining.Value == 0)
                minutesRemaining.Value = DefaultTimerMinutes;

            if (simulateEnabled.Checked)
            {
                LastMinuteChecked = DateTime.Now.Minute;
                pictureBox1.Image = animationImage;
                notifyIcon1.Icon = new Icon(Path.Combine(Application.StartupPath, "mario_star_icon.ico"));
            }
            else
            {
                //pictureBox1.Image.SelectActiveFrame(new FrameDimension(pictureBox1.Image.FrameDimensionsList[0]), 0);
                stillImage = pictureBox1.Image.GetThumbnailImage(animationImage.Width, animationImage.Height, null, IntPtr.Zero);
                pictureBox1.Image = stillImage;
                notifyIcon1.Icon = new Icon(Path.Combine(Application.StartupPath, "mushroom_icon.ico"));
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
            simulateEnabled.Checked = true;
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
            minutesRemaining.Value = 1 * 60;

            if (!simulateEnabled.Checked)
                simulateEnabled.Checked = true;
        }

        private void toolStripEnable3h_Click(object sender, EventArgs e)
        {
            minutesRemaining.Value = 3 * 60;

            if (!simulateEnabled.Checked)
                simulateEnabled.Checked = true;
        }

        private void toolStripEnable12h_Click(object sender, EventArgs e)
        {
            minutesRemaining.Value = 12 * 60;

            if (!simulateEnabled.Checked)
                simulateEnabled.Checked = true;
        }

        private void toolStrip6hours_Click(object sender, EventArgs e)
        {
            minutesRemaining.Value = 6 * 60;

            if (!simulateEnabled.Checked)
                simulateEnabled.Checked = true;
        }
    }
}
