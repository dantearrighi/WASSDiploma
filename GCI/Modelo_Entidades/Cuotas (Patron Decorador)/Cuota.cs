using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo_Entidades
{
    public abstract partial class Cuota
    {
        // Declaro las variables
        private Modelo_Entidades.GCIEntidades oModelo_Entidades = GCIEntidades.ObtenerInstancia();

        // Asigno el alterador al 1º (y único) alterador que existe
        public Modelo_Entidades.Alterador AlteradorAusar()
        {
            Modelo_Entidades.Alterador oAlterador = oModelo_Entidades.Alteradores.ToList().Find(delegate(Modelo_Entidades.Alterador fAlterador)
            {
                return fAlterador.id == 1;
            });

            return oAlterador;
        }

        // Declaro el método valor
        public abstract double Valor();
    }
}
