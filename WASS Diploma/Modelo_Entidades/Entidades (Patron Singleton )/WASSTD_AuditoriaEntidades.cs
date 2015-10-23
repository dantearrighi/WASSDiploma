using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo_Entidades
{
    public partial class WASSTD_AuditoriaContainer
    {
        private static WASSTD_AuditoriaContainer _Instancia;

        public static WASSTD_AuditoriaContainer ObtenerInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new WASSTD_AuditoriaContainer();
            }
            return _Instancia;
        }
    }
}
