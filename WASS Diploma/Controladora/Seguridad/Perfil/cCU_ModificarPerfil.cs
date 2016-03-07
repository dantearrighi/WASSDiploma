using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Seguridad
{
    public class cCU_ModificarPerfil
    {

        
       #region Variables, Metodos de clase y Constructor
       // Declaración de variables a usar en la clase
        private static cCU_ModificarPerfil instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;


        //Aplico el patron de diseño Singleton para la clase controladora del CU Gestionar GRUPOS (cuando la solicitan desde otra)
        public static cCU_ModificarPerfil ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_ModificarPerfil();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_ModificarPerfil()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

       #endregion


        //Modifico a un perfil
        public void ModificarPerfil(Modelo_Entidades.Perfil oPerfil)
        {
            oModelo_Entidades.ApplyCurrentValues("Perfiles", oPerfil);
            oModelo_Entidades.SaveChanges();
        }

    }
}
