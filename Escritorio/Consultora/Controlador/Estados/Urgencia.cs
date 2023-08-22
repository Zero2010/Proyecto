using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;

namespace Controlador.Estados
{
 public class Urgencia
    {
        Modelo.Conexion conexion = new Modelo.Conexion();
        string[] tipoUrgencia;

        public string[] motivourgencia()
        {
            tipoUrgencia = conexion.cargaUrgencia();

            return tipoUrgencia;
        }
    }
}