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
    using System.Collections.Generic;
    
    public partial class Captura_Local_Producto
    {
        public int IdCaptura { get; set; }
        public int IdLocal { get; set; }
        public int IdProducto { get; set; }
        public Nullable<bool> IsEstado { get; set; }
    
        public virtual Captura Captura { get; set; }
        public virtual Locales Locales { get; set; }
        public virtual Productos Productos { get; set; }
    }
}
