using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo_Entidades
{
  public partial class Tramite
    {

        public string Ultima_Descripcion { get; set; }

        public DateTime Ultima_Fecha { get; set; }

        public override string ToString()
        {
            return Ultima_Descripcion.ToString();
        }

    }
}
