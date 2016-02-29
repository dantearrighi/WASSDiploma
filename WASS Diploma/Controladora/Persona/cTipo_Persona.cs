using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace Controladora
{
   public class cTipo_Persona
    {
        // Declaro las variables a utilizar en la clase
        private static cTipo_Persona instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        // Aplico el patrón de diseño Singleton a la clase
        public static cTipo_Persona ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cTipo_Persona();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cTipo_Persona()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

        // Obtener los tipos de personas
        public List<Tipos_Personas> ObtenerTipos_Personass()
        {
            return oModelo_Entidades.Tipos_Personass.ToList();
        }
    }
}
