//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vista_Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Localidade
    {
        public Localidade()
        {
            this.Direcciones = new HashSet<Direccione>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public int cp { get; set; }
        public int Provincia_id { get; set; }
    
        public virtual ICollection<Direccione> Direcciones { get; set; }
        public virtual Provincia Provincia { get; set; }
    }
}
