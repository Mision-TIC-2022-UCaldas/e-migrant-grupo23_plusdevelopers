using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EMIGRANT.Model;

namespace EMIGRANT.Controllers
{
    public class MigrantesController : Controller
    {
        private BDEmigrantEntities db = new BDEmigrantEntities();

        // GET: Migrantes
        public ActionResult Index()
        {
            return View(db.Migrante.ToList());
        }

        // GET: Migrantes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Migrante migrante = db.Migrante.Find(id);
            if (migrante == null)
            {
                return HttpNotFound();
            }
            return View(migrante);
        }

        // GET: Migrantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Migrantes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEmigrante,Nombre,Apellidos,TipoDocumento,NumeroDocumento,PaisOrigen,FechaNacimiento,CorreoElectronico,NumeroTelefono,DireccionActual,Ciudad,SituacionLaboral")] Migrante migrante)
        {
            if (ModelState.IsValid)
            {
                db.Migrante.Add(migrante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(migrante);
        }

        // GET: Migrantes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Migrante migrante = db.Migrante.Find(id);
            if (migrante == null)
            {
                return HttpNotFound();
            }
            return View(migrante);
        }

        // POST: Migrantes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEmigrante,Nombre,Apellidos,TipoDocumento,NumeroDocumento,PaisOrigen,FechaNacimiento,CorreoElectronico,NumeroTelefono,DireccionActual,Ciudad,SituacionLaboral")] Migrante migrante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(migrante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(migrante);
        }

        // GET: Migrantes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Migrante migrante = db.Migrante.Find(id);
            if (migrante == null)
            {
                return HttpNotFound();
            }
            return View(migrante);
        }

        // POST: Migrantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Migrante migrante = db.Migrante.Find(id);
            db.Migrante.Remove(migrante);
            db.SaveChanges();
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
