using System;
using System.Collections.Generic;

namespace InventarioNew.Models;

public partial class Kardex
{
    public int IdKardex { get; set; }

    public string? Sku { get; set; }

    public DateTime? FechaKardex { get; set; }

    public decimal? CantidadKardex { get; set; }

    public int? Idlocal { get; set; }

    public virtual Locale? IdlocalNavigation { get; set; }
}
