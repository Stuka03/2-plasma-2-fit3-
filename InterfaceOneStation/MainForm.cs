/*
 * Created by SharpDevelop.
 * User: Efrain
 * Date: 02/03/2017
 * Time: 09:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.IO;
using System.Xml.Linq;
using System;
using System.Drawing;
using System.Windows.Forms;
using Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using InterfaceOneStation.Acciones.ConexionPhoenix;
using InterfaceOneStation.Acciones.Variables;
using System.Collections.Generic;

namespace InterfaceOneStation
{
    public partial class MainForm : Form
    {
        ConexionPhoenix obj=new ConexionPhoenix();
        varibalesDatos var=new varibalesDatos();
        CustomMessageBox customMessageBox = new CustomMessageBox();
        Tranverse tranverse;
        Lubricacion lubri;
        //INSTANCIA CUTTING SYSTEM
        private CuttingSystem SistemaCorte;
        //VARIABLES FIT3
        private bool PiercingAck;
        private bool banPrueba;
        private bool AppRunningAck;
        private bool corteEncendidoT1=false;
        private bool corteEncendidoT2=false;
        //VARIABLES SISTEMA DE LUBRICACION
        private bool LubricationSystemEnable;
        private int LubricationInterval;
        public int LubricationActive;
        public int LubricationActiveRails;
        private int seconds;
        private int tiempoFuncionamiento;
        private int tiempoOperacion;
        private int tiempolubricacion; 
        private string filePath;
        private bool BanderaBoxLS;
        XDocument xmlDocument;
        //VARIABLES MONITOREO BW Y SENSOR DE PRESION
        private bool BanderaBoxBW;
        private bool BanderaBoxPS;
        private DialogResult r;
        public MainForm()
        {
          
            Dictionary < string, dynamic> datos=var.datos;
            //APP SETUP
            InitializeComponent();
            //CONFIG FILE SETUP
            InicializeAppConfigFile();
            //PHOENIX COM SETUP
            SistemaCorte = obj.SistemaCorte;
            //LUBRICATION CONTROL SYSTEM
           
            
            BanderaBoxLS = false;
            seconds = 0;
            
            //MONITOREO
            timer1.Interval = 500;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            BanderaBoxBW = false;
            BanderaBoxPS = false;

            tranverse = new Tranverse(obj);
            
            tranverse.Size = groupBox2.Size;
            tranverse.TopLevel = false;
            tranverse.Dock = DockStyle.Fill;
            groupBox2.Controls.Add(tranverse);
            tranverse.Show();
            

            lubri = new Lubricacion(obj);
            lubri.Dock = DockStyle.Fill; // Opcional: ajusta el tamaño del formulario secundario al tamaño del TabPage
            lubri.Size = tabPage5.Size;
            lubri.TopLevel = false;
            tabPage5.Controls.Add(lubri);
            lubri.Show();
        }
        #region //METODOS STANDAR SOC-PHOENIX
        public void InicializeAppConfigFile()
        {
            filePath = "AppConfig.xml";
            if (File.Exists(filePath))
            {
                // Load the existing XML file
                xmlDocument = XDocument.Load(filePath);
            }
            else
            {
                // Create a new XML file
                xmlDocument = new XDocument(new XElement("Root"));
            }
        }
        
        private bool CheckCncFunctionState(InputFunction f)
        {
            try
            {
                return SistemaCorte.Inputs[f].State;
            }
            catch (Exception ex)
            {
                CncVariableEx(ex.Message, f);
                return false;
            }
        }
        private bool CheckCncOutputState(OutputFunction f)
        {
            try
            {
                return SistemaCorte.Outputs[f].State;
            }
            catch (Exception ex)
            {
                CncVariableExOut(ex.Message, f);
                return false;
            }
        }
        private void CncVariableEx(string ex, InputFunction f)
        {
            if (BanderaBoxLS == false)
            {
                BanderaBoxLS = true;
                
                customMessageBox.set_color_texto((ex) + "\nDar de alta la funcion: " + f.ToString(), Color.Red);
                customMessageBox.ShowDialog();
            }
        }
        private void CncVariableExOut(string ex, OutputFunction f)
        {
            if (BanderaBoxLS == false)
            {
                BanderaBoxLS = true;
               
                customMessageBox.set_color_texto((ex) + "\nDar de alta la funcion: " + f.ToString(), Color.Red);
                customMessageBox.ShowDialog();
            }
        }
        #endregion
        #region//CONTROLES OXICORTE
        //BOTON MODO AUTOMATICO/MANUAL
        private void pictureBoxTorchManualHC_Click(object sender, EventArgs e)
        {
            obj.TurnCncFunctionFalse(InputFunction.Aux_Function_Select_7);
            pictureBoxTorchManualHC.Visible = false;
            pictureBoxTorchAutomaticHC.Visible = true;
        }
        private void pictureBoxTorchAutomaticHC_Click(object sender, EventArgs e)
        {
            obj.TurnCncFunctionTrue(InputFunction.Aux_Function_Select_7);
            pictureBoxTorchManualHC.Visible = true;
            pictureBoxTorchAutomaticHC.Visible = false;
        }
        //BOTON LASER POINTER
        private void pictureBoxLaserPointer_Click(object sender, EventArgs e)
        {
            if (pictureBoxLaserPointer.BackColor == SystemColors.InactiveBorder)
            {
                pictureBoxLaserPointer.BackColor = Color.Lime;
                obj.TurnCncFunctionTrue(InputFunction.Laser_Pointer_Select);
            }
            else
            {
                pictureBoxLaserPointer.BackColor = SystemColors.InactiveBorder;
                obj.TurnCncFunctionFalse(InputFunction.Laser_Pointer_Select);
            }
        }
        //BOTON ANTORCHA
        private void pictureTorch_Click(object sender, EventArgs e)
        {
            if (pictureTorch.BackColor == Color.Lime || pictureTorch.BackColor == Color.Red)
            {
                TurnOffOxyfuel();
            }
            else if (pictureTorch.BackColor == Color.Yellow)
            {
                obj.TurnCncFunctionFalse(InputFunction.Manual_Select_3);
                pictureTorch.BackColor = SystemColors.InactiveBorder;
                TextBoxSystem.Text = "FIT+3 ST1 HABILITADA";
                TextBoxSystem.BackColor = SystemColors.InactiveBorder;
                AppRunningAck = true;
                banPrueba = true;
            }
            else
            {
                if(!CheckCncOutputState(OutputFunction.Cut_Control) && !CheckCncOutputState(OutputFunction.Motion_Output))
                    ManualTurnOnOxyfuel();
            }
           
        }
        //BOTON ANTORCHA2
        private void pictureTorch2_Click(object sender, EventArgs e)
        {
            if (pictureTorch2.BackColor == Color.Lime || pictureTorch2.BackColor == Color.Red)
            {
                TurnOffOxyfuel2();
            }
           else if (pictureTorch2.BackColor == Color.Yellow)
            {
                obj.TurnCncFunctionFalse(InputFunction.Manual_Select_4);
                pictureTorch2.BackColor = SystemColors.InactiveBorder;
                TextBoxSystem.Text = "FIT+3 ST2 DESAHABILITADA";
                TextBoxSystem.BackColor = SystemColors.InactiveBorder;
                AppRunningAck = true;
                banPrueba = true;
            }
            else
            {
                if (!CheckCncOutputState(OutputFunction.Cut_Control) && !CheckCncOutputState(OutputFunction.Motion_Output))
                    ManualTurnOnOxyfuel2();
            }
            
        }
        #endregion
        #region //METODOS OXICORTE
        //ENCENDIDO DE OXICORTE / ERROR RESET
        private void ManualTurnOnOxyfuel()
        {
            obj.TurnCncFunctionTrue(InputFunction.Manual_Select_3);
            pictureTorch.BackColor = Color.Lime;
            TextBoxSystem.Text = "FIT+3 ST1 HABILITADA";
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
            AppRunningAck = true;
            banPrueba = true;
            
        }
        private void ManualTurnOnOxyfuel2()
        {
            obj.TurnCncFunctionTrue(InputFunction.Manual_Select_4);
            pictureTorch2.BackColor = Color.Lime;
            TextBoxSystem.Text = "FIT+3 ST2 HABILITADA";
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
            AppRunningAck = true;
            banPrueba = true;
        }
        private void TurnOffOxyfuel()
        {
            if (CheckCncFunctionState(InputFunction.Aux_Function_Select_9) && pictureTorch.BackColor != Color.Red)
            {
                obj.TurnCncFunctionTrue(InputFunction.Front_Panel_Stop);
                TextBoxSystem.Text = "FIT+3 ST1 ERROR, PANEL STOP";
                pictureTorch.BackColor = Color.Red;
            }
            else if (!CheckCncFunctionState(InputFunction.Aux_Function_Select_9))
            {
                obj.TurnCncFunctionFalse(InputFunction.Front_Panel_Stop);
                DisableOxyfuel(1);
            }
        }
        private void TurnOffOxyfuel2()
        {
            if (CheckCncFunctionState(InputFunction.Aux_Function_Select_9) && pictureTorch2.BackColor != Color.Red)
            {
                obj.TurnCncFunctionTrue(InputFunction.Front_Panel_Stop);
                TextBoxSystem.Text = "FIT+3 ST2 ERROR, PANEL STOP";
                pictureTorch2.BackColor = Color.Red;
            }
            else if (!CheckCncFunctionState(InputFunction.Aux_Function_Select_9))
            {
                //TurnCncFunctionFalse(InputFunction.Manual_Select_4);
                DisableOxyfuel(2);
            }
        }
        private void DisableOxyfuel(int s)
        {
            //SI SE APAGA LA ESTACION 1 Y LA 2 SIGUE ENCENDIA
            if (s==1 )
            {
                obj.TurnCncFunctionFalse(InputFunction.Manual_Select_3);
                pictureTorch.BackColor = SystemColors.InactiveBorder;
                TextBoxSystem.Text = "FIT+3 ST1 DESHABILITADA";
            }
            //SI SE APAGA LA ESTACION 2 Y LA 1 SIGUE ENCENDIA
            else if (s == 2 )
            {
                obj.TurnCncFunctionFalse(InputFunction.Manual_Select_4);
                pictureTorch2.BackColor = SystemColors.InactiveBorder;
                TextBoxSystem.Text = "FIT+3 ST2 DESHABILITADA"; 
            }
            //SI LAS DOS ESTAN APAGADAS
            else
            {
                obj.TurnCncFunctionFalse(InputFunction.Program_Inhibit);
                obj.TurnCncFunctionFalse(InputFunction.Front_Panel_Stop);
                TextBoxSystem.Text = "FIT+3 DESHABILITADA";
                pictureTorch.BackColor = SystemColors.InactiveBorder;
                pictureTorch2.BackColor = SystemColors.InactiveBorder;
            }
            
        }
        #endregion
        #region //EVENTOS LUBRICACION   
        //#4 TERMINA SECUENCIA DE LUBRICACION, ACTUALIZA LOS VALORES DE LA CONFIGURACION Y REINICIA EL CICLO
        
        
      
        #endregion
        #region //MONITOREO BW & SENSOR DE PRESION
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckCncFunctionState(InputFunction.Aux_Function_Select_9))
                obj.TurnCncFunctionFalse(InputFunction.Front_Panel_Stop);
            //MONITOREO BW
            if (CheckCncFunctionState(InputFunction.Torch_Collision))
            {
                if (BanderaBoxBW == false)
                {
                    BanderaBoxBW = true;
                    customMessageBox.set_color_texto("Torch Collision, Revisa estado del Breakaway!", Color.Red);
                    customMessageBox.ShowDialog();
                    //Check the result after the form is closed
                    if (customMessageBox.CustomDialogResult == DialogResult.OK)
                    {
                        BanderaBoxBW = false;
                    }
                }
            }
            //MONITOREO SENSOR DE PRESION
            if (CheckCncFunctionState(InputFunction.Aux_Function_Select_6))
            {
                if (BanderaBoxPS == false)
                {
                    obj.TurnCncFunctionTrue(InputFunction.Fast_Stop);
                    if (BanderaBoxPS == false)
                    {
                        BanderaBoxPS = true;
                        customMessageBox.set_color_texto("Low Air Pressure\nProgram Inhibit Activado\n¡Revisa estado del Suministro!", Color.Red);
                        customMessageBox.ShowDialog();
                        //Check the result after the form is closed
                        if (customMessageBox.CustomDialogResult == DialogResult.OK)
                        {
                            obj.TurnCncFunctionFalse(InputFunction.Fast_Stop);
                            BanderaBoxPS = false;
                        }
                    }
                }
            }
            //MONITOREO PROGRAM RUNNING
            if (CheckCncOutputState(OutputFunction.Program_Running))
            {
                tranverse.ProgramanRuning();
                groupBox2.Enabled = false;
            }
            else if (!CheckCncOutputState(OutputFunction.Program_Running))
            {
                groupBox2.Enabled = true;
            }
            //PROGRAM INHIBIT - MOVE
            radioButtonOkToMove.Checked = !CheckCncFunctionState(InputFunction.Program_Inhibit);
            //ERROR
            radioButtonError.Checked = CheckCncFunctionState(InputFunction.Aux_Function_Select_9);
           
            //APAGAR OXICORTE SI SE ACTIVA UN ERROR
            if (AppRunningAck && CheckCncFunctionState(InputFunction.Aux_Function_Select_9))
            {
                if (CheckCncFunctionState(InputFunction.Manual_Select_3))
                {
                    TurnOffOxyfuel();
                }
                if (CheckCncFunctionState(InputFunction.Manual_Select_4))
                {
                    TurnOffOxyfuel2();
                }
            }
            //SI SE ACTIVA LA ESTACION Y CUT CONTROL SE ACTIVA PROGRAM INHIBIT PARA PAUSAR EL PROGRAMA DURANTE LA PERFORACION 
            else if (!PiercingAck && CheckCncOutputState(OutputFunction.Cut_Control) && (CheckCncFunctionState(InputFunction.Manual_Select_3) || CheckCncFunctionState(InputFunction.Manual_Select_4)))
            {
                obj.TurnCncFunctionTrue(InputFunction.Program_Inhibit);
                if (CheckCncFunctionState(InputFunction.Manual_Select_3) && !CheckCncFunctionState(InputFunction.Manual_Select_4))
                {
                    TextBoxSystem.Text = "FIT+3 ST1 PERFORANDO";
                    pictureTorch.BackColor = Color.Yellow;
                    corteEncendidoT1 = true;
                }
                else if (CheckCncFunctionState(InputFunction.Manual_Select_4) && !CheckCncFunctionState(InputFunction.Manual_Select_3))
                    {
                        TextBoxSystem.Text = "FIT+3 ST2 PERFORANDO";
                        pictureTorch2.BackColor = Color.Yellow;
                        corteEncendidoT2 = true;
                }
                else
                {
                    TextBoxSystem.Text = "FIT+3 PERFORANDO";
                    pictureTorch.BackColor = Color.Yellow;
                    pictureTorch2.BackColor = Color.Yellow;
                    corteEncendidoT1 = true;
                    corteEncendidoT2 = true;
                }
                PiercingAck = true;
            }
            //SI SE ACTIVA EL OXICORTE Y LA SENAL DE OK TO MOVE, SE ACTIVA MOVIMIENTO
            else if (banPrueba && CheckCncOutputState(OutputFunction.Cut_Control) && CheckCncFunctionState(InputFunction.Aux_Function_Select_8) && (CheckCncFunctionState(InputFunction.Manual_Select_3) || CheckCncFunctionState(InputFunction.Manual_Select_4)))
            {
                obj.TurnCncFunctionFalse(InputFunction.Program_Inhibit);
                

                if (pictureTorch.BackColor != Color.Lime && CheckCncFunctionState(InputFunction.Manual_Select_3) && !CheckCncFunctionState(InputFunction.Manual_Select_4))
                {
                    TextBoxSystem.Text = "FIT+3 ST1 CORTANDO";
                    pictureTorch.BackColor = Color.Lime;
                }
                else if (pictureTorch2.BackColor != Color.Lime && CheckCncFunctionState(InputFunction.Manual_Select_4) && !CheckCncFunctionState(InputFunction.Manual_Select_3))
                {
                    TextBoxSystem.Text = "FIT+3 ST2 CORTANDO";
                    pictureTorch2.BackColor = Color.Lime;
                }
                else if (pictureTorch.BackColor != Color.Lime  && pictureTorch2.BackColor != Color.Lime)
                {
                    TextBoxSystem.Text = "FIT+3 CORTANDO";
                    pictureTorch.BackColor = Color.Lime;
                    pictureTorch2.BackColor = Color.Lime;
                }
                
                banPrueba = false;
            }

            //SI SE ACTIVÓ UNA PERFORACION Y SE DESACTIVA CUT CONTROL SE TERMINA CORTE
            else if (PiercingAck && !CheckCncOutputState(OutputFunction.Cut_Control))
            {
                obj.TurnCncFunctionFalse(InputFunction.Program_Inhibit);
                PiercingAck = false;
                TextBoxSystem.Text = "FIT+3 CORTE FINALIZADO";
            }
            if (!CheckCncFunctionState(InputFunction.Aux_Function_Select_9) && CheckCncOutputState(OutputFunction.Cut_Control))
            {
                if (corteEncendidoT1 == true)
                {
                    pictureTorch.BackColor = Color.Yellow;
                    corteEncendidoT1=false;
                }
                if (corteEncendidoT2 == true)
                {
                    pictureTorch2.BackColor = Color.Yellow;
                    corteEncendidoT2 =false;
                }
            }
        }

        private void Funcionamiento_Tick(object sender, EventArgs e)
        {
            tiempoFuncionamiento++;
            if (CheckCncOutputState(OutputFunction.Motion_Output))
            {
                tiempoOperacion++;
            }
            Etiqueta1Funcionamiento.Text = TimeSpan.FromSeconds(tiempoFuncionamiento).ToString();
            EtiquetaMovimiento.Text= TimeSpan.FromSeconds(tiempoOperacion).ToString();
            EtiquetaLubricacion.Text = TimeSpan.FromSeconds(lubri.getTimepoLubricacion()).ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }
    }
        #endregion
}