using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Tenta_MVC_Up4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Sprite",
            //    url: "Sprite/{action}/{id}",
            //    defaults: new { controller = "Sprite", action = "Hexa", id = UrlParameter.Optional }//when we will write in url sprite after localhost:nr
            //);

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Sprite", action = "Hexa", id = UrlParameter.Optional }//default - empty url after localhost:nr
           );
        }
    }
}
