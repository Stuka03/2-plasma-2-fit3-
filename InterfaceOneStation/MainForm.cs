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
        //INSTANCIA CUTTING SYSTEM
        private CuttingSystem SistemaCorte;
        //VARIABLES FIT3
        private bool PiercingAck;
        private bool banPrueba;
        private bool AppRunningAck;
        //VARIABLES SISTEMA DE LUBRICACION
        private bool LubricationSystemEnable;
        private int LubricationInterval;
        public int LubricationActive;
        public int LubricationActiveRails;
        private int seconds;
        private int minuts;
        private int hours;
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
            UpdateValues();
            CheckLubricationSystem();
            BanderaBoxLS = false;
            seconds = 0;
            minuts = 0;
            hours = 0;
            //MONITOREO
            timer1.Interval = 500;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            BanderaBoxBW = false;
            BanderaBoxPS = false;
            //TIMER INTERVAL
            timer2.Interval = 1000;
            timer2.Enabled = false;
            timer2.Tick += new EventHandler(timer2_Tick);
            //TIMER LUBRICATION
            timer3.Interval = 1000;
            timer3.Enabled = false;
            timer3.Tick += new EventHandler(timer3_Tick);

            timer4.Interval = 1000;
            timer4.Enabled = false;
            timer4.Tick += new EventHandler(timer4_Tick);

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
        public void TurnCncFunctionTrue(InputFunction f)
        {
            try
            {   //INICIAR CONEXION
                SistemaCorte.Inputs[f].SetState(true);

            }
            catch (Exception ex)
            {
                CncVariableEx(ex.Message, f);
            }
        }
        public void TurnCncFunctionFalse(InputFunction f)
        {
            try
            {
                SistemaCorte.Inputs[f].SetState(false);
            }
            catch (Exception ex)
            {
                CncVariableEx(ex.Message, f);
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
        #region //PARK & CLAMPS CONTROLS
        //TORCH 1 CONTROLS
        private void pictureBoxClamp1_Click(object sender, EventArgs e)
        {
            
            pictureBoxUnclamp1.Visible = true;
            pictureBoxClamp1.Visible = false;
            labelMaster1Clamp.Text = "Unclamped";
            TurnCncFunctionTrue(InputFunction.Aux_Function_Select_2);
        }
        private void pictureBoxUnclamp1_Click(object sender, EventArgs e)
        {
            torch1Clamped();
        }
        //TORCH 2 CONTROLS
        private void pictureBoxAncla_Click(object sender, EventArgs e)
        {
            torch2Free();
        }
        private void pictureBoxMove_Click(object sender, EventArgs e)
        {
            pictureBoxAncla1.Visible = true;
            pictureBoxMove1.Visible = false;
            labelMaster1.Text = "Parked";
            TurnCncFunctionTrue(InputFunction.Aux_Function_Select_4);
        }
        //TORCH 3 CONTROLS
        private void pictureBoxAncla2_Click(object sender, EventArgs e)
        {
            torch3Free();

        }
        private void pictureBoxMove2_Click(object sender, EventArgs e)
        {
            TurnCncFunctionTrue(InputFunction.Aux_Function_Select_5);
            pictureBoxAncla2.Visible = true;
            pictureBoxMove2.Visible = false;
            labelMaster2.Text = "Parked";
        }
        //TORCH 4 CONTROLS
        private void pictureBoxClamp2_Click(object sender, EventArgs e)
        {
            pictureBoxClamp2.Visible = false;
            pictureBoxUnclamp2.Visible = true;
            labelMaster2Clamp.Text = "Unclamped";
            TurnCncFunctionTrue(InputFunction.Aux_Function_Select_3);
        }
        private void pictureBoxUnclamp2_Click(object sender, EventArgs e)
        {
            torch4Clamped();
        }
        #endregion
        #region//PARK & CLAMPS METHODS        
        private void torch1Clamped()
        {
            pictureBoxUnclamp1.Visible = false;
            pictureBoxClamp1.Visible = true;
            labelMaster1Clamp.Text = "Clamped";
            TurnCncFunctionFalse(InputFunction.Aux_Function_Select_2);
        }
        private void torch2Free()
        {
            pictureBoxAncla1.Visible = false;
            pictureBoxMove1.Visible = true;
            labelMaster1.Text = "Free";
            TurnCncFunctionFalse(InputFunction.Aux_Function_Select_4);
        }
        private void torch3Free()
        {
            TurnCncFunctionFalse(InputFunction.Aux_Function_Select_5);
            pictureBoxAncla2.Visible = false;
            pictureBoxMove2.Visible = true;
            labelMaster2.Text = "Free";
        }
        private void torch4Clamped()
        {
            pictureBoxClamp2.Visible = true;
            pictureBoxUnclamp2.Visible = false;
            labelMaster2Clamp.Text = "Clamped";
            TurnCncFunctionFalse(InputFunction.Aux_Function_Select_3);
        }
        #endregion
        #region//CONTROLES OXICORTE
        //BOTON MODO AUTOMATICO/MANUAL
        private void pictureBoxTorchManualHC_Click(object sender, EventArgs e)
        {
            TurnCncFunctionFalse(InputFunction.Aux_Function_Select_7);
            pictureBoxTorchManualHC.Visible = false;
            pictureBoxTorchAutomaticHC.Visible = true;
        }
        private void pictureBoxTorchAutomaticHC_Click(object sender, EventArgs e)
        {
            TurnCncFunctionTrue(InputFunction.Aux_Function_Select_7);
            pictureBoxTorchManualHC.Visible = true;
            pictureBoxTorchAutomaticHC.Visible = false;
        }
        //BOTON LASER POINTER
        private void pictureBoxLaserPointer_Click(object sender, EventArgs e)
        {
            if (pictureBoxLaserPointer.BackColor == SystemColors.InactiveBorder)
            {
                pictureBoxLaserPointer.BackColor = Color.Lime;
                TurnCncFunctionTrue(InputFunction.Laser_Pointer_Select);
            }
            else
            {
                pictureBoxLaserPointer.BackColor = SystemColors.InactiveBorder;
                TurnCncFunctionFalse(InputFunction.Laser_Pointer_Select);
            }
        }
        //BOTON ANTORCHA
        private void pictureTorch_Click(object sender, EventArgs e)
        {
            if (pictureTorch.BackColor == Color.Lime || pictureTorch.BackColor == Color.Red)
            {
                TurnOffOxyfuel();
            }
            else
            {
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
            else
            {
                ManualTurnOnOxyfuel2();
            }
        }
        #endregion
        #region //METODOS OXICORTE
        //ENCENDIDO DE OXICORTE / ERROR RESET
        private void ManualTurnOnOxyfuel()
        {
            TurnCncFunctionTrue(InputFunction.Manual_Select_3);
            pictureTorch.BackColor = Color.Lime;
            TextBoxSystem.Text = "FIT+3 ST1 HABILITADA";
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
            AppRunningAck = true;
            banPrueba = true;
        }
        private void ManualTurnOnOxyfuel2()
        {
            TurnCncFunctionTrue(InputFunction.Manual_Select_4);
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
                TurnCncFunctionTrue(InputFunction.Front_Panel_Stop);
                TextBoxSystem.Text = "FIT+3 ST1 ERROR, PANEL STOP";
                pictureTorch.BackColor = Color.Red;
            }
            else if (!CheckCncFunctionState(InputFunction.Aux_Function_Select_9))
            {
                //TurnCncFunctionFalse(InputFunction.Manual_Select_3);
                DisableOxyfuel(1);
            }
        }
        private void TurnOffOxyfuel2()
        {
            if (CheckCncFunctionState(InputFunction.Aux_Function_Select_9) && pictureTorch2.BackColor != Color.Red)
            {
                TurnCncFunctionTrue(InputFunction.Front_Panel_Stop);
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
                TurnCncFunctionFalse(InputFunction.Manual_Select_3);
                pictureTorch.BackColor = SystemColors.InactiveBorder;
                TextBoxSystem.Text = "FIT+3 ST1 DESHABILITADA";
            }
            //SI SE APAGA LA ESTACION 2 Y LA 1 SIGUE ENCENDIA
            else if (s == 2 )
            {
                TurnCncFunctionFalse(InputFunction.Manual_Select_4);
                pictureTorch2.BackColor = SystemColors.InactiveBorder;
                TextBoxSystem.Text = "FIT+3 ST2 DESHABILITADA";
            }
            //SI LAS DOS ESTAN APAGADAS
            else
            {
                TurnCncFunctionFalse(InputFunction.Program_Inhibit);
                TurnCncFunctionFalse(InputFunction.Front_Panel_Stop);
                TextBoxSystem.Text = "FIT+3 DESHABILITADA";
                pictureTorch.BackColor = SystemColors.InactiveBorder;
                pictureTorch2.BackColor = SystemColors.InactiveBorder;
            }
            
        }
        #endregion
        #region //LUBRICATION CONTROLS        
        private void DisableControls()
        {
            checkBoxEnableLubrication.Enabled = false;
            comboBoxLubricationInterval.Enabled = false;
            comboBoxLubricationActive.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            buttonSave.Enabled = false;
            button3.Enabled = false;
            checkBoxEnableLubrication.Enabled = false;
        }
        private void EnableButtons()
        {
            checkBoxEnableLubrication.Enabled = true;
            comboBoxLubricationInterval.Enabled = true;
            comboBoxLubricationActive.Enabled = true;
            buttonSave.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
            checkBoxEnableLubrication.Enabled = true;
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "1396")
            {
                EnableButtons();
                buttonEnter.Enabled = false;
                customMessageBox.set_color_texto("Contraseña Valida", Color.Lime);
                customMessageBox.ShowDialog();
                return;
            }
            customMessageBox.set_color_texto("Contraseña Invalida", Color.Red);
            customMessageBox.ShowDialog();
            textBoxPassword.Text = "";

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                //validacion de datos
                //intervalo
                if (comboBoxLubricationInterval.SelectedIndex == -1)
                {
                    customMessageBox.set_color_texto("Please select a valid item from the Interval list.",Color.Yellow);
                    customMessageBox.ShowDialog();
                    comboBoxLubricationInterval.SelectedIndex = 0;
                    return;
                    // Set the index to a default value or any other appropriate action.
                }
                //ciclo activo
                else if (comboBoxLubricationActive.SelectedIndex == -1)
                {
                    customMessageBox.set_color_texto("Please select a valid item from the Timer list.", Color.Yellow);
                    customMessageBox.ShowDialog();
                    comboBoxLubricationActive.SelectedIndex = 0; // Set the index to a default value or any other appropriate action.
                    return;
                }
                else
                {
                    
                    xmlDocument.Root.Element("LubricationEnabled")?.Remove(); // Remove existing value, if any
                    xmlDocument.Root.Element("IntervalTime")?.Remove(); // Remove existing value, if any
                    xmlDocument.Root.Element("ActivationTime")?.Remove(); // Remove existing value, if any
                    xmlDocument.Root.Add(new XElement("LubricationEnabled", checkBoxEnableLubrication.Checked));
                    xmlDocument.Root.Add(new XElement("IntervalTime", comboBoxLubricationInterval.SelectedIndex));
                    xmlDocument.Root.Add(new XElement("ActivationTime", comboBoxLubricationActive.SelectedIndex));
                    xmlDocument.Save(filePath);
                    customMessageBox.set_color_texto("Data saved succesfully.", Color.Lime);
                    customMessageBox.ShowDialog();
                }
     
            }
            catch (Exception ex)
            {
                customMessageBox.set_color_texto("No se pudo guardar configuracion, intente manualmente", Color.Red);
                customMessageBox.ShowDialog();
                return;
            }
            //ACTUALIZA VALORES, DESHABILITA CONTROLES Y REINICIA EL SISTEMA DE LUBRICACION CON LOS NUEVOS VALORES
            UpdateValues();
            DisableControls();
            CheckLubricationSystem();
        }
        #endregion
        #region //EVENTOS LUBRICACION
        //#1 REVISA SI ESTÁ EL BIT ENABLE ACTIVADO Y ARRANCA TIMER INTERVALO
        private void CheckLubricationSystem()
        {
            if (LubricationSystemEnable == true)
            {
                timer2.Enabled = true;
            }
            else
            {
                timer2.Enabled = false;
            }
        }
        //#2 TIMER INTERVALO, CUENTA TIEMPO DE INTERVALO Y LUEGO INICIALIZA TIMER DE LUBRICACION
        private void timer2_Tick(object sender, EventArgs e)
        {
            seconds = seconds + 1;
            
            labelTime.Text = TimeSpan.FromSeconds(seconds).ToString();
            if (seconds >= 30)
            //if (hours == LubricationInterval)
            {
                timer3.Enabled = true;
                timer2.Enabled = false;
                seconds = 0;
               
            }
        }
        //#3 TIMER LUBRICACION, ACTIVA SEÑALES DE LUBRICACION Y CUENTA TIEMPO DE ACTIVACION
        private void timer3_Tick(object sender, EventArgs e)
        {
            //ENCIENDE BOMBA
            TurnCncFunctionTrue(InputFunction.Aux_Function_Select_1);
            radioButtonLSAactive.Checked = true;
            //CUENTA LOS SEGUNDOS
            seconds++;
            tiempolubricacion++;
            labelTime.Text = seconds.ToString();
            //TERMINA LA LUBRICACION AL TRANSCURRIR EL TIEMPO DEFINIDO PARA TRANS Y RIELES
            if (seconds >= LubricationActive)
            {
                EndTimerLubrication();
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            //ENCIENDE BOMBA
           
            //CUENTA LOS SEGUNDOS
            
            seconds++;
            tiempolubricacion++;
            customMessageBox.set_texto((seconds).ToString());
            labelTime.Text = seconds.ToString();
            //TERMINA LA LUBRICACION AL TRANSCURRIR EL TIEMPO DEFINIDO PARA TRANS Y RIELES
            if (seconds >= LubricationActive)
            { 
                LubricationActive = 0;
                timer4.Enabled = false;
                seconds = 0;
                TurnCncFunctionFalse(InputFunction.Aux_Function_Select_1);
                radioButtonLSAactive.Checked = false;
                button1.Enabled=true;
                button2.Enabled=true;
                EnableButtons();
                labelTime.Text = "";
                customMessageBox.Close();
            }
        }
        //#4 TERMINA SECUENCIA DE LUBRICACION, ACTUALIZA LOS VALORES DE LA CONFIGURACION Y REINICIA EL CICLO
        private void EndTimerLubrication()
        {
            timer3.Enabled = false;
            //APAGA BOMBA
            TurnCncFunctionFalse(InputFunction.Aux_Function_Select_1);
            radioButtonLSAactive.Checked = false;
            seconds = 0;
            minuts = 0;
            hours = 0;
            BanderaBoxLS = false;
            UpdateValues();
            CheckLubricationSystem();
        }

        private void UpdateValues()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    // Retrieve the value from the XML document
                    XElement myValueElement1 = xmlDocument.Root.Element("LubricationEnabled");
                    XElement myValueElement2 = xmlDocument.Root.Element("IntervalTime");
                    XElement myValueElement3 = xmlDocument.Root.Element("ActivationTime"); ;
                    // updates enable value
                    if (bool.TryParse(myValueElement1.Value, out LubricationSystemEnable))
                    {
                        checkBoxEnableLubrication.Checked = LubricationSystemEnable;
                    }
                    else
                    {
                        checkBoxEnableLubrication.Checked = false;
                    }
                    // updates interval
                    if (myValueElement2 != null)
                    {
                        int interval;
                        interval = Convert.ToInt16(myValueElement2.Value);
                        LubricationInterval = interval + 1;
                        comboBoxLubricationInterval.SelectedIndex = interval; // Set the index to a default value or any other appropriate action.
                    }
                    else
                    {
                        LubricationSystemEnable = false;
                    }
                    //updates activation time
                    if (myValueElement3 != null)
                    {
                        int activation;
                        activation = Convert.ToInt16(myValueElement3.Value);
                        LubricationActive = (activation + 1) * 5;
                        comboBoxLubricationActive.SelectedIndex = activation;
                    }
                    else
                    {
                        LubricationSystemEnable = false;
                    }
                }
            }
            catch (Exception ex)
            {
                customMessageBox.set_color_texto("No se actualizaron valores", Color.Red);
                customMessageBox.ShowDialog();

            }
        }
        #endregion
        #region //MONITOREO BW & SENSOR DE PRESION
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(radioButtonTest.Checked)
            {
                TurnCncFunctionTrue(InputFunction.Aux_Function_Select_8);
            }
            if (radioButtonTest2.Checked)
            {
                TurnCncFunctionFalse(InputFunction.Aux_Function_Select_8);
            }
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
                    TurnCncFunctionTrue(InputFunction.Fast_Stop);
                    if (BanderaBoxPS == false)
                    {
                        BanderaBoxPS = true;
                        customMessageBox.set_color_texto("Low Air Pressure\nProgram Inhibit Activado\n¡Revisa estado del Suministro!", Color.Red);
                        customMessageBox.ShowDialog();
                        //Check the result after the form is closed
                        if (customMessageBox.CustomDialogResult == DialogResult.OK)
                        {
                            TurnCncFunctionFalse(InputFunction.Fast_Stop);
                            BanderaBoxPS = false;
                        }
                    }
                }
            }
            //MONITOREO PROGRAM RUNNING
            if (CheckCncOutputState(OutputFunction.Program_Running))
            {
                torch1Clamped();
                torch2Free();
                torch3Free();
                torch4Clamped();
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
                TurnCncFunctionTrue(InputFunction.Program_Inhibit);
                if (CheckCncFunctionState(InputFunction.Manual_Select_3) && !CheckCncFunctionState(InputFunction.Manual_Select_4))
                {
                    TextBoxSystem.Text = "FIT+3 ST1 PERFORANDO";
                    pictureTorch.BackColor = Color.Yellow;
                }
                else if (CheckCncFunctionState(InputFunction.Manual_Select_4) && !CheckCncFunctionState(InputFunction.Manual_Select_3))
                    {
                        TextBoxSystem.Text = "FIT+3 ST2 PERFORANDO";
                        pictureTorch2.BackColor = Color.Yellow;
                    }
                else
                {
                    TextBoxSystem.Text = "FIT+3 PERFORANDO";
                    pictureTorch.BackColor = Color.Yellow;
                    pictureTorch2.BackColor = Color.Yellow;
                }
                PiercingAck = true;
            }
            //SI SE ACTIVA EL OXICORTE Y LA SENAL DE OK TO MOVE, SE ACTIVA MOVIMIENTO
            else if (banPrueba && CheckCncOutputState(OutputFunction.Cut_Control) && CheckCncFunctionState(InputFunction.Aux_Function_Select_8) && (CheckCncFunctionState(InputFunction.Manual_Select_3) || CheckCncFunctionState(InputFunction.Manual_Select_4)))
            {
                TurnCncFunctionFalse(InputFunction.Program_Inhibit);

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
                TurnCncFunctionFalse(InputFunction.Program_Inhibit);
                PiercingAck = false;
                TextBoxSystem.Text = "FIT+3 CORTE FINALIZADO";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            comboBoxLubricationInterval.Visible = true;
            label3.Text = "Cycle Time";
            buttonSave.Visible = true;
            button3.Visible = false;

        }

        private void buttonPruebaLubrication_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            comboBoxLubricationInterval.Visible = false;
            label3.Text = "Testing Period"; 
            
            buttonSave.Visible = false;
            button3.Visible = true;
            
            
        }
        private void buttonTesting_Click(object sender, EventArgs e)
        {
            //ciclo activo
            if (comboBoxLubricationActive.SelectedIndex == -1)
            {
                customMessageBox.set_color_texto("Please select a valid item from the Timer list.", Color.Yellow);
                customMessageBox.ShowDialog();
                comboBoxLubricationActive.SelectedIndex = 0; // Set the index to a default value or any other appropriate action.
                return;
            }
            DisableControls();
            TurnCncFunctionTrue(InputFunction.Aux_Function_Select_1);
            timer4.Enabled = true;
            LubricationActive = (comboBoxLubricationActive.SelectedIndex+1)*5;
            radioButtonLSAactive.Checked = true;

            customMessageBox.set_color_texto(seconds.ToString(), Color.Gray);
            customMessageBox.ShowDialog();
        }

        private void Funcionamiento_Tick(object sender, EventArgs e)
        {
            tiempoFuncionamiento++;
            if (CheckCncOutputState(OutputFunction.Motion_Output))
            {
                tiempoOperacion++;
            }
            Etiqueta1Funcionamiento.Text = TimeSpan.FromSeconds(tiempoFuncionamiento).ToString();
            EtiquetaProduccion.Text= TimeSpan.FromSeconds(tiempoOperacion).ToString();
            EtiquetaLubricacion.Text = TimeSpan.FromSeconds(tiempolubricacion).ToString();
        }

       
    }
        #endregion
}