using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
 public class cDetalles_Tramite
    {
     // Declaro las variables a utilizar en la clase
        private static cDetalles_Tramite instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        // Aplico el patrón de diseño Singleton a la clase
        public static cDetalles_Tramite ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cDetalles_Tramite();

            return instancia;
        }

      // Coloco al constructor como privado.
        private cDetalles_Tramite()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
             
        }

        // Obtener el ultimo detalle del tramites
        public List<Modelo_Entidades.Detalles_Tramite> Obtener_Detalles_Tramites()
        {

            return oModelo_Entidades.Detalles_Tramites.ToList();
            /* var Consulta = from oUltimo_Detalle_Tramite in oModelo_Entidades.Detalles_Tramites.ToList()
                           where tram.Id == oUltimo_Detalle_Tramite.TramiteId
                           select oUltimo_Detalle_Tramite;
            return Consulta.OrderByDescending(oUltimo_Detalle_Tramite => oUltimo_Detalle_Tramite.fecha_desde).FirstOrDefault();
            */
            /*
            var q = from n in oModelo_Entidades.Detalles_Tramites.ToList()
                    where n.TramiteId == tram.Id
                    group n by n.fecha_desde into g
                    select g.OrderByDescending(t => t.fecha_desde).FirstOrDefault();

            return q.First();
            */
        }
    }
}
