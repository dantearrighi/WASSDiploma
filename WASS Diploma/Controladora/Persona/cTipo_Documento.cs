using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace Controladora
{
    public class cTipo_Documento
    {
        // Declaro las variables a utilizar en la clase
        private static cTipo_Documento instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        // Aplico el patrón de diseño Singleton a la clase
        public static cTipo_Documento ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cTipo_Documento();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cTipo_Documento()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

        // Obtener los tipos de documentos
        public List<Tipos_Documentos> ObtenerTipos_Documentos()
        {
            return oModelo_Entidades.Tipos_Documentos.ToList();
        }
    }
}
