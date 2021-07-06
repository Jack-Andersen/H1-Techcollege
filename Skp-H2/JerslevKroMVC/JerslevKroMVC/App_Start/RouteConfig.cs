using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JerslevKroMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "WithLanguage",
                url: "{language}/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional, language = "da" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
