using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Calculo
{
    public class Calculo
    {
        private DatosCalculo _datos = new DatosCalculo();
        private CalculoStrategy _calculoStrategy;

        public void SetCalculoStrategy(CalculoStrategy _Pcalculostrategy)
        {
            this._calculoStrategy = _Pcalculostrategy;
        }


        public DatosCalculo Calcular(DatosCalculo _datos)
        {
            return _calculoStrategy.RealizarCalculo(_datos);

        }

    }
}
