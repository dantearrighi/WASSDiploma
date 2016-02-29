using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace Controladora
{
 public   class cTipo_Tramite
    {

     // Declaro las variables a utilizar en la clase
        private static cTipo_Tramite instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        // Aplico el patrón de diseño Singleton a la clase
        public static cTipo_Tramite ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cTipo_Tramite();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cTipo_Tramite()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

        // Obtener los tipos de tramites
        public List<Tipos_Tramites> ObtenerTipos_Tramites()
        {
            return oModelo_Entidades.Tipos_Tramites.ToList();
        }
    }
}
