using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Web.App_Start.WebExt;

namespace Web.Areas.SYS
{
    public class SYSAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "SYS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                this.AreaName + "_default",
                this.AreaName + "/{controller}/{action}/{id}/{*catchall}",
                new { area = this.AreaName, controller = "Admin", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "Web.Areas." + this.AreaName + ".Controllers" }
            );

            RouteTable.Routes.MapHttpRoute(
                this.AreaName + "Api",
                "api/" + this.AreaName + "/{controller}/{action}/{id}",
                new
                {
                    action = RouteParameter.Optional,
                    id = RouteParameter.Optional,
                    namespaceName = new string[] { "Web.Areas." + this.AreaName + ".Controllers" }
                },
                null
            ).RouteHandler = new SessionStateRouteHandler();
        }
    }
}
