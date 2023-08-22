using System;
using System.Collections.Generic;

#nullable disable

namespace Modelo
{
    public partial class UsuarioXTusuario
    {
        public long IdUsuario { get; set; }
        public long IdTusuario { get; set; }

        public virtual TipoUsuario IdTusuarioNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
