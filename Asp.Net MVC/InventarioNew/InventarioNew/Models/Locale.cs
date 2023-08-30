using System;
using System.Collections.Generic;

namespace InventarioNew.Models;

public partial class Locale
{
    public int Idlocal { get; set; }

    public string? NombreLocal { get; set; }

    public bool? IsEstado { get; set; }

    public virtual ICollection<Captura> Capturas { get; } = new List<Captura>();

    public virtual ICollection<Kardex> Kardices { get; } = new List<Kardex>();

    public virtual ICollection<TipoUbicacion> TipoUbicacions { get; } = new List<TipoUbicacion>();

    public virtual ICollection<Ubicacion> Ubicacions { get; } = new List<Ubicacion>();

    public virtual ICollection<Direccion> IdDireccions { get; } = new List<Direccion>();

    public virtual ICollection<Empresa> IdEmpresas { get; } = new List<Empresa>();
}
