using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProyectoWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

          

            routes.MapRoute(
              name: "home",
              url: "home",
              defaults: new { controller = "Home", action="Index" }
          );
            routes.MapRoute(
            name: "Contacto",
            url: "home/contacto",
            defaults: new { controller = "Contactos", action = "Index" }
        );
            routes.MapRoute(
            name: "recomendacion",
            url: "home/recomendacion",
            defaults: new { controller = "Recomendaciones", action = "Index" }
        );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}