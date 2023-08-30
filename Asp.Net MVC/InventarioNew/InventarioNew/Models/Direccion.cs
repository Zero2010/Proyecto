using System;
using System.Collections.Generic;

namespace InventarioNew.Models;

public partial class Direccion
{
    public int IdDireccion { get; set; }

    public string? Direccion1 { get; set; }

    public int? IdComuna { get; set; }

    public virtual Comuna? IdComunaNavigation { get; set; }

    public virtual ICollection<Locale> Idlocals { get; } = new List<Locale>();
}
