using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    class RespuestaAtenciones
    {
        public string idOficina { get; set; } = "";
        public string IdSerie { get; set; } = "";
        public string IdEsc { get; set; } = "";
        public string IdEje { get; set; } = "";
        public string Turno { get; set; } = "";
        public string FH_Emi { get; set; } = "";
        public string FH_AteIni { get; set; } = "";
        public string FH_AteFin { get; set; } = "";
        public string Rut { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Cliente { get; set; } = "";
        public string TpoAte { get; set; } = "";

        public RespuestaAtenciones()
        { }
    }

    class RespuestaMotivos
    {
        public string idOficina { get; set; } = "";
        public string IdSerie { get; set; } = "";
        public string Turno { get; set; } = "";
        public string IdMotivo { get; set; } = "";
        public string FH_Mot { get; set; } = "";
        public string Cantidad { get; set; } = "";

        public RespuestaMotivos()
        { }
    }

    class RespuestaEstados
    {
        public string idOficina { get; set; } = "";
        public string IdEje { get; set; } = "";
        public string IdEsc { get; set; } = "";
        public string Evento { get; set; } = "";
        public string FH_Eve { get; set; } = "";
        public string IdPausa { get; set; } = "";

        public RespuestaEstados()
        { }
    }
}