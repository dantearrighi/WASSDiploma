using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Seguridad
{
    public class cCU_BajaGrupo
    {
        

       #region Variables, Metodos de clase y Constructor
       // Declaración de variables a usar en la clase
        private static cCU_BajaGrupo instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;


        //Aplico el patron de diseño Singleton para la clase controladora del CU Gestionar GRUPOS (cuando la solicitan desde otra)
        public static cCU_BajaGrupo ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_BajaGrupo();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_BajaGrupo()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

       #endregion


        // Elimino a un grupo
        public void EliminarGrupo(Modelo_Entidades.Grupo oGrupo)
        {
            if (ValidarMiembrosGrupo(oGrupo))
            {
                oModelo_Entidades.DeleteObject(oGrupo);
                oModelo_Entidades.SaveChanges();
            }
            else
            {
                throw new Exception("Para eliminar el grupo, primero debe desasociar a todos sus miembros y eliminar todos sus perfiles");
            }
        }

        // Valido que no un grupo no tengo miembros asociados
        public Boolean ValidarMiembrosGrupo(Modelo_Entidades.Grupo oGrup)
        {
            Modelo_Entidades.Grupo oGrupo = oModelo_Entidades.Grupos.ToList().Find(delegate(Modelo_Entidades.Grupo fGrupo)
            {
                return fGrupo == oGrup;
            });

            if (oGrupo.Usuarios.Count == 0 && oGrupo.Perfiles.Count == 0)
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
