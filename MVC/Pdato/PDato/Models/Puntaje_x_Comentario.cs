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
    
    public partial class Puntaje_x_Comentario
    {
        public long IdPuntaje { get; set; }
        public long IdUsuario { get; set; }
        public long IdComentario { get; set; }
        public Nullable<int> Valor { get; set; }
    
        public virtual Comentario Comentario { get; set; }
        public virtual Puntaje Puntaje { get; set; }
    }
}
