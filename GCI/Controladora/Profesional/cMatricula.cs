﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class cMatricula
    {
        // Declaro las variables a utilizar en la clase
        private static cMatricula instancia;
        private Modelo_Entidades.GCIEntidades oModelo_Entidades;

        // Aplico el patrón de diseño Singleton a la clase
        public static cMatricula ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cMatricula();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cMatricula()
        {
            oModelo_Entidades = Modelo_Entidades.GCIEntidades.ObtenerInstancia();
        }

        // Dar de alta a una nueva matricula
        public void Alta(Modelo_Entidades.Matricula oMatricula)
        {
            oModelo_Entidades.AddToMatriculas(oMatricula);
            oModelo_Entidades.SaveChanges();
        }

        // Modifico a una matricula
        public void Modificacion(Modelo_Entidades.Matricula oMatricula)
        {
            oModelo_Entidades.ApplyCurrentValues("Matriculas", oMatricula);
            oModelo_Entidades.SaveChanges();
        }

        // Obtener las matriculas
        public List<Modelo_Entidades.Matricula> ObtenerMatriculas()
        {
            return oModelo_Entidades.Matriculas.ToList();
        }

        // Obtener los titulos de un profesional
        public List<Modelo_Entidades.Titulo> BuscarTitulosPorProf(Modelo_Entidades.Profesional oProfesional)
        {
            var Consulta = from oMatricula in oModelo_Entidades.Matriculas.ToList()
                           where oMatricula.Profesional == oProfesional
                           select oMatricula.Legajo_Academico.Titulo;
            return (List<Modelo_Entidades.Titulo>)Consulta.ToList();
        }

        // Obtener los planes que tiene asociada una matrícula. Esto ve todos los planes que tienen hasta ahora los titulos de los profesionales.
        public List<Modelo_Entidades.Plan> BuscarPlanesPorTit(Modelo_Entidades.Titulo oTitulo)
        {
            var Consulta = from oMatricula in oModelo_Entidades.Matriculas.ToList()
                           where oMatricula.Legajo_Academico.Titulo == oTitulo
                           select oMatricula.Legajo_Academico.Plan;
            return (List<Modelo_Entidades.Plan>)Consulta.ToList();
        }

        // Obtengo el último numero de Id de las matrículas
        public Modelo_Entidades.Matricula ObtenerUltimoId()
        {
            return oModelo_Entidades.Matriculas.ToList().Last();
        }
    }
}
