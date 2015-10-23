using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class cComprobante
    {
        // Declaro las variables a utilizar en la clase
        //Modelo_Entidades.Comprobante Comprobantecalaculada;
        private static cComprobante instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        // Aplico el patrón de diseño Singleton a la clase
        public static cComprobante ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cComprobante();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cComprobante()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

        // Obtener los Comprobantees
        public List<Modelo_Entidades.Comprobante> ObtenerComprobantes()
        {
            return oModelo_Entidades.Comprobantes.ToList();
        }

        // Elimino a un Comprobante
        public void EliminarComprobante(Modelo_Entidades.Comprobante oComprobante)
        {
            oModelo_Entidades.DeleteObject(oComprobante);
            oModelo_Entidades.SaveChanges();
        }

        // Agrego un Comprobante
        public void AgregarComprobante(Modelo_Entidades.Comprobante oComprobante)
        {
            oModelo_Entidades.AddToComprobantes(oComprobante);
            oModelo_Entidades.SaveChanges();
        }

        // Modifico un Comprobante
        public void ModificarComprobante(Modelo_Entidades.Comprobante oComprobante)
        {
            oModelo_Entidades.ApplyCurrentValues("Comprobantes", oComprobante);
        }

        // Obtengo un comprobante dado su id_movimiento
        public Modelo_Entidades.Comprobante ObtenerComprobante(Modelo_Entidades.Comprobante oComp)
        {
            Modelo_Entidades.Comprobante oComprobante = oModelo_Entidades.Comprobantes.ToList().Find(delegate(Modelo_Entidades.Comprobante fComprobante)
            {
                return fComprobante.Movimientos.Equals(oComp);
            });

            return oComprobante;
        }
    }
}
