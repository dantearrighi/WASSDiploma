﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace Controladora
{
   public  class cCU_ModificarTramite
    {
         //Declaro variables
      //Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
      private static cCU_ModificarTramite instancia;

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
        }

      

        // MODIFICAR a un Tramite
        public void ModificarTramite(Tramites oTramite)
        {
            oModelo_Entidades.ApplyCurrentValues("Tramites", oTramite);
            oModelo_Entidades.SaveChanges();
        }


    }
}
