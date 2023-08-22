using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using TPSejeLMSP.Communications;

namespace TurnoWs.Clases
{
    public class IngresoUsuario
    {
        private SocketWrapper _socket;

        public IngresoUsuario(string host, int port)
        {
            _socket = new SocketWrapper(host, port);
        }

        public Communication validarusu(string idescritorio, string user, string pass)
        {
            string data, response;

            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.EstadoSesion, new List<string> { idescritorio,user,pass });

            Log.WriteLine(LogType.Query, data, Commands.EstadoSesion);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.EstadoSesion);

            return Communication.Parse(response);
        }
    }
}