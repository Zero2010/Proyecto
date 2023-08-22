using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
   public class FPrincipal
    {

        public Dictionary<int, string> Telefono()
        {
            Dictionary<int, string> telefono = new Dictionary<int, string>();
            telefono.Add(0, "--Seleccione Opción--");
            telefono.Add(1, "(00)0-0000-0000");
            telefono.Add(2, "00000-0000");
            telefono.Add(3, "0000-0000");
            return telefono;
        }

    }

}
