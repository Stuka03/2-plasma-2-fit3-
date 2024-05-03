namespace InterfaceOneStation
{
    partial class Lubricacion
    {
      
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxLubricationInterval = new System.Windows.Forms.DomainUpDown();
            this.comboBoxLubricationActive = new System.Windows.Forms.DomainUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.checkBoxEnableLubrication = new System.Windows.Forms.CheckBox();
            this.radioButtonLSAactive = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lubricacionTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.Location = new System.Drawing.Point(227, 5);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(85, 28);
            this.buttonEnter.TabIndex = 55;
            this.buttonEnter.Text = "ENTER";
            this.buttonEnter.UseMnemonic = false;
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 54;
            this.label1.Text = "PASSWORD:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(86, 8);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(135, 20);
            this.textBoxPassword.TabIndex = 53;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // comboBoxLubricationInterval
            // 
            this.comboBoxLubricationInterval.AllowDrop = true;
            this.comboBoxLubricationInterval.Enabled = false;
            this.comboBoxLubricationInterval.Items.Add("1 hr");
            this.comboBoxLubricationInterval.Items.Add("2 hr");
            this.comboBoxLubricationInterval.Items.Add("3 hr");
            this.comboBoxLubricationInterval.Items.Add("4 hr");
            this.comboBoxLubricationInterval.Items.Add("5 hr");
            this.comboBoxLubricationInterval.Items.Add("6 hr");
            this.comboBoxLubricationInterval.Items.Add("7 hr");
            this.comboBoxLubricationInterval.Items.Add("8 hr");
            this.comboBoxLubricationInterval.Location = new System.Drawing.Point(101, 45);
            this.comboBoxLubricationInterval.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLubricationInterval.Name = "comboBoxLubricationInterval";
            this.comboBoxLubricationInterval.Size = new System.Drawing.Size(86, 20);
            this.comboBoxLubricationInterval.TabIndex = 20;
            this.comboBoxLubricationInterval.Text = "Lubrication interval";
            // 
            // comboBoxLubricationActive
            // 
            this.comboBoxLubricationActive.AllowDrop = true;
            this.comboBoxLubricationActive.Enabled = false;
            this.comboBoxLubricationActive.Items.Add("5 s");
            this.comboBoxLubricationActive.Items.Add("10 s");
            this.comboBoxLubricationActive.Items.Add("15 s");
            this.comboBoxLubricationActive.Items.Add("20 s");
            this.comboBoxLubricationActive.Items.Add("25 s");
            this.comboBoxLubricationActive.Items.Add("30 s");
            this.comboBoxLubricationActive.Location = new System.Drawing.Point(102, 75);
            this.comboBoxLubricationActive.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLubricationActive.Name = "comboBoxLubricationActive";
            this.comboBoxLubricationActive.Size = new System.Drawing.Size(85, 20);
            this.comboBoxLubricationActive.TabIndex = 21;
            this.comboBoxLubricationActive.Text = "Time active";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSave.Enabled = false;
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSave.Location = new System.Drawing.Point(221, 104);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 36);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseCompatibleTextRendering = true;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(98, 112);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(71, 20);
            this.labelTime.TabIndex = 23;
            this.labelTime.Text = "00:00:00";
            // 
            // checkBoxEnableLubrication
            // 
            this.checkBoxEnableLubrication.AutoSize = true;
            this.checkBoxEnableLubrication.Enabled = false;
            this.checkBoxEnableLubrication.Location = new System.Drawing.Point(4, 10);
            this.checkBoxEnableLubrication.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableLubrication.Name = "checkBoxEnableLubrication";
            this.checkBoxEnableLubrication.Size = new System.Drawing.Size(114, 17);
            this.checkBoxEnableLubrication.TabIndex = 24;
            this.checkBoxEnableLubrication.Text = "Enable Lubrication";
            this.checkBoxEnableLubrication.UseVisualStyleBackColor = true;
            // 
            // radioButtonLSAactive
            // 
            this.radioButtonLSAactive.AutoSize = true;
            this.radioButtonLSAactive.Enabled = false;
            this.radioButtonLSAactive.Location = new System.Drawing.Point(221, 10);
            this.radioButtonLSAactive.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonLSAactive.Name = "radioButtonLSAactive";
            this.radioButtonLSAactive.Size = new System.Drawing.Size(71, 17);
            this.radioButtonLSAactive.TabIndex = 27;
            this.radioButtonLSAactive.TabStop = true;
            this.radioButtonLSAactive.Text = "LS Active";
            this.radioButtonLSAactive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Interval Time:";
            // 
            // lubricacionTime
            // 
            this.lubricacionTime.AutoSize = true;
            this.lubricacionTime.Location = new System.Drawing.Point(10, 112);
            this.lubricacionTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lubricacionTime.Name = "lubricacionTime";
            this.lubricacionTime.Size = new System.Drawing.Size(33, 13);
            this.lubricacionTime.TabIndex = 26;
            this.lubricacionTime.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cycle Time:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(221, 58);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 36);
            this.button3.TabIndex = 30;
            this.button3.Text = "TESTING";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonTesting_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.CausesValidation = false;
            this.groupBox3.Controls.Add(this.comboBoxLubricationInterval);
            this.groupBox3.Controls.Add(this.comboBoxLubricationActive);
            this.groupBox3.Controls.Add(this.buttonSave);
            this.groupBox3.Controls.Add(this.labelTime);
            this.groupBox3.Controls.Add(this.checkBoxEnableLubrication);
            this.groupBox3.Controls.Add(this.radioButtonLSAactive);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lubricacionTime);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(6, 39);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(314, 152);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            // 
            // Lubricacion
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(327, 221);
            this.ControlBox = false;
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lubricacion";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.DomainUpDown comboBoxLubricationInterval;
        private System.Windows.Forms.DomainUpDown comboBoxLubricationActive;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox checkBoxEnableLubrication;
        private System.Windows.Forms.RadioButton radioButtonLSAactive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lubricacionTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer1;
    }
}