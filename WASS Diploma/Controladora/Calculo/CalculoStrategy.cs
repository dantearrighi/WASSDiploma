using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Controladora.Calculo
{
    public abstract class CalculoStrategy
    {
        public abstract DatosCalculo RealizarCalculo(DatosCalculo pDatos);

         
        
    }
}
