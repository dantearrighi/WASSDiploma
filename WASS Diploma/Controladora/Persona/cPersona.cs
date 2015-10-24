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

        // Dar de alta a un nuevo Persona
        public void Alta(Modelo_Entidades.Persona oPersona)
        {
            oModelo_Entidades.AddToPersonas(oPersona);
            oModelo_Entidades.SaveChanges();
        }

        // Modificar a un Persona
        public void Modificacion(Modelo_Entidades.Persona oPersona)
        {
            oModelo_Entidades.ApplyCurrentValues("Personas", oPersona);
            oModelo_Entidades.SaveChanges();
        }

        // Obtener los Personas
        public List<Modelo_Entidades.Persona> ObtenerPersonas()
        {
            return oModelo_Entidades.Personas.ToList();
        }

        // Voy filtrando a los Personas según el DNI introducido
        public List<Modelo_Entidades.Persona> FiltrarPorDNI(string dni)
        {
            var Consulta = from oPersona in oModelo_Entidades.Personas.ToList()
                           where oPersona.dni.ToString().StartsWith(dni)
                           select oPersona;
            return (List<Modelo_Entidades.Persona>)Consulta.ToList();
        }

        

        // Voy filtrando a los Personas según el apellido y nombre introducido
        public List<Modelo_Entidades.Persona> FiltrarPorNyA(string nya)
        {
            var Consulta = from oPersona in oModelo_Entidades.Personas.ToList()
                           where oPersona.nombre_apellido.Contains(nya)
                           select oPersona;
            return (List<Modelo_Entidades.Persona>)Consulta.ToList();
        }

        // Valido que un Persona no exista
        public Boolean ValidarPersona(int prof_dni)
        {
            Modelo_Entidades.Persona oPersona = oModelo_Entidades.Personas.ToList().Find(delegate(Modelo_Entidades.Persona fPersona)
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
        public Modelo_Entidades.Persona ObtenerPersona(int dni)
        {
            Modelo_Entidades.Persona oPersona = oModelo_Entidades.Personas.ToList().Find(delegate(Modelo_Entidades.Persona fPersona)
            {
                return fPersona.dni == dni;
            });

            return oPersona;
        }

       

    }
}
