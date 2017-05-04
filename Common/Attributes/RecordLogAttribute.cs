using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Web;
using System.Web.Mvc;

namespace Common.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class RecordLogAttribute : ActionFilterAttribute
    {

        private readonly string _ipAddress;
        private readonly string _userName;
        private readonly string _description;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ipAddress">用户ip</param>
        /// <param name="userName">当前用户名</param>
        /// <param name="description">操作描述</param>
        public RecordLogAttribute(string ipAddress, string userName ,string description)
        {
            _ipAddress = ipAddress;
            _userName = userName;
            _description = description;
        }

       
        // OnActionExecuted 在执行操作方法后由 ASP.NET MVC 框架调用。
        // OnActionExecuting 在执行操作方法之前由 ASP.NET MVC 框架调用。
        // OnResultExecuted 在执行操作结果后由 ASP.NET MVC 框架调用。
        // OnResultExecuting 在执行操作结果之前由 ASP.NET MVC 框架调用。

        /// <summary>
        /// 在执行操作方法之前由 ASP.NET MVC 框架调用。
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
        /// <summary>
        /// 在执行操作方法后由 ASP.NET MVC 框架调用。
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            base.OnActionExecuted(filterContext);
        }

        /// <summary>
        ///  OnResultExecuted 在执行操作结果后由 ASP.NET MVC 框架调用。
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //base.OnResultExecuted(filterContext);
            LogContent logmodel = new LogContent();
            logmodel.Log_ID = Guid.NewGuid().ToString();
            logmodel.Event_Type = 3;
            logmodel.EventCategory = "";//登陆系统
            logmodel.Event_ID = 1;
            logmodel.ComputerName = _ipAddress;//Request.UserHostAddress;
            logmodel.Mac_Address = GetMacAddress();
            logmodel.Source = "";
            logmodel.SourceType = "1";
            logmodel.UserName = _userName;
            logmodel.Description = _description;//在记录数据库操作时，可以在petapoco底层将sql语句放入其中。      
            try
            {
                RecordLog.RecordDBInfo(logmodel);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// OnResultExecuting 在执行操作结果之前由 ASP.NET MVC 框架调用。
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }

        public string GetMacAddress()
        {
            string mac = "";
            try
            {
                //获取网卡硬件地址 
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();

                List<string> list = new List<string>();

                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["IPEnabled"] == true)
                    {
                        mac = mo["MacAddress"].ToString();

                        list.Add(mac);
                    }
                }
                moc = null;
                mc = null;

                mac = list[list.Count - 1];

                return mac;
            }
            catch
            {
                return "unknow";
            }
        }
    }
}