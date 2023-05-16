using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEmail
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Email { get; set; }

        public Contacto(string nombre, string email) 
        {
        Nombre=nombre;
        Email=email;

         }
        public Contacto() { }
    }
}
