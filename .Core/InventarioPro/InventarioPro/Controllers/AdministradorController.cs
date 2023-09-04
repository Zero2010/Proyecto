using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using InventarioPro.Models;

namespace InventarioPro.Controllers
{
    public class AdministradorController : Controller
    {
        // GET: Administrador
        private string  _linkPag;
        private string  _DiferenciaCapturaFaltante;
        private string  _DiferenciaCapturaSobrante;

        public ActionResult Index()
        {
            try
            {
                using (InventarioProEntities db = new InventarioProEntities())
                {
                    var _DiferenciaCapturaFaltante_     = (from diferencia in db.View_CantDiferenciaNegativa select diferencia).ToList();
                    var _DiferenciaCapturaSobrante_     = (from diferencia in db.View_CantDiferenciaPositiva select diferencia).ToList();

                    _DiferenciaCapturaFaltante          = _DiferenciaCapturaFaltante_[0].Diferencia.ToString().Replace(",00", "");
                    _DiferenciaCapturaSobrante          = _DiferenciaCapturaSobrante_[0].Diferencia.ToString().Replace(",00", "");

                    ViewBag._SkuCapturados              = (from SkuCapturado    in db.View_SkuCapturados    select SkuCapturado).ToList();
                    ViewBag._DiferenciaCapturaFaltante  = _DiferenciaCapturaFaltante;
                    ViewBag._DiferenciaCapturaSobrante  = _DiferenciaCapturaSobrante;
                }

                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpGet]
        public JsonResult GetChartDataNeg()
        {
            try
            {
                using (InventarioProEntities db = new InventarioProEntities())
                {
                    // Generar datos de ejemplo (puedes reemplazar esto con tus propios datos)

                    var labels  = (from valores in db.SP_ListadoDiferenciaNegativa() select valores.Descripcion.Substring(0, 15)).ToList();
                    var values  = (from valores in db.SP_ListadoDiferenciaNegativa() select valores.Diferencia).ToList();
                    var data    = new { labels, values };

                    return Json(data, JsonRequestBehavior.AllowGet);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet]
        public JsonResult GetChartDataPos()
        {
            try
            {
                using (InventarioProEntities db = new InventarioProEntities())
                {
                    // Generar datos de ejemplo (puedes reemplazar esto con tus propios datos)

                    var labels  = (from valores in db.SP_ListadoDiferenciaPositiva() select valores.Descripcion.Substring(0, 15)).ToList();
                    var values  = (from valores in db.SP_ListadoDiferenciaPositiva() select valores.Diferencia).ToList();
                    var data    = new { labels, values };

                    return Json(data, JsonRequestBehavior.AllowGet);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}