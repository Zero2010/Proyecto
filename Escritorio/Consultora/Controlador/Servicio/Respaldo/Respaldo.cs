using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPSejeLMSP.Communications;
using System.IO;

namespace Controlador.Servicio.Respaldo
{
    public class Respaldo
    {
        public int Id { get; set; }
        public int Serie{ get; set; }
        public int Numero { get; set; }

        Metodos.Metodos metodo = new Metodos.Metodos();

        public void GenerarRespaldo(string Respaldo, string Tipo)
        {

            switch (Tipo)
            {
                case "ATE":
                    metodo.Archivo_Plano("c:\\Consultora\\Envio\\", Respaldo, "ATE.txt");
                    break;
                case "MOT":
                    metodo.Archivo_Plano("c:\\Consultora\\Envio\\", Respaldo, "MOT.txt");
                    break;
                case "EJE":
                    metodo.Archivo_Plano("c:\\Consultora\\Envio\\", Respaldo, "EJE.txt");
                    break;
                case "URG":
                    metodo.Archivo_Plano("c:\\Consultora\\NumeroUrgencia\\", Respaldo, "Urgencia.txt");
                    break;
            }

        }


    }
}
