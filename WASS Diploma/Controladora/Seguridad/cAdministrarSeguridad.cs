using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Seguridad
{
    public class cAdministrarSeguridad
    {

        // Declaro las variables a utilizar en la clase
        private static cAdministrarSeguridad instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
        private cEncriptacion _cEncriptacion;
        private cCU_ResetearClave _cCU_ResetearClave;
        private cCU_GestionarGrupos _cCU_GestionarGrupos;
        private cCU_GestionarPerfiles _cCU_GestionarPerfiles;
        private cCU_GestionarUsuarios _cCU_GestionarUsuarios;
        private cCU_Login _cCU_Login;
        
        
        // Aplico el patrón de diseño Singleton a la clase
        public static cAdministrarSeguridad ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cAdministrarSeguridad();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cAdministrarSeguridad()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
            _cCU_GestionarGrupos = Controladora.Seguridad.cCU_GestionarGrupos.ObtenerInstancia();
            _cCU_GestionarPerfiles = Controladora.Seguridad.cCU_GestionarPerfiles.ObtenerInstancia();
            _cCU_GestionarUsuarios = Controladora.Seguridad.cCU_GestionarUsuarios.ObtenerInstancia();
            _cCU_Login = Controladora.Seguridad.cCU_Login.ObtenerInstancia();
            _cCU_ResetearClave = Controladora.Seguridad.cCU_ResetearClave.ObtenerInstancia();
            _cEncriptacion =  cEncriptacion.ObtenerInstancia();
        }


        #region Usuario

        #region Login USR

        //Loguear usuario
        public Modelo_Entidades.Usuario Login(string usuario, string clave)
        {

           return _cCU_Login.Login(usuario, clave);
            
        }

        public bool ValidarObligatoriosLogin(string usrName, string clave)
        { 
           return _cCU_Login.ValidarObligatoriosLogin(usrName,clave);
        }

        public bool ValidarContraseñaIngresada(Modelo_Entidades.Usuario oUsuario, string clave)
        {
            return _cCU_Login.ValidarContraseñaIngresada(oUsuario, clave);
        }

        public string Encriptar(string valor)
        {
            return _cEncriptacion.Encriptar(valor);
        }

        #endregion


        #region CLAVE USR
        // CAMBIAR CONTRASEÑA
        public bool CambiarContraseña(string claveNueva, string claveNuevaConfirmar, string claveActual, Modelo_Entidades.Usuario usrActual)
        {
            //SI ESTAN MAL LOS DATOS
            if (ValidarObligatoriosCambiarClave(claveNueva, claveNuevaConfirmar, claveActual, usrActual))
            {
                usrActual.clave = claveNueva;
                _cCU_GestionarUsuarios.Modificacion(usrActual);
                return true;
            }
            else
            {
                throw new Exception("Las contraseñas no coinciden o la clave actual es incorrecta. Verifique y vuelva a intentarlo.");
            }


        }

        // Generar una clave al azar para la creación del usuario
        public void ResetearClave(Modelo_Entidades.Usuario oUsuario, string email)
        {
            _cCU_ResetearClave.ResetearClave(oUsuario, email);
            
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

        #endregion


        #region Otras validaciones

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


        // Validar que se hayan ingresado clave actual y la nueva 2 veces para modificarla
        private bool ValidarObligatoriosCambiarClave(string claveNueva, string claveNuevaConfirmar, string claveActual, Modelo_Entidades.Usuario usrActual)
        {
            // VALIDACION CAMPOS VACIOS:     ClaveNueva   -     Confirmacion                    y que coincida la confirmacion
            if (string.IsNullOrEmpty(claveNueva) || string.IsNullOrEmpty(claveNuevaConfirmar) || claveNueva != claveNuevaConfirmar)
            {
                throw new Exception("Debe ingresar una contraseña, ya que o no las ha ingresado, o no coinciden");


            }

            // Validacion CAMPO VACIO CLAVE ACTUAL
            if (string.IsNullOrEmpty(claveActual))
            {
                throw new Exception("Es obligatorio ingresar la clave actual.");
            }

            // Validacion de la clave actual
            if (!ValidarContraseñaIngresada(usrActual, claveActual))
            {
                //MessageBox.Show("La contraseña actual es incorrecta, por favor introduscula nuevamente");
                throw new Exception("La contraseña actual es incorrecta.");
            }




            return true;
        }

    
#endregion


#endregion


        #region VARIOS

        // Obtengo los formularios según modulo al que pertenecen
        public List<Modelo_Entidades.Formulario> ObtenerFormulariosPorModulo(Modelo_Entidades.Modulo oModulo)
        {
            var Consulta = from oPerfil in oModelo_Entidades.Perfiles.ToList()
                           where oPerfil.Formulario.Modulo == oModulo
                           group oPerfil by oPerfil.Formulario into Formularios
                           select Formularios.Key;
            return (List<Modelo_Entidades.Formulario>)Consulta.ToList();
        }


        #endregion


    }
 }

