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
    
    public partial class Usuario_x_Cargo_x_TCuenta
    {
        public long IdUsuario { get; set; }
        public long IdCargo { get; set; }
        public long IdTipoCuenta { get; set; }
    
        public virtual Cargo Cargo { get; set; }
        public virtual TipoCuenta TipoCuenta { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
