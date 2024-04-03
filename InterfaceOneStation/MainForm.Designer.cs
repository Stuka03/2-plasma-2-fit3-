﻿/*
 * Created by SharpDevelop.
 * User: Efrain
 * Date: 02/03/2017
 * Time: 09:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace InterfaceOneStation
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureTorch2 = new System.Windows.Forms.PictureBox();
            this.TextBoxSystem = new System.Windows.Forms.RichTextBox();
            this.pictureBoxLaserPointer = new System.Windows.Forms.PictureBox();
            this.pictureBoxTorchManualHC = new System.Windows.Forms.PictureBox();
            this.pictureBoxTorchAutomaticHC = new System.Windows.Forms.PictureBox();
            this.pictureTorch = new System.Windows.Forms.PictureBox();
            this.radioButtonError = new System.Windows.Forms.RadioButton();
            this.radioButtonOkToMove = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radioButtonLSAactive = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxEnableLubrication = new System.Windows.Forms.CheckBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxLubricationActive = new System.Windows.Forms.DomainUpDown();
            this.comboBoxLubricationInterval = new System.Windows.Forms.DomainUpDown();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelMaster1Clamp = new System.Windows.Forms.Label();
            this.pictureBoxUnclamp2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxClamp1 = new System.Windows.Forms.PictureBox();
            this.labelMaster2 = new System.Windows.Forms.Label();
            this.pictureBoxMove1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxClamp2 = new System.Windows.Forms.PictureBox();
            this.labelMaster2Clamp = new System.Windows.Forms.Label();
            this.pictureBoxAncla2 = new System.Windows.Forms.PictureBox();
            this.labelMaster1 = new System.Windows.Forms.Label();
            this.pictureBoxMove2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAncla1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxUnclamp1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radioButtonVariable = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTorch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaserPointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTorchManualHC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTorchAutomaticHC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTorch)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnclamp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClamp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMove1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClamp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAncla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMove2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAncla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnclamp1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureTorch2);
            this.groupBox1.Controls.Add(this.TextBoxSystem);
            this.groupBox1.Controls.Add(this.pictureBoxLaserPointer);
            this.groupBox1.Controls.Add(this.pictureBoxTorchManualHC);
            this.groupBox1.Controls.Add(this.pictureBoxTorchAutomaticHC);
            this.groupBox1.Controls.Add(this.pictureTorch);
            this.groupBox1.Controls.Add(this.radioButtonError);
            this.groupBox1.Controls.Add(this.radioButtonOkToMove);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(411, 243);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OXICORTE";
            // 
            // pictureTorch2
            // 
            this.pictureTorch2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureTorch2.Image = ((System.Drawing.Image)(resources.GetObject("pictureTorch2.Image")));
            this.pictureTorch2.Location = new System.Drawing.Point(117, 47);
            this.pictureTorch2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureTorch2.Name = "pictureTorch2";
            this.pictureTorch2.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.pictureTorch2.Size = new System.Drawing.Size(97, 176);
            this.pictureTorch2.TabIndex = 40;
            this.pictureTorch2.TabStop = false;
            this.pictureTorch2.Click += new System.EventHandler(this.pictureTorch2_Click);
            // 
            // TextBoxSystem
            // 
            this.TextBoxSystem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBoxSystem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSystem.Location = new System.Drawing.Point(8, 23);
            this.TextBoxSystem.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSystem.Name = "TextBoxSystem";
            this.TextBoxSystem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxSystem.Size = new System.Drawing.Size(387, 23);
            this.TextBoxSystem.TabIndex = 0;
            this.TextBoxSystem.Text = "BIENVENIDO!";
            // 
            // pictureBoxLaserPointer
            // 
            this.pictureBoxLaserPointer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLaserPointer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLaserPointer.Image")));
            this.pictureBoxLaserPointer.Location = new System.Drawing.Point(220, 47);
            this.pictureBoxLaserPointer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLaserPointer.Name = "pictureBoxLaserPointer";
            this.pictureBoxLaserPointer.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.pictureBoxLaserPointer.Size = new System.Drawing.Size(160, 81);
            this.pictureBoxLaserPointer.TabIndex = 39;
            this.pictureBoxLaserPointer.TabStop = false;
            this.pictureBoxLaserPointer.Click += new System.EventHandler(this.pictureBoxLaserPointer_Click);
            // 
            // pictureBoxTorchManualHC
            // 
            this.pictureBoxTorchManualHC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTorchManualHC.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTorchManualHC.Image")));
            this.pictureBoxTorchManualHC.Location = new System.Drawing.Point(220, 141);
            this.pictureBoxTorchManualHC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxTorchManualHC.Name = "pictureBoxTorchManualHC";
            this.pictureBoxTorchManualHC.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.pictureBoxTorchManualHC.Size = new System.Drawing.Size(97, 82);
            this.pictureBoxTorchManualHC.TabIndex = 37;
            this.pictureBoxTorchManualHC.TabStop = false;
            this.pictureBoxTorchManualHC.Visible = false;
            this.pictureBoxTorchManualHC.Click += new System.EventHandler(this.pictureBoxTorchManualHC_Click);
            // 
            // pictureBoxTorchAutomaticHC
            // 
            this.pictureBoxTorchAutomaticHC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTorchAutomaticHC.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTorchAutomaticHC.Image")));
            this.pictureBoxTorchAutomaticHC.Location = new System.Drawing.Point(220, 141);
            this.pictureBoxTorchAutomaticHC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxTorchAutomaticHC.Name = "pictureBoxTorchAutomaticHC";
            this.pictureBoxTorchAutomaticHC.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.pictureBoxTorchAutomaticHC.Size = new System.Drawing.Size(97, 82);
            this.pictureBoxTorchAutomaticHC.TabIndex = 36;
            this.pictureBoxTorchAutomaticHC.TabStop = false;
            this.pictureBoxTorchAutomaticHC.Click += new System.EventHandler(this.pictureBoxTorchAutomaticHC_Click);
            // 
            // pictureTorch
            // 
            this.pictureTorch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureTorch.Image = ((System.Drawing.Image)(resources.GetObject("pictureTorch.Image")));
            this.pictureTorch.Location = new System.Drawing.Point(14, 47);
            this.pictureTorch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureTorch.Name = "pictureTorch";
            this.pictureTorch.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.pictureTorch.Size = new System.Drawing.Size(97, 176);
            this.pictureTorch.TabIndex = 34;
            this.pictureTorch.TabStop = false;
            this.pictureTorch.Click += new System.EventHandler(this.pictureTorch_Click);
            // 
            // radioButtonError
            // 
            this.radioButtonError.AutoSize = true;
            this.radioButtonError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonError.Location = new System.Drawing.Point(324, 152);
            this.radioButtonError.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonError.Name = "radioButtonError";
            this.radioButtonError.Size = new System.Drawing.Size(82, 20);
            this.radioButtonError.TabIndex = 32;
            this.radioButtonError.TabStop = true;
            this.radioButtonError.Text = "ERROR";
            this.radioButtonError.UseVisualStyleBackColor = true;
            // 
            // radioButtonOkToMove
            // 
            this.radioButtonOkToMove.AutoSize = true;
            this.radioButtonOkToMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOkToMove.Location = new System.Drawing.Point(324, 192);
            this.radioButtonOkToMove.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonOkToMove.Name = "radioButtonOkToMove";
            this.radioButtonOkToMove.Size = new System.Drawing.Size(87, 20);
            this.radioButtonOkToMove.TabIndex = 31;
            this.radioButtonOkToMove.TabStop = true;
            this.radioButtonOkToMove.Text = "MOTION";
            this.radioButtonOkToMove.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 284);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(425, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PROCESO";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabPage3.Controls.Add(this.radioButtonVariable);
            this.tabPage3.Controls.Add(this.radioButtonLSAactive);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.checkBoxEnableLubrication);
            this.tabPage3.Controls.Add(this.labelTime);
            this.tabPage3.Controls.Add(this.buttonSave);
            this.tabPage3.Controls.Add(this.comboBoxLubricationActive);
            this.tabPage3.Controls.Add(this.comboBoxLubricationInterval);
            this.tabPage3.Controls.Add(this.buttonEnter);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.textBoxPassword);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(425, 255);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CONFIGURACION";
            // 
            // radioButtonLSAactive
            // 
            this.radioButtonLSAactive.AutoSize = true;
            this.radioButtonLSAactive.Enabled = false;
            this.radioButtonLSAactive.Location = new System.Drawing.Point(305, 67);
            this.radioButtonLSAactive.Name = "radioButtonLSAactive";
            this.radioButtonLSAactive.Size = new System.Drawing.Size(84, 20);
            this.radioButtonLSAactive.TabIndex = 27;
            this.radioButtonLSAactive.TabStop = true;
            this.radioButtonLSAactive.Text = "LS Active";
            this.radioButtonLSAactive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cycle Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Interval Time:";
            // 
            // checkBoxEnableLubrication
            // 
            this.checkBoxEnableLubrication.AutoSize = true;
            this.checkBoxEnableLubrication.Enabled = false;
            this.checkBoxEnableLubrication.Location = new System.Drawing.Point(10, 40);
            this.checkBoxEnableLubrication.Name = "checkBoxEnableLubrication";
            this.checkBoxEnableLubrication.Size = new System.Drawing.Size(140, 20);
            this.checkBoxEnableLubrication.TabIndex = 24;
            this.checkBoxEnableLubrication.Text = "Enable Lubrication";
            this.checkBoxEnableLubrication.UseVisualStyleBackColor = true;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(321, 44);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(38, 16);
            this.labelTime.TabIndex = 23;
            this.labelTime.Text = "Time";
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(352, 11);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(65, 23);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxLubricationActive
            // 
            this.comboBoxLubricationActive.Enabled = false;
            this.comboBoxLubricationActive.Items.Add("5 s");
            this.comboBoxLubricationActive.Items.Add("10 s");
            this.comboBoxLubricationActive.Items.Add("15 s");
            this.comboBoxLubricationActive.Items.Add("20 s");
            this.comboBoxLubricationActive.Items.Add("25 s");
            this.comboBoxLubricationActive.Items.Add("30 s");
            this.comboBoxLubricationActive.Location = new System.Drawing.Point(113, 91);
            this.comboBoxLubricationActive.Name = "comboBoxLubricationActive";
            this.comboBoxLubricationActive.Size = new System.Drawing.Size(159, 22);
            this.comboBoxLubricationActive.TabIndex = 21;
            this.comboBoxLubricationActive.Text = "Time active";
            // 
            // comboBoxLubricationInterval
            // 
            this.comboBoxLubricationInterval.Enabled = false;
            this.comboBoxLubricationInterval.Items.Add("1 hr");
            this.comboBoxLubricationInterval.Items.Add("2 hr");
            this.comboBoxLubricationInterval.Items.Add("3 hr");
            this.comboBoxLubricationInterval.Items.Add("4 hr");
            this.comboBoxLubricationInterval.Items.Add("5 hr");
            this.comboBoxLubricationInterval.Items.Add("6 hr");
            this.comboBoxLubricationInterval.Items.Add("7 hr");
            this.comboBoxLubricationInterval.Items.Add("8 hr");
            this.comboBoxLubricationInterval.Location = new System.Drawing.Point(113, 63);
            this.comboBoxLubricationInterval.Name = "comboBoxLubricationInterval";
            this.comboBoxLubricationInterval.Size = new System.Drawing.Size(159, 22);
            this.comboBoxLubricationInterval.TabIndex = 20;
            this.comboBoxLubricationInterval.Text = "Lubrication interval";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(281, 11);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(65, 23);
            this.buttonEnter.TabIndex = 19;
            this.buttonEnter.Text = "ENTER";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "PASSWORD:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(113, 11);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(159, 22);
            this.textBoxPassword.TabIndex = 17;
            this.textBoxPassword.Enter += new System.EventHandler(this.buttonEnter_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(425, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "INFO";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "SoftOpCon 2 Stations Plasma + 2 Stations Fit3 + Lubrication system\tRev.0.0",
            "",
            "FUNCTION CONFIG:",
            "",
            "\tLUBRICATION SYSTEM",
            "1.- LUBRICATION SYSTEM\tAUXILIAR FUNCTION 1",
            "",
            "\tTRACTION CONTROL",
            "2.- CLAMP 1\t\tAUXILIAR FUNCTION 2",
            "3.- CLAMP 2\t\tAUXILIAR FUNCTION 3",
            "4.- DUAL PARK HEAD 1\t",
            "5.- DUAL PARK HEAD 2\t",
            "6.- PRESSURE SENSOR\tAUXILIAR FUNCTION 4",
            "7.- PROGRAM RUNNING\tAUXILIAR FUNCTION 5",
            "",
            "\tOXYFUEL SYSTEM",
            "8.- LASER POINTER\t- LASER POINTER SELECT",
            "9.- APC TORCH 1 DISABLE INPUT - MANUAL SELECT 3 NC",
            "10.- APC TORCH 2 DISABLE INPUT  - MANUAL SELECT 4 NC",
            "11.- APC START PROCESS INPUT - CUT CONTROL\t",
            "12.- APC HC OFF INPUT - AUXILIAR FUNCTION SELECT 6",
            "13.- APC OK TO MOVE OUTPUT - AUXILIAR FUNCTION SELECT 7",
            "14.- APC ERROR OUTPUT - AUXILIAR FUNCTION SELECT 8 NC",
            "15.- STOP MOTION DURING PIERCING - PROGRAM INHIBIT",
            "16.- CUT CONTROL SOC FEEDBACK - AUXILIAR FUNCTION SELECT 9",
            "17.- ERROR RELEASE - FRONT PANEL STOP",
            "",
            "\tSAFETY CONTROL",
            "18.- TORCH COLLISION - FRONT PANEL STOP",
            "19.- TORCH COLLISION RESET - AUXILIAR FUNCTION 10",
            "",
            "-\tNOTES:",
            "CONTROL PROGRAM INHIBIT DELAY WITH PIERCE TIME PARAMETER",
            "IN THE PROCESS CONFIG WINDOW"});
            this.listBox1.Location = new System.Drawing.Point(7, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(412, 238);
            this.listBox1.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelMaster1Clamp);
            this.groupBox2.Controls.Add(this.pictureBoxUnclamp2);
            this.groupBox2.Controls.Add(this.pictureBoxClamp1);
            this.groupBox2.Controls.Add(this.labelMaster2);
            this.groupBox2.Controls.Add(this.pictureBoxMove1);
            this.groupBox2.Controls.Add(this.pictureBoxClamp2);
            this.groupBox2.Controls.Add(this.labelMaster2Clamp);
            this.groupBox2.Controls.Add(this.pictureBoxAncla2);
            this.groupBox2.Controls.Add(this.labelMaster1);
            this.groupBox2.Controls.Add(this.pictureBoxMove2);
            this.groupBox2.Controls.Add(this.pictureBoxAncla1);
            this.groupBox2.Controls.Add(this.pictureBoxUnclamp1);
            this.groupBox2.Location = new System.Drawing.Point(12, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 144);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TRANSVERSE CONTROL";
            // 
            // labelMaster1Clamp
            // 
            this.labelMaster1Clamp.AutoSize = true;
            this.labelMaster1Clamp.Location = new System.Drawing.Point(21, 125);
            this.labelMaster1Clamp.Name = "labelMaster1Clamp";
            this.labelMaster1Clamp.Size = new System.Drawing.Size(62, 16);
            this.labelMaster1Clamp.TabIndex = 40;
            this.labelMaster1Clamp.Text = "Clamped";
            // 
            // pictureBoxUnclamp2
            // 
            this.pictureBoxUnclamp2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxUnclamp2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnclamp2.Image")));
            this.pictureBoxUnclamp2.Location = new System.Drawing.Point(324, 41);
            this.pictureBoxUnclamp2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUnclamp2.Name = "pictureBoxUnclamp2";
            this.pictureBoxUnclamp2.Size = new System.Drawing.Size(65, 82);
            this.pictureBoxUnclamp2.TabIndex = 48;
            this.pictureBoxUnclamp2.TabStop = false;
            this.pictureBoxUnclamp2.Visible = false;
            // 
            // pictureBoxClamp1
            // 
            this.pictureBoxClamp1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxClamp1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClamp1.Image")));
            this.pictureBoxClamp1.Location = new System.Drawing.Point(24, 41);
            this.pictureBoxClamp1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxClamp1.Name = "pictureBoxClamp1";
            this.pictureBoxClamp1.Size = new System.Drawing.Size(65, 82);
            this.pictureBoxClamp1.TabIndex = 39;
            this.pictureBoxClamp1.TabStop = false;
            this.pictureBoxClamp1.Click += new System.EventHandler(this.pictureBoxClamp1_Click);
            // 
            // labelMaster2
            // 
            this.labelMaster2.AutoSize = true;
            this.labelMaster2.Location = new System.Drawing.Point(233, 125);
            this.labelMaster2.Name = "labelMaster2";
            this.labelMaster2.Size = new System.Drawing.Size(35, 16);
            this.labelMaster2.TabIndex = 47;
            this.labelMaster2.Text = "Free";
            // 
            // pictureBoxMove1
            // 
            this.pictureBoxMove1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMove1.Image")));
            this.pictureBoxMove1.Location = new System.Drawing.Point(124, 41);
            this.pictureBoxMove1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMove1.Name = "pictureBoxMove1";
            this.pictureBoxMove1.Size = new System.Drawing.Size(65, 82);
            this.pictureBoxMove1.TabIndex = 43;
            this.pictureBoxMove1.TabStop = false;
            // 
            // pictureBoxClamp2
            // 
            this.pictureBoxClamp2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxClamp2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClamp2.Image")));
            this.pictureBoxClamp2.Location = new System.Drawing.Point(324, 41);
            this.pictureBoxClamp2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxClamp2.Name = "pictureBoxClamp2";
            this.pictureBoxClamp2.Size = new System.Drawing.Size(65, 82);
            this.pictureBoxClamp2.TabIndex = 38;
            this.pictureBoxClamp2.TabStop = false;
            // 
            // labelMaster2Clamp
            // 
            this.labelMaster2Clamp.AutoSize = true;
            this.labelMaster2Clamp.Location = new System.Drawing.Point(321, 125);
            this.labelMaster2Clamp.Name = "labelMaster2Clamp";
            this.labelMaster2Clamp.Size = new System.Drawing.Size(62, 16);
            this.labelMaster2Clamp.TabIndex = 41;
            this.labelMaster2Clamp.Text = "Clamped";
            // 
            // pictureBoxAncla2
            // 
            this.pictureBoxAncla2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAncla2.Image")));
            this.pictureBoxAncla2.Location = new System.Drawing.Point(224, 41);
            this.pictureBoxAncla2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAncla2.Name = "pictureBoxAncla2";
            this.pictureBoxAncla2.Size = new System.Drawing.Size(65, 82);
            this.pictureBoxAncla2.TabIndex = 45;
            this.pictureBoxAncla2.TabStop = false;
            this.pictureBoxAncla2.Visible = false;
            // 
            // labelMaster1
            // 
            this.labelMaster1.AutoSize = true;
            this.labelMaster1.Location = new System.Drawing.Point(135, 125);
            this.labelMaster1.Name = "labelMaster1";
            this.labelMaster1.Size = new System.Drawing.Size(35, 16);
            this.labelMaster1.TabIndex = 46;
            this.labelMaster1.Text = "Free";
            // 
            // pictureBoxMove2
            // 
            this.pictureBoxMove2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMove2.Image")));
            this.pictureBoxMove2.Location = new System.Drawing.Point(224, 41);
            this.pictureBoxMove2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMove2.Name = "pictureBoxMove2";
            this.pictureBoxMove2.Size = new System.Drawing.Size(65, 82);
            this.pictureBoxMove2.TabIndex = 44;
            this.pictureBoxMove2.TabStop = false;
            // 
            // pictureBoxAncla1
            // 
            this.pictureBoxAncla1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAncla1.Image")));
            this.pictureBoxAncla1.Location = new System.Drawing.Point(124, 41);
            this.pictureBoxAncla1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAncla1.Name = "pictureBoxAncla1";
            this.pictureBoxAncla1.Size = new System.Drawing.Size(65, 82);
            this.pictureBoxAncla1.TabIndex = 42;
            this.pictureBoxAncla1.TabStop = false;
            this.pictureBoxAncla1.Visible = false;
            // 
            // pictureBoxUnclamp1
            // 
            this.pictureBoxUnclamp1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxUnclamp1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnclamp1.Image")));
            this.pictureBoxUnclamp1.Location = new System.Drawing.Point(24, 41);
            this.pictureBoxUnclamp1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUnclamp1.Name = "pictureBoxUnclamp1";
            this.pictureBoxUnclamp1.Size = new System.Drawing.Size(65, 82);
            this.pictureBoxUnclamp1.TabIndex = 47;
            this.pictureBoxUnclamp1.TabStop = false;
            this.pictureBoxUnclamp1.Visible = false;
            this.pictureBoxUnclamp1.Click += new System.EventHandler(this.pictureBoxUnclamp1_Click);
            // 
            // radioButtonVariable
            // 
            this.radioButtonVariable.AutoSize = true;
            this.radioButtonVariable.Enabled = false;
            this.radioButtonVariable.Location = new System.Drawing.Point(305, 93);
            this.radioButtonVariable.Name = "radioButtonVariable";
            this.radioButtonVariable.Size = new System.Drawing.Size(119, 20);
            this.radioButtonVariable.TabIndex = 28;
            this.radioButtonVariable.TabStop = true;
            this.radioButtonVariable.Text = "Variable Active";
            this.radioButtonVariable.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1024, 235);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "INTERFACE VIRTUAL";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTorch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaserPointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTorchManualHC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTorchAutomaticHC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTorch)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnclamp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClamp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMove1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClamp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAncla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMove2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAncla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnclamp1)).EndInit();
            this.ResumeLayout(false);

		}


        private void MainForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox TextBoxSystem;
        private System.Windows.Forms.RadioButton radioButtonError;
        private System.Windows.Forms.RadioButton radioButtonOkToMove;
        private System.Windows.Forms.PictureBox pictureBoxTorchAutomaticHC;
        private System.Windows.Forms.PictureBox pictureTorch;
        private System.Windows.Forms.PictureBox pictureBoxLaserPointer;
        private System.Windows.Forms.PictureBox pictureBoxTorchManualHC;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton radioButtonLSAactive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxEnableLubrication;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DomainUpDown comboBoxLubricationActive;
        private System.Windows.Forms.DomainUpDown comboBoxLubricationInterval;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelMaster1Clamp;
        private System.Windows.Forms.PictureBox pictureBoxUnclamp2;
        private System.Windows.Forms.PictureBox pictureBoxClamp1;
        private System.Windows.Forms.Label labelMaster2;
        private System.Windows.Forms.PictureBox pictureBoxMove1;
        private System.Windows.Forms.PictureBox pictureBoxClamp2;
        private System.Windows.Forms.Label labelMaster2Clamp;
        private System.Windows.Forms.PictureBox pictureBoxAncla2;
        private System.Windows.Forms.Label labelMaster1;
        private System.Windows.Forms.PictureBox pictureBoxMove2;
        private System.Windows.Forms.PictureBox pictureBoxAncla1;
        private System.Windows.Forms.PictureBox pictureBoxUnclamp1;
        private System.Windows.Forms.PictureBox pictureTorch2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioButtonVariable;
    }
}