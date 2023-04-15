using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEmail
{
    public class Gestor
    {
        public List<Mensaje> BandejaDeEntrada { get; set; }
        public List<Mensaje> BandejaDeSalida { get; set; }
        
        public void AgregarBDE (Mensaje mensaje)
        {
            BandejaDeEntrada.Add(mensaje);
        }

        public void AgregarBDS (Mensaje mensaje)
        {
            BandejaDeSalida.Add(mensaje);
        }

        public Gestor() { 
        BandejaDeEntrada = new List<Mensaje>();
        BandejaDeSalida = new List<Mensaje>();  
        }
    }
}
