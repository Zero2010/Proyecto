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
    
    public partial class CapturaDatos
    {
        public CapturaDatos()
        {
            this.MCaptura_x_CDatos = new HashSet<MCaptura_x_CDatos>();
        }
    
        public long IdCaptura { get; set; }
        public string Local { get; set; }
        public string TipoInventario { get; set; }
        public string Ubicacion { get; set; }
        public string Ean { get; set; }
        public string Descripcion { get; set; }
        public string Sku { get; set; }
        public string Cantidad { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public string Unidad { get; set; }
        public string RutOperador { get; set; }
        public Nullable<System.DateTime> FechaCaptura { get; set; }
        public string LugarCaptura { get; set; }
        public string DescripcionCaptura { get; set; }
    
        public virtual ICollection<MCaptura_x_CDatos> MCaptura_x_CDatos { get; set; }
    }
}
