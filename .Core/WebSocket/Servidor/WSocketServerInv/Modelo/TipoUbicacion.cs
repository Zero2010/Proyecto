using System;
using System.Collections.Generic;

#nullable disable

namespace Modelo
{
    public partial class TipoUbicacion
    {
        public TipoUbicacion()
        {
            Ubicacions = new HashSet<Ubicacion>();
        }

        public long IdTubicacion { get; set; }
        public string DescripcionUbicacion { get; set; }

        public virtual ICollection<Ubicacion> Ubicacions { get; set; }
    }
}
