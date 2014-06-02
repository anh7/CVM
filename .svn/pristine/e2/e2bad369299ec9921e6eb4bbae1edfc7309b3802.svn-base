using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CRM
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Contact_Index",
                "Contact",
                 new { action = "Index", controller = "Contact", type = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Account_Index",
                "Account",
                new { action = "Index", controller = "Account", type = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Admin_elmah",
                "Admin/elmah/{type}",
                new { action = "Index", controller = "Elmah", type = UrlParameter.Optional }
            );
            
        }
    }
}
