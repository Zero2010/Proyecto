using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnoWs.Clases
{

    public enum Commands
    {
        LogIn = 1,
        LogOut=2,
        EstadoSesion = 11,
        PedirTurno = 31,
        ReLlamarTurno = 32,
        AnularTurno = 33,
        ProcesarTurno = 34,
        FinalizarTurno = 35,
        Excepcion = 37,
        VentaArticulo = 45,
        AnulacionMultiple = 46,
        OficinaCierre = 47,
        Error = 999,
        DevivarAtencion=36,
        GetPausas = 20,
        SetPausas= 30,
        SetEdoSesion=11,
        GetMotivos=22,
        SetIdC=38,
        GetEdoBase=10,
        GetSeries=21
    }
}
