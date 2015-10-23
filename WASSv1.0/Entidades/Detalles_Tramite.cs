using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Detalles_Tramite
    {
        int _idTramite;
        public int idTramite
        {
            get { return _idTramite; }
            set { _idTramite = value; }
        }

        DateTime _fechaDetalle;
        public DateTime FechaDetalle
        {
            get { return _fechaDetalle; }
            set { _fechaDetalle = value; }
        }

        string _estado;
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
