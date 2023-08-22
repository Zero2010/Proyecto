using System;

namespace WSocketClient
{
    class Program
    {

        static void Main(string[] args)
        {
            Client c = new Client("127.0.0.1", 4404);

            string      capturaInventario;

            c.Start();
 
            while (true) {

                Console.WriteLine("Ingreso de Captura: ");
                capturaInventario = Console.ReadLine();
                c.Send(capturaInventario);

                if (capturaInventario != ""){
                    Console.WriteLine("Se recepciono registro de captura: {0}", c.Receive());
                    Console.WriteLine("******************************************************************");
                }
                else {
                    Console.WriteLine("Registro de captura esta en blanco");
                    Console.WriteLine("******************************************************************");
                }
            }

            Console.ReadKey();
        }
    }
}
