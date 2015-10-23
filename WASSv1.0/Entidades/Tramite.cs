using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Tramite
    {
        int _idTramite;
        public int IdTramite
        {
            get { return _idTramite; }
            set { _idTramite = value; }
        }

        string _dniCuilCli;
        public string DniCuilCliente
        {
            get { return _dniCuilCli; }
            set { _dniCuilCli = value; }
        }

        string _TipoTramite;
        public string TipoTramite
        {
            get { return _TipoTramite; }
            set { _TipoTramite = value; }
        }

      
        string _EnviadoPor;
        public string EnviadoPor
        {
            get { return _EnviadoPor; }
            set { _EnviadoPor = value; }
        }

        string _DerivadoA;
        public string DerivadoA //Cambiar por apoderado
        {
            get { return _DerivadoA; }
            set { _DerivadoA = value; }
        }

    }
}
