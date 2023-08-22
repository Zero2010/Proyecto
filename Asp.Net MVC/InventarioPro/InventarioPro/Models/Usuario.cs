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
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Captura = new HashSet<Captura>();
            this.TipoUsuario = new HashSet<TipoUsuario>();
        }
    
        public int IdUsuario { get; set; }
        public string Usuario1 { get; set; }
        public string Clave { get; set; }
        public Nullable<System.DateTime> FCreacion { get; set; }
        public Nullable<System.DateTime> FModificacion { get; set; }
        public Nullable<bool> IsEstado { get; set; }
        public string Ip { get; set; }
        public Nullable<int> IdLocal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Captura> Captura { get; set; }
        public virtual Locales Locales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoUsuario> TipoUsuario { get; set; }
    }
}
