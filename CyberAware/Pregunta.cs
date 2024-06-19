using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberAware
{
    public partial class Pregunta
    {
        public string PreguntaTexto;
        public string respuesta1;
        public string respuesta2;
        public string respuesta3;
        public string explicacion;
        public int correcto;
        public int nivel;

        public Pregunta(string q1, string r1, string r2, string r3, string exp, int right, int level)
        {
            PreguntaTexto = q1;
            respuesta1 = r1;
            respuesta2 = r2;
            respuesta3 = r3;
            explicacion = exp;
            correcto = right;
            nivel = level;
        }
    }
}    
