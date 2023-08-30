using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventarioPro.Models;
using InventarioPro.Clases;

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

            string originalText = "YetAnotherSecretMessage789";

            var (key, iv) = AESEncryption.GenerateKeyAndIV();

            string encryptedText = AESEncryption.Encrypt(originalText, key, iv);
            Console.WriteLine($"Encrypted: {encryptedText}");

            string decryptedText = AESEncryption.Decrypt(encryptedText, key, iv);
            Console.WriteLine($"Decrypted: {decryptedText}");


            using (InventarioNvoEntities db = new InventarioNvoEntities())
            {
                var     _pass            = (from _usu in db.Usuario select _usu).ToString();


                usuario = (from _user in db.Usuario select _user).ToList();

                if (usuario.Count() > 0)
                {
                    var TUsuario        = usuario[0].User_TipoUsuario.ToList();
                    var IdTUsuario      = TUsuario[0].idTipoUsuario;
                    var _link           = (from link in db.TipoUsuario where link.idTipoUsuario == IdTUsuario select link.link).ToList();
                    _linkPag            = _link[0].ToString();

                    TempData["Usuario"] = usuario[0].User.ToString();
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