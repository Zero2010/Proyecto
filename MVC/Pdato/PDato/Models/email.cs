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
    
    public partial class Email
    {
        public Email()
        {
            this.Sucursal = new HashSet<Sucursal>();
        }
    
        public long IdEmail { get; set; }
        public string Email1 { get; set; }
    
        public virtual ICollection<Sucursal> Sucursal { get; set; }
    }
}
