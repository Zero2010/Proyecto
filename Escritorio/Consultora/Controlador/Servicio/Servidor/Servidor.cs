using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Configuration;
using System.Net;
using TPSejeLMSP.Communications;
using System.IO;

namespace Controlador.Servidor
{
    public class Servidor
    {
        string idescritorio = ConfigurationManager.AppSettings["IpConsultora"];
        string idoficina = ConfigurationManager.AppSettings["IdOficina"];
        string host = ConfigurationManager.AppSettings["IpConsultora"];
        int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoConsultora"]);

        string respuesta;
        string respuestaConectar;

        byte[] data;
        byte[] b = new byte[10000];
        int k;
        string[] login;
        string[] pausa;

        Cliente.servicios s = new Cliente.servicios();
        Metodos.Metodos metodo = new Metodos.Metodos();
        string fecha;

        public string Conectar(string usuario, string contraseina)
        {

            System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
            clientSocket.BeginConnect(IPAddress.Parse(host), port, null, null);
            fecha = "_" + Convert.ToString(System.DateTime.Now.ToString("ddMMyyyy-HHmmss")) + ".txt";

            try
            {
                if (clientSocket.Connected)
                {
                    respuestaConectar = "";
                    respuesta = s.LogIn(usuario, contraseina);
                    data = System.Text.Encoding.ASCII.GetBytes(respuesta);
                    clientSocket.Client.Send(data);
                    k = clientSocket.Client.Receive(b);
                    login = Encoding.ASCII.GetString(b, 0, k).Split('|');

                    //Extrae el nombre de ejecutivo, motivo cierre atencion, pausas, sucursal
                    respuesta = s.Pausa(); ;
                    data = System.Text.Encoding.GetEncoding("Windows-1252").GetBytes(respuesta);
                    clientSocket.Client.Send(data);
                    k = clientSocket.Client.Receive(b);
                    pausa = Encoding.GetEncoding("Windows-1252").GetString(b, 0, k).Split('|');

                    string[] registros;
                    string[] registros2;

                    for (int i = 0; i < pausa.Length; i++)
                    {
                        registros = pausa[i].ToString().Split('~');
                        registros2 = pausa[i].ToString().Replace('~', '|').Split('~');

                        if (i == 0)
                        {
                            metodo.Archivo_Plano("c:\\Consultora\\Sucursal\\", registros2, "SUC" + fecha);
                            EliminarArchivo("c:\\Consultora\\Sucursal\\", "c:\\Consultora\\Sucursal\\SUC" + fecha);
                            respuestaConectar = "ok";
                        }
                        else
                            if ("SER" == registros[0])
                        {
                            metodo.Archivo_Plano("c:\\Consultora\\Serie\\", registros2, "SER" + fecha);
                            EliminarArchivo("c:\\Consultora\\Serie\\", "c:\\Consultora\\Serie\\SER" + fecha);
                            respuestaConectar = "ok";
                        }
                        else if ("EJE" == registros[0])
                        {
                            metodo.Archivo_Plano("c:\\Consultora\\Ejecutivo\\", registros2, "EJE" + fecha);
                            EliminarArchivo("c:\\Consultora\\Ejecutivo\\", "c:\\Consultora\\Ejecutivo\\EJE" + fecha);
                            respuestaConectar = "ok";
                        }
                        else if ("MOT" == registros[0])
                        {
                            metodo.Archivo_Plano("c:\\Consultora\\Motivo\\", registros2, "MOT" + fecha);
                            EliminarArchivo("c:\\Consultora\\Motivo\\", "c:\\Consultora\\Motivo\\MOT" + fecha);
                            respuestaConectar = "ok";
                        }
                        else if ("PAU" == registros[0])
                        {
                            metodo.Archivo_Plano("c:\\Consultora\\Pausa\\", registros2, "PAU" + fecha);
                            EliminarArchivo("c:\\Consultora\\Pausa\\", "c:\\Consultora\\Pausa\\PAU" + fecha);
                            respuestaConectar = "ok";
                        }
                        else if ("TRA" == registros[0])
                        {
                            metodo.Archivo_Plano("c:\\Consultora\\Pausa\\", registros2, "PAU" + fecha);
                        }

                    }
                }
                return respuestaConectar;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }


        public void EliminarArchivo(string path, string pathNoBorrar)
        {
            foreach (var item in  Directory.GetFiles(path,"*.txt"))
            {
                if (pathNoBorrar != item)
                {
                    File.Delete(item);
                }
            }
        }


    }
}
