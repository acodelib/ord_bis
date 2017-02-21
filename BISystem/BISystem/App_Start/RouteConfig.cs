using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BISystem
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "DbType",
              url: "DbType/{action}/{id}",
              defaults: new { controller = "DbType", action = "Index", id = UrlParameter.Optional }
          );

            routes.MapRoute(
            name: "AccessRequest",
            url:  "AccessRequest/{action}/{id}",
            defaults: new { controller = "AccessRequest", action = "Index", id = UrlParameter.Optional }
        );

            routes.MapRoute(
             name: "Connection",
             url: "Connection/{action}/{id}",
             defaults: new { controller = "Connection", action = "Index", id = UrlParameter.Optional }
         );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}