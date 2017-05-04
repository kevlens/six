using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // 忽略对 WebForms 路径的路由
            routes.IgnoreRoute("WebForms/{weform}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{*catchall}",
                defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional },
                namespaces: new string[] { "Web.Controllers" }

            );

            #region =====沈阳数字工务=====
            //.....

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}/{*catchall}",
            //    defaults: new { controller = "Home", action = "SYGWLogin", id = UrlParameter.Optional },
            //    namespaces: new string[] { "Web.Controllers" }
            //);
            #endregion

        }
    }
}