using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPSejeLMSP.Communications;


namespace WindowsFormsApplication1.Cliente
{
   public class servicios
    {
        //string host = ConfigurationManager.AppSettings["IpConsultoraEscritorio"];
        //int port = Convert.ToInt32(ConfigurationManager.AppSettings["PuertoConsultoraEscritorio"]);
        //string version = ConfigurationManager.AppSettings["Mayor" + "Minor" + "Revision"];
        //string usu = ConfigurationManager.AppSettings["Usuario"];
        //string pass = ConfigurationManager.AppSettings["Clave"];
        //string idescritorio = ConfigurationManager.AppSettings["IdEscritorio"];
        //string idoficina = ConfigurationManager.AppSettings["IdOficina"];

        

        string data;

        public string Pausa()
        {
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.Pausa, new List<string> { "" });

            return data;
        }

        public string LogIn()
        {
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.LogIn, new List<string> { /*idoficina, idescritorio, usu, pass, version*/ });

            return data;
        }

        public string Metodo301()
        {
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.motivo301, new List<string> {/* "0","-1"*/ });

            return data;
        }

        public string Metodo311()
        {
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.motivo311, new List<string> { /* idoficina, "1", "1" */});

            return data;
        }

        public string Metodo320()
        {
            data = Communication.BuildMessage(TPSejeLMSP.Communications.Commands.motivo320, new List<string> {/* "" */ });

            return data;
        }

    }
}
