using System;
using System.Collections.Generic;

namespace InventarioNew.Models;

public partial class Usuario
{
    public int IdUser { get; set; }

    public string? User { get; set; }

    public string? Password { get; set; }

    public DateTime? FechaCreation { get; set; }

    public DateTime? FechaUpdate { get; set; }

    public DateTime? FechaDelete { get; set; }

    public bool? IsEstado { get; set; }

    public virtual ICollection<UserTipoUsuario> UserTipoUsuarios { get; } = new List<UserTipoUsuario>();
}
