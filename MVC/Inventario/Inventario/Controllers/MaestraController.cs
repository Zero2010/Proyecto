using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inventario.ViewModel;
using Inventario.Models;

namespace Inventario.Controllers
{
    public class MaestraController : Controller
    {
        // GET: MA

        public List<MaestraController>      ListaMaestra = new List<MaestraController>();
        public List<MaestraViewModel>       MaestraCarga = new List<MaestraViewModel>();
        public List<MaestraErrorViewModel>  MaestraRpte  = new List<MaestraErrorViewModel>();
        public InventarioEntities db = new InventarioEntities();


        public ActionResult Index(HttpPostedFileBase file)
        {
            if (file != null)
            {
                try
                {
                    string resultado            = new StreamReader(file.InputStream).ReadToEnd();
                    string[] stringSeparators   = new string[] { "\r\n" };
                    var listado                 = resultado.Split(stringSeparators, StringSplitOptions.None);

                    foreach (var item in listado)
                    {
                        var listadoMaestra = item.ToString().Split(new[] { '|' });

                        var cont = MaestraCarga.Where(s => s.EAN == listadoMaestra[20]).ToList();

                        if (cont.Count == 0)
                        {
                            MaestraCarga.Add(new MaestraViewModel
                            {
                                NUMCONTEO               = listadoMaestra[0],
                                FECHA                   = listadoMaestra[1],
                                CODIGO_INTERNO          = listadoMaestra[2],
                                LOCALES                 = listadoMaestra[3],
                                TIPO_INVENTARIO         = listadoMaestra[4],
                                DESCRIPCION             = listadoMaestra[5],
                                MARCA                   = listadoMaestra[6],
                                UNIDAD_MEDIDA           = listadoMaestra[7],
                                PRECIO                  = listadoMaestra[8],
                                MONEDA                  = listadoMaestra[9],
                                SUB_CLASE               = listadoMaestra[10],
                                DESCRIPCION_SUBCLASE    = listadoMaestra[11],
                                CLASE                   = listadoMaestra[12],
                                DESCRIPCION_CLASE       = listadoMaestra[13],
                                SUB_DEPARTAMENTO        = listadoMaestra[14],
                                DESCRIPCION_SUB_DPTO    = listadoMaestra[15],
                                DEPARTAMENTO            = listadoMaestra[16],
                                DESCRIPCION_DPTO        = listadoMaestra[17],
                                FECHA_CREACION_ARCHIVO  = listadoMaestra[18],
                                TIPO_CODBARRA           = listadoMaestra[19],
                                EAN                     = listadoMaestra[20],
                                CANTIDAD                = listadoMaestra[21].Replace(".0000", "0")
                            });
                        }
                        else
                        {
                            MaestraRpte.Add(new MaestraErrorViewModel
                            {
                                NUMCONTEO               = listadoMaestra[0],
                                FECHA                   = listadoMaestra[1],
                                CODIGO_INTERNO          = listadoMaestra[2],
                                LOCALES                 = listadoMaestra[3],
                                TIPO_INVENTARIO         = listadoMaestra[4],
                                DESCRIPCION             = listadoMaestra[5],
                                MARCA                   = listadoMaestra[6],
                                UNIDAD_MEDIDA           = listadoMaestra[7],
                                PRECIO                  = listadoMaestra[8],
                                MONEDA                  = listadoMaestra[9],
                                SUB_CLASE               = listadoMaestra[10],
                                DESCRIPCION_SUBCLASE    = listadoMaestra[11],
                                CLASE                   = listadoMaestra[12],
                                DESCRIPCION_CLASE       = listadoMaestra[13],
                                SUB_DEPARTAMENTO        = listadoMaestra[14],
                                DESCRIPCION_SUB_DPTO    = listadoMaestra[15],
                                DEPARTAMENTO            = listadoMaestra[16],
                                DESCRIPCION_DPTO        = listadoMaestra[17],
                                FECHA_CREACION_ARCHIVO  = listadoMaestra[18],
                                TIPO_CODBARRA           = listadoMaestra[19],
                                EAN                     = listadoMaestra[20],
                                CANTIDAD                = listadoMaestra[21].Replace(".0000", "0")
                            });
                        }

                    }

                    TempData["ListaMaestraRpte"]        = MaestraRpte;
                    TempData["ListaMaestraRpteCount"]   = MaestraRpte.Count();
                    TempData["ListaMaestra"]            = MaestraCarga;
                    ViewBag.ListaMaestra                = MaestraCarga;
                    TempData["ListaMaestraCount"]       = MaestraCarga.Count();
                    TempData["Estado"]                  = 1;
                    return View();

                }
                catch (IOException e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);

                    TempData["ListaMaestra"]        = new string[] { "Error", "-1" };
                    TempData["Estado"]              = -1;
                    return View();

                }
            }
            else
            {
                TempData["Estado"]                  = 0;
                return View();
            }

        }

        public void InsertarRegistro()
        {
            var maestra = TempData["ListaMaestra"] as IEnumerable<Inventario.ViewModel.MaestraViewModel>;

            using (InventarioEntities db = new InventarioEntities())
            {
                MAESTRA_PROCESO objEmp = new MAESTRA_PROCESO();
                foreach (var m in maestra)
                {
                    objEmp.NUMCONTEO              = m.EAN;
                    objEmp.FECHA                  = Convert.ToString(m.FECHA);
                    objEmp.CODIGO_INTERNO         = m.CODIGO_INTERNO;
                    objEmp.LOCALES                = m.LOCALES;
                    objEmp.TIPO_INVENTARIO        = m.TIPO_INVENTARIO;
                    objEmp.DESCRIPCION            = m.DESCRIPCION;
                    objEmp.MARCA                  = m.MARCA;
                    objEmp.UNIDAD_MEDIDA          = m.UNIDAD_MEDIDA;
                    objEmp.PRECIO                 = Convert.ToString(m.PRECIO);
                    objEmp.MONEDA                 = m.MONEDA;
                    objEmp.SUB_CLASE              = m.SUB_CLASE;
                    objEmp.DESCRIPCION_SUBCLASE   = m.DESCRIPCION_SUBCLASE;
                    objEmp.CLASE                  = m.CLASE;
                    objEmp.DESCRIPCION_CLASE      = m.DESCRIPCION_CLASE;
                    objEmp.SUB_DEPARTAMENTO       = m.SUB_DEPARTAMENTO;
                    objEmp.DESCRIPCION_SUB_DPTO   = m.DESCRIPCION_SUB_DPTO;
                    objEmp.DEPARTAMENTO           = m.DEPARTAMENTO;
                    objEmp.DESCRIPCION_DPTO       = m.DESCRIPCION_DPTO;
                    objEmp.FECHA_CREACION_ARCHIVO = m.FECHA_CREACION_ARCHIVO;
                    objEmp.TIPO_CODBARRA          = m.TIPO_CODBARRA;
                    objEmp.EAN                    = m.EAN;
                    objEmp.CANTIDAD               = m.CANTIDAD;

                    db.MAESTRA_PROCESO.Add(objEmp);

                    db.SaveChanges();
                };
            }



        }

    }

}
