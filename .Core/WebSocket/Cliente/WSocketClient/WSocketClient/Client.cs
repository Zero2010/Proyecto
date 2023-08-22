using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace WSocketClient
{
    class Client
    {
        IPHostEntry     host;
        IPAddress       ipAddr;
        IPEndPoint      endPoint;

        Socket          client;
        private string  message;
        private int     endIndex;

        public Client(string ip, int port)
        {
            host        = Dns.GetHostByAddress(ip);
            ipAddr      = host.AddressList[0];
            endPoint    = new IPEndPoint(ipAddr, port);

            client      = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start() {
            client.Connect(endPoint);
        }

        public void Send(string msg)
        {
            byte[] byteMsg = Encoding.ASCII.GetBytes(msg);
            client.Send(byteMsg);
            Console.WriteLine("Mensaje Enviado");
        }

        public string Receive()
        {
            byte[] buffer = new byte[1024];
            client.Receive(buffer);

            return byte2string(buffer);
        }

        public string byte2string(byte[] buffer)
        {
            message = Encoding.ASCII.GetString(buffer);
            endIndex = message.IndexOf('\0');
            if (endIndex > 0)
                message = message.Substring(0, endIndex);

            return message;
        }

    }
}




