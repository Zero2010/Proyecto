using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventarioPro.Models;

namespace InventarioPro.Controllers
{
    public class CapturaController : Controller
    {
        List<Productos> capturaP                = new List<Productos>();
        List<Captura> maestra                   = new List<Captura>();
        InventarioProEntities db                = new InventarioProEntities();
        public List<Productos> ListaProducto    = new List<Productos>();


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string codigo)
        {
            if (codigo == null || codigo == "")
            {
                return View();
            }
            else
            {
                List<Productos> productos   = (from p in db.Productos where p.Ean == codigo || p.Sku == codigo select p).ToList();
                TempData["Descripcion"]     = productos[0].Descripcion;
                ViewBag.Descripcion         = productos[0].Descripcion;
                TempData["IsCaptura"]       = -1;
                return View(productos);
            }
        }


        [HttpPost]
        public ActionResult CapturaInventario(string descripcion, DateTime fecha, int cantidad, string lote)
        {

            using (InventarioProEntities db = new InventarioProEntities())
            {
                if (cantidad != 0 || cantidad > 0)
                {
                    capturaP = (from pro in db.Productos where pro.Descripcion.Contains(descripcion) select pro).ToList();

                    if (capturaP.Count() > 0)
                    {
                        Captura captura             = new Captura();
                        captura.CantidadCaptura     = cantidad;
                        captura.FechaCaptura        = DateTime.Now;
                        captura.IdProducto          = capturaP[0].IdProducto;
                        captura.FechaLote           = fecha;
                        captura.Lote                = lote;
                        captura.Sku                 = capturaP[0].Sku ;


                        var Cant = (from cap in db.Captura select cap).ToList();
                        if (Cant.Count > 20)
                        {
                            TempData["LimiteCaptura"] = "Usted a alcanzado el limite de registros capturados, contacte al administrador";
                        }
                        else {
                            db.Captura.Add(captura);
                            db.SaveChanges();
                        }

                        TempData["IsCaptura"]   = 1;
                        ViewBag.IsCaptura       = 1;
                    }
                    else
                    {
                        TempData["IsCaptura"]   = 0;
                        ViewBag.IsCaptura       = 0;
                    }
                }
                else
                {
                    TempData["IsCaptura"]   = 0;
                    ViewBag.IsCaptura       = 0;
                }

                ViewBag._Locales        = (from local in db.View_Locales select local).ToList();
                ViewBag._TipoUbicacion  = (from TipoUbicacion in db.View_TipoUbicacion select TipoUbicacion).ToList();
                ViewBag._Ubicacion      = (from Ubicacion in db.View_Ubicacion select Ubicacion).ToList();


                return RedirectToAction("IngresoDescripcion", "Captura");
            }
        }

        public ActionResult IngresoDescripcion()
        {
            using (InventarioProEntities db = new InventarioProEntities())
            {
                ViewBag._ListaProductos = db.SP_ListadoProductos().ToList();
                ViewBag._Locales        = (from local in db.View_Locales select local).ToList();
                ViewBag._TipoUbicacion  = (from TipoUbicacion in db.View_TipoUbicacion select TipoUbicacion).ToList();
                ViewBag._Ubicacion      = (from Ubicacion in db.View_Ubicacion select Ubicacion).ToList();

            }

            return View("");
        }

        [HttpPost]
        public ActionResult IngresoDescripcion(string ubicacion, string descripcion, int cantidad)
        {
            return View("");
        }

        public ActionResult DiferenciaCaptura()
        {

            using (InventarioProEntities db = new InventarioProEntities())
            {
                ViewBag._DiferenciaCaptura = db.SP_ListadoDiferenciaNegativa().ToList();
            }

            return View();
        }

    }
}