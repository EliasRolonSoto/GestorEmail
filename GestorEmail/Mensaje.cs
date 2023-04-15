using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEmail
{
    public class Mensaje
    {
       public string asunto { get; set; }
        public string cuerpo { get; set; }
        public Contacto remitente { get; set; }
        public Contacto destinatario { get; set; }
        public Mensaje() { }

    }
}
