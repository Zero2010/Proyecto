using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;

namespace Controlador.Estados
{
 public class Transmicion
    {
        Modelo.Conexion conexion = new Modelo.Conexion();
        string[] tipoTransmicion;

        public string[] motivotransmicion(string path)
        {
            tipoTransmicion = conexion.Transmicion(path);

            return tipoTransmicion;
        }
    }
}
