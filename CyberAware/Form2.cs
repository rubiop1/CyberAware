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
    public partial class Pregunta : Form
    {
        public Pregunta()
        {
            InitializeComponent();
        }

        public void Actualizar_pregunta(String pregunta, String opt1, String Opt2, String opt3, String explicacion)
        {
            label3.Text = pregunta;
            radioButton1.Text = opt1;
            radioButton2.Text = Opt2;
            radioButton3.Text = opt3;
            label4.Text = explicacion;
        }

        public void Actualizar_pregunta(Pregunta pregunta)
        {
            label3.Text = pregunta.PreguntaTexto;
            radioButton1.Text = pregunta.respuesta1;
            radioButton2.Text = pregunta.respuesta2;
            radioButton3.Text = pregunta.respuesta3;
            label4.Text = pregunta.explicacion;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
