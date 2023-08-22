using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    

    public class Maestra
    {
        private Conexion ObjConexion = new Conexion();
        private string _strEan;
        private string _strSku;
        private string _strDescripcion;
        private List<ViewModelProductos> ListaProductos = new List<ViewModelProductos>();

        public string Ean
        {
            get
            {
                return _strEan;
            }
            set
            {
                _strEan = value;
            }
        }

        public string Sku
        {
            get
            {
                return _strSku;
            }
            set
            {
                _strSku = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _strDescripcion;
            }
            set
            {
                _strDescripcion = value;
            }
        }


        public void ConsultarProducto(string Ean)
        {
            try
            {
                List<ViewModelProductos> lista =  ObjConexion.EjecutarQuery("Select Ean,Descripcion,Sku from MaestraProductos where Ean='" + Ean + "'");

                for (int i = 0; i < lista.Count; i++)
                {
                    Ean         = lista[i].Ean;
                    Descripcion = lista[i].Descripcion;
                    Sku         = lista[i].Sku;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }


}
