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
    
    public partial class Habitacion_x_Motel_Result
    {
        public long IdTHabitacion { get; set; }
        public long IdSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public string DescripcionSucursal { get; set; }
        public string DescripcionProducto { get; set; }
        public long IdProducto { get; set; }
        public string precio1 { get; set; }
        public string precio2 { get; set; }
        public Nullable<int> Descuento { get; set; }
        public string HabitacionPath { get; set; }
    }
}
