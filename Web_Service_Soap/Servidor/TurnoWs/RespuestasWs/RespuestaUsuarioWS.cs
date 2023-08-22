using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnoWs.RespuestasWs
{
    public class RespuestaUsuarioWS
    {
        public string Idescritorio { get; set; } = "";
        public string user { get; set; } = "";
        public string pass { get; set; } = "";
        public string ip { get; set; } = "";
        public RespuestaUsuarioWS()
        { }
    }
}