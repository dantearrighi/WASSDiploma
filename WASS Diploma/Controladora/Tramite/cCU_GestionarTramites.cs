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
        Controladora.Seguridad.cCU_RecuperarPerfilPorFormulario cCU_RecuperarPerfilPorFormulario;
        public Controladora.cCU_AltaTramite cCU_AltaTramite;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;


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
            cCU_RecuperarPerfilPorFormulario = Controladora.Seguridad.cCU_RecuperarPerfilPorFormulario.ObtenerInstancia();
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
            cCU_AltaTramite = Controladora.cCU_AltaTramite.ObtenerInstancia();
        }


        //Obtener permisos de un usuario sobre un formulario
        public List<Modelo_Entidades.Perfil> ObtenerPermisos(Modelo_Entidades.Usuario oUsuario, string nombreForm)
        {
            //Invoco al caso de uso que devuelve los permisos que tiene un usuario sobre el formulario solicitado
            return cCU_RecuperarPerfilPorFormulario.ObtenerPermisosPorFormulario(oUsuario, nombreForm);
        }

        
    }
}

