using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public IamHere()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (simulateEnabled.Checked)
            {
                IntPtr currentWindowSaved = GetForegroundWindow();

                //this.Focus();
                KeyboardSend.KeyPress(Keys.F24);
                
                SetForegroundWindow(currentWindowSaved);
            }
        }
    }
}
