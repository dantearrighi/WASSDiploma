using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class cCU_ModificarTramite
    {
        //Declaro variables
        Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
        private static cCU_ModificarTramite instancia;
        private cEstado cEstado;

        public static cCU_ModificarTramite ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_ModificarTramite();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_ModificarTramite()
        {           
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
            cEstado = cEstado.ObtenerInstancia();
        }


        // Modificar a un tramite
        public void Modificacion(Modelo_Entidades.Tramite oTramite)
        {
            if(oTramite.Detalles_Tramite.LastOrDefault().descripcion == "Finalizado")
            {
                oTramite.Estado = ObtenerEstadoTramiteFINALIZADO();
            }
            oModelo_Entidades.ApplyCurrentValues("Tramites", oTramite);
            oModelo_Entidades.SaveChanges();
        }

        // Obtener el estado "TRAMITE FINALIZADO"
        public Modelo_Entidades.Estado ObtenerEstadoTramiteFINALIZADO()
        {
            Modelo_Entidades.Estado oEstado = oModelo_Entidades.Estados.ToList().Find(delegate(Modelo_Entidades.Estado fEstado)
            {
                return fEstado.descripcion == "Finalizado";
            });

            return oEstado;
        }


    }
}
