using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventarioPro.Models;

namespace InventarioPro.Controllers
{
    public class ProductoController : Controller
    {
        public List<Productos> ListaProducto    = new List<Productos>();
        public List<Productos> ProductoCarga    = new List<Productos>();
        public List<Productos> ProductoRpte     = new List<Productos>();

        public List<Kardex> kardexCarga         = new List<Kardex>();
        public List<Kardex> kardexRpte          = new List<Kardex>();

        public List<CargaDatosViewModel> carga  = new List<CargaDatosViewModel>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CargaMasiva(HttpPostedFileBase file)
        {
            //if (file != null)
            //{
            //    try
            //    {
            //        string resultado            = new StreamReader(file.InputStream).ReadToEnd();
            //        string[] stringSeparators   = new string[] { "\r\n" };
            //        var listado                 = resultado.Split(stringSeparators, StringSplitOptions.None);

            //        foreach (var item in listado)
            //        {
            //            var _listadoProducto     = item.ToString().Split(new[] { '|' });
            //            var cont                 = ProductoCarga.Where(s => s.Ean == _listadoProducto[0]).ToList();
            //            int _cantPro             = 0;
            //            int _cantKar             = 0;

            //            using (InventarioProEntities db = new InventarioProEntities())
            //            {
            //                Productos producto      = new Productos();
            //                producto.Sku            = _listadoProducto[0];
            //                producto.Descripcion    = _listadoProducto[1];
            //                producto.IdLocal        = Convert.ToInt16(_listadoProducto[3]);

            //                _cantPro = (from pro in db.Productos where pro.Sku == producto.Sku select pro).Count();
            //                _cantKar = (from kard in db.Kardex where kard.Sku == producto.Sku select kard).Count();

            //                if (_cantPro > 0)
            //                {
            //                    ProductoRpte.Add(new Productos
            //                    {
            //                        Sku         = _listadoProducto[0],
            //                        Descripcion = _listadoProducto[1],
            //                        IdLocal     = Convert.ToInt16(_listadoProducto[3])
            //                    });
            //                }
            //                else
            //                {
            //                    ProductoCarga.Add(new Productos
            //                    {
            //                        Sku         = _listadoProducto[0],
            //                        Descripcion = _listadoProducto[1],
            //                        IdLocal     = Convert.ToInt16(_listadoProducto[3])
            //                    });

            //                    db.Productos.Add(producto);
            //                    db.SaveChanges();
            //                }



            //                if (_cantKar > 0)
            //                {
            //                    kardexRpte.Add(new Kardex
            //                    {
            //                        Sku             = _listadoProducto[0],
            //                        FechaKardex     = DateTime.Now,
            //                        CantidadKardex  = Convert.ToInt16(_listadoProducto[2]),
            //                        IdProducto      = producto.IdProducto
            //                    }); 
            //                }
            //                else {
            //                    kardexCarga.Add(new Kardex
            //                    {
            //                        Sku                 = _listadoProducto[0],
            //                        FechaKardex         = DateTime.Now,
            //                        CantidadKardex      = Convert.ToInt16(_listadoProducto[2]),
            //                        IdProducto          = producto.IdProducto
            //                    });

            //                    Kardex kardex           = new Kardex();
            //                    kardex.Sku              = _listadoProducto[0];
            //                    kardex.FechaKardex      = DateTime.Now;
            //                    kardex.CantidadKardex   = Convert.ToInt16(_listadoProducto[2]);
            //                    kardex.IdProducto       = producto.IdProducto;


            //                    db.Kardex.Add(kardex);
            //                    db.SaveChanges();
            //                }
            //            }
            //        }



            //        TempData["ListaMaestraRpte"]        = ProductoRpte;
            //        TempData["ListaProductoRpteCount"]  = ProductoRpte.Count() == 0 ? 1 : ProductoRpte.Count();
            //        TempData["ListaMaestra"]            = ProductoCarga;
            //        ViewBag.ListaMaestra                = ProductoCarga;
            //        TempData["ListaProductoCount"]      = ProductoCarga.Count();
            //        TempData["Estado"]                  = 1;

            //        ViewBag.CountProducto               = ProductoCarga.Count();
            //        ViewBag.CountProductoRpt            = ProductoRpte.Count() == 0 ? 1 : ProductoRpte.Count();

            //        Session["CountProducto"]            = ProductoCarga.Count();
            //        Session["CountProductoRpt"]         = ProductoRpte.Count() == 0 ? 1 : ProductoRpte.Count();

            //        TempData["CountProducto"]           = ProductoCarga.Count();
            //        TempData["CountProductoRpt"]        = ProductoRpte.Count() == 0 ? 1 : ProductoRpte.Count();
            //        ViewBag.porcentajeOK                = ProductoCarga.Count() > 0 ? decimal.Round(Decimal.Divide(100, ProductoRpte.Count() + ProductoCarga.Count()) * ProductoCarga.Count(), 2) : 0;
            //        ViewBag.porcentajeError             = ProductoRpte.Count()  > 0 ? decimal.Round(Decimal.Divide(100, ProductoCarga.Count() + ProductoRpte.Count()) * ProductoRpte.Count(), 2) : 0;

            //        carga.Add(new CargaDatosViewModel
            //        {
            //            registroOk      = ProductoCarga.Count(),
            //            registroError   = ProductoRpte.Count(),
            //            porcentajeOK    = ProductoCarga.Count() == 0 ? 0 :(100 / ProductoCarga.Count()),
            //            porcentajeError = ProductoRpte.Count() == 0 ? 0 :(100 / ProductoRpte.Count())
            //        });


            //        ViewData["Registros"] = carga;
            //        return View("../Producto/Index");
            //    }
            //    catch (IOException e)
            //    {
            //        Console.WriteLine("The file could not be read:");
            //        Console.WriteLine(e.Message);

            //        TempData["ListaMaestra"]    = new string[] { "Error", "-1" };
            //        TempData["Estado"]          = -1;
            //        return View();

            //    }
            //}
            //else
            //{
            //    TempData["Estado"] = 0;
            //    return View();
            //}

            return View();
        }

        public ActionResult BusquedaProducto()
        {
            ////using (InventarioProEntities db = new InventarioProEntities())
            ////{

            ////    ListaProducto = (from pro in db.Productos select pro).ToList();

            ////    ViewBag._ListaProductos = ListaProducto.ToList();

            ////}

            return View();
        }

        public ActionResult CreacionProducto() {

            try
            {
                //using (InventarioProEntities db = new InventarioProEntities())
                //{
                //    Productos productos     = new Productos();
                //    productos.Sku           = sku;
                //    productos.Descripcion   = desripcion;
                //    productos.Precio        = precio;
                //    productos.Ean           = ean;
                //    productos.IdLocal       = idlocal;

                //    db.Productos.Add(productos);
                //    db.SaveChanges();
                //}


                using (InventarioProEntities db = new InventarioProEntities())
                {
                    ViewBag._Locales        = (from local in db.View_Locales select local).ToList();
                    ViewBag._TipoUbicacion  = (from TipoUbicacion in db.View_TipoUbicacion select TipoUbicacion).ToList();
                    ViewBag._Ubicacion      = (from Ubicacion in db.View_Ubicacion select Ubicacion).ToList();
                }              

                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult DesactivarProducto()
        {
            using (InventarioProEntities db = new InventarioProEntities())
            {

                ListaProducto = (from pro in db.Productos select pro).ToList();

                ViewBag._ListaProductos = ListaProducto.ToList();

            }

            return View();
        }
    }
}