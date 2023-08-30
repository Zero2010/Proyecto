using System;
using System.Collections.Generic;

namespace InventarioNew.Models;

public partial class Ubicacion
{
    public int IdUbicacion { get; set; }

    public string? DescripcionUbicacion { get; set; }

    public int? RangoBajo { get; set; }

    public int? RangoAlto { get; set; }

    public string? Area { get; set; }

    public string? Dpto { get; set; }

    public string? Lineal { get; set; }

    public string? Metro { get; set; }

    public string? Pasillo { get; set; }

    public int? Idlocal { get; set; }

    public virtual Locale? IdlocalNavigation { get; set; }
}
