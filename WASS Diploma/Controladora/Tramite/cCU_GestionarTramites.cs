using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class cCU_GestionarTramites
    {
         // Declaración de variables a usar en la clase
        private static cCU_GestionarTramites instancia;
        Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
        Controladora.cCU_RecuperarPerfilPorFormulario cCU_RecuperarPerfilPorFormulario;

         //Aplico el patron de diseño Singleton para la clase cGrupo (cuando la solicitan desde otra)
        public static cCU_GestionarTramites ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_GestionarTramites();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_GestionarTramites()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
            cCU_RecuperarPerfilPorFormulario = Controladora.cCU_RecuperarPerfilPorFormulario.ObtenerInstancia();
        }


        public List<Modelo_Entidades.Perfil> ObtenerPermisos(Modelo_Entidades.Usuario oUsuario, string nombreForm)
        {
            return cCU_RecuperarPerfilPorFormulario.ObtenerPermisosPorFormulario(oUsuario, nombreForm);
        }
    }
}
