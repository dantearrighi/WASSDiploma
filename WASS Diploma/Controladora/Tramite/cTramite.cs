using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
  public  class cTramite
    {

        // Declaro las variables a utilizar en la clase
        private static cTramite instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        // Aplico el patrón de diseño Singleton a la clase
        public static cTramite ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cTramite();

            return instancia;
        }

       // Coloco al constructor como privado.
        private cTramite()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
             
        }

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
            return (List<Modelo_Entidades.Tramite>)Consulta.ToList();
        }
      
       

    }
}
