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
        private Pregunta item;
        
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

        public void Actualizar_pregunta(int nivel)
        {
            lista question = new lista();
            item = question.ObtenerPregunta(nivel);
            label3.Text = item.PreguntaTexto;
            radioButton1.Text = item.respuesta1;
            radioButton2.Text = item.respuesta2;
            radioButton3.Text = item.respuesta3;
            label4.Text = item.explicacion;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int respuesta = Obtener_respuesta();
            if (respuesta == item.correcto)
            {
                button2.Visible = true;
                button1.Visible = false;
                string text = "Correcto!";
                MessageBox.Show(text);
            }
            else
            {
                label2.Visible = true;
                label4.Visible = true;
                button2.Visible = true;
                button1.Visible = false;
                string text = "Eso no es correcto. Porfavor revisa la explicacion!";
                MessageBox.Show(text,"Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private int Obtener_respuesta()
        {
            int response;
            if (radioButton1.Checked)
            {
                response = 1;
            }
            else if (radioButton2.Checked)
            {
                response = 2;
            }
            else if (radioButton3.Checked)
            {
                response = 3;
            }
            else
            {
                response = 0;
            }
            return response;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pregunta ventana = new Pregunta();
            ventana.Actualizar_pregunta(1);
            ventana.Show();
        }
    }
}
