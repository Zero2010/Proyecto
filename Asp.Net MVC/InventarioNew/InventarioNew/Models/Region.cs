using System;
using System.Collections.Generic;

namespace InventarioNew.Models;

public partial class Region
{
    public int IdRegion { get; set; }

    public string? Region1 { get; set; }

    public virtual ICollection<Comuna> Comunas { get; } = new List<Comuna>();
}
