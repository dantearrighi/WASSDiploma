using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Controladora.Seguridad
{
    public class cCU_GestionarGrupos
    {
        // Declaración de variables a usar en la clase
        private static cCU_GestionarGrupos instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;


        //Aplico el patron de diseño Singleton para la clase controladora del CU Gestionar GRUPOS (cuando la solicitan desde otra)
        public static cCU_GestionarGrupos ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_GestionarGrupos();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_GestionarGrupos()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }







    }
}
