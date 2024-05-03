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
using System.Threading;

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
        //VARIABLES SISTEMA DE LUBRICACION
        public int LubricationActive;
        public int LubricationActiveRails;
        private int tiempoFuncionamiento;
        private int tiempoOperacion;
        private int timepoCorte; 
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
                                { 1,  3, -1, -1, 13},
                                { 0,  2,  4, -1, 10},
                                { 3,  1,  6, -1, 11},
                                { 2,  0,  9, -1, 12},
                                { 0, -1,  1,  5, 10},
                                { 0, -1,  1, -1, 10},
                                { 9,  4,  2,  8, 11},
                                {-1,  0,  3, -1, 12},
                                { 7,  5,  2, -1, 11},
                                {-1,  0,  3,  7, 12},
                                {13, 11, -1, -1,  1},
                                {12, 10, -1, -1,  2},
                                {11, 13, -1, -1,  3},
                                {10, 12, -1, -1,  0},
                            };
            Dictionary < string, dynamic> datos=var.datos;
            //APP SETUP
            InitializeComponent();
          
            //PHOENIX COM SETUP
            SistemaCorte = obj.SistemaCorte;
            //LUBRICATION CONTROL SYSTEM
            BanderaBoxLS = false;  
            //MONITOREO
            timer2.Interval = 500;
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Enabled = true;
            BanderaBoxBW = false;
            BanderaBoxPS = false;

            //LLAMADA DEL FORM TRANCERSE Y COLOCASION DENTRO DEL GROUPBOX2
            tranverse = new Tranverse(obj);
            tranverse.Size = groupBox2.Size;
            tranverse.TopLevel = false;
            tranverse.Dock = DockStyle.Fill;
            groupBox2.Controls.Add(tranverse);
            tranverse.Show();
            
            //LLAMADA DEL FROM LUBRICACION Y COLOCACION DEL ELEMENTOS tabPage5
            lubri = new Lubricacion(obj);
            lubri.Dock = DockStyle.Fill; // Opcional: ajusta el tamaño del formulario secundario al tamaño del TabPage
            lubri.Size = tabPage5.Size;
            lubri.TopLevel = false;
            tabPage5.Controls.Add(lubri);
            lubri.Show();
        }
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
        
        /*FUNCION ENFOCADA EN PODER CAMBIAR ENTRE LOS DISTINTOS ESTADOS QUE PUEDE TEBER EL SISTEMA, DESDE ENCENDIO, APARAGDO
          ERROR, MOVILIDAD, PERFORRACION Y CORTE. ESTO MEDIANTE LA MATRIZ DE ESTADOS QUE INDICA A CUAL SE TIENE QUE DESPLAZAR.
         */
        private void EstadoSistema(int posicion)
        {
            if (matriz[pos, posicion] != -1)//Siempre que la pocicion  octenida de la matis desa diferente a -1 este cambiara la pocision del estado
                pos = matriz[pos, posicion];
            label1.Text = "E "+(pos).ToString() + "," + posicion.ToString();//muestra en una label el esto actual en donde se encuntra la matriz
            switch (pos)
            {
                //Opcion para apagado de las 2 antorchas
                case 0:
                    if(posicion==4)
                    {
                        DesactivarTorch1();
                        DesactivarTorch2();
                        obj.TurnCncFunctionFalse(InputFunction.Front_Panel_Stop);
                    }
                    else if (posicion == 0)
                    {
                        DesactivarTorch1();
                    }
                    else
                        DesactivarTorch2();
                    if (obj.CheckCncOutputState(OutputFunction.Cut_Control) || obj.CheckCncFunctionState(InputFunction.Program_Inhibit))
                    {
                        obj.TurnCncFunctionTrue(InputFunction.Front_Panel_Stop);
                        Thread.Sleep(1000);
                        obj.TurnCncFunctionFalse(InputFunction.Front_Panel_Stop);                    
                    }
                    if (obj.CheckCncFunctionState(InputFunction.Aux_Function_Select_9))
                    {
                        obj.TurnCncFunctionFalse(InputFunction.Front_Panel_Stop);
                        //EstadoError = true;
                    }
                    if (obj.CheckCncFunctionState(InputFunction.Program_Inhibit))
                        obj.TurnCncFunctionFalse(InputFunction.Program_Inhibit);
                    TextBoxSystem.Text = "FIT+3 DEHABILITADA";
                    break;
                //Opcion para el encendio de la antorcha 1 y apagado de la antorcha 2
                case 1:
                    if (posicion == 0 || posicion == 2 || posicion == 4)
                    {
                        EncedidoTorch1();
                        if (obj.CheckCncFunctionState(InputFunction.Front_Panel_Stop))
                            obj.TurnCncFunctionFalse(InputFunction.Front_Panel_Stop);
                    }
                    else
                        DesactivarTorch2();
                    TextBoxSystem.Text = "FIT+3 ST1 HABILITADA";
                    break;
                //Opcion para el encendio de las dos antorchas
                case 2:
                    if (posicion == 2 || posicion==4)
                    {
                        EncedidoTorch1();
                        EncendidoTorch2();
                    }
                    else if (posicion == 0)
                    {
                        EncedidoTorch1();
                        if (obj.CheckCncFunctionState(InputFunction.Front_Panel_Stop))
                            obj.TurnCncFunctionFalse(InputFunction.Front_Panel_Stop);
                    }
                    else
                        EncendidoTorch2();
                    TextBoxSystem.Text = "FIT+3 HABILITADA";
                    break;
                //Opcion para el encendio de la antorcha 2 y el apagado de la antorhca 1
                case 3:
                    if (posicion == 1 || posicion == 2 || posicion == 4)
                        EncendidoTorch2();
                    else
                        DesactivarTorch1();
                    TextBoxSystem.Text = "FIT+3 ST2 HABILITADA";
                    break;
                //Opcion para iniciar la perforacion cunado solo este iniciada la antorcha 1
                case 4:
                    if(posicion==1)
                        DesactivarTorch2();
                    PerforacionTorch1();
                    TextBoxSystem.Text = "FIT+3 ST1 PERFORANDO";
                    break;
                //Opcion para iniciar el corte de la antocha 1
                case 5:
                    if (posicion == 1)
                        DesactivarTorch2();
                    CorteTorch1();
                    TextBoxSystem.Text = "FIT+3 ST1 CORTANDO";
                    break;
                //Opcion para iniciar la perforacion de las dos antorchas
                case 6:
                    PerforacionTorch1();
                    PerforracionTorch2();
                    TextBoxSystem.Text = "FIT+3 PERFORANDO";
                    break;
                //Opcion para iniciar el corte de la antorcha 1
                case 7:
                    if (posicion == 0)
                        DesactivarTorch1();
                    CorteTorch2();
                    TextBoxSystem.Text = "FIT+3 ST2 CORTANDO";
                    break;
                //Opcion para iniciar el corte de las 2 antorchas
                case 8:
                    CorteTorch1();
                    CorteTorch2();
                    TextBoxSystem.Text = "FIT+3 CORTANDO";
                    break;
                //Opcion para iniciar la perforacion de la antorcha 2
                case 9:
                    if (posicion == 0)
                        DesactivarTorch1();
                    PerforracionTorch2();
                    TextBoxSystem.Text = "FIT+3 ST2 PERORANDO";
                    break;
                //Opcion de error que se actuiva cunado el errro es detectado, y indica que hay un problema cambiando la antorcha 1 a color rojo
                case 10:
                    if(posicion==0 || posicion==4)
                        errorTorch1();
                    if (posicion == 1)
                        DesactivarTorch2();
                    TextBoxSystem.Text = "FIT+3 ST1 ERROR";
                    break;
                //Opcion de error que se actuiva cunado el errro es detectado, y indica que hay un problema cambiando las 2 antorcha a color rojo
                case 11:
                    if (posicion == 4)
                    {
                        errorTorch1();
                        errorTorch2();
                    }
                    if (posicion == 0)
                        errorTorch1();
                    if(posicion==1)
                        errorTorch2();
                    TextBoxSystem.Text = "FIT+3 ERROR";
                    break;
                //Opcion de error que se actuiva cunado el errro es detectado, y indica que hay un problema cambiando la antorcha 2 a color rojo
                case 12:
                    if (posicion == 1 || posicion==4)
                        errorTorch2();
                    if (posicion == 0)
                        DesactivarTorch1();
                    TextBoxSystem.Text = "FIT+3 ST2 ERROR";
                    break;
                case 13:
                    if (posicion == 0)
                        DesactivarTorch1();
                    if (posicion == 1)
                        DesactivarTorch2();
                    break;
            }
        }
        //Metodo encargado de desabilitar en manuel select 3 y cambia de color a la antorcha  1 a color rojo
        private void errorTorch1()
        {
            obj.TurnCncFunctionTrue(InputFunction.Manual_Select_3);
            pictureTorch.BackColor = Color.Red;
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        //Metodo encargado de desabilitar en manuel select 4 y cambia de color a la antorcha  2 a color rojo
        private void errorTorch2()
        {
            obj.TurnCncFunctionTrue(InputFunction.Manual_Select_4);
            pictureTorch2.BackColor = Color.Red;
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        //Metodo que cambia a la antorcha 1 a color azul(indica que esta cortando con el oxicorte) cuando la perforacion ha terminado
        private void CorteTorch1()
        {
            pictureTorch.BackColor = Color.Blue;
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        //Metodo que cambia a la antorcha 2 a color azul(indica que esta cortando con el oxicorte) cuando la perforacion ha terminado

        private void CorteTorch2()
        {
            pictureTorch2.BackColor = Color.Blue;
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        //Metodo que 
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
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        private void EncendidoTorch2()
        {
            obj.TurnCncFunctionTrue(InputFunction.Manual_Select_4);
            pictureTorch2.BackColor = Color.Lime;
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        private void DesactivarTorch1()
        {
            obj.TurnCncFunctionFalse(InputFunction.Manual_Select_3);
            pictureTorch.BackColor = SystemColors.InactiveBorder;
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        private void DesactivarTorch2()
        {
            obj.TurnCncFunctionFalse(InputFunction.Manual_Select_4);
            pictureTorch2.BackColor = SystemColors.InactiveBorder;
            TextBoxSystem.BackColor = SystemColors.InactiveBorder;
        }
        //FUNCION QUE OCTIENE LOS TIMEPO DE ENCENDIDO, MOVIMIENTO Y LUBRICASION.
        private void Funcionamiento_Tick(object sender, EventArgs e)
        {
            tiempoFuncionamiento++;
            if (obj.CheckCncOutputState(OutputFunction.Motion_Output))
            {
                tiempoOperacion++;
            }
            if(obj.CheckCncOutputState(OutputFunction.Cut_Control))
            {
                timepoCorte++;
            }
            Etiqueta1Funcionamiento.Text = TimeSpan.FromSeconds(tiempoFuncionamiento).ToString();
            EtiquetaMovimiento.Text = TimeSpan.FromSeconds(tiempoOperacion).ToString();
            EtiquetaLubricacion.Text = TimeSpan.FromSeconds(lubri.getTimepoLubricacion()).ToString();//Octiene el tiempo de lubricacion desde el form de lubricasion
            EtiquetaCorte.Text = TimeSpan.FromSeconds(timepoCorte).ToString();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                //MONITOREO BW
                if (obj.CheckCncFunctionState(InputFunction.Torch_Collision))
                {
                    if (BanderaBoxBW == false && !BanderaBoxPS)
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
                if (obj.CheckCncFunctionState(InputFunction.Aux_Function_Select_6))
                {
                    if (BanderaBoxPS == false && !BanderaBoxBW)
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
                if (obj.CheckCncOutputState(OutputFunction.Program_Running))
                {
                    tranverse.ProgramanRuning();
                    groupBox2.Enabled = false;
                }
                else
                {
                    groupBox2.Enabled = true;
                }
                //PROGRAM INHIBIT - MOVE
                radioButtonOkToMove.Checked = !obj.CheckCncFunctionState(InputFunction.Program_Inhibit);
                //ERROR
                radioButtonError.Checked = obj.CheckCncFunctionState(InputFunction.Aux_Function_Select_9);
                

                if (obj.CheckCncFunctionState(InputFunction.Aux_Function_Select_9))
                {
                    if (obj.CheckCncOutputState(OutputFunction.Cut_Control))
                    {
                        obj.TurnCncFunctionTrue(InputFunction.Front_Panel_Stop);
                        customMessageBox.set_color_texto("Existe un error, no puedes activar corte", Color.Red);
                        customMessageBox.ShowDialog();
                        obj.TurnCncFunctionFalse(InputFunction.Front_Panel_Stop);
                    }
                    if(EstadoError)
                    {
                        EstadoError = false;
                        if (obj.CheckCncFunctionState(InputFunction.Program_Inhibit))
                            obj.TurnCncFunctionFalse(InputFunction.Program_Inhibit);
                        obj.TurnCncFunctionTrue(InputFunction.Front_Panel_Stop);
                        EstadoSistema(4);
                        customMessageBox.set_color_texto("Acaba de ocurrir un error", Color.Red);
                        customMessageBox.ShowDialog();
                        obj.TurnCncFunctionFalse(InputFunction.Front_Panel_Stop);
                    }
                }
                else if (!obj.CheckCncFunctionState(InputFunction.Aux_Function_Select_9) && !EstadoError)
                {
                    //obj.TurnCncFunctionFalse(InputFunction.Front_Panel_Stop);
                    EstadoError = true;
                    EstadoSistema(4);
                    customMessageBox.set_color_texto("Error Solucionado", Color.Lime);
                    customMessageBox.ShowDialog();
                }
                if (obj.CheckCncFunctionState(InputFunction.Aux_Function_Select_8))
                {
                    obj.TurnCncFunctionFalse(InputFunction.Program_Inhibit);
                    EstadoSistema(3);
                }
                if (obj.CheckCncOutputState(OutputFunction.Cut_Control) && EstadoCorte)
                {
                    obj.TurnCncFunctionTrue(InputFunction.Program_Inhibit);
                    EstadoSistema(2);
                    EstadoCorte = false;
                } else if (!obj.CheckCncOutputState(OutputFunction.Cut_Control) && !EstadoCorte)
                {
                    if (obj.CheckCncFunctionState(InputFunction.Program_Inhibit))
                        obj.TurnCncFunctionFalse(InputFunction.Program_Inhibit);
                    EstadoSistema(2);
                    EstadoCorte = true;
                }
            }
            catch(Exception ex)
            {
               // customMessageBox.set_color_texto(ex.ToString(), Color.Red);
                //customMessageBox.ShowDialog();
            }
           }
    }
}