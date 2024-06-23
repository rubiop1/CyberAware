using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberAware
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                string text = "Please enter your name to begin!";
                MessageBox.Show(text);
            }
            else {
                Bienvenida.ActiveForm.Hide();
                Pregunta ventana = new Pregunta();
                //ventana.Actualizar_pregunta("Pregunta...", "opt1", "Opt2", "opt3", "explicacion");
                ventana.Actualizar_pregunta(1);
                ventana.Show();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
