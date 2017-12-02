using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AutomatedTellerMachine
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Serial Number",
              url: "serial/{letterCase}",
              defaults: new { controller = "Home", action = "Serial", letterCase = "upper" }
          );
            // Parameter cannot be passed like /person_name/person_1
            // but it can be passed like /person_name?person=person_1
            routes.MapRoute(
              name: "Person\'s Name",
              url: "person_name",
              defaults: new { controller = "Home", action = "PersonName" }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
