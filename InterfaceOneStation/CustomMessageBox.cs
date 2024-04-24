using InternalComms;
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
    public partial class CustomMessageBox : Form
    {
        public DialogResult CustomDialogResult { get; private set; }
        public CustomMessageBox()
        {
            InitializeComponent();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            CustomDialogResult = DialogResult.OK;
            this.Close();
        }
        public void set_color_texto(string message, Color color)
        {
            richTextBox1.Text = message;
            richTextBox1.BackColor = color;
            pictureBox1.BackColor = color;
            buttonOK.BackColor = color;
            groupBox1.BackColor= color;
        }
        public void set_texto(string datos) {
            richTextBox1.Text = datos;
         }
    }
}
