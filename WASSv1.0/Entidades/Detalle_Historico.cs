using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Detalle_Historico
    {
        public string estadoAnterior{ get; set; }

        public string idUserModificador { get; set; }

        public DateTime fechaHoraModificacion{ get; set; }
    }
}
