using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;

namespace Controlador
{
    public class Transaction
    {
        Controlador.Cryptography encriptar = new Controlador.Cryptography();
        Controlador.AtencionesTxt atencion = new Controlador.AtencionesTxt();
        Controlador.RespuestaAtenciones ratenciones = new Controlador.RespuestaAtenciones();
        public string respuestaEncriptada;
        public string respuestaDescriptar;

        public string Ingreso(string rut, string telefono,string turno)
        {

            respuestaEncriptada = encriptar.cifrar(rut + "|" + telefono + "|" + turno );
            respuestaDescriptar = encriptar.descifrar(respuestaEncriptada);

            return "";
        }
    }
}
