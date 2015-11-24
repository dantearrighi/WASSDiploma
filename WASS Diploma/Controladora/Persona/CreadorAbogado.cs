using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Persona
{
    public class CreadorAbogado
    {

        public virtual Modelo_Entidades.Persona AltaPersona(string tipo)
        {
            Modelo_Entidades.Abogado oPersona = new Modelo_Entidades.Abogado();

            return oPersona;

        }
    }
}
