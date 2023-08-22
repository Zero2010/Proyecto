using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Controlador;
using System.Linq;

namespace Servidor
{
    public class Server
    {

        IPHostEntry host;
        IPAddress   ipAddr;
        IPEndPoint  endPoint;

        Socket  server;
        Socket  client;
        private string  message;
        private int     endIndex;
        private string  captura;
        
        private Maestra maestra= new Maestra();


        public Server(string ip, int port)
        {
            host        = Dns.GetHostEntry(ip);
            ipAddr      = host.AddressList[0];
            endPoint    = new IPEndPoint(ipAddr, port);

            server      = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(endPoint);
            server.Listen(10);
        }

        public void Start()
        {

            Thread t;

            while (true)
            {
                Console.WriteLine("Esperando conexiones...");
                client  = server.Accept();
                t       = new Thread(clientConnection);
                t.Start(client);
                Console.WriteLine("Se ha conectado un cliente...");
            }
        }

        public void clientConnection(object s)
        {
            Socket client = (Socket)s;
            Byte[] buffer;
            string Descripcion;

            try
            {
                while (true)
                {
                    buffer                  = new byte[1024];
                    client.Receive(buffer);
                    captura                 = byte2string(buffer);

                    var producto            = maestra.Buscar(captura);

                    if (producto.Count() > 0)
                    {
                        Descripcion = "Ean :" + producto[0].Ean.ToString() + ", Descripción :" + producto[0].Descripcion.ToString();
                    }
                    else {
                        Descripcion = "Ean : Codigo no encontrado";
                    }

                    


                    if (maes.Count() > 0)
                    {
                        byte[] response = Encoding.ASCII.GetBytes("success :" + Descripcion);
                        client.Send(response);
                    }
                    else
                    {
                        byte[] response = Encoding.ASCII.GetBytes("failed :" + Descripcion);
                        client.Send(response);
                    }

                }
            }
            catch (SocketException error)
            {

                Console.WriteLine("Se ha desconectado un usuario: {0}", error.Message);
            }

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
