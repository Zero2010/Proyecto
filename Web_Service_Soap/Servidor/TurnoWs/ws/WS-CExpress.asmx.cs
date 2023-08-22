using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;
using TPSejeLMSP.Communications;
using TPSejeLMSP.Extensions;
using TurnoWs.Clases;

namespace TurnoWs.ws
{
    /// <summary>
    /// Summary description for WS_CExpress
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_CExpress : System.Web.Services.WebService
    {
        TurnoWs.clases.ClassValidaciones validaciones = new TurnoWs.clases.ClassValidaciones();

        TurnoWs.Clases.RespuestaWSGetEdoSesion respuestagetdosesion = new TurnoWs.Clases.RespuestaWSGetEdoSesion();
        TurnoWs.Clases.RespuestaInicarSession respuestausuario = new TurnoWs.Clases.RespuestaInicarSession();
        TurnoWs.Clases.RespuestaWS respuesta = new TurnoWs.Clases.RespuestaWS();
        TurnoWs.Clases.RespuestaWSPausa respuestapausa = new TurnoWs.Clases.RespuestaWSPausa();
        TurnoWs.Clases.RespuestaWSGetEdoBase respuestagetesobase = new TurnoWs.Clases.RespuestaWSGetEdoBase();
        TurnoWs.Clases.RespuestaSetIdC respuestasetidc = new TurnoWs.Clases.RespuestaSetIdC();
        TurnoWs.Clases.RespuestaInicarSession respuestainiciosesion = new TurnoWs.Clases.RespuestaInicarSession();
        TurnoWs.Clases.RespuestaWSMotivo respuestamotivo = new TurnoWs.Clases.RespuestaWSMotivo();
        TurnoWs.Clases.RespuestaWSPSeries respuestaseries = new TurnoWs.Clases.RespuestaWSPSeries();
        TurnoWs.Clases.RespuestaWSExcepcion respuestaexcepcion = new TurnoWs.Clases.RespuestaWSExcepcion();
        TurnoWs.Clases.RespuestaWSRellamada respuestarellamada = new TurnoWs.Clases.RespuestaWSRellamada();

        TurnoWs.Clases.Log log = new Clases.Log();

        [WebMethod]
        public RespuestaInicarSession LogIn(string idEscritorio, string user, string pass, string ip)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["IpMultiConsultora"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoMultiConsultora"]);
                Log.WriteLine(LogType.Informacion, "IP:{0}, Puerto:{1}", host, port);
                TurnoWs.Clases.
                TransactionManager transaction = new TransactionManager(host, port);

                respuestainiciosesion = transaction.IngresarLogIn(idEscritorio, user, pass, ip);

                Log.WriteLine(LogType.Response, respuesta);
                return respuestainiciosesion;
            }
            catch (CommunicationException ex)
            {
                if (ex.InternalError != null)
                {
                    respuestainiciosesion.CodigoRespuesta = ex.InternalError.ErrorCode.ToString();
                    respuestainiciosesion.GlosaRespuesta = ex.InternalError.Message;
                }
                else
                {
                    respuestainiciosesion.CodigoRespuesta = ex.FormatError.ToIntegerString();
                    respuestainiciosesion.GlosaRespuesta = ex.Message;
                }

                Log.WriteLine(LogType.Response, respuestausuario);
                return respuestainiciosesion;
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, ex.ToString());
                respuestainiciosesion.CodigoRespuesta = "1";
                respuestainiciosesion.GlosaRespuesta = ex.Message;
                Log.WriteLine(LogType.Response, respuestainiciosesion);
                return respuestainiciosesion;
            }
        }

        [WebMethod]
        public RespuestaInicarSession LogOut(string idEscritorio)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["IpMultiConsultora"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoMultiConsultora"]);
                Log.WriteLine(LogType.Informacion, "IP:{0}, Puerto:{1}", host, port);
                TurnoWs.Clases.
                TransactionManager transaction = new TransactionManager(host, port);
                respuestausuario = transaction.IngresarLogOut(idEscritorio);

                Log.WriteLine(LogType.Response, respuesta);
                return respuestausuario;
            }
            catch (CommunicationException ex)
            {
                if (ex.InternalError != null)
                {
                    respuestausuario.CodigoRespuesta = ex.InternalError.ErrorCode.ToString();
                    respuestausuario.GlosaRespuesta = ex.InternalError.Message;
                }
                else
                {
                    respuestausuario.CodigoRespuesta = ex.FormatError.ToIntegerString();
                    respuestausuario.GlosaRespuesta = ex.Message;
                }

                Log.WriteLine(LogType.Response, respuestausuario);
                return respuestausuario;
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, ex.ToString());
                respuestausuario.CodigoRespuesta = "1";
                respuestausuario.GlosaRespuesta = ex.Message;
                Log.WriteLine(LogType.Response, respuestausuario);
                return respuestausuario;
            }
        }

        [WebMethod]
        public RespuestaWS IniciarAtencion(string idEscritorio)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["IpMultiConsultora"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoMultiConsultora"]);
                Log.WriteLine(LogType.Informacion, "IP:{0}, Puerto:{1}", host, port);
                TurnoWs.Clases.
                TransactionManager transaction = new TransactionManager(host, port);

                respuesta = transaction.PedirTurno(idEscritorio);

                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;

            }
            catch (CommunicationException ex)
            {
                if (ex.InternalError != null)
                {
                    respuesta.CodigoRespuesta = ex.InternalError.ErrorCode.ToString();
                    respuesta.GlosaRespuesta = ex.InternalError.Message;
                    respuesta.LetraTurno = ex.InternalError.LetraTurno ?? "";
                    respuesta.NumeroTurno = ex.InternalError.NumeroTurno.HasValue ? ex.InternalError.NumeroTurno.Value.ToString() : "";
                }
                else
                {
                    respuesta.CodigoRespuesta = ex.FormatError.ToIntegerString();
                    respuesta.GlosaRespuesta = ex.Message;
                }

                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, ex.ToString());
                respuesta.CodigoRespuesta = "1";
                respuesta.GlosaRespuesta = ex.Message;
                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
        }

        [WebMethod]
        public RespuestaWSPausa GetPausas(string idEscritorio)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["IpMultiConsultora"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoMultiConsultora"]);
                Log.WriteLine(LogType.Informacion, "IP:{0}, Puerto:{1}", host, port);
                TurnoWs.Clases.
                TransactionManager transaction = new TransactionManager(host, port);

                respuestapausa = transaction.GetPausas(idEscritorio);

                Log.WriteLine(LogType.Response, respuesta);
                return respuestapausa;
            }
            catch (CommunicationException ex)
            {
                if (ex.InternalError != null)
                {
                    respuestapausa.CodigoRespuesta = ex.InternalError.ErrorCode.ToString();
                    respuestapausa.GlosaRespuesta = ex.InternalError.Message;
                }
                else
                {
                    respuestapausa.CodigoRespuesta = ex.FormatError.ToIntegerString();
                    respuestapausa.GlosaRespuesta = ex.Message;
                }

                Log.WriteLine(LogType.Response, respuestapausa);
                return respuestapausa;
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, ex.ToString());
                respuestapausa.CodigoRespuesta = "1";
                respuestapausa.GlosaRespuesta = ex.Message;
                Log.WriteLine(LogType.Response, respuestapausa);
                return respuestapausa;
            }
        }

        [WebMethod]
        public RespuestaWS SetPausas(string idEscritorio, string idPausa)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["IpMultiConsultora"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoMultiConsultora"]);
                Log.WriteLine(LogType.Informacion, "IP:{0}, Puerto:{1}", host, port);
                TurnoWs.Clases.
                TransactionManager transaction = new TransactionManager(host, port);

                respuesta = transaction.SetPausas(idEscritorio, idPausa);

                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
            catch (CommunicationException ex)
            {
                if (ex.InternalError != null)
                {
                    respuesta.CodigoRespuesta = ex.InternalError.ErrorCode.ToString();
                    respuesta.GlosaRespuesta = ex.InternalError.Message;
                    respuesta.LetraTurno = ex.InternalError.LetraTurno ?? "";
                    respuesta.NumeroTurno = ex.InternalError.NumeroTurno.HasValue ? ex.InternalError.NumeroTurno.Value.ToString() : "";
                }
                else
                {
                    respuesta.CodigoRespuesta = ex.FormatError.ToIntegerString();
                    respuesta.GlosaRespuesta = ex.Message;
                }

                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, ex.ToString());
                respuesta.CodigoRespuesta = "1";
                respuesta.GlosaRespuesta = ex.Message;
                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
        }

        [WebMethod]
        public RespuestaWSRellamada Rellamada(string idEscritorio)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["IpMultiConsultora"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoMultiConsultora"]);
                Log.WriteLine(LogType.Informacion, "IP:{0}, Puerto:{1}", host, port);
                TurnoWs.Clases.
                TransactionManager transaction = new TransactionManager(host, port);

                respuestarellamada = transaction.ReLlamarTurno(idEscritorio);

                Log.WriteLine(LogType.Response, respuesta);
                return respuestarellamada;
            }
            catch (CommunicationException ex)
            {
                if (ex.InternalError != null)
                {
                    respuestarellamada.CodigoRespuesta = ex.InternalError.ErrorCode.ToString();
                    respuestarellamada.GlosaRespuesta = ex.InternalError.Message;
                }
                else
                {
                    respuestarellamada.CodigoRespuesta = ex.FormatError.ToIntegerString();
                    respuestarellamada.GlosaRespuesta = ex.Message;
                }

                Log.WriteLine(LogType.Response, respuesta);
                return respuestarellamada;
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, ex.ToString());
                respuestarellamada.CodigoRespuesta = "1";
                respuestarellamada.GlosaRespuesta = ex.Message;
                Log.WriteLine(LogType.Response, respuestarellamada);
                return respuestarellamada;
            }
        }


        //
        [WebMethod]
        public RespuestaWSPSeries GetSeries(string idEscritorio)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["IpMultiConsultora"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoMultiConsultora"]);
                Log.WriteLine(LogType.Informacion, "IP:{0}, Puerto:{1}", host, port);
                TurnoWs.Clases.
                TransactionManager transaction = new TransactionManager(host, port);

                respuestaseries = transaction.GetSeries(idEscritorio);

                Log.WriteLine(LogType.Response, respuesta);
                return respuestaseries;
            }
            catch (CommunicationException ex)
            {
                if (ex.InternalError != null)
                {
                    respuestaseries.CodigoRespuesta = ex.InternalError.ErrorCode.ToString();
                    respuestaseries.GlosaRespuesta = ex.InternalError.Message;
                }
                else
                {
                    respuestaseries.CodigoRespuesta = ex.FormatError.ToIntegerString();
                    respuestaseries.GlosaRespuesta = ex.Message;
                }

                Log.WriteLine(LogType.Response, respuestaseries);
                return respuestaseries;
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, ex.ToString());
                respuestaseries.CodigoRespuesta = "1";
                respuestaseries.GlosaRespuesta = ex.Message;
                Log.WriteLine(LogType.Response, respuesta);
                return respuestaseries;
            }
        }

        //

        [WebMethod]
        public RespuestaWSExcepcion Excepcion(string idEscritorio, string serie, string numeroTurno)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["IpMultiConsultora"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoMultiConsultora"]);
                Log.WriteLine(LogType.Informacion, "IP:{0}, Puerto:{1}", host, port);
                TurnoWs.Clases.
                TransactionManager transaction = new TransactionManager(host, port);

                respuestaexcepcion = transaction.Excepcion(idEscritorio, serie, numeroTurno);

                Log.WriteLine(LogType.Response, respuesta);
                return respuestaexcepcion;
            }
            catch (CommunicationException ex)
            {
                if (ex.InternalError != null)
                {
                    respuestaexcepcion.CodigoRespuesta = ex.InternalError.ErrorCode.ToString();
                    respuestaexcepcion.GlosaRespuesta = ex.InternalError.Message;
                    respuestaexcepcion.Serie = ex.InternalError.LetraTurno ?? "";
                    respuestaexcepcion.NumeroTurno = ex.InternalError.NumeroTurno.HasValue ? ex.InternalError.NumeroTurno.Value.ToString() : "";
                }
                else
                {
                    respuestaexcepcion.CodigoRespuesta = ex.FormatError.ToIntegerString();
                    respuestaexcepcion.GlosaRespuesta = ex.Message;
                }

                Log.WriteLine(LogType.Response, respuestaexcepcion);
                return respuestaexcepcion;
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, ex.ToString());
                respuestaexcepcion.CodigoRespuesta = "1";
                respuestaexcepcion.GlosaRespuesta = ex.Message;
                Log.WriteLine(LogType.Response, respuestaexcepcion);
                return respuestaexcepcion;
            }
        }

        [WebMethod]
        public RespuestaWS Llego(string idEscritorio)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["IpMultiConsultora"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoMultiConsultora"]);
                Log.WriteLine(LogType.Informacion, "IP:{0}, Puerto:{1}", host, port);
                TurnoWs.Clases.
                TransactionManager transaction = new TransactionManager(host, port);

                respuesta = transaction.ProcesarTurno(idEscritorio);

                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
            catch (CommunicationException ex)
            {
                if (ex.InternalError != null)
                {
                    respuesta.CodigoRespuesta = ex.InternalError.ErrorCode.ToString();
                    respuesta.GlosaRespuesta = ex.InternalError.Message;
                    respuesta.LetraTurno = ex.InternalError.LetraTurno ?? "";
                    respuesta.NumeroTurno = ex.InternalError.NumeroTurno.HasValue ? ex.InternalError.NumeroTurno.Value.ToString() : "";
                }
                else
                {
                    respuesta.CodigoRespuesta = ex.FormatError.ToIntegerString();
                    respuesta.GlosaRespuesta = ex.Message;
                }

                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, ex.ToString());
                respuesta.CodigoRespuesta = "1";
                respuesta.GlosaRespuesta = ex.Message;
                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
        }

        [WebMethod]
        public RespuestaWS Anular(string idEscritorio)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["IpMultiConsultora"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoMultiConsultora"]);
                Log.WriteLine(LogType.Informacion, "IP:{0}, Puerto:{1}", host, port);
                TurnoWs.Clases.
                TransactionManager transaction = new TransactionManager(host, port);

                respuesta = transaction.AnularTurno(idEscritorio);

                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
            catch (CommunicationException ex)
            {
                if (ex.InternalError != null)
                {
                    respuesta.CodigoRespuesta = ex.InternalError.ErrorCode.ToString();
                    respuesta.GlosaRespuesta = ex.InternalError.Message;
                    respuesta.LetraTurno = ex.InternalError.LetraTurno ?? "";
                    respuesta.NumeroTurno = ex.InternalError.NumeroTurno.HasValue ? ex.InternalError.NumeroTurno.Value.ToString() : "";
                }
                else
                {
                    respuesta.CodigoRespuesta = ex.FormatError.ToIntegerString();
                    respuesta.GlosaRespuesta = ex.Message;
                }

                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, ex.ToString());
                respuesta.CodigoRespuesta = "1";
                respuesta.GlosaRespuesta = ex.Message;
                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
        }

        [WebMethod]
        public RespuestaWS Derivar(string idEscritorio, string serie)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["IpMultiConsultora"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoMultiConsultora"]);
                Log.WriteLine(LogType.Informacion, "IP:{0}, Puerto:{1}", host, port);
                TurnoWs.Clases.
                TransactionManager transaction = new TransactionManager(host, port);

                respuesta = transaction.DevivarAtencion(idEscritorio, serie);

                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
            catch (CommunicationException ex)
            {
                if (ex.InternalError != null)
                {
                    respuesta.CodigoRespuesta = ex.InternalError.ErrorCode.ToString();
                    respuesta.GlosaRespuesta = ex.InternalError.Message;
                    respuesta.LetraTurno = ex.InternalError.LetraTurno ?? "";
                    respuesta.NumeroTurno = ex.InternalError.NumeroTurno.HasValue ? ex.InternalError.NumeroTurno.Value.ToString() : "";
                }
                else
                {
                    respuesta.CodigoRespuesta = ex.FormatError.ToIntegerString();
                    respuesta.GlosaRespuesta = ex.Message;
                }

                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, ex.ToString());
                respuesta.CodigoRespuesta = "1";
                respuesta.GlosaRespuesta = ex.Message;
                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
        }

        [WebMethod]
        public RespuestaWS FinalizarAtencion(string idEscritorio, string motivo)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["IpMultiConsultora"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoMultiConsultora"]);
                Log.WriteLine(LogType.Informacion, "IP:{0}, Puerto:{1}", host, port);
                TurnoWs.Clases.
                TransactionManager transaction = new TransactionManager(host, port);

                if (!string.IsNullOrEmpty(motivo)) motivo += ",1";
                respuesta = transaction.FinalizarTurno(idEscritorio, motivo);

                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
            catch (CommunicationException ex)
            {
                if (ex.InternalError != null)
                {
                    respuesta.CodigoRespuesta = ex.InternalError.ErrorCode.ToString();
                    respuesta.GlosaRespuesta = ex.InternalError.Message;
                    respuesta.LetraTurno = ex.InternalError.LetraTurno ?? "";
                    respuesta.NumeroTurno = ex.InternalError.NumeroTurno.HasValue ? ex.InternalError.NumeroTurno.Value.ToString() : "";
                }
                else
                {
                    respuesta.CodigoRespuesta = ex.FormatError.ToIntegerString();
                    respuesta.GlosaRespuesta = ex.Message;
                }

                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, ex.ToString());
                respuesta.CodigoRespuesta = "1";
                respuesta.GlosaRespuesta = ex.Message;
                Log.WriteLine(LogType.Response, respuesta);
                return respuesta;
            }
        }


        [WebMethod]
        public RespuestaWSMotivo GetMotivos(string idEscritorio)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["IpMultiConsultora"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoMultiConsultora"]);
                Log.WriteLine(LogType.Informacion, "IP:{0}, Puerto:{1}", host, port);
                TurnoWs.Clases.
                TransactionManager transaction = new TransactionManager(host, port);

                respuestamotivo = transaction.GetMotivos(idEscritorio);

                Log.WriteLine(LogType.Response, respuesta);
                return respuestamotivo;
            }
            catch (CommunicationException ex)
            {
                if (ex.InternalError != null)
                {
                    respuestamotivo.CodigoRespuesta = ex.InternalError.ErrorCode.ToString();
                    respuestamotivo.GlosaRespuesta = ex.InternalError.Message;
                }
                else
                {
                    respuestamotivo.CodigoRespuesta = ex.FormatError.ToIntegerString();
                    respuestamotivo.GlosaRespuesta = ex.Message;
                }

                Log.WriteLine(LogType.Response, respuestamotivo);
                return respuestamotivo;
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, ex.ToString());
                respuestamotivo.CodigoRespuesta = "1";
                respuestamotivo.GlosaRespuesta = ex.Message;
                Log.WriteLine(LogType.Response, respuestamotivo);
                return respuestamotivo;
            }
        }


        [WebMethod]
        public RespuestaWSGetEdoBase GetEdoBase(string idEscritorio, string ip)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["IpMultiConsultora"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoMultiConsultora"]);
                Log.WriteLine(LogType.Informacion, "IP:{0}, Puerto:{1}", host, port);
                TurnoWs.Clases.
                TransactionManager transaction = new TransactionManager(host, port);

                respuestagetesobase = transaction.GetEdoBase(idEscritorio, ip);

                Log.WriteLine(LogType.Response, respuestagetesobase);
                return respuestagetesobase;
            }
            catch (CommunicationException ex)
            {
                if (ex.InternalError != null)
                {
                    respuestagetesobase.CodigoRespuesta = ex.InternalError.ErrorCode.ToString();
                    respuestagetesobase.GlosaRespuesta = ex.InternalError.Message;
                }
                else
                {
                    respuestagetesobase.CodigoRespuesta = ex.FormatError.ToIntegerString();
                    respuestagetesobase.GlosaRespuesta = ex.Message;
                }

                Log.WriteLine(LogType.Response, respuestagetesobase);
                return respuestagetesobase;
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, ex.ToString());
                respuestagetesobase.CodigoRespuesta = "1";
                respuestagetesobase.GlosaRespuesta = ex.Message;
                Log.WriteLine(LogType.Response, respuestagetesobase);
                return respuestagetesobase;
            }
        }


        [WebMethod]
        public RespuestaWSGetEdoSesion SetEdoSesion(string idEscritorio)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["IpMultiConsultora"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoMultiConsultora"]);
                Log.WriteLine(LogType.Informacion, "IP:{0}, Puerto:{1}", host, port);
                TurnoWs.Clases.
                TransactionManager transaction = new TransactionManager(host, port);

                respuestagetdosesion = transaction.SetEdoSesion(idEscritorio);

                Log.WriteLine(LogType.Response, respuestagetdosesion);
                return respuestagetdosesion;
            }
            catch (CommunicationException ex)
            {
                if (ex.InternalError != null)
                {
                    respuestagetdosesion.CodigoRespuesta = ex.InternalError.ErrorCode.ToString();
                    respuestagetdosesion.GlosaRespuesta = ex.InternalError.Message;
                }
                else
                {
                    respuestagetdosesion.CodigoRespuesta = ex.FormatError.ToIntegerString();
                    respuestagetdosesion.GlosaRespuesta = ex.Message;
                }

                Log.WriteLine(LogType.Response, respuestagetdosesion);
                return respuestagetdosesion;
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, ex.ToString());
                respuestagetdosesion.CodigoRespuesta = "1";
                respuestagetdosesion.GlosaRespuesta = ex.Message;
                Log.WriteLine(LogType.Response, respuestagetdosesion);
                return respuestagetdosesion;
            }
        }



        [WebMethod]
        public RespuestaSetIdC SetIdC(string idEscritorio, string rut, string fono)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["IpMultiConsultora"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoMultiConsultora"]);
                Log.WriteLine(LogType.Informacion, "IP:{0}, Puerto:{1}", host, port);
                TurnoWs.Clases.
                TransactionManager transaction = new TransactionManager(host, port);

                respuestasetidc = transaction.SetIdC(idEscritorio,rut,fono);

                Log.WriteLine(LogType.Response, respuestasetidc);
                return respuestasetidc;
            }
            catch (CommunicationException ex)
            {
                if (ex.InternalError != null)
                {
                    respuestasetidc.CodigoRespuesta = ex.InternalError.ErrorCode.ToString();
                    respuestasetidc.GlosaRespuesta = ex.InternalError.Message;
                }
                else
                {
                    respuestasetidc.CodigoRespuesta = ex.FormatError.ToIntegerString();
                    respuestasetidc.GlosaRespuesta = ex.Message;
                }

                Log.WriteLine(LogType.Response, respuestasetidc);
                return respuestasetidc;
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, ex.ToString());
                respuestasetidc.CodigoRespuesta = "1";
                respuestasetidc.GlosaRespuesta = ex.Message;
                Log.WriteLine(LogType.Response, respuestasetidc);
                return respuestasetidc;
            }
        }

    }

}
