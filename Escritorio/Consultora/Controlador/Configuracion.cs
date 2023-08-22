using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Configuration;

namespace Controlador
{
 public class Configuracion
    {
        public string Idejecutivo { set; get; }
        public string Usuario { set; get; }
        public string Contrasenia { set; get; }
        public string Ip { set; get; }
        public string Puerto { set; get; }

        public string idEscritorio = ConfigurationManager.AppSettings["IdEscritorio"];
        public string idSerie = ConfigurationManager.AppSettings["IdSerie"];
        public string idEje = ConfigurationManager.AppSettings["IdEje"];

        Modelo.Conexion conexion = new Modelo.Conexion();

        public string Login()
        {
            //conexion.Ip;

            return "";
        }

    }
}
