using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PDato.Models;

namespace PDato.Controllers
{
    public class HomeController : Controller
    {

        pasaelda_PasaelDatoEntities pdato = new pasaelda_PasaelDatoEntities();

        [OutputCache(Duration =10)]
        public ActionResult Index()
        {
            ViewBag.portada = pdato.Portada_x_Carrusel().ToList();

            ViewBag.Iportada = (from p in pdato.Portada_x_Carrusel()
                                select new Portada_x_Carrusel_Result {
                                    NombreSucursal  =   p.NombreSucursal,
                                    Nosotros        =   p.Nosotros,
                                    ImagenBase64    =   string.Format("data:image/jpg;base64,{0}", p.ImagenBase64),
                                    PortadaPath     =   p.PortadaPath,
                                    IdSucursal      =   p.IdSucursal
                                });

            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult Motel(int id)
        {
            ViewBag.portada = pdato.Portada_x_Motel(id).ToList();
            ViewBag.menu = pdato.MenuIndex().ToList();
            ViewBag.Habitaciones = pdato.Habitacion_x_Motel(0).ToList();
            ViewBag.horario = pdato.HorarioHabitacion(id).ToList();
            ViewBag.precio = pdato.Precio_x_Producto().ToList();
      
            ViewBag.fpago = pdato.FPagoSucursal(id).ToList();
            return View();
        }


        [OutputCache(Duration =10)]
        public ActionResult Promociones()
        {
            return View();
        }


        [OutputCache(Duration =10)]
        public ActionResult Novedades()
        {
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult Listado()
        {
            ViewBag.menu = pdato.MenuIndex().ToList();
            ViewBag.imagen = pdato.ListadoMoteles().ToList();
            ViewBag.servicio_x_sucursal = pdato.Servicio_x_Sucursal().ToList();
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult Contacto()
        {
            return View();
        }
    }
}
