using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using PDato.Models;

namespace PDato.Controllers
{
    public class UsuarioController : Controller
    {
        pasaelda_PasaelDatoEntities db = new pasaelda_PasaelDatoEntities();

        [OutputCache(Duration =10)]
        public ActionResult IniciarSesion(string user, string pasw)
        {

            if (user != null && pasw != null)
            {
                var Validacion = (from usuario in db.Usuario where usuario.Usuario1 == user && usuario.Pass == pasw select usuario).First();

                if (Validacion.IdUsuario != 0)
                {
                    var TipoUsuario = (from tusuario in db.Usuario_x_Cargo_x_TCuenta where tusuario.IdUsuario == Validacion.IdUsuario select tusuario).FirstOrDefault();

                    if (TipoUsuario.IdCargo == 1)//Administrador
                    {
                        return RedirectToAction("Administrador", "Usuario");
                    }
                    else if (TipoUsuario.IdCargo == 2)//Cliente
                    {
                        return RedirectToAction("Cliente", "Usuario");
                    }
                    else if (TipoUsuario.IdCargo == 3)//Motel
                    {
                        return RedirectToAction("AdministradorMotel", "Usuario");
                    }
                }
            }

            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult UpdateUsuario()
        {
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult CreateUsuario()
        {
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult Deleteusuario()
        {
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult AdministradorMotel()
        {
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult Administrador()
        {
            return View();
        }

        [OutputCache(Duration =10)]
        public ActionResult Cliente()
        {
            return View();
        }

    }
}
