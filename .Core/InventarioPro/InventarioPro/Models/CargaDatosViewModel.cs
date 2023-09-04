using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventarioPro.Models
{
    public class CargaDatosViewModel
    {
        public int registroOk           { get; set; }
        public int registroError        { get; set; }
        public decimal porcentajeOK     { get; set; }
        public decimal porcentajeError  { get; set; }
    }
}