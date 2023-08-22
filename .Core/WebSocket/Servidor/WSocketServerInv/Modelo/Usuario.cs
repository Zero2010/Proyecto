using System;
using System.Collections.Generic;

#nullable disable

namespace Modelo
{
    public partial class Usuario
    {
        public Usuario()
        {
            McapturaXCdatos = new HashSet<McapturaXCdato>();
            UsuarioXTusuarios = new HashSet<UsuarioXTusuario>();
        }

        public long IdUsuario { get; set; }
        public string Usuario1 { get; set; }
        public string Password { get; set; }
        public DateTime? FechaIngreso { get; set; }

        public virtual ICollection<McapturaXCdato> McapturaXCdatos { get; set; }
        public virtual ICollection<UsuarioXTusuario> UsuarioXTusuarios { get; set; }
    }
}
