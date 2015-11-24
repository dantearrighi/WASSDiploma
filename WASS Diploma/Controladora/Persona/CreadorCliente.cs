using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Persona
{
  public  class CreadorCliente
    {


      public Modelo_Entidades.Persona AltaPersona(string tipo)
      {
          Modelo_Entidades.Cliente oPersona = new Modelo_Entidades.Cliente();

          return oPersona;

      }
    }
}
