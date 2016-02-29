using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Controladora
{
   public class cCU_GestionarPersonas
    {
       // Declaración de variables a usar en la clase
        private static cCU_GestionarPersonas instancia;
        Controladora.Seguridad.cCU_RecuperarPerfilPorFormulario cCU_RecuperarPerfilPorFormulario;
       
        
       
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
        public List<Perfiles> ObtenerPermisos(Usuarios oUsuario, string nombreForm)
        {
            //Invoco al caso de uso que devuelve los permisos que tiene un usuario sobre el formulario solicitado
            return cCU_RecuperarPerfilPorFormulario.ObtenerPermisosPorFormulario(oUsuario, nombreForm);
        }


        #region ====    OBTENER PERSONAS    ====

        // Obtener TODAS las Personas
        public List<Personas> ObtenerPersonas()
        {
            return oPersonass.ToList();
        }

        // Obtener personas por DNI
        public List<Personas> FiltrarPorDNI(string dni)
        {
            var Consulta = from oPersona in oPersonass.ToList()
                           where oPersona.dni.ToString().StartsWith(dni)
                           select oPersona;
            return (List<Personas>)Consulta.ToList();
        }

        // Obtener personas por Nombre y Apellido
        public List<Personas> FiltrarPorNyA(string nya)
        {
            var Consulta = from oPersona in oPersonass.ToList()
                           where oPersona.nombre_apellido.ToLower().Contains(nya)
                           select oPersona;
            return (List<Personas>)Consulta.ToList();
        }

        #endregion

        #region ////    ABMC PERSONAS    \\\\


        // ALTA a una nueva Persona
        public void Alta(Personas oPersona)
        {
            oModelo_Entidades.AddToPersonas(oPersona);
            oModelo_Entidades.SaveChanges();
        }

        // MODIFICAR a una Persona
        public void Modificacion(Personas oPersona)
        {
            oModelo_Entidades.ApplyCurrentValues("Personas", oPersona);
            oModelo_Entidades.SaveChanges();
        }

        // ELIMINAR a una persona
        public void EliminarPersona(Personas oPersona)
        {
                oModelo_Entidades.DeleteObject(oPersona);
                oModelo_Entidades.SaveChanges();
           
        }

        #endregion


        #region ****    VALIDACIONES PERSONAS    ****

        // Valido que una Persona no exista
        public Boolean ValidarPersona(int dni)
        {
            Personas oPersona = oPersonass.ToList().Find(delegate(Personas fPersona)
            {
                return fPersona.dni == dni;
            });


            if (oPersona == null)
            {     //Si no se encontro persona registrada con el dni ingresado, devuelvo true
                return true;
            }

            else
            {     //Si la persona ya existe
                return false;
            }
        }


        // Valido que no un grupo no tengo miembros asociados
        public Boolean ValidarTramitesAsociadosPersona(Personas oPersona)
        {
            Personas oPers = oPersonass.ToList().Find(delegate(Personas fPersona)
            {
                return fPersona == oPersona;
            });

            if (oPers.Tramites.Count == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        #endregion
    }
}
