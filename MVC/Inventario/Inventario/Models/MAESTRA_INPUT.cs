//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventario.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MAESTRA_INPUT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAESTRA_INPUT()
        {
            this.MODIFICAR_CAPTURA = new HashSet<MODIFICAR_CAPTURA>();
        }
    
        public int ID_INPUT { get; set; }
        public string LOCAL { get; set; }
        public string TIPO_INVENTARIO { get; set; }
        public Nullable<int> PATENTE { get; set; }
        public string EAN { get; set; }
        public string DESCRIPCION { get; set; }
        public string SKU { get; set; }
        public string CANTIDAD { get; set; }
        public Nullable<decimal> PRECIO { get; set; }
        public string UNIDAD { get; set; }
        public string RUT { get; set; }
        public string HORA { get; set; }
        public byte[] FECHA { get; set; }
        public Nullable<int> ID_EST { get; set; }
        public Nullable<int> ID_BODEGA { get; set; }
        public string DESCRIPCION_PAT { get; set; }
    
        public virtual ESTADO_MAESTRA ESTADO_MAESTRA { get; set; }
        public virtual TIPO_UBICACION TIPO_UBICACION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MODIFICAR_CAPTURA> MODIFICAR_CAPTURA { get; set; }
    }
}
