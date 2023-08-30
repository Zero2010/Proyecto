using System;
using System.Collections.Generic;

namespace InventarioNew.Models;

public partial class UserTipoUsuario
{
    public int IdUser { get; set; }

    public int IdTipoUsuario { get; set; }

    public int? IdEmpresa { get; set; }

    public virtual Empresa? IdEmpresaNavigation { get; set; }

    public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; } = null!;

    public virtual Usuario IdUserNavigation { get; set; } = null!;
}
