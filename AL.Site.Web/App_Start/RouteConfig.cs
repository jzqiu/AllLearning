using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AL.Site.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "index",
                "index.html", 
                new { controller = "Home", action = "Index", id = UrlParameter.Optional });
            routes.MapRoute(
                "login",
                "login.html",
                new { controller = "Account", action = "Login", id = UrlParameter.Optional });
            routes.MapRoute(
                "register",
                "register.html",
                new { controller = "Account", action = "Register", id = UrlParameter.Optional });
            routes.MapRoute(
                "fgpassword",
                "fgpassword.html",
                new { controller = "Account", action = "FgPassword", id = UrlParameter.Optional });
            routes.MapRoute(
                "map",
                "map.html",
                new { controller = "Home", action = "Map", id = UrlParameter.Optional });
            routes.MapRoute(
                "news",
                "news_{id}_.html",
                new { controller = "News", action = "Index", id = UrlParameter.Optional });
            routes.MapRoute(
                "newscontent",
                "newscontent_{id}_.html",
                new { controller = "News", action = "Content", id = UrlParameter.Optional });
            routes.MapRoute(
                "achievement",
                "achievement_{id}_.html",
                new { controller = "Achievement", action = "Index", id = UrlParameter.Optional });
            routes.MapRoute(
                "achcontent",
                "achcontent_{id}_.html",
                new { controller = "Achievement", action = "Content", id = UrlParameter.Optional });
            routes.MapRoute(
                "course",
                "course_{id}_.html",
                new { controller = "Course", action = "Index", id = UrlParameter.Optional });
            routes.MapRoute(
                "contact",
                "contact.html",
                new { controller = "Home", action = "Contact", id = UrlParameter.Optional });
            routes.MapRoute(
                "GetValidateCode",
                "GetValidateCode.html",
                new { controller = "Account", action = "GetValidateCode", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}