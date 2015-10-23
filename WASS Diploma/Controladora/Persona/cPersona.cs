using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class cPersona
    {
         // Declaro las variables a utilizar en la clase
        private static cPersona instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        // Aplico el patrón de diseño Singleton a la clase
        public static cPersona ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cPersona();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cPersona()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

        // Dar de alta a una nueva Persona
        public void Alta(Modelo_Entidades.Persona oPersona)
        {
            
            oModelo_Entidades.AddToPersonas(oPersona);
            oModelo_Entidades.SaveChanges();
        }

        // Modificar a una Persona
        public void Modificacion(Modelo_Entidades.Persona oPersona)
        {
            oModelo_Entidades.ApplyCurrentValues("Personas", oPersona);
            oModelo_Entidades.SaveChanges();
        }

        // Obtener lista de Personas
        public List<Modelo_Entidades.Persona> ObtenerPersonas()
        {
            return oModelo_Entidades.Personas.ToList();
        }

        // Obtener lista de personas filtrando según el DNI ingresado
        public List<Modelo_Entidades.Persona> FiltrarPorDNI(string dni)
        {
            var Consulta = from oPersona in oModelo_Entidades.Personas.ToList()
                           where oPersona.dni_cuil.ToString().StartsWith(dni)
                           select oPersona;
            return (List<Modelo_Entidades.Persona>)Consulta.ToList();
        }


        // Obtener lista de personas filtrando según el apellido y nombre ingresado
        public List<Modelo_Entidades.Persona> FiltrarPorNyA(string nya)
        {
            var Consulta = from oPersona in oModelo_Entidades.Personas.ToList()
                           where oPersona.apellido_nombre.Contains(nya)
                           select oPersona;
            return (List<Modelo_Entidades.Persona>)Consulta.ToList();
        }

        // Valido que una Persona no exista
        public Boolean ValidarPersona(int pers_dni)
        {
            Modelo_Entidades.Persona oPersona = oModelo_Entidades.Personas.ToList().Find(delegate(Modelo_Entidades.Persona fPersona)
            {
                return fPersona.dni_cuil == pers_dni;
            });

            if (oPersona == null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // Obtengo UN OBJETO Persona dado su dni
        public Modelo_Entidades.Persona ObtenerPersona(int dni)
        {
            Modelo_Entidades.Persona oPersona = oModelo_Entidades.Personas.ToList().Find(delegate(Modelo_Entidades.Persona fPersona)
            {
                return fPersona.dni_cuil == dni;
            });

            return oPersona;
        }
    }
}
