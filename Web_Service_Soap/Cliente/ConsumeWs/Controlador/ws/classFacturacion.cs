using System;
using System.Collections.Generic;
using System.Text;

namespace Controlador
{
    class classFacturacion
    {

        public string[] substrings;

        public string[] EjecutarFacturacion(string[] rows, string nombre)
        {
            try
            {
                Controlador.Facturacion.facturacion service = new Controlador.Facturacion.facturacion();

                var Respuesta = service.Facturacion(rows[0], rows[1], rows[2], rows[3], rows[4], rows[5], rows[6], rows[7], rows[8], rows[9], rows[10], rows[11], rows[12], rows[13], rows[14], rows[15], rows[16], rows[17], rows[18], rows[19], rows[20], rows[21], rows[21], rows[22], rows[23], rows[24], rows[25], rows[26], rows[27], rows[28], rows[29], rows[30], rows[31], rows[32]);
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
