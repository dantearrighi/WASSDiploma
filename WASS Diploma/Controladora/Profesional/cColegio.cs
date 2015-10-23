using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class cColegio
    {
        // Declaro las variables a utilizar en la clase
        private static cColegio instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        // Aplico el patrón de diseño Singleton a la clase
        public static cColegio ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cColegio();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cColegio()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

        // Obtener los estados
        public List<Modelo_Entidades.Colegio> ObtenerColegios()
        {
            return oModelo_Entidades.Colegios.ToList();
        }
    }
}
