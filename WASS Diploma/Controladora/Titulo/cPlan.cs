using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class cPlan
    {
        // Declaro las variables a utilizar en la clase
        private static cPlan instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        // Aplico el patrón de diseño Singleton a la clase
        public static cPlan ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cPlan();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cPlan()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

        // Agrego un plan
        public void AgregarPlan(Modelo_Entidades.Plan oPlan)
        {
            oModelo_Entidades.AddToPlanes(oPlan);
            oModelo_Entidades.SaveChanges();
        }

        // Elimino a un plan
        public void EliminarPlan(Modelo_Entidades.Plan oPlan)
        {
            oModelo_Entidades.DeleteObject(oPlan);
            oModelo_Entidades.SaveChanges();
        }

        // Modifico un plan
        public void ModificarPlan(Modelo_Entidades.Plan oPlan)
        {
            oModelo_Entidades.ApplyCurrentValues("Planes", oPlan);
            oModelo_Entidades.SaveChanges();
        }

        // Obtener los planes
        public List<Modelo_Entidades.Plan> ObtenerPlanes()
        {
            return oModelo_Entidades.Planes.ToList();
        }
    }
}
