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
    
    public partial class MCaptura_x_CDatos
    {
        public long IdCaptura { get; set; }
        public long IdMCaptura { get; set; }
        public Nullable<System.DateTime> FechaActualizacion { get; set; }
        public Nullable<long> IdUsuario { get; set; }
    
        public virtual CapturaDatos CapturaDatos { get; set; }
        public virtual ModificacionCaptura ModificacionCaptura { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
