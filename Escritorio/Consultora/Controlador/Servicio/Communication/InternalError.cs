using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPSejeLMSP.Communications
{
    public class InternalError
    {
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public string LetraTurno { get; set; }
        public int? NumeroTurno { get; set; }
    }
}