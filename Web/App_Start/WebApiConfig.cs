using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Routing;
using SxShWeb.App_Start.WebExt;
using SxShWeb.Areas.Filters;


namespace SxShWeb
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //是为了让WebAPI自动批配后台为ApiController的类
            var suffix = typeof(DefaultHttpControllerSelector).GetField("ControllerSuffix", BindingFlags.Static | BindingFlags.Public);
            if (suffix != null) suffix.SetValue(null, "ApiController");
            //这里是为了让WebAPI也支持NameSpace
            config.Services.Replace(typeof(IHttpControllerSelector), new NamespaceHttpControllerSelector(config));
            config.MessageHandlers.Add(new WebApiLoginHandler());
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
            RouteTable.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            ).RouteHandler = new SessionStateRouteHandler();
        }
    }
}
