using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
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
        public Usuarios Login(string usuario, string clave)
        {
            // Aca instancio un objeto "Usuario" y tomo el objeto "Entidades" que instancie en un principio.
            // Luego, a esas "Entidades", les pido que me traigan a todos los "Usuarios" en forma de Lista.
            // A esa Lista de "Usuarios" le pido que me encuentre y que me devuelva el usuario "usuario" que pasé por parámetros. 
            Usuarios oUsuario = oUsuarioss.ToList().Find(delegate(Usuarios fUsuario)
            {
                return fUsuario.usuario == usuario;
            });


            if (cUsuario.ValidarUsuarioExistente(oUsuario))
            {
                if (cUsuario.ValidarUsuarioActivo(oUsuario))
                {
                    if (cUsuario.ValidarContraseñaIngresada(oUsuario, clave))
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




        // Validar que se hayan ingresado clave actual y la nueva 2 veces para modificarla
        private bool ValidarObligatoriosCambiarClave(string claveNueva, string claveNuevaConfirmar, string claveActual, Usuarios usrActual)
        {
            // VALIDACION CAMPOS VACIOS:     ClaveNueva   -     Confirmacion                    y que coincida la confirmacion
            if (string.IsNullOrEmpty(claveNueva) || string.IsNullOrEmpty(claveNuevaConfirmar) ||  claveNueva != claveNuevaConfirmar)
            {
                throw new Exception("Debe ingresar una contraseña, ya que o no las ha ingresado, o no coinciden");
                

            }

            // Validacion CAMPO VACIO CLAVE ACTUAL
            if (string.IsNullOrEmpty(claveActual))
            {
                throw new Exception("Es obligatorio ingresar la clave actual.");
            }
           
            // Validacion de la clave actual
           if (!cUsuario.ValidarContraseñaIngresada(usrActual, claveActual))
            {
                //MessageBox.Show("La contraseña actual es incorrecta, por favor introduscula nuevamente");
                throw new Exception("La contraseña actual es incorrecta.");
            }

           


            return true;
        }
        
        // CAMBIAR CONTRASEÑA
        public bool CambiarContraseña(string claveNueva, string claveNuevaConfirmar, string claveActual, Usuarios usrActual)
        {
            //SI ESTAN MAL LOS DATOS
            if (ValidarObligatoriosCambiarClave(claveNueva, claveNuevaConfirmar, claveActual, usrActual))
            {
                usrActual.clave = claveNueva;
                cUsuario.Modificacion(usrActual);
                return true;
            }
            else
            {
                throw new Exception("Las contraseñas no coinciden o la clave actual es incorrecta. Verifique y vuelva a intentarlo.");
            }
                                   
          
        }

     

    
    }
}
