using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Seguridad
{
   public class cCU_AltaPerfil
    {
       
       #region Variables, Metodos de clase y Constructor
       // Declaración de variables a usar en la clase
        private static cCU_AltaPerfil instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;


        //Aplico el patron de diseño Singleton para la clase controladora del CU Gestionar GRUPOS (cuando la solicitan desde otra)
        public static cCU_AltaPerfil ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_AltaPerfil();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_AltaPerfil()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

       #endregion




        //Agrego un perfil
        public void AltaPerfil(Modelo_Entidades.Perfil oPerfil)
        {
            
                oModelo_Entidades.Perfiles.AddObject(oPerfil);
                oModelo_Entidades.SaveChanges();
        
        }



    }
}
