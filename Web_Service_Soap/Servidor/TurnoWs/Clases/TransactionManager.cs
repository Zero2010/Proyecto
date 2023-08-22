using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using TPSejeLMSP.Communications;

namespace TurnoWs.Clases
{
    public class TransactionManager
    {
        private SocketWrapper _socket;
        public string[] Vector;
        public string[][] Tablero;
        public string resp;

        public TransactionManager(string host, int port)
        {
            _socket = new SocketWrapper(host, port);
        }

        private Communication ObtenerEstadoSesion(string idEscritorio)
        {
            string data, response;

            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.EstadoSesion, new List<string> { idEscritorio });

            Log.WriteLine(LogType.Query, data, Commands.EstadoSesion);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.EstadoSesion);

            return Communication.Parse(response);
        }

        public RespuestaWS ProcesarTurno(string idEscritorio)
        {
            RespuestaWS respuesta;
            Communication message;
            string data, response, estadoEscritorio;

            respuesta = new RespuestaWS() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.ProcesarTurno, new List<string> { idEscritorio });

            Log.WriteLine(LogType.Query, data, Commands.ProcesarTurno);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.ProcesarTurno);

            Communication.Parse(response);
            message = ObtenerEstadoSesion(idEscritorio);

            estadoEscritorio = message.Data[1];
            respuesta.CantidadEnEspera = message.Data[5];
            respuesta.TiempoDeEspera = message.Data[6];

            if (estadoEscritorio == "LLAMANDO" || estadoEscritorio == "ATENDIENDO")
            {
                respuesta.LetraTurno = message.Data[12];
                respuesta.NumeroTurno = message.Data[11];
                respuesta.Rut = message.Data[19];
            }

            return respuesta;
        }

        public RespuestaWS PedirTurno(string idEsc)
        {
            RespuestaWS respuesta;
            Communication message;
            string data, response, estadoEscritorio, version;

            version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            respuesta = new RespuestaWS() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.PedirTurno, new List<string> { idEsc, version });

            Log.WriteLine(LogType.Query, data, Commands.PedirTurno);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.PedirTurno);

            Communication.Parse(response);
            message = ObtenerEstadoSesion(idEsc);

            estadoEscritorio = message.Data[1];
            respuesta.CantidadEnEspera = message.Data[5];
            respuesta.TiempoDeEspera = message.Data[6];
            respuesta.LetraTurno = message.Data[12];
            respuesta.NumeroTurno = message.Data[11];
            respuesta.Rut = message.Data[19];

            if (string.IsNullOrEmpty(respuesta.LetraTurno))
            {
                respuesta.CodigoRespuesta = "13098";
                respuesta.GlosaRespuesta = "No hay turnos en espera";
            }

            return respuesta;
        }


        public RespuestaWS AnularTurno(string idEscritorio)
        {
            RespuestaWS respuesta;
            Communication message;
            string data, response, estadoEscritorio;

            respuesta = new RespuestaWS() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.AnularTurno, new List<string> { idEscritorio });

            Log.WriteLine(LogType.Query, data, Commands.AnularTurno);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.AnularTurno);

            Communication.Parse(response);
            message = ObtenerEstadoSesion(idEscritorio);

            estadoEscritorio = message.Data[1];
            respuesta.CantidadEnEspera = message.Data[5];
            respuesta.TiempoDeEspera = message.Data[6];

            if (estadoEscritorio == "LLAMANDO" || estadoEscritorio == "ATENDIENDO")
            {
                respuesta.LetraTurno = message.Data[12];
                respuesta.NumeroTurno = message.Data[11];
                respuesta.Rut = message.Data[19];
            }

            return respuesta;
        }

        public RespuestaWS FinalizarTurno(string idEscritorio, string motivo)
        {
            RespuestaWS respuesta;
            Communication message;
            string data, response, estadoEscritorio;

            respuesta = new RespuestaWS() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.FinalizarTurno, new List<string> { idEscritorio, motivo });

            Log.WriteLine(LogType.Query, data, Commands.FinalizarTurno);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.FinalizarTurno);

            var a = Communication.Parse(response);
            Vector = a.Data.ToArray();

            message = ObtenerEstadoSesion(idEscritorio);

            estadoEscritorio = message.Data[1];
            respuesta.CantidadEnEspera = message.Data[5];
            respuesta.TiempoDeEspera = message.Data[6];

            if (estadoEscritorio == "LLAMANDO" || estadoEscritorio == "ATENDIENDO")
            {
                respuesta.LetraTurno = message.Data[12];
                respuesta.NumeroTurno = message.Data[11];
                respuesta.Rut = message.Data[19];
            }

            return respuesta;
        }

        public RespuestaWSRellamada ReLlamarTurno(string idEscritorio)
        {
            RespuestaWSRellamada respuesta;
            string data, response;

            respuesta = new RespuestaWSRellamada() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.ReLlamarTurno, new List<string> { idEscritorio });

            Log.WriteLine(LogType.Query, data, Commands.ReLlamarTurno);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.ReLlamarTurno);

            var a = Communication.Parse(response);
            Vector = a.Data.ToArray();

            Communication.Parse(response);
            return respuesta;
        }

        public RespuestaWSPSeries GetSeries(string idEscritorio)
        {
            RespuestaWSPSeries respuesta;
            string data, response;

            respuesta = new RespuestaWSPSeries() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.GetSeries, new List<string> { idEscritorio });

            Log.WriteLine(LogType.Query, data, Commands.GetSeries);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.GetSeries);

            var a = Communication.Parse(response);
            Vector = a.Data.ToArray();

            if (respuesta.CodigoRespuesta == "0")
            {
                respuesta.CodigoRespuesta = "0";
                respuesta.GlosaRespuesta = "";
                respuesta.opciones = new List<Series>();

                foreach (var item in Vector)
                {
                    string[] V = item.Split('~');
                    var serie = new Series();

                    serie.IdSerie = Convert.ToInt32(V[0]);
                    serie.Letra = V[2];
                    serie.Descripcion = V[3];

                    respuesta.opciones.Add(serie);
                }
            }
            return respuesta;
        }



        public RespuestaWSExcepcion Excepcion(string idEscritorio, string serie, string turno)
        {
            RespuestaWSExcepcion respuesta;
            Communication message;
            string data, response, estadoEscritorio;

            respuesta = new RespuestaWSExcepcion() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.Excepcion, new List<string> { idEscritorio, serie, turno });

            Log.WriteLine(LogType.Query, data, Commands.Excepcion);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.Excepcion);

            var a = Communication.Parse(response);
            Vector = a.Data.ToArray(); message = ObtenerEstadoSesion(idEscritorio);

            estadoEscritorio = message.Data[1];
            respuesta.CantidadEnEspera = message.Data[5];
            respuesta.TiempoDeEspera = message.Data[6];

            if (estadoEscritorio == "LLAMANDO" || estadoEscritorio == "ATENDIENDO")
            {
                respuesta.Serie = message.Data[12];
                respuesta.NumeroTurno = message.Data[11];
                respuesta.Rut = message.Data[19];
            }

            return respuesta;
        }


        public RespuestaWS AnulacionMultiple(string idEscritorio, string letra, string turno)
        {
            RespuestaWS respuesta;
            string data, response;

            respuesta = new RespuestaWS() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.AnulacionMultiple, new List<string> { idEscritorio, letra, turno });

            Log.WriteLine(LogType.Query, data, Commands.AnulacionMultiple);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.AnulacionMultiple);

            Communication.Parse(response);

            return respuesta;
        }

        public RespuestaWS OficinaCierre(string idEscritorio)
        {
            RespuestaWS respuesta;
            string data, response;

            respuesta = new RespuestaWS() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.OficinaCierre, new List<string> { idEscritorio });

            Log.WriteLine(LogType.Query, data, Commands.OficinaCierre);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.OficinaCierre);

            Communication.Parse(response);

            return respuesta;
        }
        //nuevos metodos para chile express
        public RespuestaWS DevivarAtencion(string idEscritorio, string serie)
        {
            RespuestaWS respuesta;
            string data, response;

            respuesta = new RespuestaWS() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.DevivarAtencion, new List<string> { idEscritorio, serie });

            Log.WriteLine(LogType.Query, data, Commands.DevivarAtencion);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.DevivarAtencion);


            var a = Communication.Parse(response);
            Vector = a.Data.ToArray();

            return respuesta;
        }


        public RespuestaWS IniciarProceso(string idEscritorio)
        {
            RespuestaWS respuesta;
            string data, response;

            respuesta = new RespuestaWS() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.PedirTurno, new List<string> { idEscritorio });

            Log.WriteLine(LogType.Query, data, Commands.PedirTurno);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.PedirTurno);

            Communication.Parse(response);

            return respuesta;
        }


        public RespuestaInicarSession IngresarLogIn(string escritorio, string user, string pass, string ip)
        {

            RespuestaInicarSession respuesta;
            string data, response;

            respuesta = new RespuestaInicarSession() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.LogIn, new List<string> { escritorio, user, pass, ip });

            Log.WriteLine(LogType.Query, data, Commands.LogIn);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.LogIn);

            var a = Communication.Parse(response);
            Vector = a.Data.ToArray();

            if (respuesta.CodigoRespuesta == "0")
            {
                respuesta.CodigoRespuesta = "0";
                respuesta.GlosaRespuesta = "";
                respuesta.IdOfi = Vector[0];
                respuesta.Ofi = Vector[1];
                respuesta.Esc = Vector[2];
                respuesta.IdEje = Vector[3];
                respuesta.Eje = Vector[4];
                respuesta.Edo = Vector[5];
                respuesta.Encuesta = "";// se tiene que devolver vacío
            }



            return respuesta;
        }


        public RespuestaInicarSession IngresarLogOut(string idEscritorio)
        {

            RespuestaInicarSession respuesta;
            string data, response;

            respuesta = new RespuestaInicarSession() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.LogOut, new List<string> { idEscritorio });

            Log.WriteLine(LogType.Query, data, Commands.LogOut);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.LogOut);

            Communication.Parse(response);

            return respuesta;
        }

        //nuevos metodos
        public RespuestaWSPausa GetPausas(string idEscritorio)
        {
            RespuestaWSPausa respuesta;
            string data, response;

            respuesta = new RespuestaWSPausa() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.GetPausas, new List<string> { idEscritorio });

            Log.WriteLine(LogType.Query, data, Commands.GetPausas);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.GetPausas);

            var a = Communication.Parse(response);
            Vector = a.Data.ToArray();

            if (respuesta.CodigoRespuesta == "0")
            {
                respuesta.CodigoRespuesta = "0";
                respuesta.GlosaRespuesta = "";
                respuesta.opciones = new List<Pausa>();

                foreach (var item in Vector)
                {
                    string[] V = item.Split('~');
                    var pausa = new Pausa();

                    pausa.IdPausa = Convert.ToInt32(V[0]);
                    pausa.Descripcion = V[1];

                    respuesta.opciones.Add(pausa);
                }
            }
            return respuesta;
        }


        public RespuestaWS SetPausas(string idEscritorio, string idPausa)
        {
            RespuestaWS respuesta;
            string data, response;

            respuesta = new RespuestaWS() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.SetPausas, new List<string> { idEscritorio, idPausa });

            Log.WriteLine(LogType.Query, data, Commands.SetPausas);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.SetPausas);

            var a = Communication.Parse(response);
            Vector = a.Data.ToArray();

            return respuesta;
        }


        public RespuestaWSGetEdoSesion SetEdoSesion(string idEscritorio)
        {
            RespuestaWSGetEdoSesion respuesta;
            string data, response;

            respuesta = new RespuestaWSGetEdoSesion() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.EstadoSesion, new List<string> { idEscritorio });

            Log.WriteLine(LogType.Query, data, Commands.EstadoSesion);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.EstadoSesion);

            var a = Communication.Parse(response);
            Vector = a.Data.ToArray();


            if (respuesta.CodigoRespuesta == "0")
            {
                respuesta.CodigoRespuesta = "0";
                respuesta.GlosaRespuesta = "";
                respuesta.HNow = Vector[0];
                respuesta.Estado = Vector[1];
                respuesta.QEspO = Vector[2];
                respuesta.TEspO = Vector[3];
                respuesta.TEspAO = Vector[4];
                respuesta.QEspE = Vector[5];
                respuesta.TEspE = Vector[6];
                respuesta.TEspAE = Vector[7];
                respuesta.QSer = Vector[8];
                respuesta.IdSer = Vector[9];
                respuesta.IdSerG = Vector[10];
                respuesta.Turno = Vector[11];
                respuesta.Letra = Vector[12];
                respuesta.Serie = Vector[13];
                respuesta.TEsp = Vector[14];
                respuesta.TEspA = Vector[15];
                respuesta.TEspC = Vector[16];
                respuesta.TAte = Vector[17];
                respuesta.TAteA = Vector[18];
                respuesta.Rut = Vector[19];
                respuesta.Fono = Vector[20];
                respuesta.Cliente = Vector[21];
            }

            return respuesta;
        }

        public RespuestaWSMotivo GetMotivos(string idEscritorio)
        {

            RespuestaWSMotivo respuesta;
            string data, response;

            respuesta = new RespuestaWSMotivo() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.GetMotivos, new List<string> { idEscritorio });

            Log.WriteLine(LogType.Query, data, Commands.GetMotivos);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.GetMotivos);

            var a = Communication.Parse(response);
            Vector = a.Data.ToArray();


                respuesta.CodigoRespuesta = "0";
                respuesta.GlosaRespuesta = "";
                respuesta.motivo = new List<Motivo>();

            if (Vector.Length == 0 || Vector[0]=="")
            {
                respuesta.CodigoRespuesta = "14000";
                respuesta.GlosaRespuesta = "No Tiene Motivos para Mostrar";
            }
            else
            {
                foreach (var item in Vector)
                {
                    string[] V = item.Split('~');
                    var motivo = new Motivo();

                    motivo.IdMotivo = Convert.ToInt32(V[0]);
                    motivo.Descripcion = V[1];

                    respuesta.motivo.Add(motivo);
                }
            }

            
            return respuesta;
        }



        public RespuestaWSGetEdoBase GetEdoBase(string idEscritorio, string ip)
        {
            RespuestaWSGetEdoBase respuesta;
            string data, response;

            respuesta = new RespuestaWSGetEdoBase() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.GetEdoBase, new List<string> { idEscritorio, ip });

            Log.WriteLine(LogType.Query, data, Commands.GetEdoBase);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.GetEdoBase);

            var a = Communication.Parse(response);
            Vector = a.Data.ToArray();

            if (respuesta.CodigoRespuesta == "0")
            {
                respuesta.CodigoRespuesta = "0";
                respuesta.GlosaRespuesta = "";
                respuesta.Oficina = Vector[0];
                respuesta.Escritorio = Vector[1];
                respuesta.IdEje = Vector[2];
                respuesta.Ejecutivo = Vector[3];
                respuesta.Estado = Vector[4];
                respuesta.ClienteInterno = Vector[5];
                respuesta.Encuesta = "";// se tiene que devolver vacío
            }

            return respuesta;
        }


        public RespuestaSetIdC SetIdC(string idEscritorio, string rut, string fono)
        {
            RespuestaSetIdC respuesta;
            //Communication message;
            string data, response;

            respuesta = new RespuestaSetIdC() { CodigoRespuesta = "0" };
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.SetIdC, new List<string> { idEscritorio, rut, fono });

            Log.WriteLine(LogType.Query, data, Commands.SetIdC);
            response = _socket.Send(data);
            Log.WriteLine(LogType.Response, response, Commands.SetIdC);

            var a = Communication.Parse(response);
            Vector = a.Data.ToArray();

            Communication.Parse(response);
            //message = ObtenerEstadoSesion(idEscritorio);

            if (respuesta.CodigoRespuesta == "0")
            {
                respuesta.CodigoRespuesta = "0";
                respuesta.GlosaRespuesta = "";
            }

            return respuesta;
        }

    }
}
