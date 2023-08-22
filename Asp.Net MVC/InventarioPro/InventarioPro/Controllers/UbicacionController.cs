using InventarioPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventarioPro.Controllers
{
    public class UbicacionController : Controller
    {
        // GET: Ubicacion
        public ActionResult Index()
        {

            using (InventarioProEntities db = new InventarioProEntities())
            {
                ViewBag._ListaUbicaciones = db.SP_ListadoUbicaciones().ToList();
            }

            return View();
        }
    }
}