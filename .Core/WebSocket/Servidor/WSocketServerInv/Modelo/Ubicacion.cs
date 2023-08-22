using System;
using System.Collections.Generic;

#nullable disable

namespace Modelo
{
    public partial class Ubicacion
    {
        public long IdUbicacion { get; set; }
        public string Descripcion { get; set; }
        public int? RangoBajo { get; set; }
        public int? RangoAlto { get; set; }
        public int? TotalUbicacion { get; set; }
        public decimal? PorcentajeCerrado { get; set; }
        public decimal? PorcentajeNulo { get; set; }
        public decimal? PorcentajeAbierto { get; set; }
        public long? IdTubicacion { get; set; }
        public long? IdEubicacion { get; set; }

        public virtual EstadoUbicacion IdEubicacionNavigation { get; set; }
        public virtual TipoUbicacion IdTubicacionNavigation { get; set; }
    }
}
