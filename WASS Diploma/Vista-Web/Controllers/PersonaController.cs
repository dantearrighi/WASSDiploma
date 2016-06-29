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
    public class PersonaController : Controller
    {
        private WASSTDEntities db = new WASSTDEntities();

        // GET: /Persona/
        public ActionResult Index()
        {
            var personas = db.Personas.Include(p => p.Estado).Include(p => p.Tipos_Documentos).Include(p => p.Tipos_Personas);
            return View(personas.ToList());
        }

        // GET: /Persona/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // GET: /Persona/Create
        public ActionResult Create()
        {
            ViewBag.Estado_id = new SelectList(db.Estados, "id", "descripcion");
            ViewBag.Tipo_Documento_id = new SelectList(db.Tipos_Documentos, "id", "descripcion");
            ViewBag.Tipo_PersonaId = new SelectList(db.Tipos_Personas, "Id", "descripcion");
            return View();
        }

        // POST: /Persona/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="dni,nombre_apellido,sexo,telefono,celular,email1,observaciones,clave_fiscal,fecha_nacimiento,Tipo_PersonaId,Tipo_Documento_id,Estado_id")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                db.Personas.Add(persona);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Estado_id = new SelectList(db.Estados, "id", "descripcion", persona.Estado_id);
            ViewBag.Tipo_Documento_id = new SelectList(db.Tipos_Documentos, "id", "descripcion", persona.Tipo_Documento_id);
            ViewBag.Tipo_PersonaId = new SelectList(db.Tipos_Personas, "Id", "descripcion", persona.Tipo_PersonaId);
            return View(persona);
        }

        // GET: /Persona/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            ViewBag.Estado_id = new SelectList(db.Estados, "id", "descripcion", persona.Estado_id);
            ViewBag.Tipo_Documento_id = new SelectList(db.Tipos_Documentos, "id", "descripcion", persona.Tipo_Documento_id);
            ViewBag.Tipo_PersonaId = new SelectList(db.Tipos_Personas, "Id", "descripcion", persona.Tipo_PersonaId);
            return View(persona);
        }

        // POST: /Persona/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="dni,nombre_apellido,sexo,telefono,celular,email1,observaciones,clave_fiscal,fecha_nacimiento,Tipo_PersonaId,Tipo_Documento_id,Estado_id")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(persona).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Estado_id = new SelectList(db.Estados, "id", "descripcion", persona.Estado_id);
            ViewBag.Tipo_Documento_id = new SelectList(db.Tipos_Documentos, "id", "descripcion", persona.Tipo_Documento_id);
            ViewBag.Tipo_PersonaId = new SelectList(db.Tipos_Personas, "Id", "descripcion", persona.Tipo_PersonaId);
            return View(persona);
        }

        // GET: /Persona/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: /Persona/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Persona persona = db.Personas.Find(id);
            db.Personas.Remove(persona);
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
