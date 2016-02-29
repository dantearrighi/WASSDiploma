using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace Controladora
{
    public class cLocalidad
    {
        // Declaro las variables a utilizar en la clase
        private static cLocalidad instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        // Aplico el patrón de diseño Singleton a la clase
        public static cLocalidad ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cLocalidad();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cLocalidad()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

        // Obtener las provincias
        public List<Localidades> ObtenerLocalidades()
        {
            return oLocalidadeses.ToList();
        }
    }
}
