/*
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
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.Funcionamiento = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Etiqueta1Funcionamiento = new System.Windows.Forms.Label();
            this.EtiquetaLubricacion = new System.Windows.Forms.Label();
            this.EtiquetaMovimiento = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOkToMove = new System.Windows.Forms.RadioButton();
            this.radioButtonError = new System.Windows.Forms.RadioButton();
            this.pictureTorch = new System.Windows.Forms.PictureBox();
            this.pictureBoxTorchAutomaticHC = new System.Windows.Forms.PictureBox();
            this.pictureBoxTorchManualHC = new System.Windows.Forms.PictureBox();
            this.pictureBoxLaserPointer = new System.Windows.Forms.PictureBox();
            this.TextBoxSystem = new System.Windows.Forms.RichTextBox();
            this.pictureTorch2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnclamp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClamp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMove1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClamp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAncla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMove2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAncla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnclamp1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTorch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTorchAutomaticHC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTorchManualHC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaserPointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTorch2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 248);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(321, 117);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TRANSVERSE CONTROL";
            // 
            // labelMaster1Clamp
            // 
            this.labelMaster1Clamp.AutoSize = true;
            this.labelMaster1Clamp.Location = new System.Drawing.Point(16, 102);
            this.labelMaster1Clamp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaster1Clamp.Name = "labelMaster1Clamp";
            this.labelMaster1Clamp.Size = new System.Drawing.Size(72, 20);
            this.labelMaster1Clamp.TabIndex = 40;
            this.labelMaster1Clamp.Text = "Clamped";
            // 
            // pictureBoxUnclamp2
            // 
            this.pictureBoxUnclamp2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxUnclamp2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnclamp2.Image")));
            this.pictureBoxUnclamp2.Location = new System.Drawing.Point(244, 33);
            this.pictureBoxUnclamp2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUnclamp2.Name = "pictureBoxUnclamp2";
            this.pictureBoxUnclamp2.Size = new System.Drawing.Size(49, 67);
            this.pictureBoxUnclamp2.TabIndex = 48;
            this.pictureBoxUnclamp2.TabStop = false;
            this.pictureBoxUnclamp2.Visible = false;
            this.pictureBoxUnclamp2.Click += new System.EventHandler(this.pictureBoxUnclamp2_Click);
            // 
            // pictureBoxClamp1
            // 
            this.pictureBoxClamp1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxClamp1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClamp1.Image")));
            this.pictureBoxClamp1.Location = new System.Drawing.Point(18, 33);
            this.pictureBoxClamp1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxClamp1.Name = "pictureBoxClamp1";
            this.pictureBoxClamp1.Size = new System.Drawing.Size(49, 67);
            this.pictureBoxClamp1.TabIndex = 39;
            this.pictureBoxClamp1.TabStop = false;
            this.pictureBoxClamp1.Click += new System.EventHandler(this.pictureBoxClamp1_Click);
            // 
            // labelMaster2
            // 
            this.labelMaster2.AutoSize = true;
            this.labelMaster2.Location = new System.Drawing.Point(175, 102);
            this.labelMaster2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaster2.Name = "labelMaster2";
            this.labelMaster2.Size = new System.Drawing.Size(42, 20);
            this.labelMaster2.TabIndex = 47;
            this.labelMaster2.Text = "Free";
            // 
            // pictureBoxMove1
            // 
            this.pictureBoxMove1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMove1.Image")));
            this.pictureBoxMove1.Location = new System.Drawing.Point(93, 33);
            this.pictureBoxMove1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMove1.Name = "pictureBoxMove1";
            this.pictureBoxMove1.Size = new System.Drawing.Size(49, 67);
            this.pictureBoxMove1.TabIndex = 43;
            this.pictureBoxMove1.TabStop = false;
            this.pictureBoxMove1.Click += new System.EventHandler(this.pictureBoxMove_Click);
            // 
            // pictureBoxClamp2
            // 
            this.pictureBoxClamp2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxClamp2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClamp2.Image")));
            this.pictureBoxClamp2.Location = new System.Drawing.Point(243, 33);
            this.pictureBoxClamp2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxClamp2.Name = "pictureBoxClamp2";
            this.pictureBoxClamp2.Size = new System.Drawing.Size(49, 67);
            this.pictureBoxClamp2.TabIndex = 38;
            this.pictureBoxClamp2.TabStop = false;
            this.pictureBoxClamp2.Click += new System.EventHandler(this.pictureBoxClamp2_Click);
            // 
            // labelMaster2Clamp
            // 
            this.labelMaster2Clamp.AutoSize = true;
            this.labelMaster2Clamp.Location = new System.Drawing.Point(241, 102);
            this.labelMaster2Clamp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaster2Clamp.Name = "labelMaster2Clamp";
            this.labelMaster2Clamp.Size = new System.Drawing.Size(72, 20);
            this.labelMaster2Clamp.TabIndex = 41;
            this.labelMaster2Clamp.Text = "Clamped";
            // 
            // pictureBoxAncla2
            // 
            this.pictureBoxAncla2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAncla2.Image")));
            this.pictureBoxAncla2.Location = new System.Drawing.Point(168, 33);
            this.pictureBoxAncla2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAncla2.Name = "pictureBoxAncla2";
            this.pictureBoxAncla2.Size = new System.Drawing.Size(49, 67);
            this.pictureBoxAncla2.TabIndex = 45;
            this.pictureBoxAncla2.TabStop = false;
            this.pictureBoxAncla2.Visible = false;
            this.pictureBoxAncla2.Click += new System.EventHandler(this.pictureBoxAncla2_Click);
            // 
            // labelMaster1
            // 
            this.labelMaster1.AutoSize = true;
            this.labelMaster1.Location = new System.Drawing.Point(101, 102);
            this.labelMaster1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaster1.Name = "labelMaster1";
            this.labelMaster1.Size = new System.Drawing.Size(42, 20);
            this.labelMaster1.TabIndex = 46;
            this.labelMaster1.Text = "Free";
            // 
            // pictureBoxMove2
            // 
            this.pictureBoxMove2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMove2.Image")));
            this.pictureBoxMove2.Location = new System.Drawing.Point(168, 33);
            this.pictureBoxMove2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMove2.Name = "pictureBoxMove2";
            this.pictureBoxMove2.Size = new System.Drawing.Size(49, 67);
            this.pictureBoxMove2.TabIndex = 44;
            this.pictureBoxMove2.TabStop = false;
            this.pictureBoxMove2.Click += new System.EventHandler(this.pictureBoxMove2_Click);
            // 
            // pictureBoxAncla1
            // 
            this.pictureBoxAncla1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAncla1.Image")));
            this.pictureBoxAncla1.Location = new System.Drawing.Point(93, 33);
            this.pictureBoxAncla1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAncla1.Name = "pictureBoxAncla1";
            this.pictureBoxAncla1.Size = new System.Drawing.Size(49, 67);
            this.pictureBoxAncla1.TabIndex = 42;
            this.pictureBoxAncla1.TabStop = false;
            this.pictureBoxAncla1.Visible = false;
            this.pictureBoxAncla1.Click += new System.EventHandler(this.pictureBoxAncla_Click);
            // 
            // pictureBoxUnclamp1
            // 
            this.pictureBoxUnclamp1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxUnclamp1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnclamp1.Image")));
            this.pictureBoxUnclamp1.Location = new System.Drawing.Point(18, 33);
            this.pictureBoxUnclamp1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUnclamp1.Name = "pictureBoxUnclamp1";
            this.pictureBoxUnclamp1.Size = new System.Drawing.Size(49, 67);
            this.pictureBoxUnclamp1.TabIndex = 47;
            this.pictureBoxUnclamp1.TabStop = false;
            this.pictureBoxUnclamp1.Visible = false;
            this.pictureBoxUnclamp1.Click += new System.EventHandler(this.pictureBoxUnclamp1_Click);
            // 
            // Funcionamiento
            // 
            this.Funcionamiento.Enabled = true;
            this.Funcionamiento.Interval = 1000;
            this.Funcionamiento.Tick += new System.EventHandler(this.Funcionamiento_Tick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(325, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "INFO";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 9;
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
            this.listBox1.Location = new System.Drawing.Point(5, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 193);
            this.listBox1.TabIndex = 40;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.EtiquetaMovimiento);
            this.tabPage4.Controls.Add(this.EtiquetaLubricacion);
            this.tabPage4.Controls.Add(this.Etiqueta1Funcionamiento);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(325, 331);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "TIEMPOS";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tiempo de funcionamiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-2, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tiempo de libricacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tiempo de movimiento:";
            // 
            // Etiqueta1Funcionamiento
            // 
            this.Etiqueta1Funcionamiento.AutoSize = true;
            this.Etiqueta1Funcionamiento.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta1Funcionamiento.Location = new System.Drawing.Point(215, 20);
            this.Etiqueta1Funcionamiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Etiqueta1Funcionamiento.Name = "Etiqueta1Funcionamiento";
            this.Etiqueta1Funcionamiento.Size = new System.Drawing.Size(88, 23);
            this.Etiqueta1Funcionamiento.TabIndex = 2;
            this.Etiqueta1Funcionamiento.Text = "00:00:00";
            // 
            // EtiquetaLubricacion
            // 
            this.EtiquetaLubricacion.AutoSize = true;
            this.EtiquetaLubricacion.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaLubricacion.Location = new System.Drawing.Point(215, 98);
            this.EtiquetaLubricacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EtiquetaLubricacion.Name = "EtiquetaLubricacion";
            this.EtiquetaLubricacion.Size = new System.Drawing.Size(88, 23);
            this.EtiquetaLubricacion.TabIndex = 2;
            this.EtiquetaLubricacion.Text = "00:00:00";
            // 
            // EtiquetaMovimiento
            // 
            this.EtiquetaMovimiento.AutoSize = true;
            this.EtiquetaMovimiento.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaMovimiento.Location = new System.Drawing.Point(215, 59);
            this.EtiquetaMovimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EtiquetaMovimiento.Name = "EtiquetaMovimiento";
            this.EtiquetaMovimiento.Size = new System.Drawing.Size(88, 23);
            this.EtiquetaMovimiento.TabIndex = 3;
            this.EtiquetaMovimiento.Text = "00:00:00";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(325, 331);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "CONFIGURACION";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(325, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PROCESO";
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
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 197);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OXICORTE";
            // 
            // radioButtonOkToMove
            // 
            this.radioButtonOkToMove.AutoSize = true;
            this.radioButtonOkToMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOkToMove.Location = new System.Drawing.Point(243, 154);
            this.radioButtonOkToMove.Name = "radioButtonOkToMove";
            this.radioButtonOkToMove.Size = new System.Drawing.Size(74, 17);
            this.radioButtonOkToMove.TabIndex = 31;
            this.radioButtonOkToMove.TabStop = true;
            this.radioButtonOkToMove.Text = "MOTION";
            this.radioButtonOkToMove.UseVisualStyleBackColor = true;
            // 
            // radioButtonError
            // 
            this.radioButtonError.AutoSize = true;
            this.radioButtonError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonError.Location = new System.Drawing.Point(243, 124);
            this.radioButtonError.Name = "radioButtonError";
            this.radioButtonError.Size = new System.Drawing.Size(69, 17);
            this.radioButtonError.TabIndex = 32;
            this.radioButtonError.TabStop = true;
            this.radioButtonError.Text = "ERROR";
            this.radioButtonError.UseVisualStyleBackColor = true;
            // 
            // pictureTorch
            // 
            this.pictureTorch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureTorch.Image = ((System.Drawing.Image)(resources.GetObject("pictureTorch.Image")));
            this.pictureTorch.Location = new System.Drawing.Point(10, 38);
            this.pictureTorch.Margin = new System.Windows.Forms.Padding(2);
            this.pictureTorch.Name = "pictureTorch";
            this.pictureTorch.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pictureTorch.Size = new System.Drawing.Size(73, 143);
            this.pictureTorch.TabIndex = 34;
            this.pictureTorch.TabStop = false;
            this.pictureTorch.Click += new System.EventHandler(this.pictureTorch_Click);
            // 
            // pictureBoxTorchAutomaticHC
            // 
            this.pictureBoxTorchAutomaticHC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTorchAutomaticHC.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTorchAutomaticHC.Image")));
            this.pictureBoxTorchAutomaticHC.Location = new System.Drawing.Point(165, 115);
            this.pictureBoxTorchAutomaticHC.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxTorchAutomaticHC.Name = "pictureBoxTorchAutomaticHC";
            this.pictureBoxTorchAutomaticHC.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pictureBoxTorchAutomaticHC.Size = new System.Drawing.Size(73, 67);
            this.pictureBoxTorchAutomaticHC.TabIndex = 36;
            this.pictureBoxTorchAutomaticHC.TabStop = false;
            this.pictureBoxTorchAutomaticHC.Click += new System.EventHandler(this.pictureBoxTorchAutomaticHC_Click);
            // 
            // pictureBoxTorchManualHC
            // 
            this.pictureBoxTorchManualHC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTorchManualHC.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTorchManualHC.Image")));
            this.pictureBoxTorchManualHC.Location = new System.Drawing.Point(165, 115);
            this.pictureBoxTorchManualHC.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxTorchManualHC.Name = "pictureBoxTorchManualHC";
            this.pictureBoxTorchManualHC.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pictureBoxTorchManualHC.Size = new System.Drawing.Size(73, 67);
            this.pictureBoxTorchManualHC.TabIndex = 37;
            this.pictureBoxTorchManualHC.TabStop = false;
            this.pictureBoxTorchManualHC.Visible = false;
            this.pictureBoxTorchManualHC.Click += new System.EventHandler(this.pictureBoxTorchManualHC_Click);
            // 
            // pictureBoxLaserPointer
            // 
            this.pictureBoxLaserPointer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLaserPointer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLaserPointer.Image")));
            this.pictureBoxLaserPointer.Location = new System.Drawing.Point(165, 38);
            this.pictureBoxLaserPointer.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLaserPointer.Name = "pictureBoxLaserPointer";
            this.pictureBoxLaserPointer.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pictureBoxLaserPointer.Size = new System.Drawing.Size(120, 66);
            this.pictureBoxLaserPointer.TabIndex = 39;
            this.pictureBoxLaserPointer.TabStop = false;
            this.pictureBoxLaserPointer.Click += new System.EventHandler(this.pictureBoxLaserPointer_Click);
            // 
            // TextBoxSystem
            // 
            this.TextBoxSystem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBoxSystem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSystem.Location = new System.Drawing.Point(6, 19);
            this.TextBoxSystem.Name = "TextBoxSystem";
            this.TextBoxSystem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxSystem.Size = new System.Drawing.Size(200, 19);
            this.TextBoxSystem.TabIndex = 0;
            this.TextBoxSystem.Text = "BIENVENIDO!";
            // 
            // pictureTorch2
            // 
            this.pictureTorch2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureTorch2.Image = ((System.Drawing.Image)(resources.GetObject("pictureTorch2.Image")));
            this.pictureTorch2.Location = new System.Drawing.Point(88, 38);
            this.pictureTorch2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureTorch2.Name = "pictureTorch2";
            this.pictureTorch2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pictureTorch2.Size = new System.Drawing.Size(73, 143);
            this.pictureTorch2.TabIndex = 40;
            this.pictureTorch2.TabStop = false;
            this.pictureTorch2.Click += new System.EventHandler(this.pictureTorch2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(8, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 361);
            this.tabControl1.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(342, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1024, 235);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "INTERFACE VIRTUAL";
            this.TopMost = true;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTorch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTorchAutomaticHC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTorchManualHC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaserPointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTorch2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

		}


        private void MainForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer Funcionamiento;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label EtiquetaMovimiento;
        private System.Windows.Forms.Label EtiquetaLubricacion;
        private System.Windows.Forms.Label Etiqueta1Funcionamiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureTorch2;
        private System.Windows.Forms.RichTextBox TextBoxSystem;
        private System.Windows.Forms.PictureBox pictureBoxLaserPointer;
        private System.Windows.Forms.PictureBox pictureBoxTorchManualHC;
        private System.Windows.Forms.PictureBox pictureBoxTorchAutomaticHC;
        private System.Windows.Forms.PictureBox pictureTorch;
        private System.Windows.Forms.RadioButton radioButtonError;
        private System.Windows.Forms.RadioButton radioButtonOkToMove;
        private System.Windows.Forms.TabControl tabControl1;
    }
}
