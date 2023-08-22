using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;

namespace Controlador.Estados
{
  public class Sucursal
    {
        Modelo.Conexion conexion = new Modelo.Conexion();
        string[] tipoSucursal;

        public string[] nombreSucursal()
        {
            tipoSucursal = conexion.Sucursal();

            return tipoSucursal;
        }
    }
}
