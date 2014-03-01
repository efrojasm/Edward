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
               name: "Contacto",
               url: "contacto/{action}",
               defaults: new { controller = "Contactos", action = "Index"}
           );

            routes.MapRoute(
               name: "Recomendacion",
               url: "recomendaciones/{action}",
               defaults: new { controller = "Recomendaciones", action = "Index"}
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Curriculums", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}