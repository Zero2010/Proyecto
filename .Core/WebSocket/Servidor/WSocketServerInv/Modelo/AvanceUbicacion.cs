using System;
using System.Collections.Generic;

#nullable disable

namespace Modelo
{
    public partial class AvanceUbicacion
    {
        public long IdAubicacion { get; set; }
        public int? Ubicacion { get; set; }
        public string DescripcionUbicacion { get; set; }
        public string Motivo { get; set; }
    }
}
