using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Configuration;
using System.Net;
using TPSejeLMSP.Communications;

namespace WindowsFormsApplication1.Servidor
{
    class Servidor
    {

        string host = ConfigurationManager.AppSettings["IpConsultoraEscritorio"];
        int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoConsultoraEscritorio"]);

        string respuesta;

        byte[] data;
        byte[] b = new byte[10000];
        int k;
        string[] login;
        string[] pausa;
        string[] metodo301;
        string[] metodo311;
        string[] metodo320;

        Cliente.servicios s = new Cliente.servicios();
        Metodos.Metodos metodo = new Metodos.Metodos();
        string fecha;

        public void Conectar()
        {

            System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
            clientSocket.BeginConnect(IPAddress.Parse(host), port, null, null);
            fecha = "_" + Convert.ToString(System.DateTime.Now.ToString("ddMMyyyy-HHmmss")) + ".txt";

            try
            {
                if (clientSocket.Connected)
                {
                    respuesta = s.LogIn();
                    data = System.Text.Encoding.ASCII.GetBytes(respuesta);
                    clientSocket.Client.Send(data);
                    k = clientSocket.Client.Receive(b);
                    login = Encoding.ASCII.GetString(b, 0, k).Split('|');

                    metodo.Archivo_Plano("c:\\Consultora\\LogIn\\", login, "LogIn" + fecha);

                    respuesta = s.Pausa();
                    data = System.Text.Encoding.ASCII.GetBytes(respuesta);
                    clientSocket.Client.Send(data);
                    k = clientSocket.Client.Receive(b);
                    pausa = Encoding.ASCII.GetString(b, 0, k).Split('|');

                    metodo.Archivo_Plano("c:\\Consultora\\Pausa\\", pausa, "Pausa" + fecha);

                    respuesta = s.Metodo301();
                    data = System.Text.Encoding.ASCII.GetBytes(respuesta);
                    clientSocket.Client.Send(data);
                    k = clientSocket.Client.Receive(b);
                    metodo301 = Encoding.ASCII.GetString(b, 0, k).Split('|');

                    metodo.Archivo_Plano("c:\\Consultora\\Metodo301\\", metodo301, "Metodo301" + fecha);

                    respuesta = s.Metodo311();
                    data = System.Text.Encoding.ASCII.GetBytes(respuesta);
                    clientSocket.Client.Send(data);
                    k = clientSocket.Client.Receive(b);
                    metodo311 = Encoding.ASCII.GetString(b, 0, k).Split('|');

                    metodo.Archivo_Plano("c:\\Consultora\\Metodo311\\", metodo311, "Metodo311" + fecha);

                    respuesta = s.Metodo320();
                    data = System.Text.Encoding.ASCII.GetBytes(respuesta);
                    clientSocket.Client.Send(data);
                    k = clientSocket.Client.Receive(b);
                    metodo320 = Encoding.ASCII.GetString(b, 0, k).Split('|');

                    metodo.Archivo_Plano("c:\\Consultora\\Metodo320\\", metodo320, "Metodo320" + fecha);
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}
