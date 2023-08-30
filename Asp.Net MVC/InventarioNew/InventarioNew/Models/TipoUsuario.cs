using System;
using System.Collections.Generic;

namespace InventarioNew.Models;

public partial class TipoUsuario
{
    public int IdTipoUsuario { get; set; }

    public string? DescripcionTipoUsuario { get; set; }

    public string? Link { get; set; }

    public virtual ICollection<UserTipoUsuario> UserTipoUsuarios { get; } = new List<UserTipoUsuario>();
}
