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
    
    public partial class Permisos
    {
        public Permisos()
        {
            this.Perfiles = new HashSet<Perfiles>();
        }
    
        public int id { get; set; }
        public string descripcion { get; set; }
    
        public virtual ICollection<Perfiles> Perfiles { get; set; }
    }
}
