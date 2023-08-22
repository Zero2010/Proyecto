using System;
using System.Collections.Generic;

#nullable disable

namespace Modelo
{
    public partial class MaestraProducto
    {
        public long IdMproducto { get; set; }
        public string Fecha { get; set; }
        public string Sku { get; set; }
        public string Locales { get; set; }
        public string Tinventario { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string UnidadMedida { get; set; }
        public decimal? Precio { get; set; }
        public string Moneda { get; set; }
        public string SubClase { get; set; }
        public string DescripcionSubClase { get; set; }
        public string Clase { get; set; }
        public string DescripcionClase { get; set; }
        public string SubDepartamento { get; set; }
        public string DescripcionSubDpto { get; set; }
        public string Departamento { get; set; }
        public string DescripcionDpto { get; set; }
        public DateTime? FechaCarga { get; set; }
        public string TipoCodBarra { get; set; }
        public string Ean { get; set; }
        public string Cantidad { get; set; }
    }
}
