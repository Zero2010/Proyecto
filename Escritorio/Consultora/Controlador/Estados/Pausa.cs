using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class Pausa
    {
        Modelo.Conexion conexion = new Modelo.Conexion();
        string[] tipoPausa;

        public string[] motivosPausa()
        {
            tipoPausa = conexion.cargarPausas();

            return tipoPausa;
        }
    }
}
