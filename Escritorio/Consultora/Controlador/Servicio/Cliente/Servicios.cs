using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPSejeLMSP.Communications;


namespace Controlador.Cliente
{
   public class servicios
    {
        string host = ConfigurationManager.AppSettings["IpConsultora"];
        int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoConsultora"]);
        string version = ConfigurationManager.AppSettings["Major" + "Minor" + "Revision"];
        string idescritorio = ConfigurationManager.AppSettings["IdEscritorio"];
        string idoficina = ConfigurationManager.AppSettings["IdOficina"];

        string data;

        public string Pausa()
        {
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.Pausa, new List<string> { "" });

            return data;
        }

        public string LogIn(string usu, string pass)
        {
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.LogIn, new List<string> { idoficina, idescritorio, usu, pass, version });

            return data;
        }

        public string Transmitir(string cadenaTransmicion)
        {
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.Transmitir, new List<string> { cadenaTransmicion });

            return data;
        }


    }
}
