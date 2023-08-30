using System;
using System.Collections.Generic;

namespace InventarioNew.Models;

public partial class Captura
{
    public int IdCaptura { get; set; }

    public DateTime? FechaCaptura { get; set; }

    public decimal? CantidadCaptura { get; set; }

    public int? Idlocal { get; set; }

    public virtual Locale? IdlocalNavigation { get; set; }
}
