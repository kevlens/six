using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Timers;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.SessionState;
using SxShWeb.Areas.Filters;
using Microsoft.AspNet.SignalR;
using SxShWeb.DBMonitor;
using System.Collections;
using Common;
using System.Web.Configuration;
using System.Configuration;
using SxShWeb.Areas.Models;

namespace SxShWeb
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public string ss = System.Environment.CurrentDirectory;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalFilters.Filters.Add(new JsonAttribute());//注册JSON，兼容IE下返回JSON时弹出下载的提示
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
        protected void Session_End(object sender, EventArgs e)
        {
            Hashtable useronLine = (Hashtable)Application["Online"];
            if (useronLine != null)
            {
                if (useronLine[Session.SessionID] != null)
                {
                    useronLine.Remove(Session.SessionID);
                    Application.Lock();
                    Application["Online"] = useronLine;
                    Application.UnLock();
                }
            }
        }
     
        public override void Init()
        {
            base.Init();
        }

        void MvcApplication_PostAuthenticateRequest(object sender, EventArgs e)
        {
            HttpContext.Current.SetSessionStateBehavior(
                SessionStateBehavior.Required);
        }

       
    }

}