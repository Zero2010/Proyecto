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
    
    public partial class PreguntaSecreta
    {
        public PreguntaSecreta()
        {
            this.DatosPersonales = new HashSet<DatosPersonales>();
        }
    
        public long IdPSecreta { get; set; }
        public string PreguntaSecreta1 { get; set; }
    
        public virtual ICollection<DatosPersonales> DatosPersonales { get; set; }
    }
}
