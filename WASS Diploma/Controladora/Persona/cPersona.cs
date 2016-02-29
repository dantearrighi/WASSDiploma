using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
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
        public void Alta(Personas oPersona)
        {
            oModelo_Entidades.AddToPersonas(oPersona);
            oModelo_Entidades.SaveChanges();
        }


        
        // Modificar a un Persona
        public void Modificacion(Personas oPersona)
        {
            oModelo_Entidades.ApplyCurrentValues("Personas", oPersona);
            oModelo_Entidades.SaveChanges();
        }

        // Obtener los Personas
        public List<Personas> ObtenerPersonas()
        {
            return oPersonass.ToList();
        }

        // Voy filtrando a los Personas según el DNI introducido
        public List<Personas> FiltrarPorDNI(string dni)
        {
            var Consulta = from oPersona in oPersonass.ToList()
                           where oPersona.dni.ToString().StartsWith(dni)
                           select oPersona;
            return (List<Personas>)Consulta.ToList();
        }

        

        // Voy filtrando a los Personas según el apellido y nombre introducido
        public List<Personas> FiltrarPorNyA(string nya)
        {
            var Consulta = from oPersona in oPersonass.ToList()
                           where oPersona.nombre_apellido.ToLower().Contains(nya)
                           select oPersona;
            return (List<Personas>)Consulta.ToList();
        }

        // Valido que un Persona no exista
        public Boolean ValidarPersona(int prof_dni)
        {
            Personas oPersona = oPersonass.ToList().Find(delegate(Personas fPersona)
            {
                return fPersona.dni == prof_dni;
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

        // Obtengo un Persona dado su dni
        public Personas ObtenerPersona(int dni)
        {
            Personas oPersona = oPersonass.ToList().Find(delegate(Personas fPersona)
            {
                return fPersona.dni == dni;
            });

            return oPersona;
        }

       

    }
}
