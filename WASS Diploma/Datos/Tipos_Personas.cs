//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tipos_Personass
    {
        public Tipos_Personass()
        {
            this.Personas = new HashSet<Personas>();
        }
    
        public int Id { get; set; }
        public string descripcion { get; set; }
    
        public virtual ICollection<Personas> Personas { get; set; }
    }
}
