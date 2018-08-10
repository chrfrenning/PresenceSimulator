﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresenceSimulator
{
    static class Program
    {
        static Mutex mtx = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (AnInstanceAlreadyRunning())
            {
# if DEBUG
                MessageBox.Show("An instance is already running");
#endif
                return;
            }
                

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.AddMessageFilter(new MouseMessageFilter());
            MouseMessageFilter.MouseMove += new MouseEventHandler(OnGlobalMouseMove);

            Application.Run(new IamHere());
        }

        private static bool AnInstanceAlreadyRunning()
        {
            string mutexName = $"presenceSimulator.{System.Security.Principal.WindowsIdentity.GetCurrent().Name.Replace('\\', '.')}";
            if (Mutex.TryOpenExisting(mutexName, out mtx))
                return true;

            bool createdNew = false;
            mtx = new Mutex(true, mutexName, out createdNew);

            return false;
        }

        private static void OnGlobalMouseMove(object sender, MouseEventArgs e)
        {
            Debug.WriteLine(e.Location.ToString());
        }
    }
}
