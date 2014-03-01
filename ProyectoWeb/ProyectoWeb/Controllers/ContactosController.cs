using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers
{
    public class ContactosController : Controller
    {
        private ProyectoDb db = new ProyectoDb();
        //
        // GET: /Contactos/

        public ActionResult Index()
        {
            List<Contacto> Contactos = db.Contactos.ToList();
            ViewBag.contactos = Contactos;
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}
