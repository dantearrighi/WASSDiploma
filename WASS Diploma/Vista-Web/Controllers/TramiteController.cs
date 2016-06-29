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
    public class TramiteController : Controller
    {
        private WASSTDEntities db = new WASSTDEntities();

        // GET: /Tramite/
        public ActionResult Index()
        {
            var tramites = db.Tramites.Include(t => t.Estado).Include(t => t.Persona).Include(t => t.Tipos_Tramites);
            return View(tramites.ToList());
        }

        // GET: /Tramite/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tramite tramite = db.Tramites.Find(id);
            if (tramite == null)
            {
                return HttpNotFound();
            }
            return View(tramite);
        }

        // GET: /Tramite/Create
        public ActionResult Create()
        {
            ViewBag.Estado_id = new SelectList(db.Estados, "id", "descripcion");
            ViewBag.Persona_dni = new SelectList(db.Personas, "dni", "nombre_apellido");
            ViewBag.Tipo_Tramite_id = new SelectList(db.Tipos_Tramites, "id", "descripcion");
            return View();
        }

        // POST: /Tramite/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Tipo_Tramite_id,Estado_id,Persona_dni")] Tramite tramite)
        {
            if (ModelState.IsValid)
            {
                db.Tramites.Add(tramite);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Estado_id = new SelectList(db.Estados, "id", "descripcion", tramite.Estado_id);
            ViewBag.Persona_dni = new SelectList(db.Personas, "dni", "nombre_apellido", tramite.Persona_dni);
            ViewBag.Tipo_Tramite_id = new SelectList(db.Tipos_Tramites, "id", "descripcion", tramite.Tipo_Tramite_id);
            return View(tramite);
        }

        // GET: /Tramite/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tramite tramite = db.Tramites.Find(id);
            if (tramite == null)
            {
                return HttpNotFound();
            }
            ViewBag.Estado_id = new SelectList(db.Estados, "id", "descripcion", tramite.Estado_id);
            ViewBag.Persona_dni = new SelectList(db.Personas, "dni", "nombre_apellido", tramite.Persona_dni);
            ViewBag.Tipo_Tramite_id = new SelectList(db.Tipos_Tramites, "id", "descripcion", tramite.Tipo_Tramite_id);
            return View(tramite);
        }

        // POST: /Tramite/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Tipo_Tramite_id,Estado_id,Persona_dni")] Tramite tramite)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tramite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Estado_id = new SelectList(db.Estados, "id", "descripcion", tramite.Estado_id);
            ViewBag.Persona_dni = new SelectList(db.Personas, "dni", "nombre_apellido", tramite.Persona_dni);
            ViewBag.Tipo_Tramite_id = new SelectList(db.Tipos_Tramites, "id", "descripcion", tramite.Tipo_Tramite_id);
            return View(tramite);
        }

        // GET: /Tramite/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tramite tramite = db.Tramites.Find(id);
            if (tramite == null)
            {
                return HttpNotFound();
            }
            return View(tramite);
        }

        // POST: /Tramite/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tramite tramite = db.Tramites.Find(id);
            db.Tramites.Remove(tramite);
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
