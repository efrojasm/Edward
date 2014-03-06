using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers
{
    public class RecomendacionesController : Controller
    {
        private ProyectoDb db = new ProyectoDb();
        //
        // GET: /Recomendaciones/

        public ActionResult Index()
        {
            List<Recomendacion> Recomendaciones = db.Recomendaciones.ToList();
            ViewBag.recomendaciones = Recomendaciones;
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Aulas/Create

        [HttpPost]
        public ActionResult Create(string nombre = "", string telefono = "", string email = "", string comentario = "")
        {
            Recomendacion nueva = new Recomendacion();
            nueva.Nombre = nombre;
            nueva.Telefono = telefono;
            nueva.Mail = email;
            nueva.Comentario = comentario;
            if (ModelState.IsValid)
            {
                db.Recomendaciones.Add(nueva);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}
