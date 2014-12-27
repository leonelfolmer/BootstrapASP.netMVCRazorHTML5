using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace App
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*routes.MapRoute(
                name: "Principal",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Principal", action = "Principal", id = UrlParameter.Optional }
            );*/


            routes.MapRoute(
                "Principal",
                "Principal", // url
                defaults: new { controller = "Principal", action = "Principal" }
            );

            routes.MapRoute(
                "Contato",
                "Contato", // url
                defaults: new { controller = "Contato", action = "Contato" }
            );

        }
    }
}