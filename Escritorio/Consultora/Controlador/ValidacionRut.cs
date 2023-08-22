using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ValidacionRut
    {
        string dv;
        Boolean respuesta;
        string mensaje="";

        public string formatearRut(string rut)
        {
            int cont = 0;
            string format;
            if (rut.Length == 0)
            {
                return "";
            }
            else
            {
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                format = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {
                    format = rut.Substring(i, 1) + format;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "." + format;
                        cont = 0;
                    }
                }
                return format;
            }
        }


        public Boolean ValidarRut(String rut, String dv)
        {
            var longitud = rut.Length;
            var factor = 2;
            var sumaProducto = 0;
            var con = 0;
            var caracter = 0;

            for (con = longitud - 1; con >= 0; con--)
            {
                caracter = Int32.Parse(rut.Substring(con, 1));
                sumaProducto += (factor * caracter);
                factor++; if (factor > 7) factor = 2;
            }

            var digitoAuxiliar = 11 - (sumaProducto % 11);
            var caracteres = "-123456789K0";
            var digitoCaracter = caracteres.Substring(digitoAuxiliar, 1);
            return dv.ToUpper().Equals(digitoCaracter);
        }


        public string SepararRut(string rut)
        {
            try
            {
                if (rut.Length >= 11 || rut.Length >= 9)
                {
                    rut = rut.Replace(".", "").Replace("-", "");
                    dv = rut.Substring(rut.Length - 1, 1);
                    rut = rut.Substring(0, rut.Length - 1);

                    respuesta = ValidarRut(rut, dv);

                    mensaje = Convert.ToString(respuesta);
                }
                else if (rut.Length==0)
                {
                    mensaje = "No ha Ingresado Rut";
                }
                else
                {
                    mensaje = "Error en el tamaño del rut";
                }
                return mensaje;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
