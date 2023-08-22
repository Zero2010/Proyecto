using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnoWs.clases
{
    public class ClassValidaciones
    {

        string rut;
        string dv;
        int largo_cadena;
        string mensaje;

        public string IngresarRut(string mirut)
        {
            mirut = mirut.Replace("-", "");
            largo_cadena = mirut.Length;
            dv = mirut.Substring(largo_cadena - 1);
            rut = mirut.Remove(mirut.Length - 1);

            if (rut.Length == 7 || rut.Length == 8)
            {
                mensaje = ValidadRut(Convert.ToInt32(rut), dv);
            }
            else
            {
                mensaje = "El Largo del Rut no es el Correcto";
            }


            return mensaje;
        }


        public String ValidadRut(int rut, string dv)
        {
            int suma = 0;
            int multiplicador = 1;
            while (rut != 0)
            {
                multiplicador++;
                if (multiplicador == 8)
                    multiplicador = 2;
                suma += (rut % 10) * multiplicador;
                rut = rut / 10;
            }

            suma = 11 - (suma % 11);
            if (suma == 11)
            {
                return mensaje = "Rut Ingreso es Correcto";
            }
            else if (suma == 10)
            {
                return mensaje = "Rut Ingreso es Correcto";
            }
            else if (suma == 1 || suma == 2 || suma == 3 || suma == 4 || suma == 5 || suma == 6 || suma == 7 || suma == 8 || suma == 9)
            {
                return mensaje = "Rut Ingreso es Correcto";
            }
            else
            {
                return mensaje = "Rut Ingreso es Correcto";
            }

        }




    }
}