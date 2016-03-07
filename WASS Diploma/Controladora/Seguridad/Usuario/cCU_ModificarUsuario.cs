using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Seguridad
{
  public  class cCU_ModificarUsuario
    {

       // Declaración de variables a usar en la clase
        private static cCU_ModificarUsuario instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        //Aplico el patron de diseño Singleton para la clase controladora del CU Gestionar PERFILES (cuando la solicitan desde otra)
        public static cCU_ModificarUsuario ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_ModificarUsuario();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_ModificarUsuario()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
            
            
        }

      
        // Modificar a un usuario
        public void Modificacion(Modelo_Entidades.Usuario oUsuario)
        {
          
            oModelo_Entidades.ApplyCurrentValues("Usuarios", oUsuario);
            oModelo_Entidades.SaveChanges();
        }
    }
}
