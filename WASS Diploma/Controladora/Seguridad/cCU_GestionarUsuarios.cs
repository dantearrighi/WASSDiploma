using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Seguridad
{
    public class cCU_GestionarUsuarios
    {
        // Declaro las variables a utilizar en la clase
        private static cCU_GestionarUsuarios instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
        Controladora.cEncriptacion cEncriptacion = new cEncriptacion();
        Controladora.cUsuario cUsuario;
        

        // Aplico el patrón de diseño Singleton a la clase
        public static cCU_GestionarUsuarios ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_GestionarUsuarios();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_GestionarUsuarios()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
            cUsuario = cUsuario.ObtenerInstancia();
        }

        // Validar que se hayan ingresado un nombre de usuario y contraseña
        public bool ValidarObligatorios(string username, string password)
        {
         
            if (username == "")
            {
                return false;
            }

            if (password == "")
            {
                return false;
            }

            return true;
        }

        // Loguear usuario
        public Modelo_Entidades.Usuario Login(string usuario, string clave)
        {
            // Aca instancio un objeto "Usuario" y tomo el objeto "Entidades" que instancie en un principio.
            // Luego, a esas "Entidades", les pido que me traigan a todos los "Usuarios" en forma de Lista.
            // A esa Lista de "Usuarios" le pido que me encuentre y que me devuelva el id del usuario "usuario" que pasé por parámetros. 
            Modelo_Entidades.Usuario oUsuario = oModelo_Entidades.Usuarios.ToList().Find(delegate(Modelo_Entidades.Usuario fUsuario)
            {
                return fUsuario.usuario == usuario;
            });

            cUsuario.ValidarUsuario(oUsuario, cEncriptacion.Encriptar(clave));

            // En caso de que pase todas la validaciones, devuelvo al Usuario
            return oUsuario;
        }


      
        
    
    }
}
