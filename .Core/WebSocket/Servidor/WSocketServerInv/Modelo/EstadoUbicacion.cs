using System;
using System.Collections.Generic;

#nullable disable

namespace Modelo
{
    public partial class EstadoUbicacion
    {
        public EstadoUbicacion()
        {
            Ubicacions = new HashSet<Ubicacion>();
        }

        public long IdEubicacion { get; set; }
        public string DescripcionEstado { get; set; }

        public virtual ICollection<Ubicacion> Ubicacions { get; set; }
    }
}
