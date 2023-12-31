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
    
    public partial class Ubicacion
    {
        public long IdUbicacion { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> RangoBajo { get; set; }
        public Nullable<int> RangoAlto { get; set; }
        public Nullable<int> TotalUbicacion { get; set; }
        public Nullable<decimal> PorcentajeCerrado { get; set; }
        public Nullable<decimal> PorcentajeNulo { get; set; }
        public Nullable<decimal> PorcentajeAbierto { get; set; }
        public Nullable<long> IdTUbicacion { get; set; }
        public Nullable<long> IdEUbicacion { get; set; }
    
        public virtual EstadoUbicacion EstadoUbicacion { get; set; }
        public virtual TipoUbicacion TipoUbicacion { get; set; }
    }
}
