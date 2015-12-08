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

        // Obtener los tramites con sus detalles para mostrar en la lista
        public List<Modelo_Entidades.Tramite> ObtenerListaTramites
        {
            //return oModelo_Entidades.Tramites.ToList();

           
        }

    }
}
