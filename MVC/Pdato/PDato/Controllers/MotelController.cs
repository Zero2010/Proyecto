using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using PDato.Models;


namespace PDato.Controllers
{
    public class MotelController : Controller
    {

        pasaelda_PasaelDatoEntities pdato = new pasaelda_PasaelDatoEntities();

        [OutputCache(Duration =10)]
        public ActionResult DetalleMotel(int id)
        {
            ViewBag.menu = pdato.MenuIndex().ToList();
            ViewBag.Habitaciones = pdato.Habitacion_x_Motel_x_Detalle(id).ToList();
            ViewBag.portada = pdato.Portada_x_Motel(id).ToList();

            var lImagen = (from i in pdato.Portada_x_Motel(id) select i.ImagenBase64).ToList();
            string imageDataURL = string.Format("data:image/jpg;base64,{0}", lImagen[0]);
            ViewBag.iPortada = imageDataURL;

            ViewBag.horario = pdato.HorarioHabitacion(id).ToList();
            ViewBag.servicio_x_Habitacion = pdato.Servicio_x_Habitacion().ToList();
            ViewBag.precio = pdato.Precio_x_Producto().ToList();
            ViewBag.TelefonoSucursal = pdato.Sucursal_x_Telefonos(id).ToList();
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult DetalleHabitacion(int id)
        {
            ViewBag.menu = pdato.MenuIndex().ToList();
            ViewBag.ImagenHabitacion = pdato.Imagen_x_Habitacion(id).ToList();
            ViewBag.ServicioHabitacion = pdato.Detalle_x_SHabitacion(id).ToList();
            ViewBag.PrecioHabitacion = pdato.Precio_x_Habitacion(id).ToList();
            ViewBag.precio = pdato.Precio_x_Producto().ToList();
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult ListaMotel()
        {
            return View();
        }


        [OutputCache(Duration =10)]
        public ActionResult Productos()
        {
            return View();
        }


        [OutputCache(Duration =10)]
        public ActionResult Vip()
        {
            ViewBag.menu = pdato.MenuIndex().ToList();
            ViewBag.Habitaciones = pdato.Habitacion_x_Motel(1).ToList();
            ViewBag.horario = pdato.HorarioHabitacion(1).ToList();
            ViewBag.servicio_x_Habitacion = pdato.Servicio_x_Habitacion().ToList();
            ViewBag.precio = pdato.Precio_x_Producto().ToList();
            ViewBag.minimo = (from min in pdato.Precio_x_Producto() select min.Precio).Min();
            ViewBag.maximo = (from min in pdato.Precio_x_Producto() select min.Precio).Max();
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult Jacuzzi()
        {
            ViewBag.menu = pdato.MenuIndex().ToList();
            ViewBag.Habitaciones = pdato.Habitacion_x_Motel(2).ToList();
            ViewBag.horario = pdato.HorarioHabitacion(1).ToList();
            ViewBag.servicio_x_Habitacion = pdato.Servicio_x_Habitacion().ToList();
            ViewBag.precio = pdato.Precio_x_Producto().ToList();
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult Ambientacion()
        {
            ViewBag.menu = pdato.MenuIndex().ToList();
            ViewBag.Habitaciones = pdato.Habitacion_x_Motel(3).ToList();
            ViewBag.horario = pdato.HorarioHabitacion(1).ToList();
            ViewBag.servicio_x_Habitacion = pdato.Servicio_x_Habitacion().ToList();
            ViewBag.precio = pdato.Precio_x_Producto().ToList();

            ViewBag.minimo = (from m in pdato.Precio_x_Producto_x_Min() select m).First();
            ViewBag.maximo = (from m in pdato.Precio_x_Producto_x_Max() select m).First();

            ViewBag.comunas = (from c in pdato.Comuna where c.IdRegion ==13 select c).ToList();
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult SexShop()
        {
            ViewBag.menu = pdato.MenuIndex().ToList();
            ViewBag.Habitaciones = pdato.Habitacion_x_Motel(4).ToList();
            ViewBag.horario = pdato.HorarioHabitacion(1).ToList();
            ViewBag.servicio_x_Habitacion = pdato.Servicio_x_Habitacion().ToList();
            ViewBag.precio = pdato.Precio_x_Producto().ToList();
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult Promociones()
        {
            ViewBag.menu = pdato.MenuIndex().ToList();
            ViewBag.Habitaciones = pdato.Habitacion_x_Motel(5).ToList();
            ViewBag.horario = pdato.HorarioHabitacion(1).ToList();
            ViewBag.servicio_x_Habitacion = pdato.Servicio_x_Habitacion().ToList();
            ViewBag.precio = pdato.Precio_x_Producto().ToList();
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult Nuevos()
        {
            ViewBag.menu = pdato.MenuIndex().ToList();
            ViewBag.Habitaciones = pdato.Habitacion_x_Motel(6).ToList();
            ViewBag.horario = pdato.HorarioHabitacion(1).ToList();
            ViewBag.servicio_x_Habitacion = pdato.Servicio_x_Habitacion().ToList();
            ViewBag.precio = pdato.Precio_x_Producto().ToList();
            return View();
        }


        [OutputCache(Duration =10)]
        public ActionResult SilladelAmor()
        {
            ViewBag.menu = pdato.MenuIndex().ToList();
            ViewBag.Habitaciones = pdato.Habitacion_x_Motel(7).ToList();
            ViewBag.horario = pdato.HorarioHabitacion(1).ToList();
            ViewBag.servicio_x_Habitacion = pdato.Servicio_x_Habitacion().ToList();
            ViewBag.precio = pdato.Precio_x_Producto().ToList();
            return View();
        }
       
        [OutputCache(Duration =10)]
        public ActionResult Suite()
        {
            ViewBag.menu = pdato.MenuIndex().ToList();
            ViewBag.Habitaciones = pdato.Habitacion_x_Motel(8).ToList();
            ViewBag.horario = pdato.HorarioHabitacion(1).ToList();
            ViewBag.servicio_x_Habitacion = pdato.Servicio_x_Habitacion().ToList();
            ViewBag.precio = pdato.Precio_x_Producto().ToList();
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult Habitacion()
        {
            ViewBag.menu = pdato.MenuIndex().ToList();
            ViewBag.Habitaciones = pdato.Habitacion_x_Motel(9).ToList();
            ViewBag.horario = pdato.HorarioHabitacion(1).ToList();
            ViewBag.servicio_x_Habitacion = pdato.Servicio_x_Habitacion().ToList();
            ViewBag.precio = pdato.Precio_x_Producto().ToList();
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult TopTen()
        {
            ViewBag.menu = pdato.MenuIndex().ToList();
            ViewBag.Habitaciones = pdato.Habitacion_x_Motel(10).ToList();
            ViewBag.horario = pdato.HorarioHabitacion(1).ToList();
            ViewBag.servicio_x_Habitacion = pdato.Servicio_x_Habitacion().ToList();
            ViewBag.precio = pdato.Precio_x_Producto().ToList();
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult PoloDance()
        {
            ViewBag.menu = pdato.MenuIndex().ToList();
            ViewBag.Habitaciones = pdato.Habitacion_x_Motel(12).ToList();
            ViewBag.horario = pdato.HorarioHabitacion(1).ToList();
            ViewBag.servicio_x_Habitacion = pdato.Servicio_x_Habitacion().ToList();
            ViewBag.precio = pdato.Precio_x_Producto().ToList();
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult Golden()
        {
            ViewBag.menu = pdato.MenuIndex().ToList();
            ViewBag.Habitaciones = pdato.Habitacion_x_Motel(13).ToList();
            ViewBag.horario = pdato.HorarioHabitacion(1).ToList();
            ViewBag.servicio_x_Habitacion = pdato.Servicio_x_Habitacion().ToList();
            ViewBag.precio = pdato.Precio_x_Producto().ToList();
            return View();
        }

    }
}
