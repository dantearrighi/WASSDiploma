using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
  public  class cCU_AltaTramite
    {

      //Declaro variables
      Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
      private static cCU_AltaTramite instancia;

        public static cCU_AltaTramite ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_AltaTramite();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_AltaTramite()
        {           
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }


        // Validar Obligatorios (PASO 4 CU ALTA TRAMITE)
        public bool ValidarObligatorios(Modelo_Entidades.Tramite oTramite)
        {
            
            if (oTramite.Detalles_Tramite.Count == 0)
            {
                return false;
            }
            if (oTramite.estado == null)
            {
                return false;
            }
            if (oTramite.Persona == null)
            {
                return false;
            }
            if (oTramite.Tipo_Tramite == null)
            {
                return false; 
            }

            return true;
        }

        // CU ALTA TRAMITE: REGISTRARLO EN EL SISTEMA (PASO 5)
        public void AltaTramite(Modelo_Entidades.Tramite oTramite)
        {
            oModelo_Entidades.AddToTramites(oTramite);
            oModelo_Entidades.SaveChanges();

        }

    }
}
