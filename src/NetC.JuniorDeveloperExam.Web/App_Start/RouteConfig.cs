using System.Web.Mvc;
using System.Web.Routing;

namespace NetC.JuniorDeveloperExam.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "BlogPages",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Blog", action = "BlogPost", id = UrlParameter.Optional }
                );
        }
    }
}
