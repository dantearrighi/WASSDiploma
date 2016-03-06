using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Seguridad
{
   public class cCU_Login
    {
        // Declaro las variables a utilizar en la clase
        private static cCU_Login instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
        private Controladora.Seguridad.cCU_GestionarUsuarios cCU_GestionarUsuarios;
        Controladora.cEncriptacion cEncriptacion;
    
        

        // Aplico el patrón de diseño Singleton a la clase
        public static cCU_Login ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_Login();

            return instancia;
        }



        // Coloco al constructor como privado.
        private cCU_Login()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
           
            cCU_GestionarUsuarios = Controladora.Seguridad.cCU_GestionarUsuarios.ObtenerInstancia();
            cEncriptacion = cEncriptacion.ObtenerInstancia();
        }



        // Validar que se hayan INGRESADO un nombre de usuario y contraseña
        public bool ValidarObligatoriosLogin(string username, string password)
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


        // LOGUEAR USUARIO
        public Modelo_Entidades.Usuario Login(string usuario, string clave)
        {
            // Aca instancio un objeto "Usuario" y tomo el objeto "Entidades" que instancie en un principio.
            // Luego, a esas "Entidades", les pido que me traigan a todos los "Usuarios" en forma de Lista.
            // A esa Lista de "Usuarios" le pido que me encuentre y que me devuelva el usuario "usuario" que pasé por parámetros. 
            Modelo_Entidades.Usuario oUsuario = cCU_GestionarUsuarios.ObtenerUsuario(usuario);
            

            if (ValidarUsuarioExistente(oUsuario))
            {
                if (ValidarUsuarioActivo(oUsuario))
                {
                    if (ValidarContraseñaIngresada(oUsuario, clave))
                    {
                        // En caso de que pase todas la validaciones, devuelvo al Usuario
                        return oUsuario;
                    }
                    else
                    {
                        throw new Exception("La contraseña ingresada es incorrecta.");
                    }
                }
                else
                {
                    throw new Exception("El usuario se encuentra desactivado.");
                }
            }
            else
            {
                throw new Exception("El usuario ingresado no se encuentra registrado en el sistema.");

            }

        }
        
       
        // Validar USUARIO ACTIVO
        public bool ValidarUsuarioActivo(Modelo_Entidades.Usuario oUsuario)
        {
                
            // Pregunto por el estado del usuario, y devuelvo un mensaje, en caso de que sea inactivo.
            if (oUsuario.estado == false)
            {
                return false;
            }
            return true;
        }

        // Validar USUARIO EXISTENTE
        public bool ValidarUsuarioExistente(Modelo_Entidades.Usuario oUsuario)
        {
            // Pregunto si el usuario es nulo, y devuelvo un mensaje, en caso de que sea así.
            if (oUsuario == null)
            {
                return false;
                
            }
            return true;
                
        }

        // Validar CONTRASEÑA INGRESADA
        public bool ValidarContraseñaIngresada(Modelo_Entidades.Usuario usrActual, string claveIngresada)
        {
            if (usrActual.clave != claveIngresada)
            {
                return false;
            }
            return true;
 
        }



    }
}
