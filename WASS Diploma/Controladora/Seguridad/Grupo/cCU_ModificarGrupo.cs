using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Seguridad
{
   public class cCU_ModificarGrupo
    {
       
       #region Variables, Metodos de clase y Constructor
       // Declaración de variables a usar en la clase
        private static cCU_ModificarGrupo instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;


        //Aplico el patron de diseño Singleton para la clase controladora del CU Gestionar GRUPOS (cuando la solicitan desde otra)
        public static cCU_ModificarGrupo ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_ModificarGrupo();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_ModificarGrupo()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

       #endregion



        // Modifico un grupo
        public void ModificarGrupo(Modelo_Entidades.Grupo oGrupo)
        {
            oModelo_Entidades.ApplyCurrentValues("Grupos", oGrupo);
            oModelo_Entidades.SaveChanges();

        }
       

    }
}
