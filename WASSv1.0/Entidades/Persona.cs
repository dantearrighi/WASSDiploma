using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
  public class Persona
    {
        string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        string _Apellido;
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        string _DniCuil;
        public string DniCuil
        {
            get { return _DniCuil; }
            set { _DniCuil = value; }

        }

        string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        string _tel1;
        public string Tel1
        {
            get { return _tel1; }
            set { _tel1 = value; }
        }

        string _tel2;
        public string Tel2
        {
            get { return _tel2; }
            set { _tel2 = value; }
        }
    }
}
