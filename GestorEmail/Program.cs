
// See https://aka.ms/new-console-template for more information
using GestorEmail;
using System.Data.SqlClient;

string connectionString =
   "Persist Security Info=True;Initial Catalog=Demo;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";


string querySql =
    "SELECT Correo_Id, Asunto, Cuerpo, Nombre, Email FROM dbo.GestorMail_Prueba";

Gestor gestor = new Gestor();

using (var connection =
    new SqlConnection(connectionString))
{
    var command = new SqlCommand(querySql, connection);

    try
    {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            var contacto = new Contacto();
            var mensaje = new Mensaje();


            contacto.Nombre = reader[3].ToString();
            contacto.Email = reader[4].ToString();

            mensaje.remitente = contacto;

            mensaje.asunto = reader[1].ToString();
            mensaje.cuerpo = reader[2].ToString();

            gestor.AgregarBDE(mensaje);
        }
        reader.Close();
    }
    catch(Exception ex)
    {
        Console.WriteLine($"[ERROR]{ex.Message}");
    }
    foreach (var item in gestor.BandejaDeEntrada){

        Console.Write($"Remitente: {item.remitente.Nombre}\nCorreo: {item.remitente.Email}\nAsunto: {item.asunto}\nMensaje:\n{item.cuerpo}\n ---------------------- \n");
       
    }
    
}

