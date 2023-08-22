using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using TurnoWs.Extensions;

namespace TurnoWs.Clases
{
    public enum LogType
    {
        Inicio,
        Request,
        Response,
        Fin,
        Error,
        Parametros,
        Conexion,
        Desconexion,
        Timeout,
        InicioOperacion,
        Evento,
        Query,
        Informacion
    }

    public class Log
    {
        private static Dictionary<LogType, string> LogTypeToString = new Dictionary<LogType, string>()
        {
            { LogType.Inicio, "INI" },
            { LogType.Request, "REQ" },
            { LogType.Response, "RES" },
            { LogType.Error, "ERR" },
            { LogType.Fin, "FIN" },
            { LogType.Parametros, "PAR" },
            { LogType.Conexion, "CXN" },
            { LogType.Desconexion, "DXN" },
            { LogType.Timeout, "TIM" },
            { LogType.InicioOperacion, "IOP" },
            { LogType.Evento, "EVE" },
            { LogType.Query, "QRY" },
            { LogType.Informacion, "INF" }
        };

        private static readonly object Locker = new object();
        private static string Command;

        public static void WriteLine(LogType logType, string message)
        {
            StringBuilder sb;
            string logName = "TPSejeLMSP_" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
            Directory.CreateDirectory(fullPath);

            lock (Locker)
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(fullPath, logName), true))
                {
                    sb = new StringBuilder();

                    if (logType == LogType.Inicio) sb.AppendLine();
                    sb.Append(DateTime.Now.ToString("HH:mm:ss.fff")).Append(",");
                    sb.Append(Command == null ? "000" : Command).Append(",");
                    sb.Append(LogTypeToString[logType]).Append(": ");
                    sb.Append(message);

                    sw.WriteLine(sb);
                    sw.Flush();
                    sw.Close();
                    sb = null;
                    Command = null;
                }
            }
        }

        public static void WriteLine(LogType logType, string message, params object[] args)
        {
            if (message == null)
                throw new ArgumentNullException("message");
            if (args == null)
                throw new ArgumentNullException("args");

            message = string.Format(message, args);
            WriteLine(logType, message);
        }

        public static void WriteLine(LogType logType, string message, Commands command)
        {
            Command = ((int)command).ToString().PadLeft(3, '0');
            WriteLine(logType, message);
        }

        public static void WriteLine<T>(LogType logType, T o)
        {
            WriteLine(logType, o.Serialize());
        }
    }
}