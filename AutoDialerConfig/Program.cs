using System;
using System.IO;
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
            if (args.Length > 0)
            {
                if (File.Exists(args[0]))
                {
                    configFilePath = args[0];
                }
                else
                {
                    string strErrorMsg = String.Format("Couldn't find configuration file {0}. Default config file set: {1}", 
                                                args[0], 
                                                configFilePath);

                    System.Windows.Forms.MessageBox.Show(strErrorMsg);
                }
            }
            Application.Run(new Form1(configFilePath));
        }
    }
}
