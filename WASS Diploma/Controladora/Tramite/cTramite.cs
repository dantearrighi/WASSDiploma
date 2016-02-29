using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
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
        public List<Tramites> ObtenerTramites()
        {
            return oTramitess.ToList();
        }

        // Obtener los tramites de una persona POR NOMBRE Y APELLIDO
        public List<Tramites> ObtenerTramitesPorNombeApellido(string textoNombre)
        {
            
             var Consulta = from oTramite in oTramitess.ToList()
                           where oTramite.Persona.nombre_apellido.ToLower().Contains(textoNombre)
                           select oTramite;
            return (List<Tramites>)Consulta.ToList();
        }

        // Obtener los tramites de una persona POR DNI
        public List<Tramites> ObtenerTramitesPorDNI(string textoDNI)
        {

            var Consulta = from oTramite in oTramitess.ToList()
                           where oTramite.Persona.dni.ToString().ToLower().Contains(textoDNI)
                           select oTramite;
            return (List<Tramites>)Consulta.ToList();
        }

        // Obtener los tramites de una persona POR ID/ NUMERO DE TRAMITE
        public List<Tramites> ObtenerTramitesPorNumeroID(string textoID)
        {

            var Consulta = from oTramite in oTramitess.ToList()
                           where oTramite.Id.ToString().ToLower().Contains(textoID)
                           select oTramite;
            return (List<Tramites>)Consulta.ToList();
        }
      
       //Obtener Tramite
        // Obtengo un Persona dado su dni
        public Tramites ObtenerTramite(int idTramite)
        {
            Tramites oTramite = oTramitess.ToList().Find(delegate(Tramites fTramite)
            {
                return fTramite.Id == idTramite;
            });

            return oTramite;
        }


    }
}
