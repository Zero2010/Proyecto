using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PDato.Controllers
{
    public class PubController : Controller
    {
        //
        // GET: /Pub/

        [OutputCache(Duration =10)]
        public ActionResult ListadoPub()
        {
            return View();
        }

    }
}
