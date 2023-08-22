using System;
using System.Collections.Generic;

#nullable disable

namespace Modelo
{
    public partial class AvanceCaptura
    {
        public long IdAcaptura { get; set; }
        public int? CantidadRegistros { get; set; }
        public string Ubicacion { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? PorcentajeTotal { get; set; }
    }
}
