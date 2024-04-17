using InterfaceOneStation.Acciones.ConexionPhoenix;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;


namespace InterfaceOneStation
{
    public partial class Lubricacion : Form
    {
        ConexionPhoenix conexionPhoenix;
        CustomMessageBox customMessageBox = new CustomMessageBox();
        XDocument xmlDocument=new XDocument();
        private string filePath;
        private int seconds;
        private int LubricationActive;
        private int LubricationInterval;
        private int tiempolubricacion;
        private bool BanderaBoxLS;
        private bool LubricationSystemEnable;
        public Lubricacion(ConexionPhoenix conexionPhoenix)
        {
            this.conexionPhoenix = conexionPhoenix;
            seconds = 0;
            LubricationActive = 0;
            InitializeComponent();
            InicializeAppConfigFile();
            UpdateValues();
            CheckLubricationSystem();

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

            checkBox1.Visible = true;
            checkBox2.Visible = true;
        }
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
                    customMessageBox.set_color_texto("Please select a valid item from the Interval list.", Color.Yellow);
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
            lubricacionTime.Text = "Tiempo Ciclo";
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
            conexionPhoenix.TurnCncFunctionTrue(InputFunction.Aux_Function_Select_1);
            timer4.Enabled = true;
            lubricacionTime.Text = "Tiempo de lubricacion";
            LubricationActive = (comboBoxLubricationActive.SelectedIndex + 1) * 5;
            radioButtonLSAactive.Checked = true;

            customMessageBox.set_color_texto(seconds.ToString(), Color.Gray);
            customMessageBox.ShowDialog();
        }
        private void EnableButtons()
        {
            checkBoxEnableLubrication.Enabled = true;
            comboBoxLubricationInterval.Enabled = true;
            comboBoxLubricationActive.Enabled = true;
            buttonSave.Enabled = true;
            button3.Enabled = true;
            checkBoxEnableLubrication.Enabled = true;
        }
        private void DisableControls()
        {
            checkBoxEnableLubrication.Enabled = false;
            comboBoxLubricationInterval.Enabled = false;
            comboBoxLubricationActive.Enabled = false;
            buttonSave.Enabled = false;
            button3.Enabled = false;
            checkBoxEnableLubrication.Enabled = false;
        }
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
        private void EndTimerLubrication()
        {
            timer3.Enabled = false;
            //APAGA BOMBA
            conexionPhoenix.TurnCncFunctionFalse(InputFunction.Aux_Function_Select_1);
            radioButtonLSAactive.Checked = false;
            seconds = 0;
            BanderaBoxLS = false;
            UpdateValues();
            CheckLubricationSystem();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                conexionPhoenix.TurnCncFunctionTrue(InputFunction.Aux_Function_Select_9);
           else
                conexionPhoenix.TurnCncFunctionFalse(InputFunction.Aux_Function_Select_9);
        }
        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                conexionPhoenix.TurnCncFunctionTrue(InputFunction.Aux_Function_Select_8);
            else
                conexionPhoenix.TurnCncFunctionFalse(InputFunction.Aux_Function_Select_8);
        }
        //#2 TIMER INTERVALO, CUENTA TIEMPO DE INTERVALO Y LUEGO INICIALIZA TIMER DE LUBRICACION
        private void timer2_Tick(object sender, EventArgs e)
        {
            seconds++;

            labelTime.Text = TimeSpan.FromSeconds(seconds).ToString();
            if (seconds == LubricationInterval * 3600)
            {
                timer3.Enabled = true;
                timer2.Enabled = false;
                seconds = 0;
                lubricacionTime.Text = "Tiempo lubri";
            }
        }
        //#3 TIMER LUBRICACION, ACTIVA SEÑALES DE LUBRICACION Y CUENTA TIEMPO DE ACTIVACION
        private void timer3_Tick(object sender, EventArgs e)
        {
            //ENCIENDE BOMBA
            conexionPhoenix.TurnCncFunctionTrue(InputFunction.Aux_Function_Select_1);
            radioButtonLSAactive.Checked = true;
            //CUENTA LOS SEGUNDOS
            seconds++;
            tiempolubricacion++;
            labelTime.Text = TimeSpan.FromSeconds(seconds).ToString();
            //TERMINA LA LUBRICACION AL TRANSCURRIR EL TIEMPO DEFINIDO PARA TRANS Y RIELES
            if (seconds >= LubricationActive)
            {
                lubricacionTime.Text = "Tiempo ciclo";
                EndTimerLubrication();
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            //ENCIENDE BOMBA

            //CUENTA LOS SEGUNDOS

            seconds++;
            tiempolubricacion++;
            customMessageBox.set_texto("Prueba de Lubricasion lleva "+(seconds).ToString()+" segundos trascurridos");
            labelTime.Text = TimeSpan.FromSeconds(seconds).ToString();
            //TERMINA LA LUBRICACION AL TRANSCURRIR EL TIEMPO DEFINIDO PARA TRANS Y RIELES
            if (seconds >= LubricationActive)
            {
                LubricationActive = 0;
                timer4.Enabled = false;
                seconds = 0;
                conexionPhoenix.TurnCncFunctionFalse(InputFunction.Aux_Function_Select_1);
                radioButtonLSAactive.Checked = false;
                EnableButtons();
                labelTime.Text = "";
               
            }
        }
        public int getTimepoLubricacion()
        {
            return tiempolubricacion;
        }

        
    }
}
