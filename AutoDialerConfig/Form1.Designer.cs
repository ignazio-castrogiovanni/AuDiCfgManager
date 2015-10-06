namespace AutoDialerConfig
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogoPictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTalkFileLocation = new System.Windows.Forms.TextBox();
            this.buttonChangeFileLocation = new System.Windows.Forms.Button();
            this.labelTargetProcessName = new System.Windows.Forms.Label();
            this.labelTalkProcessName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLocationX = new System.Windows.Forms.TextBox();
            this.textBoxLocationY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCaptureHeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCaptureWidth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxAlertSound = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAlertSound = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxSoundDelay = new System.Windows.Forms.TextBox();
            this.checkBoxCleanup = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxNumberOverride = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNumberOverride = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSoundFileLocation = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialogTalk = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogSound = new System.Windows.Forms.OpenFileDialog();
            this.labelADConfigFile = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surveycraft Process Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Talk Process Name:";
            // 
            // LogoPictureBox1
            // 
            this.LogoPictureBox1.Image = global::AutoDialerConfig.Properties.Resources.rW2EoD2B_bigger;
            this.LogoPictureBox1.InitialImage = global::AutoDialerConfig.Properties.Resources.rW2EoD2B_bigger;
            this.LogoPictureBox1.Location = new System.Drawing.Point(208, 12);
            this.LogoPictureBox1.Name = "LogoPictureBox1";
            this.LogoPictureBox1.Size = new System.Drawing.Size(77, 77);
            this.LogoPictureBox1.TabIndex = 4;
            this.LogoPictureBox1.TabStop = false;
            this.LogoPictureBox1.WaitOnLoad = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Talk File Location:";
            // 
            // textBoxTalkFileLocation
            // 
            this.textBoxTalkFileLocation.Location = new System.Drawing.Point(12, 92);
            this.textBoxTalkFileLocation.Name = "textBoxTalkFileLocation";
            this.textBoxTalkFileLocation.Size = new System.Drawing.Size(417, 20);
            this.textBoxTalkFileLocation.TabIndex = 6;
            this.textBoxTalkFileLocation.TabStop = false;
            // 
            // buttonChangeFileLocation
            // 
            this.buttonChangeFileLocation.Location = new System.Drawing.Point(435, 89);
            this.buttonChangeFileLocation.Name = "buttonChangeFileLocation";
            this.buttonChangeFileLocation.Size = new System.Drawing.Size(32, 23);
            this.buttonChangeFileLocation.TabIndex = 7;
            this.buttonChangeFileLocation.Text = "...";
            this.buttonChangeFileLocation.UseVisualStyleBackColor = true;
            this.buttonChangeFileLocation.Click += new System.EventHandler(this.buttonChangeFileLocation_Click);
            // 
            // labelTargetProcessName
            // 
            this.labelTargetProcessName.AutoSize = true;
            this.labelTargetProcessName.Location = new System.Drawing.Point(189, 19);
            this.labelTargetProcessName.Name = "labelTargetProcessName";
            this.labelTargetProcessName.Size = new System.Drawing.Size(58, 13);
            this.labelTargetProcessName.TabIndex = 8;
            this.labelTargetProcessName.Text = "(not found)";
            // 
            // labelTalkProcessName
            // 
            this.labelTalkProcessName.AutoSize = true;
            this.labelTalkProcessName.Location = new System.Drawing.Point(189, 48);
            this.labelTalkProcessName.Name = "labelTalkProcessName";
            this.labelTalkProcessName.Size = new System.Drawing.Size(58, 13);
            this.labelTalkProcessName.TabIndex = 9;
            this.labelTalkProcessName.Text = "(not found)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Capture Location:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "X:";
            // 
            // textBoxLocationX
            // 
            this.textBoxLocationX.Location = new System.Drawing.Point(207, 23);
            this.textBoxLocationX.Name = "textBoxLocationX";
            this.textBoxLocationX.Size = new System.Drawing.Size(30, 20);
            this.textBoxLocationX.TabIndex = 15;
            // 
            // textBoxLocationY
            // 
            this.textBoxLocationY.Location = new System.Drawing.Point(278, 23);
            this.textBoxLocationY.Name = "textBoxLocationY";
            this.textBoxLocationY.Size = new System.Drawing.Size(30, 20);
            this.textBoxLocationY.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Y:";
            // 
            // textBoxCaptureHeight
            // 
            this.textBoxCaptureHeight.Location = new System.Drawing.Point(278, 54);
            this.textBoxCaptureHeight.Name = "textBoxCaptureHeight";
            this.textBoxCaptureHeight.Size = new System.Drawing.Size(30, 20);
            this.textBoxCaptureHeight.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Height:";
            // 
            // textBoxCaptureWidth
            // 
            this.textBoxCaptureWidth.Location = new System.Drawing.Point(207, 54);
            this.textBoxCaptureWidth.Name = "textBoxCaptureWidth";
            this.textBoxCaptureWidth.Size = new System.Drawing.Size(30, 20);
            this.textBoxCaptureWidth.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Width:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Capture Size:";
            // 
            // checkBoxAlertSound
            // 
            this.checkBoxAlertSound.AutoSize = true;
            this.checkBoxAlertSound.Location = new System.Drawing.Point(77, 47);
            this.checkBoxAlertSound.Name = "checkBoxAlertSound";
            this.checkBoxAlertSound.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAlertSound.TabIndex = 26;
            this.checkBoxAlertSound.UseVisualStyleBackColor = true;
            this.checkBoxAlertSound.CheckedChanged += new System.EventHandler(this.checkBoxAlertSound_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Alert Sound";
            // 
            // textBoxAlertSound
            // 
            this.textBoxAlertSound.Location = new System.Drawing.Point(123, 74);
            this.textBoxAlertSound.Name = "textBoxAlertSound";
            this.textBoxAlertSound.Size = new System.Drawing.Size(306, 20);
            this.textBoxAlertSound.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Sound File Location:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(120, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Sound delay:";
            // 
            // textBoxSoundDelay
            // 
            this.textBoxSoundDelay.Location = new System.Drawing.Point(227, 48);
            this.textBoxSoundDelay.Name = "textBoxSoundDelay";
            this.textBoxSoundDelay.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoundDelay.TabIndex = 30;
            // 
            // checkBoxCleanup
            // 
            this.checkBoxCleanup.AutoSize = true;
            this.checkBoxCleanup.Location = new System.Drawing.Point(150, 27);
            this.checkBoxCleanup.Name = "checkBoxCleanup";
            this.checkBoxCleanup.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCleanup.TabIndex = 32;
            this.checkBoxCleanup.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cleanup Logs and Pictures";
            // 
            // checkBoxNumberOverride
            // 
            this.checkBoxNumberOverride.AutoSize = true;
            this.checkBoxNumberOverride.Location = new System.Drawing.Point(102, 17);
            this.checkBoxNumberOverride.Name = "checkBoxNumberOverride";
            this.checkBoxNumberOverride.Size = new System.Drawing.Size(15, 14);
            this.checkBoxNumberOverride.TabIndex = 35;
            this.checkBoxNumberOverride.UseVisualStyleBackColor = true;
            this.checkBoxNumberOverride.CheckedChanged += new System.EventHandler(this.checkBoxNumberOverride_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Number Override";
            // 
            // textBoxNumberOverride
            // 
            this.textBoxNumberOverride.Location = new System.Drawing.Point(227, 14);
            this.textBoxNumberOverride.Name = "textBoxNumberOverride";
            this.textBoxNumberOverride.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOverride.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTalkProcessName);
            this.groupBox1.Controls.Add(this.labelTargetProcessName);
            this.groupBox1.Controls.Add(this.buttonChangeFileLocation);
            this.groupBox1.Controls.Add(this.textBoxTalkFileLocation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 125);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCaptureHeight);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxCaptureWidth);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxLocationY);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxLocationX);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 83);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Capture";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSoundFileLocation);
            this.groupBox3.Controls.Add(this.checkBoxNumberOverride);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxNumberOverride);
            this.groupBox3.Controls.Add(this.textBoxSoundDelay);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBoxAlertSound);
            this.groupBox3.Controls.Add(this.checkBoxAlertSound);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(12, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 116);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Behaviour";
            // 
            // buttonSoundFileLocation
            // 
            this.buttonSoundFileLocation.Location = new System.Drawing.Point(435, 72);
            this.buttonSoundFileLocation.Name = "buttonSoundFileLocation";
            this.buttonSoundFileLocation.Size = new System.Drawing.Size(32, 23);
            this.buttonSoundFileLocation.TabIndex = 36;
            this.buttonSoundFileLocation.Text = "...";
            this.buttonSoundFileLocation.UseVisualStyleBackColor = true;
            this.buttonSoundFileLocation.Click += new System.EventHandler(this.buttonSoundFileLocation_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxCleanup);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(12, 492);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(473, 60);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Performance";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.Location = new System.Drawing.Point(192, 573);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 37);
            this.buttonSave.TabIndex = 40;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialogTalk
            // 
            this.openFileDialogTalk.InitialDirectory = "C:\\";
            // 
            // labelADConfigFile
            // 
            this.labelADConfigFile.AutoSize = true;
            this.labelADConfigFile.Location = new System.Drawing.Point(119, 104);
            this.labelADConfigFile.Name = "labelADConfigFile";
            this.labelADConfigFile.Size = new System.Drawing.Size(37, 13);
            this.labelADConfigFile.TabIndex = 41;
            this.labelADConfigFile.Text = "(none)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Autodial config file:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 632);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labelADConfigFile);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LogoPictureBox1);
            this.Name = "Form1";
            this.Text = "Autodialer Config";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox LogoPictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTalkFileLocation;
        private System.Windows.Forms.Button buttonChangeFileLocation;
        private System.Windows.Forms.Label labelTargetProcessName;
        private System.Windows.Forms.Label labelTalkProcessName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLocationX;
        private System.Windows.Forms.TextBox textBoxLocationY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCaptureHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCaptureWidth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxAlertSound;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAlertSound;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxSoundDelay;
        private System.Windows.Forms.CheckBox checkBoxCleanup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxNumberOverride;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNumberOverride;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSoundFileLocation;
        private System.Windows.Forms.OpenFileDialog openFileDialogTalk;
        private System.Windows.Forms.OpenFileDialog openFileDialogSound;
        private System.Windows.Forms.Label labelADConfigFile;
        private System.Windows.Forms.Label label16;
    }
}

