using System;
using System.Collections.Generic;

namespace InventarioNew.Models;

public partial class Giro
{
    public int IdGiro { get; set; }

    public string? GiroEmpresa { get; set; }

    public virtual ICollection<EmpresaGiro> EmpresaGiros { get; } = new List<EmpresaGiro>();
}
