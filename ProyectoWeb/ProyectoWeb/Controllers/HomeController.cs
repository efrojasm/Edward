using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers
{
    public class HomeController : Controller
    {
        private ProyectoDb db = new ProyectoDb();
        //
        // GET: /Curriculums/

        public ActionResult Index()
        {
            List<Home> Home = db.Home.ToList();
            ViewBag.home = Home;
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}
