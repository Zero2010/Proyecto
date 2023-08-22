using System;
using System.Collections.Generic;

#nullable disable

namespace Modelo
{
    public partial class ModificacionCaptura
    {
        public ModificacionCaptura()
        {
            McapturaXCdatos = new HashSet<McapturaXCdato>();
        }

        public long IdMcaptura { get; set; }
        public int? Conteo1 { get; set; }
        public DateTime? Fecha1 { get; set; }
        public int? Conteo2 { get; set; }
        public DateTime? Fecha2 { get; set; }

        public virtual ICollection<McapturaXCdato> McapturaXCdatos { get; set; }
    }
}
