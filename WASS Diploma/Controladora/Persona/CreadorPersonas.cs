using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo_Entidades;

namespace Controladora.Persona
{
    public class CreadorPersonas
    {

            public virtual Modelo_Entidades.Persona AltaPersona(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "abogado":
                    return new Abogado();
                case "cliente":
                    return new Cliente();
             
                default:
                    throw new ArgumentException("Tipo de persona desconocido");
            }
                
                                
           
        }
    }
}
