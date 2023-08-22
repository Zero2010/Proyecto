using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TPSejeLMSP.Communications
{
    public class SocketWrapper
    {
        public string Host { get; set; }
        public int Port { get; set; }

        private IPEndPoint remoteEndPoint;
        private byte[] bufferOut;
        private byte[] bufferIn;

        public SocketWrapper()
        { }

        public SocketWrapper(string host, int port)
        {
            Host = host;
            Port = port;
        }

        public string Send(string data)
        {
            using (Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                IPAddress ipAddress = IPAddress.Parse(Host);
                int timeout = Convert.ToInt32(ConfigurationManager.AppSettings["TcpTimeout"]);

                remoteEndPoint = new IPEndPoint(ipAddress, Port);
                sender.ReceiveTimeout = sender.SendTimeout = timeout * 1000;
                sender.Connect(remoteEndPoint);
                bufferOut = Encoding.GetEncoding("Windows-1252").GetBytes(data);
                bufferIn = new byte[(int)StructureLength.MAX_MSG_LEN];
                int bytesSent = sender.Send(bufferOut);
                int bytesReceived = sender.Receive(bufferIn);
                string response = Encoding.GetEncoding("Windows-1252").GetString(bufferIn.Where(x => x != 0x00).ToArray());
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
                return response;
            }
        }

        public void SendAsync(string data)
        {
            Task.Factory.StartNew(() => Send(data));
        }
    }
}