//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class ModificacionCaptura
    {
        public ModificacionCaptura()
        {
            this.MCaptura_x_CDatos = new HashSet<MCaptura_x_CDatos>();
        }
    
        public long IdMCaptura { get; set; }
        public Nullable<int> Conteo1 { get; set; }
        public Nullable<System.DateTime> Fecha1 { get; set; }
        public Nullable<int> Conteo2 { get; set; }
        public Nullable<System.DateTime> Fecha2 { get; set; }
    
        public virtual ICollection<MCaptura_x_CDatos> MCaptura_x_CDatos { get; set; }
    }
}
