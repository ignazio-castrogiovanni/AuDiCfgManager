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
        private XmlDocument m_xmlDocConfig;
        Dictionary<string, string> m_dictKeys;

        public Form1(string strConfigFilePath)
        {
            InitializeComponent();
            this.labelADConfigFile.Text = strConfigFilePath;
            
            m_dictKeys = new Dictionary<string, string>();

            ReadConfigSettings(strConfigFilePath);
            updateUI();
        }

        private void ReadConfigSettings(string strConfigFilePath)
        {
            m_strConfigFilePath = strConfigFilePath;
            // Open the xml file
            m_xmlDocConfig = new XmlDocument();
            m_xmlDocConfig.Load(m_strConfigFilePath);

            // Read all the app tag and fill the configMap with key and value
            XmlNodeList xmlNLAppTags = m_xmlDocConfig.GetElementsByTagName("add");
            for(int i = 0; i < xmlNLAppTags.Count; ++i)
            {
                // bool isCapital = nodes.Attributes["IsCapital"] != null;

                XmlNode xmlCurrNode = xmlNLAppTags.Item(i);
                if (xmlCurrNode.Attributes["key"] != null && xmlCurrNode.Attributes["value"] != null)
                {
                    string strCurrKey = xmlCurrNode.Attributes["key"].Value;
                    string strCurrVal = xmlCurrNode.Attributes["value"].Value;
                    m_dictKeys.Add(strCurrKey, strCurrVal);
                }
                
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

                    if (m_dictKeys.ContainsKey("alertDelay"))
                    {
                        this.textBoxSoundDelay.Text = m_dictKeys["alertDelay"];
                    }
                    else
                    {
                        this.textBoxSoundDelay.Text = "";
                        this.textBoxSoundDelay.Enabled = false;
                    }
                }
            }
            else
            {
                this.textBoxAlertSound.Text = "";
                this.textBoxAlertSound.Enabled = false;

                this.textBoxSoundDelay.Text = "";
                this.textBoxSoundDelay.Enabled = false;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Ask user for confirmation before saving config file
            DialogResult dialogAreYouSure = MessageBox.Show("Are you sure you want to save config values?", "Save config values", MessageBoxButtons.YesNo);
            if (dialogAreYouSure == DialogResult.Yes)
            {
                storeUiConfigInDictionary();
                updateConfigFile();
            }
        }

        private void storeUiConfigInDictionary()
        {
            m_dictKeys["programFileLocation"] = this.textBoxTalkFileLocation.Text;

            m_dictKeys["captureLocationX"] = this.textBoxLocationX.Text;

            m_dictKeys["captureLocationY"] = this.textBoxLocationY.Text;

            m_dictKeys["captureWidth"] = this.textBoxCaptureWidth.Text;

            m_dictKeys["captureHeight"] = this.textBoxCaptureHeight.Text;

            // Number override
            if (this.checkBoxNumberOverride.Checked == true)
            {
                m_dictKeys["numberOverride"] = this.textBoxNumberOverride.Text;
            }
            else
            {
                m_dictKeys["numberOverride"] = "";
            }

            // Sound alert
            if (this.checkBoxAlertSound.Checked == true)
            {
                m_dictKeys["alertSound"] = this.textBoxAlertSound.Text;
                m_dictKeys["alertDelay"] = this.textBoxSoundDelay.Text;
            }
            else
            {
                m_dictKeys["alertSound"] = "";
                m_dictKeys["alertDelay"] = "";
            }

            // Cleanup option
            if (this.checkBoxCleanup.Checked == true)
            {
                m_dictKeys["cleanupFolder"] = "true";
            }
            else
            {
                m_dictKeys["cleanupFolder"] = "false";
            }

            Console.WriteLine("Ohh yeah ohh yeah!");
            // Save values in config file.
        }

        private void updateConfigFile()
        {
            XmlNodeList xmlNodeList = m_xmlDocConfig.SelectNodes("/configuration/appSettings/add");
            List<string> keyList = new List<string>(this.m_dictKeys.Keys);

            for (int i = 0; i < keyList.Count; ++i)
            {
                // Get current key
                string strKey = keyList.ElementAt(i);
                
                // Look for that key in the xml and change it.
                foreach (XmlNode node in xmlNodeList)
                {
                    // Get node key
                    XmlAttribute keyAttr = node.Attributes["key"];
                    if(keyAttr.Value == strKey)
                    {
                        XmlAttribute valueAttr = node.Attributes["value"];
                        string strValue = "";
                        if(m_dictKeys.TryGetValue(strKey, out strValue))
                        {
                            valueAttr.Value = strValue;
                        }
                    }
                }
            }
            m_xmlDocConfig.Save(m_strConfigFilePath);
        }
    }
}
