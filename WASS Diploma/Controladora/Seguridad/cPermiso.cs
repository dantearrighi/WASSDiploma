using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Controladora
{
    public class cPermiso
    {
         // Declaración de variables a usar en la clase
        private static cPermiso instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        //Aplico el patron de diseño Singleton para la clase cPermiso (cuando la solicitan desde otra)
        public static cPermiso ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cPermiso();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cPermiso()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

        // Obtengo los permisos
        public List<Permisos> ObtenerPermisos()
        {
            return oPermisoss.ToList();
        }
    }
}
