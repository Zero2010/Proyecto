using System;
using System.Collections.Generic;

namespace InventarioNew.Models;

public partial class Empresa
{
    public int IdEmpresa { get; set; }

    public string? NombreEmpresa { get; set; }

    public string? RutEmpresa { get; set; }

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();

    public virtual ICollection<UserTipoUsuario> UserTipoUsuarios { get; } = new List<UserTipoUsuario>();

    public virtual ICollection<Locale> Idlocals { get; } = new List<Locale>();
}
