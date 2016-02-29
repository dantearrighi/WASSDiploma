using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Controladora
{
    public class cEstado
    {
        // Declaro las variables a utilizar en la clase
        private static cEstado instancia;
        //private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        // Aplico el patrón de diseño Singleton a la clase
        public static cEstado ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cEstado();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cEstado()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

        // Obtener los estados
        public List<Estados> ObtenerEstados()
        {
            return oEstadoss.ToList();
        }

        // Obtener el estado "Habilitado"
        public Estados ObtenerEstadoHabilitado()
        {
            Estados oEstado = oEstadoss.ToList().Find(delegate(Estados fEstado)
            {
                return fEstado.descripcion == "Habilitado";
            });

            return oEstado;
        }

        // Obtener el estado "No Habilitado"
        public Estados ObtenerEstadoNoHabilitado()
        {
            Estados oEstado = oEstadoss.ToList().Find(delegate(Estados fEstado)
            {
                return fEstado.descripcion == "No Habilitado";
            });

            return oEstado;
        }

        // Obtener el estado "Baja"
        public Estados ObtenerEstadoBaja()
        {
            Estados oEstado = oEstadoss.ToList().Find(delegate(Estados fEstado)
            {
                return fEstado.descripcion == "Baja";
            });

            return oEstado;
        }

        /////////////ESTADOS DEL TRAMITE   \\\\\\\\\\\\\\
        
        // Obtener el estado "TRAMITE ACTIVO"
        public Estados ObtenerEstadoTramiteACTIVO()
        {
            Estados oEstado = oEstadoss.ToList().Find(delegate(Estados fEstado)
            {
                return fEstado.descripcion == "Activo";
            });

            return oEstado;
        }

        // Obtener el estado "TRAMITE FINALIZADO"
        public Estados ObtenerEstadoTramiteFINALIZADO()
        {
            Estados oEstado = oEstadoss.ToList().Find(delegate(Estados fEstado)
            {
                return fEstado.descripcion == "Finalizado";
            });

            return oEstado;
        }
    }
}
