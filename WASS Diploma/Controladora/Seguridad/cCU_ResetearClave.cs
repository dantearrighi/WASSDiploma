using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace Controladora.Seguridad
{
   public class cCU_ResetearClave
    {
        // Declaro las variables a utilizar en la clase
        private static cCU_ResetearClave instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
        Controladora.cEncriptacion cEncriptacion;
        Controladora.Seguridad.cCU_GestionarUsuarios cCU_GestionarUsuarios;
      

        // Aplico el patrón de diseño Singleton a la clase
        public static cCU_ResetearClave ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_ResetearClave();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_ResetearClave()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
            cEncriptacion = Controladora.cEncriptacion.ObtenerInstancia();
            cCU_GestionarUsuarios = Controladora.Seguridad.cCU_GestionarUsuarios.ObtenerInstancia();
        }


        // Método para la generación de la contraseña al azar
        private string GenerarClaveAleatoria(int caracteres, bool minusculas)
        {
            StringBuilder constructor = new StringBuilder();
            Random numeroalazar = new Random(DateTime.Now.Millisecond); // generar con el milisegundo actual como semilla
            char caracter;
            for (int i = 0; i < caracteres; i++)
            {
                caracter = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * numeroalazar.NextDouble() + 65)));
                constructor.Append(caracter);
            }
            if (minusculas)
            {
                return constructor.ToString().ToLower();
            }
            else
            {
                return constructor.ToString();
            }
        }

        // Generar una clave al azar para la creación del usuario
        public void ResetearClave(Modelo_Entidades.Usuario oUsuario, string email)
        {
            //generar una clave aleatoria
            oUsuario.clave = GenerarClaveAleatoria(4, false);
            //enviar la clave sin encriptar por mail

            string De = "dantearrighi@gmail.com";
            string Password = "9789hrqs";
            string Para = email;
            string Mensaje = "Bienvenido al WASS.  Su nombre de usuario es: " + oUsuario.usuario + ". El sistema ha generado una clave aleatoria porque el administrador de WASS le ha dado de alta. Su clave temporal es: " + oUsuario.clave + ". Por favor cambie su clave la primera vez que entre al sistema.";
            string Asunto = "AUTOMATICO: Usuario y Contraseña para WASS";
            System.Net.Mail.MailMessage Email;

            Email = new System.Net.Mail.MailMessage(De, Para, Asunto, Mensaje);
            /*
            System.Net.Mail.SmtpClient smtpMail = new System.Net.Mail.SmtpClient("smtp.gmail.com"); 
            Email.IsBodyHtml = false; 
            smtpMail.EnableSsl = true; 
            smtpMail.UseDefaultCredentials = false;
            smtpMail.Host = "smtp.gmail.com";
            smtpMail.Port = ; 
            smtpMail.Credentials = new System.Net.NetworkCredential(De, Password); 
            smtpMail.ClientCertificates. 
            SmtpClient clienteSmtp = new SmtpClient("WIN02");
             * */
            /*
             * Cliente SMTP
             * Gmail:  smtp.gmail.com  puerto:587
             * Hotmail: smtp.liva.com  puerto:25
             */
            SmtpClient server = new SmtpClient("smtp.gmail.com", 587);
            /*
            * Autenticacion en el Servidor
            * Utilizaremos nuestra cuenta de correo
            *
            * Direccion de Correo (Gmail o Hotmail)
            * y Contrasena correspondiente
            */
            server.Credentials = new System.Net.NetworkCredential(De, Password);
            server.EnableSsl = true;

            server.Send(Email);

            //obtener el hash md5 de la clave generada
            string clave_temporal = oUsuario.clave;
            oUsuario.clave = cEncriptacion.Encriptar(clave_temporal);
            //guardar el cambio 
            cCU_GestionarUsuarios.Modificacion(oUsuario);
        }


    }
}
