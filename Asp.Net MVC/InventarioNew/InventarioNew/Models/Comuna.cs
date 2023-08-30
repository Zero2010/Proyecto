using System;
using System.Collections.Generic;

namespace InventarioNew.Models;

public partial class Comuna
{
    public int IdComuna { get; set; }

    public string? Comuna1 { get; set; }

    public int? IdRegion { get; set; }

    public virtual ICollection<Direccion> Direccions { get; } = new List<Direccion>();

    public virtual Region? IdRegionNavigation { get; set; }
}
