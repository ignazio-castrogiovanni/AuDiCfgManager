using System;
using System.IO;
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
        private string m_strConfigFilePath;
        Dictionary<string, string> m_dictKeys;
        public Form1(string strConfigFilePath)
        {
            m_dictKeys = new Dictionary<string, string>();
            InitializeComponent();
            ReadConfigSettings(strConfigFilePath);
            updateUI();
        }

        private void ReadConfigSettings(string strConfigFilePath)
        {
            // Open the xml file
            XmlDocument xmlConfigDoc = new XmlDocument();
            xmlConfigDoc.Load(strConfigFilePath);

            // Read all the app tag and fill the configMap with key and value
            XmlNodeList xmlNLAppTags = xmlConfigDoc.GetElementsByTagName("add");
            for(int i = 0; i < xmlNLAppTags.Count; ++i)
            {
                XmlNode xmlCurrNode = xmlNLAppTags.Item(i);
                m_dictKeys.Add(xmlCurrNode.Attributes["key"].Value, xmlCurrNode.Attributes["value"].Value);
            }

            Console.WriteLine("Finished reading");
        }

        // Later on, Look on the configMap to update the UI
        private void updateUI()
        {
            if (m_dictKeys.ContainsKey("targetProcessName"))
            {
                this.labelTargetProcessName.Text = m_dictKeys["targetProcessName"];
            }

            if (m_dictKeys.ContainsKey("targetProcessName"))
            {
                this.labelTalkProcessName.Text = m_dictKeys["talkProcessName"];
            }

            if (m_dictKeys.ContainsKey("programFileLocation"))
            {
                this.textBoxTalkFileLocation.Text = m_dictKeys["programFileLocation"];
            }
            //textBoxLocationX
            if (m_dictKeys.ContainsKey("captureLocationX"))
            {
                this.textBoxLocationX.Text = m_dictKeys["captureLocationX"];
            }

            if (m_dictKeys.ContainsKey("captureLocationY"))
            {
                this.textBoxLocationY.Text = m_dictKeys["captureLocationY"];
            }

            if (m_dictKeys.ContainsKey("captureWidth"))
            {
                this.textBoxCaptureWidth.Text = m_dictKeys["captureWidth"];
            }

            if (m_dictKeys.ContainsKey("captureHeight"))
            {
                this.textBoxCaptureHeight.Text = m_dictKeys["captureHeight"];
            }

            if (m_dictKeys.ContainsKey("alertSound"))
            {
                string strAlertSound = m_dictKeys["alertSound"];
                this.textBoxAlertSound.Text = strAlertSound;

                if (strAlertSound != "")
                {
                    this.checkBoxAlertSound.Checked = true;
                    this.textBoxAlertSound.Enabled = true;

                    if (m_dictKeys.ContainsKey("alertDelay"))
                    {
                        this.textBoxSoundDelay.Text = m_dictKeys["alertDelay"];
                    }
                }
            }
            else
            {
                this.checkBoxAlertSound.Enabled = false;
                this.textBoxAlertSound.Text = "";
                this.textBoxAlertSound.Enabled = false;
            }

            if (m_dictKeys.ContainsKey("numberOverride") && m_dictKeys["numberOverride"] != "")
            {
                this.checkBoxNumberOverride.Checked = true;
                this.textBoxNumberOverride.Enabled = true;
                this.textBoxNumberOverride.Text = m_dictKeys["numberOverride"];
            }
            else
            {
                this.checkBoxNumberOverride.Checked = false;
                this.textBoxNumberOverride.Text = "";
                this.textBoxNumberOverride.Enabled = false;
            }

            if (m_dictKeys.ContainsKey("cleanupFolder") && m_dictKeys["cleanupFolder"] == "true")
            {
                this.checkBoxCleanup.Checked = true;
            }
            else
            {
                this.checkBoxCleanup.Checked = false;
            }
        }

        private void checkBoxNumberOverride_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxNumberOverride.Checked == true)
            {
                this.textBoxNumberOverride.Enabled = true;
            }
            else
            {
                this.textBoxNumberOverride.Enabled = false;
            }
        }

        private void checkBoxAlertSound_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAlertSound.Checked == true)
            {
                this.textBoxAlertSound.Enabled = true;
                this.textBoxSoundDelay.Enabled = true;
                this.buttonSoundFileLocation.Enabled = true;
            }
            else
            {
                this.textBoxAlertSound.Enabled = false;
                this.textBoxSoundDelay.Enabled = false;
                this.buttonSoundFileLocation.Enabled = false;
            }
        }

        private void buttonChangeFileLocation_Click(object sender, EventArgs e)
        {
            this.openFileDialogTalk.Title = "Open target process (Talk) file";
            this.openFileDialogTalk.RestoreDirectory = true;
            this.openFileDialogTalk.Filter = "Exe files (*.exe)|*.exe";
           
            DialogResult talkFileResult = this.openFileDialogTalk.ShowDialog();

            if (talkFileResult == DialogResult.OK)
            {
                this.textBoxTalkFileLocation.Text = openFileDialogTalk.FileName;
            }
        }

        private void buttonSoundFileLocation_Click(object sender, EventArgs e)
        {
            this.openFileDialogSound.Title = "Open alert sound file";
            this.openFileDialogSound.Filter = "Wav files (*.wav)|*.wav";

            DialogResult soundFileResult = this.openFileDialogSound.ShowDialog();

            if (soundFileResult == DialogResult.OK)
            {
                this.textBoxAlertSound.Text = openFileDialogSound.FileName;
            }
        }
        
        // Later on, on value changed update configMap.

        // Later on, on save write the value in the xml file 

    }
}
