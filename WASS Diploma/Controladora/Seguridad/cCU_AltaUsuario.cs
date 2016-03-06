using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Seguridad
{
    public class cCU_AltaUsuario
    {
        // Declaración de variables a usar en la clase
        private static cCU_AltaUsuario instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
        private cCU_GestionarGrupos cCU_GestionarGrupos;
        
       


        //Aplico el patron de diseño Singleton para la clase controladora del CU Gestionar PERFILES (cuando la solicitan desde otra)
        public static cCU_AltaUsuario ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_AltaUsuario();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_AltaUsuario()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
            cCU_GestionarGrupos = Controladora.Seguridad.cCU_GestionarGrupos.ObtenerInstancia();
            
        }


        // Dar de alta a un nuevo usuario
        public void Alta(Modelo_Entidades.Usuario oUsuario)
        {
            oModelo_Entidades.AddToUsuarios(oUsuario);
            oModelo_Entidades.SaveChanges();
        }

    }
}
