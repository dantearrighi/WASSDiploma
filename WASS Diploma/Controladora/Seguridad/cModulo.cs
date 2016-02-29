using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace Controladora
{
    public class cModulo
    {
        // Declaración de variables a usar en la clase
        private static cModulo instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        //Aplico el patron de diseño Singleton para la clase cModulo (cuando la solicitan desde otra)
        public static cModulo ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cModulo();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cModulo()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

        // Obtengo los módulos
        public List<Modulos> ObtenerModulos()
        {
            return oModuloss.ToList();
        }

        // Obtengo los formularios que pertenecen a un cierto modulo
        public List<Formularios> ObtenerFormulariosPorModulo(int modulo)
        {
            var Consulta = from oFormulario in oFormularioss.ToList()
                           where oFormulario.Modulo.id == modulo
                           group oFormulario by oFormulario into Formularios
                           select Formularios.Key;
            return (List<Formularios>)Consulta.ToList();
        }
    }
}
