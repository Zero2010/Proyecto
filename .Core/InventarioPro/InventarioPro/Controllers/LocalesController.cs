using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InventarioPro.Models;

namespace InventarioPro.Controllers
{
    public class LocalesController : Controller
    {
        private InventarioProEntities db = new InventarioProEntities();

        // GET: Locales
        public async Task<ActionResult> Index()
        {
            return View(await db.Locales.ToListAsync());
        }

        // GET: Locales/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Locales locales = await db.Locales.FindAsync(id);
            if (locales == null)
            {
                return HttpNotFound();
            }
            return View(locales);
        }

        // GET: Locales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Locales/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "IdLocal,NombreLocal")] Locales locales)
        {
            if (ModelState.IsValid)
            {
                db.Locales.Add(locales);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(locales);
        }

        // GET: Locales/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Locales locales = await db.Locales.FindAsync(id);
            if (locales == null)
            {
                return HttpNotFound();
            }
            return View(locales);
        }

        // POST: Locales/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IdLocal,NombreLocal")] Locales locales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(locales).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(locales);
        }

        // GET: Locales/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Locales locales = await db.Locales.FindAsync(id);
            if (locales == null)
            {
                return HttpNotFound();
            }
            return View(locales);
        }

        // POST: Locales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Locales locales = await db.Locales.FindAsync(id);
            db.Locales.Remove(locales);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
