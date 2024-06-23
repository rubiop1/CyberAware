using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CyberAware
{
    internal class lista
    {
        private static Pregunta p1 = new Pregunta("**Recibes un correo electrónico de tu banco pidiéndote que actualices tu información de seguridad haciendo clic en un enlace. ¿Qué deberías hacer ? **", "Hacer clic en el enlace y actualizar la información", "Ignorar el correo electrónico", "Llamar al banco utilizando un número de contacto oficial para confirmar la solicitud", "*Llamar al banco utilizando un número de contacto oficial para confirmar la solicitud*. Los correos electrónicos pueden ser intentos de phishing. Confirmar directamente con el banco evita caer en fraudes.", 3, 1);
        private static Pregunta p2 = new Pregunta("**Mientras navegas por internet, ves una oferta que parece demasiado buena para ser verdad en un sitio web que no conoces. ¿Qué deberías hacer?**", "Proporcionar tu información personal para aprovechar la oferta", "Ignorar la oferta y cerrar el sitio web", "Compartir la oferta con tus amigos en redes sociales", "*Ignorar la oferta y cerrar el sitio web*. Las ofertas que parecen demasiado buenas para ser verdad suelen ser estafas para robar información personal.", 2, 1);
        private static Pregunta p3 = new Pregunta("**En el trabajo, recibes un archivo adjunto de un remitente desconocido. ¿Cuál es la mejor manera de proceder?**", "Abrir el archivo adjunto para ver su contenido", "Eliminar el correo electrónico sin abrir el archivo adjunto", "Responder al remitente preguntando sobre el archivo", "*Eliminar el correo electrónico sin abrir el archivo adjunto*. Abrir archivos adjuntos de remitentes desconocidos puede infectar tu sistema con malware.", 2, 1);
        private static Pregunta p4 = new Pregunta("**Tu computadora te pide actualizar el software antivirus. ¿Qué deberías hacer?**", "Ignorar la solicitud", "Actualizar el software antivirus de inmediato", "Desactivar el software antivirus para evitar interrupciones", "*Actualizar el software antivirus de inmediato*. Mantener el antivirus actualizado es crucial para protegerse contra las últimas amenazas.", 2, 1);
        private static Pregunta p5 = new Pregunta("**Ves un anuncio emergente en tu navegador que dice que tu computadora está infectada y ofrece un enlace para solucionar el problema. ¿Qué deberías hacer?**", "Reiniciar la computadora para solucionar el problema", "Hacer clic en el enlace para solucionar el problema", "Ignorar el anuncio y cerrar la ventana del navegador", "*Ignorar el anuncio y cerrar la ventana del navegador*. Los anuncios emergentes que afirman que tu computadora está infectada suelen ser intentos de engaño para instalar malware.", 3 , 1);

        // Crear un arreglo y agregar p1 y p2
        private static Pregunta[] preguntasArrayn1 = new Pregunta[] { p1, p2, p3, p4, p5 };

        public Pregunta ObtenerPregunta(int nivel)
        {
            var random = new Random();
            var rNUm = random.Next(1, 5);
            if (nivel == 1)
            {
                return preguntasArrayn1[rNUm];
            }
            else
            {
                return null;
            }

        }
    }
}
