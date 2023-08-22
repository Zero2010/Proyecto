using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{

    public class Usuario
    {

        private Conexion ObjConexion    = new Conexion();
        private int cont                = 0;
        private int respuesta           = 0;

        public void CrearUsuario()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            };
        }

        public int ValidarUsuario(string usuario, string password)
        {
            try
            {
                var cont1 = Convert.ToInt32(ObjConexion.EjecutarQuery("Select count(Usuario) as count from Usuario where Usuario='" + usuario + "' and Password='" + password + "'"));

                if (cont >= 1)
                {
                    respuesta = 1;
                }
                else {
                    respuesta = -1;
                }

                return respuesta;
            }
            catch (Exception)
            {

                throw;
            };
        }

        public void ElimianrUsuario()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            };
        }
    }
}
