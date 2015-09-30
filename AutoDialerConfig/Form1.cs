using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDialerConfig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string strAutodialerConfigFile = @"AutoDial.exe.config";
            InitializeComponent();
            ReadConfigSettings(strAutodialerConfigFile);
        }

        private void ReadConfigSettings(string strAutodialerConfigFile)
        {
            // Have a look at http://stackoverflow.com/questions/10150785/using-xmltextreader
            XmlTextReader xmlReader = new XmlTextReader(strAutodialerConfigFile);

        }

    }
}
