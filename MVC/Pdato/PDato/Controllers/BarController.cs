using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PDato.Controllers
{
    public class BarController : Controller
    {
        //
        // GET: /Bar/

        [OutputCache(Duration =10)]
        public ActionResult ListadoBar()
        {
            return View();
        }

    }
}
