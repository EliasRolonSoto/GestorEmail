namespace GestorEmail.test
{
    public class UnitTest1
    {
        [Fact]
        public void MensajeTest()
        {
            
            var mensaje = new Mensaje();
            var remitente = new Contacto("JOSE", "correo-jose@ejemplo.com");
            mensaje.remitente = remitente;

            mensaje.asunto = "Nota Lab 3";
            mensaje.cuerpo = "Su nota es: 8";

            Assert.Equal("Su nota es: 8", mensaje.cuerpo);
            Assert.Equal("Nota Lab 3", mensaje.asunto);
            Assert.Equal("JOSE", mensaje.remitente.Nombre);
            Assert.Equal("correo-jose@ejemplo.com", mensaje.remitente.Email);

           
        }
        [Fact]
        public void GestorRecibido()
        {
            var gestor = new Gestor();
            var mensaje = new Mensaje();
            mensaje.asunto = "Nota Lab 3";
            

            gestor.AgregarBDE(mensaje);

            Assert.Equal("Nota Lab 3", gestor.BandejaDeEntrada[0].asunto);
           


        }
        [Fact]
        public void GestorEnviado()
        {
            var gestor = new Gestor();
            var mensaje = new Mensaje();
            mensaje.asunto = "Nota Lab 3";


            gestor.AgregarBDS(mensaje);

            Assert.Equal("Nota Lab 3", gestor.BandejaDeSalida[0].asunto);


        }

    }
}