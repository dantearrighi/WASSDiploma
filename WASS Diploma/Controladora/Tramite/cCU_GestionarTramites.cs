using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Controladora
{
    public class cCU_GestionarTramites
    {
        // Declaración de variables a usar en la clase
        private static cCU_GestionarTramites instancia;
        Controladora.Seguridad.cCU_RecuperarPerfilPorFormulario cCU_RecuperarPerfilPorFormulario;
        public Controladora.cCU_AltaTramite cCU_AltaTramite;
        public Controladora.cCU_ModificarTramite cCU_ModificarTramite;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
        private cEstado cEstado;


        //Aplico el patron de diseño Singleton para la clase cGrupo (cuando la solicitan desde otra)
        public static cCU_GestionarTramites ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_GestionarTramites();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_GestionarTramites()
        {
            cCU_RecuperarPerfilPorFormulario = Controladora.Seguridad.cCU_RecuperarPerfilPorFormulario.ObtenerInstancia();
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
            cCU_AltaTramite = Controladora.cCU_AltaTramite.ObtenerInstancia();
            cCU_ModificarTramite = Controladora.cCU_ModificarTramite.ObtenerInstancia();
            cEstado = cEstado.ObtenerInstancia();
        }

        //Obtener permisos de un usuario sobre un formulario
        public List<Modelo_Entidades.Perfil> ObtenerPermisos(Modelo_Entidades.Usuario oUsuario, string nombreForm)
        {
            //Invoco al caso de uso que devuelve los permisos que tiene un usuario sobre el formulario solicitado
            return cCU_RecuperarPerfilPorFormulario.ObtenerPermisosPorFormulario(oUsuario, nombreForm);
        }



       

        // BAJA TRAMITE
        public void BajaTramite(Modelo_Entidades.Tramite oTramite)
        {
            oTramite.Estado = cEstado.ObtenerEstadoBaja();
            cCU_ModificarTramite.Modificacion(oTramite);
        }
        


        

        #region OBTENER TRAMITES

        // Obtener los tramites
        public List<Modelo_Entidades.Tramite> ObtenerTramites()
        {
            return oModelo_Entidades.Tramites.ToList();
        }

        // Obtener los tramites de una persona POR NOMBRE Y APELLIDO
        public List<Modelo_Entidades.Tramite> ObtenerTramitesPorNombeApellido(string textoNombre)
        {

            var Consulta = from oTramite in oModelo_Entidades.Tramites.ToList()
                           where oTramite.Persona.nombre_apellido.ToLower().Contains(textoNombre)
                           select oTramite;
            return (List<Modelo_Entidades.Tramite>)Consulta.ToList();
        }

        // Obtener los tramites de una persona POR DNI
        public List<Modelo_Entidades.Tramite> ObtenerTramitesPorDNI(string textoDNI)
        {

            var Consulta = from oTramite in oModelo_Entidades.Tramites.ToList()
                           where oTramite.Persona.dni.ToString().ToLower().Contains(textoDNI)
                           select oTramite;
            return (List<Modelo_Entidades.Tramite>)Consulta.ToList();
        }

        // Obtener los tramites de una persona POR ID/ NUMERO DE TRAMITE
        public List<Modelo_Entidades.Tramite> ObtenerTramitesPorNumeroID(string textoID)
        {

            var Consulta = from oTramite in oModelo_Entidades.Tramites.ToList()
                           where oTramite.Id.ToString().ToLower().Contains(textoID)
                           select oTramite;

            /* ESTO DEBERIA HACERLO ACA 
             * //Conseguir ultimo detalle y ultima fecha de cada tramite en la lista
             foreach (Modelo_Entidades.Tramite t in Consulta)
             {
                
                 //Obtengo la descripción correspondiente a la ultima fecha y la fecha
                 foreach (Modelo_Entidades.Detalles_Tramite dt in t.Detalles_Tramite)
                 {
                     //Si la fecha del detalle es la ultima, me quedo con el dato descripcion y fecha
                     if (dt.fecha_desde == t.Detalles_Tramite.OrderByDescending(ddt => ddt.fecha_desde).FirstOrDefault().fecha_desde)
                     {
                         t.Ultima_Descripcion = dt.descripcion;
                         t.Ultima_Fecha = Convert.ToDateTime(dt.fecha_desde.ToString());
                     }
                 }
             }*/
            return (List<Modelo_Entidades.Tramite>)Consulta.ToList();
        }


        // Obtener los tramites DE UN TIPO DE TRAMITE
        public List<Modelo_Entidades.Tramite> ObtenerTramitesPorTipo(string textoTipoTramite)
        {

            var Consulta = from oTramite in oModelo_Entidades.Tramites.ToList()
                           where oTramite.Tipo_Tramite.descripcion.Equals(textoTipoTramite)
                           select oTramite;
            return (List<Modelo_Entidades.Tramite>)Consulta.ToList();
        }

        // Obtener los tipos de tramites
        public List<Modelo_Entidades.Tipo_Tramite> ObtenerTipos_Tramites()
        {
            return oModelo_Entidades.Tipos_Tramites.ToList();
        }
        #endregion

        

    }
}

