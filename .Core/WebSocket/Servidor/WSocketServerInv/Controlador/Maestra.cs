using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class Maestra
    {

        InvProContext db = new InvProContext();

        public List<MaestraProducto> Buscar(string Ean)
        {
            List<MaestraProducto> maestraProductos = db.MaestraProductos.Where(b => b.Ean == Ean).ToList();

            return maestraProductos;
        }


    }
}
