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

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}
