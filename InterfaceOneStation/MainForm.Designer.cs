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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Funcionamiento = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EtiquetaCorte = new System.Windows.Forms.Label();
            this.tiempoCorte = new System.Windows.Forms.Label();
            this.EtiquetaMovimiento = new System.Windows.Forms.Label();
            this.EtiquetaLubricacion = new System.Windows.Forms.Label();
            this.Etiqueta1Funcionamiento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LFuncionamiento = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureTorch2 = new System.Windows.Forms.PictureBox();
            this.TextBoxSystem = new System.Windows.Forms.RichTextBox();
            this.pictureBoxLaserPointer = new System.Windows.Forms.PictureBox();
            this.pictureBoxTorchManualHC = new System.Windows.Forms.PictureBox();
            this.pictureBoxTorchAutomaticHC = new System.Windows.Forms.PictureBox();
            this.pictureTorch = new System.Windows.Forms.PictureBox();
            this.radioButtonError = new System.Windows.Forms.RadioButton();
            this.radioButtonOkToMove = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTorch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaserPointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTorchManualHC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTorchAutomaticHC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTorch)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
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
            "SoftOpCon 2 Stations Plasma + 2 Stations Fit3 + Lubrication system",
            "\t",
            "\t\t\t\t\tRev.1.0-2sp2sf1L",
            "FUNCTION CONFIG:",
            "",
            "\tLUBRICATION SYSTEM",
            "1.- LUBRICATION SYSTEM - AUXILIAR FUNCTION 1",
            "",
            "\tTRACTION CONTROL",
            "2.- CLAMP 1 - AUXILIAR FUNCTION 2",
            "3.- CLAMP 2 - AUXILIAR FUNCTION 3",
            "4.- DUAL PARK  1 ",
            "5.- DUAL PARK 2\t",
            "6.- CONTROLS LOCK - PROGRAM RUNNING",
            "7.- PRESSURE SENSOR - AUXILIAR FUNCTION 6",
            "8.- PRESSURE ERROR RELEASE - FAST STOP",
            "",
            "\tOXYFUEL SYSTEM",
            "9.- LASER POINTER - LASER POINTER SELECT",
            "10.- APC TORCH 1 DISABLE INPUT - MANUAL SELECT 3 NC",
            "11.- APC TORCH 2 DISABLE INPUT - MANUAL SELECT 4 NC",
            "12.- APC START PROCESS INPUT - CUT CONTROL\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" +
                "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t",
            "13.- APC HC OFF INPUT - AUXILIAR FUNCTION SELECT 7",
            "14.- APC OK TO MOVE OUTPUT - AUXILIAR FUNCTION SELECT 8",
            "15.- APC ERROR OUTPUT - AUXILIAR FUNCTION SELECT 9 NC",
            "16.- STOP MOTION DURING PIERCING - PROGRAM INHIBIT\t\t",
            "17.- APC ERROR RELEASE - FRONT PANEL STOP",
            "",
            "\tSAFETY CONTROL",
            "18.- TORCH COLLISION",
            "",
            "\tMOTION",
            "19.- MOTION OUTPUT",
            "",
            "\tNOTES:",
            "-MATCH THE CNC FUNCTIONS WITH THE PHYSICAL IO FOR PROPER FUNCTIONING ",
            "-CONTROL PROGRAM INHIBIT DELAY WITH PIERCE TIME PARAMETER",
            "IN THE PROCESS CONFIG WINDOW\t\t\t"});
            this.listBox1.Location = new System.Drawing.Point(5, 10);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 193);
            this.listBox1.TabIndex = 40;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(325, 331);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "TIEMPOS";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EtiquetaCorte);
            this.groupBox3.Controls.Add(this.tiempoCorte);
            this.groupBox3.Controls.Add(this.EtiquetaMovimiento);
            this.groupBox3.Controls.Add(this.EtiquetaLubricacion);
            this.groupBox3.Controls.Add(this.Etiqueta1Funcionamiento);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.LFuncionamiento);
            this.groupBox3.Location = new System.Drawing.Point(3, -6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 207);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // EtiquetaCorte
            // 
            this.EtiquetaCorte.AutoSize = true;
            this.EtiquetaCorte.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaCorte.Location = new System.Drawing.Point(228, 100);
            this.EtiquetaCorte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EtiquetaCorte.Name = "EtiquetaCorte";
            this.EtiquetaCorte.Size = new System.Drawing.Size(88, 23);
            this.EtiquetaCorte.TabIndex = 13;
            this.EtiquetaCorte.Text = "00:00:00";
            // 
            // tiempoCorte
            // 
            this.tiempoCorte.AutoSize = true;
            this.tiempoCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempoCorte.Location = new System.Drawing.Point(4, 100);
            this.tiempoCorte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tiempoCorte.Name = "tiempoCorte";
            this.tiempoCorte.Size = new System.Drawing.Size(146, 20);
            this.tiempoCorte.TabIndex = 12;
            this.tiempoCorte.Text = "Tiempo de Corte:";
            // 
            // EtiquetaMovimiento
            // 
            this.EtiquetaMovimiento.AutoSize = true;
            this.EtiquetaMovimiento.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaMovimiento.Location = new System.Drawing.Point(228, 58);
            this.EtiquetaMovimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EtiquetaMovimiento.Name = "EtiquetaMovimiento";
            this.EtiquetaMovimiento.Size = new System.Drawing.Size(88, 23);
            this.EtiquetaMovimiento.TabIndex = 11;
            this.EtiquetaMovimiento.Text = "00:00:00";
            // 
            // EtiquetaLubricacion
            // 
            this.EtiquetaLubricacion.AutoSize = true;
            this.EtiquetaLubricacion.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaLubricacion.Location = new System.Drawing.Point(228, 143);
            this.EtiquetaLubricacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EtiquetaLubricacion.Name = "EtiquetaLubricacion";
            this.EtiquetaLubricacion.Size = new System.Drawing.Size(88, 23);
            this.EtiquetaLubricacion.TabIndex = 9;
            this.EtiquetaLubricacion.Text = "00:00:00";
            // 
            // Etiqueta1Funcionamiento
            // 
            this.Etiqueta1Funcionamiento.AutoSize = true;
            this.Etiqueta1Funcionamiento.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta1Funcionamiento.Location = new System.Drawing.Point(228, 15);
            this.Etiqueta1Funcionamiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Etiqueta1Funcionamiento.Name = "Etiqueta1Funcionamiento";
            this.Etiqueta1Funcionamiento.Size = new System.Drawing.Size(88, 23);
            this.Etiqueta1Funcionamiento.TabIndex = 10;
            this.Etiqueta1Funcionamiento.Text = "00:00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tiempo de movimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tiempo de libricacion:";
            // 
            // LFuncionamiento
            // 
            this.LFuncionamiento.AutoSize = true;
            this.LFuncionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFuncionamiento.Location = new System.Drawing.Point(4, 15);
            this.LFuncionamiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFuncionamiento.Name = "LFuncionamiento";
            this.LFuncionamiento.Size = new System.Drawing.Size(225, 20);
            this.LFuncionamiento.TabIndex = 7;
            this.LFuncionamiento.Text = "Tiempo de funcionamiento:";
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
            this.groupBox1.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "posicion";
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
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 236);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(318, 126);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TRANSVERSE CONTROL";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(342, 376);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTorch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaserPointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTorchManualHC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTorchAutomaticHC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTorch)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer Funcionamiento;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage4;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label EtiquetaCorte;
        private System.Windows.Forms.Label tiempoCorte;
        private System.Windows.Forms.Label EtiquetaMovimiento;
        private System.Windows.Forms.Label EtiquetaLubricacion;
        private System.Windows.Forms.Label Etiqueta1Funcionamiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LFuncionamiento;
    }
}
