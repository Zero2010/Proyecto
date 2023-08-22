using System;
using System.Collections.Generic;
using System.Text;
using Controlador.Cotizacion;
using System.IO;

namespace Controlador
{
    class classCotizacion
    {
        //consume el ws enviando los registros del archivo plano.
        public string[] substrings;


        public string [] EjecutarCotizacion(string[] rows, string nombre)
        {
            try
            {
                Controlador.Cotizacion.Cotizacion service = new Controlador.Cotizacion.Cotizacion();

                var Respuesta = service.cotizacion(rows[0], rows[1], rows[2], rows[3], rows[4], rows[5], rows[6], rows[7], rows[8], rows[9], rows[10], rows[11], rows[12], rows[13], rows[14], rows[15], rows[16], rows[17]);
                substrings = new string[Respuesta.Length];
                string cadena = "";

                //genera una ciclo que almacena los errores
                for (int i = 0; i < Respuesta.Length; i++)
                {
                    cadena = "'" + DateTime.Today.ToShortDateString() + "','" + DateTime.Now.ToLongTimeString() + "','" + Convert.ToInt16(i + 1) + "','" + rows[0] + "','" + rows[1] + "','" + Respuesta[i] + "','" + nombre + "'";
                    substrings[i] = cadena;
                }

                return substrings;
            }
            catch (System.IndexOutOfRangeException ex)
            {
                throw ex;
            }
        }

    }
}
