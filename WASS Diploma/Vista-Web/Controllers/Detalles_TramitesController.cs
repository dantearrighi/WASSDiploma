using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vista_Web.Models;

namespace Vista_Web.Controllers
{
    public class Detalles_TramitesController : Controller
    {
        private WASSTDEntities db = new WASSTDEntities();

        // GET: /Detalles_Tramites/
        public ActionResult Index()
        {
            var detalles_tramites = db.Detalles_Tramites.Include(d => d.Tramite);
            return View(detalles_tramites.ToList());
        }

        // GET: /Detalles_Tramites/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detalles_Tramites detalles_tramites = db.Detalles_Tramites.Find(id);
            if (detalles_tramites == null)
            {
                return HttpNotFound();
            }
            return View(detalles_tramites);
        }

        // GET: /Detalles_Tramites/Create
        public ActionResult Create()
        {
            ViewBag.TramiteId = new SelectList(db.Tramites, "Id", "Id");
            return View();
        }

        // POST: /Detalles_Tramites/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,descripcion,fecha_desde,TramiteId")] Detalles_Tramites detalles_tramites)
        {
            if (ModelState.IsValid)
            {
                db.Detalles_Tramites.Add(detalles_tramites);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TramiteId = new SelectList(db.Tramites, "Id", "Id", detalles_tramites.TramiteId);
            return View(detalles_tramites);
        }

        // GET: /Detalles_Tramites/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detalles_Tramites detalles_tramites = db.Detalles_Tramites.Find(id);
            if (detalles_tramites == null)
            {
                return HttpNotFound();
            }
            ViewBag.TramiteId = new SelectList(db.Tramites, "Id", "Id", detalles_tramites.TramiteId);
            return View(detalles_tramites);
        }

        // POST: /Detalles_Tramites/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,descripcion,fecha_desde,TramiteId")] Detalles_Tramites detalles_tramites)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detalles_tramites).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TramiteId = new SelectList(db.Tramites, "Id", "Id", detalles_tramites.TramiteId);
            return View(detalles_tramites);
        }

        // GET: /Detalles_Tramites/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detalles_Tramites detalles_tramites = db.Detalles_Tramites.Find(id);
            if (detalles_tramites == null)
            {
                return HttpNotFound();
            }
            return View(detalles_tramites);
        }

        // POST: /Detalles_Tramites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Detalles_Tramites detalles_tramites = db.Detalles_Tramites.Find(id);
            db.Detalles_Tramites.Remove(detalles_tramites);
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
