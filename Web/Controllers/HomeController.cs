using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using Common.Attributes;
using Model;
using Web.Areas.Models;
using System.Configuration;
using System.Linq.Expressions;
using System.IO;
using System.Management;


namespace Web.Controllers
{
    public class HomeController : BaseController
    {
        //
        // GET: /Home/

        #region 返回登录页
        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.title = "铁路安全防控管理系统";
            return View();
        }
        #endregion

        #region 登录验证，只允许POST提交
        /// <summary>
        /// 登录验证，只允许POST提交
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult LoginIn(string id)
        {
            string ip = Request.ServerVariables["REMOTE_ADDR"].ToString();
                if (Request.Form["username"] == null || Request.Form["password"] == null || Request.Form["checkcode"] == null)
                {
                    return PackagingAjaxmsg(AjaxStatu.err, string.Format(Message.ParGetFail, "登录名|密码|验证码"));
                }
                string username = Request["username"].ToString();
                string password = Request["password"].ToString();
                string checkcode = Request["checkcode"].ToString();

                AjaxMsgModel amm = Model_SYS_USER.LoginIn(username, password, checkcode,id);

                Model_SYS_USER.GenerateValidateCode();//北京后台刷新验证码
               return PackagingAjaxmsg(amm);

        }
        #endregion

        #region 验证码的实现
        /// <summary>
        /// 验证码的实现
        /// </summary>
        /// <returns>返回验证码</returns>
        [HttpGet]
        public ActionResult CheckCode()
        {
            //得到验证码的图片
            byte[] bytes = Model_SYS_USER.GenerateValidateCode();
            ////最后将验证码返回
            return File(bytes, @"image/jpeg");
        }
        [HttpGet]
        public ActionResult CheckWordCode()
        {
            using (MemoryStream m = new MemoryStream())
            {
                VerificationCode va = new VerificationCode(105, 30);
                var s = va.Create(m);
                string code = va.IdentifyingCode.ToLower();//string code = Common.DEncrypt.DESEncrypt.Encrypt(va.IdentifyingCode.ToLower());
                oc.CurrentUserVcode = code;
                byte[] bytes = m.ToArray();
                return File(bytes, @"image/gif");
            }
        }
        #endregion

        #region MAC地址
        public string getMac()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");

            ManagementObjectCollection moc2 = mc.GetInstances();

            foreach (ManagementObject mo in moc2)
            {
                if ((bool)mo["IPEnabled"] == true)
                {
                    return mo["MacAddress"].ToString();
                    mo.Dispose();
                }
            }
            return "";
        } 
        #endregion

        #region 用户IP
        public static string GetWebClientIp()
        {
            string userIP = "未获取用户IP";

            try
            {
                if (System.Web.HttpContext.Current == null
            || System.Web.HttpContext.Current.Request == null
            || System.Web.HttpContext.Current.Request.ServerVariables == null)
                    return "";

                string CustomerIP = "";

                //CDN加速后取到的IP   
                CustomerIP = System.Web.HttpContext.Current.Request.Headers["Cdn-Src-Ip"];
                if (!string.IsNullOrEmpty(CustomerIP))
                {
                    return CustomerIP;
                }

                CustomerIP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];


                if (!String.IsNullOrEmpty(CustomerIP))
                    return CustomerIP;

                if (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_VIA"] != null)
                {
                    CustomerIP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                    if (CustomerIP == null)
                        CustomerIP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                }
                else
                {
                    CustomerIP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

                }

                if (string.Compare(CustomerIP, "unknown", true) == 0)
                    return System.Web.HttpContext.Current.Request.UserHostAddress;
                return CustomerIP;
            }
            catch { }

            return userIP;
        }  
        #endregion

        #region 退出系统
        /// <summary>
        /// 退出系统
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AjaxRequest]
        [Description("退出登录")]
        public JsonResult LoginOut()
        {
            //清除Sesson
            Session.Abandon();
            //Session.Clear();
            oc.CurrentUser = null;

            if (Request.Cookies["systemLoginName"] != null)
            {
                HttpCookie tmpCooki = new HttpCookie("systemLoginName");

                tmpCooki.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(tmpCooki);
            }

            return PackagingAjaxmsg(AjaxStatu.ok, "", null, "/Home/Login");


            //return PackagingAjaxmsg(AjaxStatu.ok, "", null, "/Home/SYGWLogin");
        }
        #endregion



    }
}
