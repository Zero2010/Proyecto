using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace TurnoWs.Clases
{

    public class RespuestaWS
    {
        public string CodigoRespuesta { get; set; } = "";
        public string GlosaRespuesta { get; set; } = "";
        public string CantidadEnEspera { get; set; } = "";
        public string TiempoDeEspera { get; set; } = "";
        public string LetraTurno { get; set; } = "";
        public string NumeroTurno { get; set; } = "";
        public string Rut { get; set; } = "";

        public RespuestaWS()
        { }
    }


    public class RespuestaWSUsuario
    {
        public string CodigoRespuesta { get; set; } = "";
        public string GlosaRespuesta { get; set; } = "";
        public string User { get; set; } = "";
        public string Pass { get; set; } = "";
        public string ip { get; set; } = "";

        public RespuestaWSUsuario()
        { }
    }

    public class RespuestaWSGetEdoSesion
    {

        public string CodigoRespuesta { get; set; } = "";
        public string GlosaRespuesta { get; set; } = "";
        public string HNow { get; set; } = "";
        public string Estado { get; set; } = "";
        public string QEspO { get; set; } = "";
        public string TEspO { get; set; } = "";
        public string TEspAO { get; set; } = "";
        public string QEspE { get; set; } = "";
        public string TEspE { get; set; } = "";
        public string TEspAE { get; set; } = "";
        public string QSer { get; set; } = "";
        public string IdSer { get; set; } = "";
        public string IdSerG { get; set; } = "";
        public string Turno { get; set; } = "";
        public string Letra { get; set; } = "";
        public string Serie { get; set; } = "";
        public string TEsp { get; set; } = "";
        public string TEspA { get; set; } = "";
        public string TEspC { get; set; } = "";
        public string TAte { get; set; } = "";
        public string TAteA { get; set; } = "";
        public string Rut { get; set; } = "";
        public string Fono { get; set; } = "";
        public string Cliente { get; set; } = "";

         public RespuestaWSGetEdoSesion()
     {}
    }



    public class RespuestaWSPausa
    {
        public string CodigoRespuesta { get; set; } = "";
        public string GlosaRespuesta { get; set; } = "";

        public string opcion { get; set; }
        public string descripcion { get; set; }

        public List<Pausa> opciones { get; set; }

        public RespuestaWSPausa()
        { }
    }

    public class RespuestaWSGetEdoBase
    {
        public string CodigoRespuesta { get; set; } = "";
        public string GlosaRespuesta { get; set; } = "";
        public string Oficina { get; set; } = "";
        public string Escritorio { get; set; } = "";
        public string IdEje { get; set; } = "";
        public string Ejecutivo { get; set; } = "";
        public string Estado { get; set; } = "";
        public string ClienteInterno { get; set; } = "";
        public string Encuesta { get; set; } = "";

        public RespuestaWSGetEdoBase()
        { }
    }

    public class RespuestaSetIdC
    {
        public string CodigoRespuesta { get; set; } = "";
        public string GlosaRespuesta { get; set; } = "";

        public RespuestaSetIdC()
        { }

    }

    public class RespuestaInicarSession
    {
        public string CodigoRespuesta { get; set; } = "";
        public string GlosaRespuesta { get; set; } = "";
        public string IdOfi { get; set; } = "";
        public string Ofi { get; set; } = "";
        public string Esc { get; set; } = "";
        public string IdEje { get; set; } = "";
        public string Eje { get; set; } = "";
        public string Edo { get; set; } = "";
        public string Encuesta { get; set; } = "";

        public RespuestaInicarSession()
        { }
    }

    public class RespuestaWSMotivo
    {
        public string CodigoRespuesta { get; set; } = "";
        public string GlosaRespuesta { get; set; } = "";

        public string idmotivo { get; set; }
        public string descripcion { get; set; }

        public List<Motivo> motivo { get; set; }

        public RespuestaWSMotivo()
        { }
    }


    public class RespuestaWSPSeries
    {
        public string CodigoRespuesta { get; set; } = "";
        public string GlosaRespuesta { get; set; } = "";

        public string idserie { get; set; }
        public string letra { get; set; }
        public string descripcion { get; set; }

        public List<Series> opciones { get; set; }

        public RespuestaWSPSeries()
        { }
    }



    public class RespuestaWSExcepcion
    {
        public string CodigoRespuesta { get; set; } = "";
        public string GlosaRespuesta { get; set; } = "";
        public string CantidadEnEspera { get; set; } = "";
        public string TiempoDeEspera { get; set; } = "";
        public string Serie { get; set; } = "";
        public string NumeroTurno { get; set; } = "";
        public string Rut { get; set; } = "";

        public RespuestaWSExcepcion()
        { }
    }

    public class RespuestaWSRellamada
    {
        public string CodigoRespuesta { get; set; } = "";
        public string GlosaRespuesta { get; set; } = "";

        public RespuestaWSRellamada()
        { }
    }
}