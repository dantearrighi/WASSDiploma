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


      
        // Obtener los tramites con sus detalles para mostrar en la lista
    /*    public var ObtenerListaTramites()
        {
            //Obtengo la lista de todos los tramites
            List<Modelo_Entidades.Tramite> Tramites = oModelo_Entidades.Tramites.ToList();
            List<Modelo_Entidades.Detalles_Tramite> Detalles_Tramites = oModelo_Entidades.Detalles_Tramites.ToList();

            var Consulta = from Modelo_Entidades.Tramite t in Tramites
                        join Modelo_Entidades.Detalles_Tramite dt in Detalles_Tramites on t.Id equals dt.TramiteId
                        
                        select new { 
                            ID = t.Id,
                            Tipo = t.tipo_tramite,
                            Documento= t.Persona.dni,  
                            Persona = t.Persona.nombre_apellido, 
                            Fecha_Ultimo = (from ddtt in Detalles_Tramites
                                            where t.Id == ddtt.TramiteId
                                            select ddtt.fecha_desde).Max(),
                            Descripcion = (from udt in Detalles_Tramites
                                               where udt.fecha_desde == (from ddtt in Detalles_Tramites
                                                                         where t.Id == ddtt.TramiteId
                                                                         select ddtt.fecha_desde).Max()
                                                select udt.descripcion
                                               
                                            )
                        };


          /*  //Para cada tramite
            foreach (Modelo_Entidades.Tramite tram in Tramites)
            {
                //Obtengo el detalle cuya fecha es la mas reciente
                Modelo_Entidades.Detalles_Tramite oDetTramite = oModelo_Entidades.Detalles_Tramites.ToList().Find(delegate(Modelo_Entidades.Detalles_Tramite fDetTramite)
              {
                  return fDetTramite.fecha_desde >= tram.Detalles_Tramite.OrderByDescending(t => t.fecha_desde).FirstOrDefault().fecha_desde;
              });

                //Al tramite seleccionado (de la lista) le limpio los detalles, y le agrego solo el ultimo
                if (oDetTramite.fecha_desde >= tram.Detalles_Tramite.OrderByDescending(t => t.fecha_desde).FirstOrDefault().fecha_desde)
                {
                    tram.Detalles_Tramite = null;
                    tram.Detalles_Tramite.Add(oDetTramite);
                }
            }

            return Consulta.ToList();
            
               

        }*/

    }
}
