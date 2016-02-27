using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
   public class cCU_GestionarPersonas
    {
       // Declaración de variables a usar en la clase
        private static cCU_GestionarPersonas instancia;
        Controladora.Seguridad.cCU_RecuperarPerfilPorFormulario cCU_RecuperarPerfilPorFormulario;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
       
        //Aplico el patron de diseño Singleton para la clase cGrupo (cuando la solicitan desde otra)
        public static cCU_GestionarPersonas ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_GestionarPersonas();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_GestionarPersonas()
        {           
            cCU_RecuperarPerfilPorFormulario = Controladora.Seguridad.cCU_RecuperarPerfilPorFormulario.ObtenerInstancia();
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

        //Obtener permisos de un usuario sobre un formulario
        public List<Modelo_Entidades.Perfil> ObtenerPermisos(Modelo_Entidades.Usuario oUsuario, string nombreForm)
        {
            //Invoco al caso de uso que devuelve los permisos que tiene un usuario sobre el formulario solicitado
            return cCU_RecuperarPerfilPorFormulario.ObtenerPermisosPorFormulario(oUsuario, nombreForm);
        }


        #region ====    OBTENER PERSONAS    ====

        // Obtener TODAS las Personas
        public List<Modelo_Entidades.Persona> ObtenerPersonas()
        {
            return oModelo_Entidades.Personas.ToList();
        }

        // Obtener personas por DNI
        public List<Modelo_Entidades.Persona> FiltrarPorDNI(string dni)
        {
            var Consulta = from oPersona in oModelo_Entidades.Personas.ToList()
                           where oPersona.dni.ToString().StartsWith(dni)
                           select oPersona;
            return (List<Modelo_Entidades.Persona>)Consulta.ToList();
        }

        // Obtener personas por Nombre y Apellido
        public List<Modelo_Entidades.Persona> FiltrarPorNyA(string nya)
        {
            var Consulta = from oPersona in oModelo_Entidades.Personas.ToList()
                           where oPersona.nombre_apellido.ToLower().Contains(nya)
                           select oPersona;
            return (List<Modelo_Entidades.Persona>)Consulta.ToList();
        }

        #endregion


    }
}
