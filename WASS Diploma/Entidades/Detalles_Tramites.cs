//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detalles_Tramites
    {
        public int Id { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.DateTime> fecha_desde { get; set; }
        public int TramiteId { get; set; }
    
        public virtual Tramites Tramites { get; set; }
    }
}
