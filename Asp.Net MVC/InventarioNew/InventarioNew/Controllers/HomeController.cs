using InventarioNew.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using InventarioNew.Class;

namespace InventarioNew.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string key      = "mysecretkey12345"; // Llave secreta
        private string iv       = "1234567890123456"; // Vector de inicialización
        private string _path    = "";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            using (var db = new InventarioNvoContext())
            {
                string encryptedText = Cryptography.Encrypt(password, key, iv);
                string decryptedText = Cryptography.Decrypt(encryptedText, key, iv);

                var _User = (from _userLogin in db.Usuarios where _userLogin.User == username select _userLogin).ToList();

                if (_User[0].Password == encryptedText && _User[0].IsEstado == true)
                {
                    _path = "../Home/Index";
                }
                else
                {
                    _path = "../Home/Login";
                }

            }

            return View(_path);
        }
    }
}