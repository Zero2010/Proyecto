using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIsla_Crud_V1.Models
{
    public class EmpleadoController : Controller
    {
        CrudFIslaEntities db = new CrudFIslaEntities();

        public ActionResult Index()
        {
            ViewBag.ListadoEmpleado = db.Empleado.ToList();
            return View();
        }

        [HttpGet]
        public JsonResult FiltrarPorCategoria(int id)
        {
            if (id == 0)
            {
                var lista = db.Empleado.Select(x => new
                {
                    idempleado  = x.IdEmpleado,
                    nombre      = x.Nombre,
                    apaterno    = x.Apaterno,
                    amaterno    = x.Amaterno,
                    rut         = x.Rut,
                    Categorias = new { idempleado = x.IdEmpleado, nombre = x.Nombre}
                });
                return Json(lista, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var lista = db.Empleado.Where(x => x.IdEmpleado == id).Select(x => new
                {
                    idempleado = x.IdEmpleado,
                    nombre = x.Nombre,
                    apaterno = x.Apaterno,
                    amaterno = x.Amaterno,
                    rut = x.Rut,
                    Categorias = new { idempleado = x.IdEmpleado, nombre = x.Nombre }
                });
                return Json(lista, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Modificar(int id)
        {
            var Listado = db.Empleado.Where(x => x.IdEmpleado == id).First();
            ViewBag.Filtro = Listado;

            return View();
        }


        [HttpPost]
        public ActionResult Edit(int id, string Nombre, string Apaterno, string Amaterno, string Rut)
        {
            var lista = db.Empleado.Where(x => x.IdEmpleado == id).First();
            lista.Nombre = Nombre;
            lista.Apaterno = Apaterno;
            lista.Amaterno = Amaterno;
            lista.Rut = Rut;
            db.SaveChanges();
            Response.Redirect("/Empleado/Index");
            return View();
        }

        public ActionResult Detalle(int id)
        {
            var ListadoPersonal = db.Empleado.Where(x => x.IdEmpleado == id).First();
            ViewBag.Detalle = ListadoPersonal;

            return View();
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            var obj = db.Empleado.Where(x => x.IdEmpleado == id).First();
            db.Empleado.Remove(obj);
            db.SaveChanges();
            Response.Redirect("/Empleado/Index");
            return View();
        }

        [HttpGet]
        public JsonResult EliminarPersonal(int id)
        {
            var lista = db.Empleado.Where(x => x.IdEmpleado == id).Select(x => new
            {
                idempleado = x.IdEmpleado,
                nombre = x.Nombre,
                apaterno = x.Apaterno,
                amaterno = x.Amaterno,
                rut = x.Rut,
                Categorias = new { idempleado = x.IdEmpleado, nombre = x.Nombre }
            });
            return Json(lista, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(string Nombre, string Apaterno, string Amaterno, string Rut)
        {
            var validar = db.Empleado.Where(x => x.Nombre == Nombre && x.Apaterno == Apaterno && x.Amaterno==Amaterno && x.Rut == Rut).Count();

            if (validar == 0)
            {
                Empleado AgregarEmpleado = new Empleado();
                AgregarEmpleado.Nombre = Nombre;
                AgregarEmpleado.Apaterno = Apaterno;
                AgregarEmpleado.Amaterno = Amaterno;
                AgregarEmpleado.Rut = Rut;
                db.Empleado.Add(AgregarEmpleado);
                db.SaveChanges();
            }
            return Redirect("~/Empleado/index");
        }
    }
}