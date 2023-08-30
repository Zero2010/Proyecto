using System;
using System.Collections.Generic;

namespace InventarioNew.Models;

public partial class TipoUbicacion
{
    public int IdTubicacion { get; set; }

    public string? TipoUbicacion1 { get; set; }

    public int? Idlocal { get; set; }

    public virtual Locale? IdlocalNavigation { get; set; }
}
