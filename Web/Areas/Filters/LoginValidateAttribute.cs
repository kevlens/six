using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using Model;
using SxShWeb.Areas.Models;
using SxShWeb.Controllers;

namespace SxShWeb.Areas.Filters
{
    public class LoginValidateAttribute : AuthorizeAttribute
    {


        protected  bool AuthorizeIs(HttpContextBase httpContext)
        {
            Hashtable userOnline = (Hashtable)httpContext.Application["Online"];
            if (userOnline != null)
            {

                var ide = userOnline.GetEnumerator();
                if (userOnline.Count > 0)
                {
                    while (ide.MoveNext())
                    {
                        //判断登录时保存的Session是否与现在的Session相同
                        if (userOnline.Contains(httpContext.Session.SessionID))
                        {
                            if (ide.Key != null && ide.Key.ToString() == httpContext.Session.SessionID)
                            {
                                if (ide.Value != null && ide.Value == "-1")
                                { //说明该帐户已经被人重复登录
                                    //把当前的这个Session所对应的用户”踢出“
                                    userOnline.Remove(httpContext.Session.SessionID);
                                    httpContext.Application.Lock();
                                    httpContext.Application["Online"] = userOnline;
                                    httpContext.Application.UnLock();
                                    //httpContext.Response.Redirect("/Account/LogOn?SSO=1", true);
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            RecordLog.RecordInfo("httpContext.Session.SessionID：" + httpContext.Session.SessionID + "-userOnline：" + userOnline.Count);
                            return false;
                        }
                    }
                }
                else
                {
                    RecordLog.RecordInfo("userOnline：" + userOnline.Count);
                    return false;
                }
            }

            return true;

            //return base.AuthorizeCore(httpContext);
        }
        #region  在过程请求授权时调用
        //
        // 摘要: 
        //     在过程请求授权时调用。
        //
        // 参数: 
        //   filterContext:
        //     筛选器上下文，它封装有关使用 System.Web.Mvc.AuthorizeAttribute 的信息。
        //
        // 异常: 
        //   System.ArgumentNullException:
        //     filterContext 参数为 null。
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            /**
             * 如果请求的区域包含area并且area的名称等于SYSs
             * 那么就进行权限验证 
             * */

            if (filterContext.RouteData.DataTokens.Keys.Contains("area")
                && (filterContext.RouteData.DataTokens["area"].ToString().ToLower() == "sys"
                || filterContext.RouteData.DataTokens["area"].ToString().ToLower() == "gate"
                || filterContext.RouteData.DataTokens["area"].ToString().ToLower() == "gis"
                || filterContext.RouteData.DataTokens["area"].ToString().ToLower() == "job"
                || filterContext.RouteData.DataTokens["area"].ToString().ToLower() == "material"
                || filterContext.RouteData.DataTokens["area"].ToString().ToLower() == "rule"
                || filterContext.RouteData.DataTokens["area"].ToString().ToLower() == "scripts"
                || filterContext.RouteData.DataTokens["area"].ToString().ToLower() == "rain"
                || filterContext.RouteData.DataTokens["area"].ToString().ToLower() == "tool"
                || filterContext.RouteData.DataTokens["area"].ToString().ToLower() == "rail"
                || filterContext.RouteData.DataTokens["area"].ToString().ToLower() == "car"
                || filterContext.RouteData.DataTokens["area"].ToString().ToLower() == "repair"
                ))
            {
                ///**
                //   * 验证用户是否登录
                //   * */
                if (!Model_SYS_USER.IsLogin())
                { ///如果没有登录那么就跳转到登录页面
                    filterContext.Result = new BaseController().Redirect("/Home/Login?msg=noLogin", filterContext.ActionDescriptor, AjaxStatu.nologin);
                }
                else
                {
                    if (!AuthorizeIs(filterContext.HttpContext))
                    {
                        filterContext.Result = new BaseController().Redirect("/Home/Login?msg=noLogin", filterContext.ActionDescriptor, AjaxStatu.none);
                    }
                    else
                    {
                        /**
                         * Action方法本身及它所属控制器都没有定义Skip特性
                         * 那么就可以进行权限验证
                         * */
                        if (!filterContext.ActionDescriptor.AttributeExists<Common.Attributes.SkipAttribute>(false)
                            && !filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(Common.Attributes.SkipAttribute), false))
                        {
                            //验证该登录用户是否有访问该页面的权限
                            string strAreaName = filterContext.RouteData.DataTokens["area"].ToString().ToLower();
                            string strControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName.ToLower();
                            string strActionName = filterContext.ActionDescriptor.ActionName.ToLower();

                            if (strActionName == "index")
                            {
                                string[] url = filterContext.HttpContext.Request.FilePath.Split('/');
                                if (url.Length > 4)
                                {
                                    for (int i = 4; i < url.Length; i++)
                                    {
                                        strActionName = strActionName + "/" + url[i];
                                    }
                                }
                            }

                            string strHttpMethod = filterContext.HttpContext.Request.HttpMethod;
                            HttpMethod httpMethod = strHttpMethod.ToLower().Equals("get") ? HttpMethod.Get
                                : strHttpMethod.ToLower().Equals("post") ? HttpMethod.Post : HttpMethod.HEAD;

                            if (!Model_SYS_MENU.HasPermission(strAreaName, strControllerName, strActionName, httpMethod))
                            {
                                filterContext.Result = new BaseController().Redirect("/Home/Login?msg=noPermission", filterContext.ActionDescriptor, AjaxStatu.noperm);
                            }
                            else
                            {
                                if (strActionName.ToLower() == "list" && filterContext.HttpContext.Request["page"] != null && filterContext.HttpContext.Request["rows"] != null)
                                {
                                    string pageIndex = filterContext.HttpContext.Request["page"].ToString();
                                    string pageSize = filterContext.HttpContext.Request["rows"].ToString();
                                    if (pageIndex == "0" && pageSize == "0")
                                    {
                                        filterContext.Result = ObjToJson.GetToJson(null, 0, true);
                                    }
                                }
                            }
                        }
                    }

                }
            }

        }
        #endregion
    }
}