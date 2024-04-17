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

namespace InterfaceOneStation
{
    public partial class Tranverse : Form
    {
        ConexionPhoenix sistemaCorte;
        public Tranverse(ConexionPhoenix obj)
        {
            sistemaCorte = obj;
            InitializeComponent();
        }
        private void pictureBoxClamp1_Click(object sender, EventArgs e)
        {

            pictureBoxUnclamp1.Visible = true;
            pictureBoxClamp1.Visible = false;
            labelMaster1Clamp.Text = "Unclamped";
            sistemaCorte.TurnCncFunctionTrue(InputFunction.Aux_Function_Select_2);
        }
        private void pictureBoxUnclamp1_Click(object sender, EventArgs e)
        {
            pictureBoxUnclamp1.Visible = false;
            pictureBoxClamp1.Visible = true;
            labelMaster1Clamp.Text = "Clamped";
            sistemaCorte.TurnCncFunctionFalse(InputFunction.Aux_Function_Select_2);

        }
        private void pictureBoxMove_Click(object sender, EventArgs e)
        {
            pictureBoxAncla1.Visible = true;
            pictureBoxMove1.Visible = false;
            labelMaster1.Text = "Parked";
            sistemaCorte.TurnCncFunctionTrue(InputFunction.Aux_Function_Select_4);
        }
        private void pictureBoxAncla_Click(object sender, EventArgs e)
        {
            pictureBoxAncla1.Visible = false;
            pictureBoxMove1.Visible = true;
            labelMaster1.Text = "Free";
            sistemaCorte.TurnCncFunctionFalse(InputFunction.Aux_Function_Select_4);

        }
        private void pictureBoxAncla2_Click(object sender, EventArgs e)
        {
            sistemaCorte.TurnCncFunctionFalse(InputFunction.Aux_Function_Select_5);
            pictureBoxAncla2.Visible = false;
            pictureBoxMove2.Visible = true;
            labelMaster2.Text = "Free";
        }
        private void pictureBoxMove2_Click(object sender, EventArgs e)
        {
            sistemaCorte.TurnCncFunctionTrue(InputFunction.Aux_Function_Select_5);
            pictureBoxAncla2.Visible = true;
            pictureBoxMove2.Visible = false;
            labelMaster2.Text = "Parked";
        }
        private void pictureBoxUnclamp2_Click(object sender, EventArgs e)
        {
            pictureBoxClamp2.Visible = true;
            pictureBoxUnclamp2.Visible = false;
            labelMaster2Clamp.Text = "Clamped";
            sistemaCorte.TurnCncFunctionFalse(InputFunction.Aux_Function_Select_3);
        }

        private void pictureBoxClamp2_Click(object sender, EventArgs e)
        {
            pictureBoxClamp2.Visible = false;
            pictureBoxUnclamp2.Visible = true;
            labelMaster2Clamp.Text = "Unclamped";
            sistemaCorte.TurnCncFunctionTrue(InputFunction.Aux_Function_Select_3);
        }

        public void ProgramanRuning()
        {
            pictureBoxUnclamp1.Visible = false;
            pictureBoxClamp1.Visible = true;
            labelMaster1Clamp.Text = "Clamped";
            sistemaCorte.TurnCncFunctionFalse(InputFunction.Aux_Function_Select_2);

            pictureBoxAncla1.Visible = false;
            pictureBoxMove1.Visible = true;
            labelMaster1.Text = "Free";
            sistemaCorte.TurnCncFunctionFalse(InputFunction.Aux_Function_Select_4);

            sistemaCorte.TurnCncFunctionFalse(InputFunction.Aux_Function_Select_5);
            pictureBoxAncla2.Visible = false;
            pictureBoxMove2.Visible = true;
            labelMaster2.Text = "Free";

            pictureBoxClamp2.Visible = true;
            pictureBoxUnclamp2.Visible = false;
            labelMaster2Clamp.Text = "Clamped";
            sistemaCorte.TurnCncFunctionFalse(InputFunction.Aux_Function_Select_3);

        }

        
    }


}
