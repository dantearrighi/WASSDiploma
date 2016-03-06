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



        // Obtener ultima fecha del detalle de un tramite especifico
        public DateTime ObtenerUltimaFechaDetalle(int idTramite)
        {
            //Obtengo todos los detalles del tramite especificado
            List<Modelo_Entidades.Detalles_Tramite> listaDetalles = (from item in oModelo_Entidades.Detalles_Tramites.ToList()
                                                                     where item.TramiteId == idTramite
                                                                     select item).ToList();

            DateTime UltimaFecha = (from detalles in listaDetalles
                                    where detalles.fecha_desde == listaDetalles.OrderByDescending(t => t.fecha_desde).FirstOrDefault().fecha_desde
                                    select detalles.fecha_desde).FirstOrDefault().Value;

            return UltimaFecha;
        }

        // Obtener todos los detalles de todos los tramites, ordenados por fecha de mayor a menor
        public List<Modelo_Entidades.Detalles_Tramite> Obtener_Detalles_Tramites()
        {

            List<Modelo_Entidades.Detalles_Tramite> listaDetalles = oModelo_Entidades.Detalles_Tramites.ToList();

            listaDetalles = (from item in listaDetalles

                             orderby item.fecha_desde

                             select item).ToList();

            return listaDetalles;
        }


        // Obtener todos los detalles de UN SOLO tramite, ordenados por fecha de mayor a menor
        public List<Modelo_Entidades.Detalles_Tramite> Obtener_Detalles_Tramites(int idTramite)
        {

            List<Modelo_Entidades.Detalles_Tramite> listaDetalles = oModelo_Entidades.Detalles_Tramites.ToList();

            listaDetalles = (from item in listaDetalles
                             where item.TramiteId == idTramite
                             orderby item.fecha_desde

                             select item).ToList();

            return listaDetalles;
        }


        
    }
}

