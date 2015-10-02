using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDialerConfig
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Standard hardcoded value to take for granted if no parameter is passed through the 'console'
            string configFilePath = @"C:\Autodial\Dialing\AutoDial_0.14\AutoDial.exe.config";
            if (args.Length > 1)
            {
                configFilePath = args[1];
            }
            Application.Run(new Form1(configFilePath));
        }
    }
}
