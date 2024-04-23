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
        private bool activacionBotones;
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
        private int[,] matriz;
        private int pos;
        private bool EstadoCorte=true;
        private bool EstadoError=true;
        public MainForm()
        {
            pos = 0;
            matriz = new int[,]
                           {
                                { 1,  3, -1, -1, -1},
                                { 0,  2,  4, -1, 10},
                                { 3,  1,  6, -1, 11},
                                { 2,  0,  9, -1, 12},
                                { 0, -1,  1,  5, 10},
                                { 0, -1,  1, -1, 10},
                                { 9,  4,  2,  8, 11},
                                {-1,  0,  3, -1, 12},
                                { 7,  5,  2, -1, 11},
                                {-1,  0,  3,  7, 12},
                                {0, -1, -1, -1,  1},
                                {12, 10, -1, -1,  2},
                                {-1, 0, -1, -1,  3},
                            };
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

            timer2.Interval = 500;
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Enabled = true;

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
            EstadoSistema(0); 
        }
        //BOTON ANTORCHA2
        private void pictureTorch2_Click(object sender, EventArgs e)
        {
            EstadoSistema(1);
        }
        #endregion
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

        private void EstadoSistema(int posicion)
        {

            if (matriz[pos, posicion] != -1)
                pos = matriz[pos, posicion];
            label1.Text = (pos).ToString() + " " + posicion.ToString();
            switch (pos)
            {
                case 0:
                    if(posicion==4)
                    {
                        DesactivarTorch1();
                        DesactivarTorch2();
                    }
                    else if (posicion == 0)
                    {
                        DesactivarTorch1();
                    }
                    else
                        DesactivarTorch2();
                    if (CheckCncOutputState(OutputFunction.Cut_Control))
                        obj.TurnCncFunctionTrue(InputFunction.Front_Panel_Stop);

                    if (CheckCncFunctionState(InputFunction.Aux_Function_Select_9))
                    {
                        obj.TurnCncFunctionFalse(InputFunction.Aux_Function_Select_9);
                        EstadoError = true;
                    }
                    break;
                case 1:

                    if (posicion == 0 || posicion == 2 || posicion==4)
                    {
                        EncedidoTorch1();
                        if(CheckCncFunctionState(InputFunction.Front_Panel_Stop))
                            obj.TurnCncFunctionFalse(InputFunction.Front_Panel_Stop);
                    }
                    else
                        DesactivarTorch2();
                    break;
                case 2:
                    if (posicion == 2 || posicion==4)
                    {
                        EncedidoTorch1();
                        EncendidoTorch2();
                    }
                    else if (posicion == 0)
                    {
                        EncedidoTorch1();
                        if (CheckCncFunctionState(InputFunction.Front_Panel_Stop))
                            obj.TurnCncFunctionFalse(InputFunction.Front_Panel_Stop);
                    }

                    else
                        EncendidoTorch2();
                    break;
                case 3:
                    if (posicion == 0 || posicion == 2 || posicion == 4)
                        DesactivarTorch1();
                    else
                        EncendidoTorch2();
                    break;
                case 4:
                    if(posicion==1)
                        DesactivarTorch2();
                    PerforacionTorch1();
                    TextBoxSystem.Text = "FIT+3 ST1 PERFORANDO";
                    break;
                case 5:
                    if (posicion == 1)
                        DesactivarTorch2();
                    CorteTorch1();
                    TextBoxSystem.Text = "FIT+3 ST1 CORTANDO";
                    break;
                case 6:
                    PerforacionTorch1();
                    PerforracionTorch2();
                    TextBoxSystem.Text = "FIT+3 PERFORANDO";
                    break;
                case 7:
                    if (posicion == 0)
                        DesactivarTorch1();
                    CorteTorch2();
                    TextBoxSystem.Text = "FIT+3 ST2 CORTANDO";
                    break;
                case 8:
                    CorteTorch1();
                    CorteTorch2();
                    TextBoxSystem.Text = "FIT+3 CORTANDO";
                    break;
                case 9:
                    if (posicion == 0)
                        DesactivarTorch1();
                    PerforracionTorch2();
                    TextBoxSystem.Text = "FIT+3 ST2 HABILITADA";
                    break;
                case 10:
                    if (posicion == 1)
                        DesactivarTorch2();
                    errorTorch1();
                    TextBoxSystem.Text = "FIT+3 ST1 ERROR";
                    break;
                case 11:
                    errorTorch1();
                    errorTorch2();
                    TextBoxSystem.Text = "FIT+3 ERROR";
                    break;
                case 12:
                    if (posicion == 0)
                        DesactivarTorch1();
                    errorTorch2();
                    TextBoxSystem.Text = "FIT+3 ST2 ERROR";
                    break;
                case 13:
                    errorTorch1();
                    errorTorch2();
                    break;

            }
        }
        private void errorTorch1()
        {
            obj.TurnCncFunctionFalse(InputFunction.Manual_Select_3);
            pictureTorch.BackColor = Color.Red;
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        private void errorTorch2()
        {
            obj.TurnCncFunctionFalse(InputFunction.Manual_Select_4);
            pictureTorch2.BackColor = Color.Red;
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        private void CorteTorch1()
        {
            pictureTorch.BackColor = Color.Blue;
            TextBoxSystem.Text = "FIT+3 ST1 Cortando";
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        private void CorteTorch2()
        {
            pictureTorch2.BackColor = Color.Blue;
            TextBoxSystem.Text = "FIT+3 ST2 Cortando";
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        private void PerforacionTorch1()
        {
            pictureTorch.BackColor = Color.Yellow;
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        private void PerforracionTorch2()
        {
            pictureTorch2.BackColor = Color.Yellow;
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        private void EncedidoTorch1()
        {
            obj.TurnCncFunctionTrue(InputFunction.Manual_Select_3);
            pictureTorch.BackColor = Color.Lime;
            TextBoxSystem.Text = "FIT+3 ST1 HABILITADA";
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        private void EncendidoTorch2()
        {
            obj.TurnCncFunctionTrue(InputFunction.Manual_Select_4);
            pictureTorch2.BackColor = Color.Lime;
            TextBoxSystem.Text = "FIT+3 ST2 HABILITADA";
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        private void DesactivarTorch1()
        {
            obj.TurnCncFunctionFalse(InputFunction.Manual_Select_3);
            pictureTorch.BackColor = SystemColors.InactiveBorder;
            TextBoxSystem.Text = "FIT+3 ST2 DESAHABILITADA";
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        private void DesactivarTorch2()
        {
            obj.TurnCncFunctionFalse(InputFunction.Manual_Select_4);
            pictureTorch2.BackColor = SystemColors.InactiveBorder;
            TextBoxSystem.Text = "FIT+3 ST2 DESAHABILITADA";
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
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
            else
            {
                groupBox2.Enabled = true;
            }
            //PROGRAM INHIBIT - MOVE
            radioButtonOkToMove.Checked = !CheckCncFunctionState(InputFunction.Program_Inhibit);
            //ERROR
            radioButtonError.Checked = CheckCncFunctionState(InputFunction.Aux_Function_Select_9);

            if (CheckCncFunctionState(InputFunction.Aux_Function_Select_9) && EstadoError)
            {
                obj.TurnCncFunctionTrue(InputFunction.Front_Panel_Stop);
                EstadoSistema(4);
                EstadoError = false;
            }
            else if (!CheckCncFunctionState(InputFunction.Aux_Function_Select_9) && !EstadoError)
            {
                obj.TurnCncFunctionFalse(InputFunction.Front_Panel_Stop);
                EstadoSistema(4);
                EstadoError = true;
            }
            if (CheckCncOutputState(OutputFunction.Aux_Function_Output_8))
            { 
                obj.TurnCncFunctionFalse(InputFunction.Program_Inhibit);
                EstadoSistema(3);
            }
            if (CheckCncOutputState(OutputFunction.Cut_Control )&& EstadoCorte)
            {
                obj.TurnCncFunctionTrue(InputFunction.Program_Inhibit);
                EstadoSistema(2);
                EstadoCorte = false;
            }else if(!CheckCncOutputState(OutputFunction.Cut_Control) && !EstadoCorte)
            {
                EstadoSistema(2);
                EstadoCorte = true;
            }


        }
    }
}