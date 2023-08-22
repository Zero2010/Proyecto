using System;
using Servidor;

namespace WSocketServerInv
{
    class Program
    {
        static void Main(string[] args)
        {
            Server s = new Server("127.0.0.1", 4404);
            s.Start();
            Console.ReadKey();
        }
    }
}
