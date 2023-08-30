using System;
using System.Collections.Generic;

namespace InventarioNew.Models;

public partial class Producto
{
    public int IdProductos { get; set; }

    public string? DescripcionProductos { get; set; }

    public decimal? Precio { get; set; }

    public string? Moneda { get; set; }

    public string? Clase { get; set; }

    public string? DescripcionClase { get; set; }

    public string? SubClase { get; set; }

    public string? DescripcionSubClase { get; set; }

    public bool? IsEstado { get; set; }

    public int? IdEmpresa { get; set; }

    public virtual Empresa? IdEmpresaNavigation { get; set; }
}
