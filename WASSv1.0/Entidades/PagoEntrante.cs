using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;

namespace Entidades
{
    public class PagoEntrante
    {

        private SqlMoney _valor;
        public SqlMoney Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        private DateTime _fecha;
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private string _detalle;
        public string Detalle
        {
            get { return _detalle; }
            set { _detalle = value; }
        }
        int _idTramite;
        public int IdTramite
        {
            get { return _idTramite; }
            set { _idTramite = value; }
        }

        string _DniCuilCliente;
        public string DniCuilCliente
        {
            get { return _DniCuilCliente; }
            set { _DniCuilCliente = value; }

        }
        
    }
}
