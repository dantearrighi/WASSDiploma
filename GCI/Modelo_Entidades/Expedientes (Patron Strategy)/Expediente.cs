using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo_Entidades
{
    public abstract partial class Expediente
    {
        //private Modelo_Entidades.Expediente oExpediente;

        //public void CambiarExpediente(Expediente nuevoexpediente)
        //{
        //    this.oExpediente = nuevoexpediente;
        //}

        //public List<Modelo_Entidades.Liquidacion> Calcular()
        //{
        //    List<Modelo_Entidades.Liquidacion> ListaLiquidaciones = oExpediente.Liquidaciones.OrderBy(x => x.Id).ToList();
        //    ListaLiquidaciones = this.oExpediente.Calcular_Valor(ListaLiquidaciones);
        //    return ListaLiquidaciones;
        //}

        public abstract List<Modelo_Entidades.Liquidacion> Calcular_Valor(List<Modelo_Entidades.Liquidacion> ListaLiquidaciones);
    }
}
