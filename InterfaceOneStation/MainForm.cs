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

namespace InterfaceOneStation
{
    public partial class MainForm : Form
    {

        //INSTANCIA CUTTING SYSTEM
        private CuttingSystem SistemaCorte;
        //VARIABLES FIT3
        private bool ProgramInihibitAck;
        private bool AppRunningAck;
        //VARIABLES SISTEMA DE LUBRICACION
        private bool LubricationSystemEnable;
        private int LubricationInterval;
        public int LubricationActive;
        public int LubricationActiveRails;
        private int seconds;
        private int minuts;
        private int hours;
        private string filePath;
        private bool BanderaBoxLS;
        XDocument xmlDocument;
        //VARIABLES MONITOREO BW Y SENSOR DE PRESION
        private bool BanderaBoxBW;
        private bool BanderaBoxPS;
        private DialogResult r;
        public MainForm()
        {
            //APP SETUP
            InitializeComponent();
            //CONFIG FILE SETUP
            InicializeAppConfigFile();
            //PHOENIX COM SETUP
            IniciaConexionPhoenix();
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
        public void IniciaConexionPhoenix()
        {
            try
            {   //INICIAR CONEXION
                SistemaCorte = CuttingSystem.Instance;
                do
                {
                    SistemaCorte.GetAssignedIO();
                } while (SistemaCorte.Inputs.Count <= 0 &&
                SistemaCorte.Outputs.Count <= 0);
                //SINCRONIZAR
                SistemaCorte.SetSyncTimerTick(0.5);
                SistemaCorte.StartSync();
                SistemaCorte.Synchronize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Conexion Phoenix");
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
                MessageBox.Show("Dar de alta la funcion: " + f.ToString(), (ex));
            }
        }
        private void CncVariableExOut(string ex, OutputFunction f)
        {
            if (BanderaBoxLS == false)
            {
                BanderaBoxLS = true;
                MessageBox.Show("Dar de alta la funcion: " + f.ToString(), (ex));
            }
        }
        #endregion
        #region //PARK & CLAMPS CONTROLS
        //TORCH 1 CONTROLS
        private void pictureBoxClamp1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.variable.ToString());
            //Properties.Settings.Default.variable.ToString();
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
            TurnCncFunctionTrue(InputFunction.Park_SKR);
        }
        //TORCH 3 CONTROLS
        private void pictureBoxAncla2_Click(object sender, EventArgs e)
        {
            torch3Free();

        }
        private void pictureBoxMove2_Click(object sender, EventArgs e)
        {
            TurnCncFunctionTrue(InputFunction.Park_DSKR);
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
            TurnCncFunctionFalse(InputFunction.Park_SKR);
        }
        private void torch3Free()
        {
            TurnCncFunctionFalse(InputFunction.Park_DSKR);
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
            TurnCncFunctionFalse(InputFunction.Aux_Function_Select_6);
            pictureBoxTorchManualHC.Visible = false;
            pictureBoxTorchAutomaticHC.Visible = true;
        }
        private void pictureBoxTorchAutomaticHC_Click(object sender, EventArgs e)
        {
            TurnCncFunctionTrue(InputFunction.Aux_Function_Select_6);
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
            if (pictureTorch.BackColor == Color.Lime || pictureTorch.BackColor == Color.Red)
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
        }
        private void ManualTurnOnOxyfuel2()
        {
            TurnCncFunctionTrue(InputFunction.Manual_Select_4);
            pictureTorch.BackColor = Color.Lime;
            TextBoxSystem.Text = "FIT+3 ST 2HABILITADA";
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
            AppRunningAck = true;
        }
        private void TurnOffOxyfuel()
        {
            if (CheckCncFunctionState(InputFunction.Aux_Function_Select_8) && pictureTorch.BackColor != Color.Red)
            {
                TurnCncFunctionTrue(InputFunction.Front_Panel_Stop);
                TextBoxSystem.Text = "FIT+3 ST1 ERROR, PANEL STOP";
                pictureTorch.BackColor = Color.Red;
            }
            else
            {
                TurnCncFunctionFalse(InputFunction.Manual_Select_3);
                DisableOxyfuel(1);
            }
        }
        private void TurnOffOxyfuel2()
        {
            if (CheckCncFunctionState(InputFunction.Aux_Function_Select_8) && pictureTorch2.BackColor != Color.Red)
            {
                TurnCncFunctionTrue(InputFunction.Front_Panel_Stop);
                TextBoxSystem.Text = "FIT+3 ST2 ERROR, PANEL STOP";
                pictureTorch.BackColor = Color.Red;
            }
            else
            {
                TurnCncFunctionFalse(InputFunction.Manual_Select_4);
                DisableOxyfuel(2);
            }
        }
        private void DisableOxyfuel(int s)
        {
            //SI SE APAGA LA ESTACION 1 Y LA 2 SIGUE ENCENDIA
            if (s==1 && CheckCncFunctionState(InputFunction.Manual_Select_4))
            {
                TextBoxSystem.Text = "FIT+3 ST1 DESHABILITADA";
            }
            //SI SE APAGA LA ESTACION 2 Y LA 1 SIGUE ENCENDIA
            else if (s == 2 && CheckCncFunctionState(InputFunction.Manual_Select_3))
            {
                TextBoxSystem.Text = "FIT+3 ST2 DESHABILITADA";
            }
            //SI LAS DOS ESTAN APAGADAS
            else
            {
                TurnCncFunctionFalse(InputFunction.Program_Inhibit);
                TurnCncFunctionFalse(InputFunction.Front_Panel_Stop);
                TextBoxSystem.Text = "FIT+3 DESHABILITADA";
                pictureTorch.BackColor = SystemColors.InactiveBorder;
            }
        }
        #endregion
        #region //LUBRICATION CONTROLS        
        private void DisableControls()
        {
            checkBoxEnableLubrication.Enabled = false;
            comboBoxLubricationInterval.Enabled = false;
            comboBoxLubricationActive.Enabled = false;
            buttonSave.Enabled = false;
            checkBoxEnableLubrication.Enabled = false;
        }
        private void EnableButtons()
        {
            checkBoxEnableLubrication.Enabled = true;
            comboBoxLubricationInterval.Enabled = true;
            comboBoxLubricationActive.Enabled = true;
            buttonSave.Enabled = true;
            checkBoxEnableLubrication.Enabled = true;
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "1396")
            {
                EnableButtons();
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                //validacion de datos
                //intervalo
                if (comboBoxLubricationInterval.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid item from the Interval list.");
                    comboBoxLubricationInterval.SelectedIndex = 0; // Set the index to a default value or any other appropriate action.
                }
                //ciclo activo
                else if (comboBoxLubricationActive.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid item from the Timer list.");
                    comboBoxLubricationActive.SelectedIndex = 0; // Set the index to a default value or any other appropriate action.
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
                    MessageBox.Show("Data saved succesfully.");
                }
     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo guardar configuracion, intente manualmente");
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
            if (seconds == 60)
            {
                minuts = minuts + 1;
                seconds = 0;
            }
            if (minuts == 60)
            {
                hours = hours + 1;
                minuts = 0;
            }
            labelTime.Text = hours.ToString() + ":" + minuts.ToString() + ":" + seconds.ToString();
            if (seconds >= 30)
            //if (hours == LubricationInterval)
            {
                timer3.Enabled = true;
                timer2.Enabled = false;
                seconds = 0;
                minuts = 0;
                hours = 0;
            }
        }
        //#3 TIMER LUBRICACION, ACTIVA SEÑALES DE LUBRICACION Y CUENTA TIEMPO DE ACTIVACION
        private void timer3_Tick(object sender, EventArgs e)
        {
            //ENCIENDE BOMBA
            TurnCncFunctionTrue(InputFunction.Aux_Function_Select_1);
            radioButtonLSAactive.Checked = true;
            //CUENTA LOS SEGUNDOS
            seconds = seconds + 1;
            labelTime.Text = seconds.ToString();
            //TERMINA LA LUBRICACION AL TRANSCURRIR EL TIEMPO DEFINIDO PARA TRANS Y RIELES
            if (seconds >= LubricationActive)
            {
                EndTimerLubrication();
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
                MessageBox.Show(ex.Message, "No se actualizaron valores");
            }
        }
        #endregion
        #region //MONITOREO BW & SENSOR DE PRESION
        private void timer1_Tick(object sender, EventArgs e)
        {
            radioButtonVariable.Checked = CheckCncOutputState(OutputFunction.Aux_Function_Output_2);
        //    //MONITOREO BW
        //    if (CheckCncFunctionState(InputFunction.Torch_Collision))
        //    {
        //        if (BanderaBoxBW == false)
        //        {
        //            BanderaBoxBW = true;
        //            CustomMessageBox customMessageBox = new CustomMessageBox("Torch Collision, Revisa estado del Breakaway!", Color.Red);
        //            customMessageBox.ShowDialog();
        //            //Check the result after the form is closed
        //            if (customMessageBox.CustomDialogResult == DialogResult.OK)
        //            {
        //                BanderaBoxBW = false;
        //            }
        //        }
        //    }
        //    //MONITOREO SENSOR DE PRESION
        //    if (CheckCncFunctionState(InputFunction.Aux_Function_Select_8))
        //    {
        //        if (BanderaBoxPS == false)
        //        {
        //            if (BanderaBoxPS == false)
        //            {
        //                BanderaBoxPS = true;
        //                CustomMessageBox customMessageBox = new CustomMessageBox("Low Air Pressure\nProgram Inhibit Activado\n¡Revisa estado del Suministro!", Color.Red);
        //                customMessageBox.ShowDialog();
        //                //(InputFunction.Fast_Stop);
        //                TurnCncFunctionTrue(InputFunction.Program_Inhibit);
        //                //Check the result after the form is closed
        //                if (customMessageBox.CustomDialogResult == DialogResult.OK)
        //                {
        //                    BanderaBoxPS = false;
        //                }
        //            }
        //        }
        //    }
        //    else
        //    { TurnCncFunctionFalse(InputFunction.Program_Inhibit); }
        //    //MONITOREO PROGRAM RUNNING
        //    if (CheckCncFunctionState(InputFunction.Aux_Function_Select_9))
        //    {
        //        torch1Clamped();
        //        torch2Free();
        //        torch3Free();
        //        torch4Clamped();
        //        groupBox1.Enabled = false;

        //    }
        //    else if (!CheckCncFunctionState(InputFunction.Aux_Function_Select_9))
        //    {
        //        groupBox1.Enabled = true;
        //    }
        //    //PROGRAM INHIBIT - MOVE
        //    radioButtonOkToMove.Checked = !CheckCncFunctionState(InputFunction.Program_Inhibit);

        //    //ERROR
        //    radioButtonError.Checked = CheckCncFunctionState(InputFunction.Aux_Function_Select_1);

        //    //APAGAR OXICORTE SI SE ACTIVA UN ERROR
        //    if (AppRunningAck && CheckCncFunctionState(InputFunction.Aux_Function_Select_1))
        //    {
        //        TurnOffOxyfuel();
        //    }

        //    //SI SE ACTIVA LA ESTACION Y CUT CONTROL SE ACTIVA PROGRAM INHIBIT PARA PAUSAR EL PROGRAMA DURANTE LA PERFORACION 
        //    else if (!ProgramInihibitAck && CheckCncFunctionState(InputFunction.Aux_Function_Select_5) && CheckCncFunctionState(InputFunction.Manual_Select_2))
        //    {
        //        TurnCncFunctionTrue(InputFunction.Program_Inhibit);
        //        ProgramInihibitAck = true;
        //        TextBoxSystem.Text = "FIT+3 PERFORANDO";
        //        pictureTorch.BackColor = Color.Yellow;
        //    }

        //    //SI SE ACTIVA EL OXICORTE Y LA SENAL DE OK TO MOVE, SE ACTIVA MOVIMIENTO
        //    else if (CheckCncFunctionState(InputFunction.Aux_Function_Select_2) && CheckCncFunctionState(InputFunction.Manual_Select_2))
        //    {
        //        TurnCncFunctionFalse(InputFunction.Program_Inhibit);
        //        TextBoxSystem.Text = "FIT+3 CORTANDO";
        //        if (pictureTorch.BackColor != Color.Lime)
        //        {
        //            pictureTorch.BackColor = Color.Lime;
        //        }
        //        else
        //        {
        //            pictureTorch.BackColor = SystemColors.InactiveBorder;
        //        }
        //    }

        //    //SI SE ACTIVÓ UNA PERFORACION Y SE DESACTIVA CUT CONTROL SE TERMINA CORTE
        //    else if (ProgramInihibitAck && !CheckCncFunctionState(InputFunction.Aux_Function_Select_5))
        //    {
        //        TurnCncFunctionFalse(InputFunction.Program_Inhibit);
        //        ProgramInihibitAck = false;
        //        TextBoxSystem.Text = "FIT+3 CORTE FINALIZADO";
        //        pictureTorch.BackColor = Color.Lime;
        //    }
        }
    }
        #endregion
}