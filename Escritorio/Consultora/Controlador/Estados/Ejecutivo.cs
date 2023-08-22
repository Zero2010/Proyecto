using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;

namespace Controlador.Estados
{
  public class Ejecutivo
    {
        Modelo.Conexion conexion = new Modelo.Conexion();
        string[] tipoEjecutivo;

        public string[] nombreEjecutivo()
        {
            tipoEjecutivo = conexion.Ejecutivo();

            return tipoEjecutivo;
        }
    }
}
