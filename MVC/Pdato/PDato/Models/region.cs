//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PDato.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Region
    {
        public Region()
        {
            this.Comuna = new HashSet<Comuna>();
        }
    
        public long IdRegion { get; set; }
        public string Region1 { get; set; }
    
        public virtual ICollection<Comuna> Comuna { get; set; }
    }
}
