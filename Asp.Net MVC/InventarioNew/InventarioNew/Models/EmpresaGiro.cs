using System;
using System.Collections.Generic;

namespace InventarioNew.Models;

public partial class EmpresaGiro
{
    public int IdEmpresa { get; set; }

    public int IdGiro { get; set; }

    public virtual Giro IdGiroNavigation { get; set; } = null!;
}
