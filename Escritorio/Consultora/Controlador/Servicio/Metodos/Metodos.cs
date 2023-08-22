using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Controlador.Metodos
{
 public class Metodos
    {

        public void Archivo_Plano(string path, string[] archivo, string fecha)
        {
            if (Directory.Exists(path))
            {
                using (StreamWriter file = new StreamWriter(path + fecha, true))
                {
                    foreach (var item in archivo)
                    {
                        file.WriteLine(item);
                    }

                    file.Close();
                }
            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(path);

                using (StreamWriter file = new StreamWriter(path + fecha, true))
                {
                    foreach (var item in archivo)
                    {
                        file.WriteLine(item);
                    }

                    file.Close();
                }
            }
        }

        public void Archivo_Plano(string path, string archivo, string fecha)
        {
            if (Directory.Exists(path))
            {
                using (StreamWriter file = new StreamWriter(path + fecha, true))
                {
                    for (int i = 0; i < archivo.Length; i++)
                    {
                        file.WriteLine(archivo);
                        break;
                    }

                    file.Close();
                }
            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(path);

                using (StreamWriter file = new StreamWriter(path + fecha, true))
                {
                    for (int i = 0; i < archivo.Length; i++)
                    {
                        file.WriteLine(archivo);
                        break;
                    }

                    file.Close();
                }
            }
        }

        public string IsNumeric(string valor)
        {
            bool isNumber;
            double isItNumeric;
            valor = valor.Replace("-", "").Replace("(", "").Replace(")","");
            isNumber = Double.TryParse(Convert.ToString(valor), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out isItNumeric);
            return Convert.ToString(isNumber);
        }


        public int validarTelefono(string telefono)
        {
            int valor=0;
            var validar = telefono.Length;

            if (validar >= 10)
            {
                valor = 1;
            }
            else if (validar < 10)
            {
                valor = -1;
            }

            return valor;
        }

    }
}
