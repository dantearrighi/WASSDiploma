using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using Entidades;
namespace Controladora
{
    public class cUsuario
    {
        // Declaro las variables a utilizar en la clase
        private static cUsuario instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
        Controladora.cEncriptacion cEncriptacion = new cEncriptacion();
      

        // Aplico el patrón de diseño Singleton a la clase
        public static cUsuario ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cUsuario();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cUsuario()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
             
        }

       

        // Busco al usuario según su email y código
        public Usuarios ObtenerUsuario(string usuario)
        {
            Usuarios oUsuario = oUsuarioss.ToList().Find(delegate(Usuarios fUsuario)
            {
                return fUsuario.usuario == usuario; 
            });

            return oUsuario;
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
        public void ResetearClave(Usuarios oUsuario, string email) 
        {
            //generar una clave aleatoria
            oUsuario.clave = GenerarClaveAleatoria(4, false);
            //enviar la clave sin encriptar por mail

            string De = "dantearrighi@gmail.com";
            string Password = "9789hrqs";
            string Para = email;
            string Mensaje = "Bienvenido al WASS.  Su nombre de usuario es: " + oUsuario.usuario + ". El sistema a generado una clave aleatoria porque el administrador de WASS le ha dado de alta. Su clave temporal es: " + oUsuario.clave + ". Por favor cambie su clave la primera vez que entre al sistema.";
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
            Modificacion(oUsuario);
        }

        /*// Busco al usuario en las entidades, haciendo las validaciones necesarias
        public Usuarios Login(string usuario, string clave)
        {
            // Aca instancio un objeto "Usuario" y tomo el objeto "Entidades" que instancie en un principio.
            // Luego, a esas "Entidades", les pido que me traigan a todos los "Usuarios" en forma de Lista.
            // A esa Lista de "Usuarios" le pido que me encuentre y que me devuelva el id del usuario "usuario" que pasé por parámetros. 
            Usuarios oUsuario = oUsuarioss.ToList().Find(delegate(Usuarios fUsuario)
            {
                return fUsuario.usuario == usuario;
            });

            ValidarUsuario(oUsuario, clave);

            // En caso de que pase todas la validaciones, devuelvo al Usuario
            return oUsuario;
        }*/

        // Obtengo los grupos de un usuario
        public List<Grupos> ObtenerGruposUsuario(int id)
        {
            // Aca instancio un objeto "Usuario" y tomo el objeto "Entidades" que instancie en un principio.
            // Luego, a esas "Entidades", les pido que me traigan a todos los "Usuarios" en forma de Lista.
            // A esa Lista de "Usuarios" le pido que me encuentre y que me devuelva los grupos del usuario "usuario" que pasé por parámetros. 
            Usuarios oUsuario = oUsuarioss.ToList().Find(delegate(Usuarios fUsuario)
            {
                    return fUsuario.id == id;
            });
                return oUsuario.Grupos.ToList();
        }

        // Dar de alta a un nuevo usuario
        public void Alta(Usuarios oUsuario)
        {
            oModelo_Entidades.AddToUsuarios(oUsuario);
            oModelo_Entidades.SaveChanges();
        }

        // Modificar a un usuario
        public void Modificacion(Usuarios oUsuario)
        {
            oModelo_Entidades.ApplyCurrentValues("Usuarios", oUsuario);
            oModelo_Entidades.SaveChanges();
        }

        // Obtener los usuarios
        public List<Usuarios> ObtenerUsuarios()
        {
            return oUsuarioss.ToList();
        }

        // Busco los usuarios por una descripción parcial
        public List<Usuarios> BuscarUsuarios(string texto)
        {
            var Consulta = from oUsuario in oUsuarioss.ToList()
                           where oUsuario.nombre_apellido.ToLower().Contains(texto.ToLower())
                           select oUsuario;
            return (List<Usuarios>)Consulta.ToList();
        }

        // Valido que no exista un usuario dado el nombre del usuario
        public Boolean ValidarUsuario(string usuario)
        {
            Usuarios oUsuario = oUsuarioss.ToList().Find(delegate(Usuarios fUsuario)
            {
                return fUsuario.usuario == usuario;
            });

            if (oUsuario == null)
            {
                return true;
            }

            else 
            {
                return false;
            }
        }


        // Metodo de validación general para todos los usuarios - Los busca segun estado y grupo al que pertenecen 
        public List<Usuarios> FiltrarUsuarios(string nya, string grupo, string estado)
        {
            var Consulta = from oUsuario in oUsuarioss.ToList()
                           select oUsuario;

            if (nya != "0")
            {                                                                   // aca iba containts
                Consulta = Consulta.Where(oUsuario => oUsuario.nombre_apellido.Contains(nya) );
            }

            if (grupo != "0")
            {
                Consulta = Consulta.Where(oUsuario => oUsuario.Grupos.Contains(this.BuscoGrupo(grupo)));
            }

            if (estado == "0")
            {
                Consulta = Consulta.Where(oUsuario => oUsuario.estado == false);
            }

            if (estado == "1")
            {
                Consulta = Consulta.Where(oUsuario => oUsuario.estado == true);
            }

            return (List<Usuarios>)Consulta.ToList();
        }

        // Método interno para buscar un grupo
        private Grupos BuscoGrupo(string grupo)
        {
            Grupos oGrupo = oGruposs.ToList().Find(delegate(Grupos fGrupo)
            {
                return fGrupo.descripcion == grupo;
            });

            return oGrupo;
        }



        // Validar USUARIO ACTIVO
        public bool ValidarUsuarioActivo(Usuarios oUsuario)
        {
                
            // Pregunto por el estado del usuario, y devuelvo un mensaje, en caso de que sea inactivo.
            if (oUsuario.estado == false)
            {
                return false;
            }
            return true;
        }

        // Validar USUARIO EXISTENTE
        public bool ValidarUsuarioExistente(Usuarios oUsuario)
        {
            // Pregunto si el usuario es nulo, y devuelvo un mensaje, en caso de que sea así.
            if (oUsuario == null)
            {
                return false;
                
            }
            return true;
                
        }

        // Validar CONTRASEÑA INGRESADA
        public bool ValidarContraseñaIngresada(Usuarios usrActual, string claveIngresada)
        {
            if (usrActual.clave != claveIngresada)
            {
                return false;
            }
            return true;
 
        }

        // Validar USUARIO: EXISTENTE, ACTIVO Y CONTRASEÑA
        public bool ValidarUsuarioExistenteActivoContraseña(Usuarios usrActual, string claveIngresada)
        {
            if(ValidarContraseñaIngresada(usrActual,claveIngresada) || ValidarUsuarioActivo(usrActual) || ValidarUsuarioExistente(usrActual))
            {
                return true;
            }

            return false;
        }
    }
}
