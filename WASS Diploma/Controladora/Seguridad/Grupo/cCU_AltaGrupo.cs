using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Seguridad
{
   public class cCU_AltaGrupo
   {

       #region Variables, Metodos de clase y Constructor
       // Declaración de variables a usar en la clase
        private static cCU_AltaGrupo instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;


        //Aplico el patron de diseño Singleton para la clase controladora del CU Gestionar GRUPOS (cuando la solicitan desde otra)
        public static cCU_AltaGrupo ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_AltaGrupo();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_AltaGrupo()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

       #endregion


        // Agrego un grupo
        public void AltaGrupo(Modelo_Entidades.Grupo oGrupo)
        {
            if (ValidarGrupo(oGrupo.descripcion))
            {
                oModelo_Entidades.AddToGrupos(oGrupo);
                oModelo_Entidades.SaveChanges();
            }
            else
            {
                throw new Exception("El grupo ingresado ya existe. Verifique y vuelva a intentar.");
            }
        }

        // Valido que no exista un grupo con el nombre del grupo ingresado
        public Boolean ValidarGrupo(string grupo)
        {
            Modelo_Entidades.Grupo oGrupo = oModelo_Entidades.Grupos.ToList().Find(delegate(Modelo_Entidades.Grupo fGrupo)
            {
                return fGrupo.descripcion == grupo;
            });

            if (oGrupo == null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }





    }
}
