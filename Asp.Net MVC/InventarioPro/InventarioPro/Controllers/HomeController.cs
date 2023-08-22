using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventarioPro.Models;

namespace InventarioPro.Controllers
{
    public class HomeController : Controller
    {

        private string _linkPag;
        // GET: Home
        public ActionResult Index()
        {
            try
            {
                using (InventarioProEntities db = new InventarioProEntities())
                {
                    ViewBag._SkuCapturados = (from SkuCapturado in db.View_SkuCapturados select SkuCapturado.CountSku).ToList();
                }
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string User, string Pass)
        {
            List<Usuario> usuario = new List<Usuario>();
            //string _linkPag;

            using (InventarioProEntities db = new InventarioProEntities())
            {
                usuario = (from usu in db.Usuario where usu.Usuario1 == User && usu.Clave.Contains(Pass) select usu).ToList();

                if (usuario.Count() > 0)
                {
                    var TUsuario        = usuario[0].TipoUsuario.ToList();
                    var IdTUsuario      = TUsuario[0].IdTUsuario;
                    var _link           = (from link in db.TipoUsuario where link.IdTUsuario == IdTUsuario select link.Link).ToList();
                    _linkPag            = _link[0].ToString();

                    TempData["Usuario"] = usuario[0].Usuario1.ToString();
                    return RedirectToAction(_linkPag);
                }
                else {
                    TempData["ErrorLogin"] = "Usuario u Clave ingresada no son correctas!!";
                    return RedirectToAction("../Home/Login");
                }
            }
        }
    }
}