using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo_Entidades
{
    public partial class WASSTDEntidades
    {
        private static WASSTDEntidades _Instancia;

            public static WASSTDEntidades ObtenerInstancia()
            {
                if (_Instancia == null)
                {
                    _Instancia = new WASSTDEntidades();
                }
                return _Instancia;
            }
    }
}
