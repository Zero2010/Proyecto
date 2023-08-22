using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPSejeLMSP.Communications
{
    public enum Commands
    {
        Pausa= 300,
        motivo301= 301,
        LogIn = 310,
        motivo311=311,
        motivo320=320,
        LogOut = 313,
        FinalizarTurno = 328,
        Error = 999,
    }
}