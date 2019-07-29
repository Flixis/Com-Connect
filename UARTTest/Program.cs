using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using AutoUpdaterDotNET;

namespace UARTTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            //check for updates before starting app
            AutoUpdater.Start("http://welldonelasagna.com/latestrelease.xml");
            AutoUpdater.UpdateFormSize = new System.Drawing.Size(800, 600);
            AutoUpdater.DownloadPath = Environment.CurrentDirectory;
            AutoUpdater.Mandatory = false;
            AutoUpdater.OpenDownloadPage = false;
            AutoUpdater.ReportErrors = true;

            //Try to load app
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new AppForm());
            }
            catch (Exception err)//If failed to launch display error in message box
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
