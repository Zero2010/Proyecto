using System;
using System.Collections.Generic;

#nullable disable

namespace Modelo
{
    public partial class McapturaXCdato
    {
        public long IdCaptura { get; set; }
        public long IdMcaptura { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public long? IdUsuario { get; set; }

        public virtual CapturaDato IdCapturaNavigation { get; set; }
        public virtual ModificacionCaptura IdMcapturaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
