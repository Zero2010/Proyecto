using System;
using System.Collections.Generic;

#nullable disable

namespace Modelo
{
    public partial class CapturaDato
    {
        public CapturaDato()
        {
            McapturaXCdatos = new HashSet<McapturaXCdato>();
        }

        public long IdCaptura { get; set; }
        public string Local { get; set; }
        public string TipoInventario { get; set; }
        public string Ubicacion { get; set; }
        public string Ean { get; set; }
        public string Descripcion { get; set; }
        public string Sku { get; set; }
        public string Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public string Unidad { get; set; }
        public string RutOperador { get; set; }
        public DateTime? FechaCaptura { get; set; }
        public string LugarCaptura { get; set; }
        public string DescripcionCaptura { get; set; }

        public virtual ICollection<McapturaXCdato> McapturaXCdatos { get; set; }
    }
}
