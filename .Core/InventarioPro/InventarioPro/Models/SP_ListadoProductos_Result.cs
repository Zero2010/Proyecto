//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventarioPro.Models
{
    using System;
    
    public partial class SP_ListadoProductos_Result
    {
        public int IdProducto { get; set; }
        public string Sku { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public string Moneda { get; set; }
        public string Ean { get; set; }
        public Nullable<bool> IsEstado { get; set; }
        public string Clase { get; set; }
        public string DescripcionClase { get; set; }
        public string SubClase { get; set; }
        public string DescripcionSubClase { get; set; }
        public Nullable<int> IdLocal { get; set; }
        public Nullable<int> IdUbicacion { get; set; }
        public Nullable<int> IdTUbicacion { get; set; }
    }
}
