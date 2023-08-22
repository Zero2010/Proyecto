using System;
using System.Collections.Generic;

#nullable disable

namespace Modelo
{
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            UsuarioXTusuarios = new HashSet<UsuarioXTusuario>();
        }

        public long IdTusuario { get; set; }
        public string DescripcionUsuario { get; set; }

        public virtual ICollection<UsuarioXTusuario> UsuarioXTusuarios { get; set; }
    }
}
