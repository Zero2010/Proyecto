using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controlador.Estados
{
  public class Motivo
    {
        Modelo.Conexion conexion = new Modelo.Conexion();
        string[] tipoMotivo;

        public string[] motivocierre()
        {
            tipoMotivo = conexion.cargaMotivo();

            return tipoMotivo;
        }
    }
}
