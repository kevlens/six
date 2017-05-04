using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.SessionState;
using BLL;
using IBLL;
using Model;

namespace SxShWeb.Areas
{
    public class OperContext
    {
        /// <summary>
        /// 保存当前用户信息的CookieID
        /// </summary>
        public const string Admin_Cookie_UserLoginName = "Cookie_Login_Name";
        /// <summary>
        /// cookie所存储的位置
        /// </summary>
        public const string Admin_Cookie_Path = "/admin/";


        #region 使用线程优化业务层仓储
        public IBLLSession BllSession;

        private OperContext()
        {
            BllSession = new BLLSessionFactory().GetBLLSesson();// SpringHelper.GetObject<IBLLSession>("BLLSession");

        }

        public static OperContext CurrentContext
        {
            get
            {
                OperContext opContext = CallContext.GetData(typeof(OperContext).Name) as OperContext;
                if (opContext == null)
                {
                    opContext = new OperContext();
                    CallContext.SetData(typeof(OperContext).Name, opContext);

                }
                return opContext;
            }
        }
        #endregion


        #region 封装HTTP对象
        #region Http上下文
        /// <summary>
        /// Http上下文
        /// </summary>
        HttpContext ContextHttp
        {
            get
            {
                return HttpContext.Current;
            }
        }
        #endregion

        #region Response对象
        public HttpResponse Response
        {
            get
            {
                return ContextHttp.Response;
            }
        }
        #endregion

        #region Request对象
        public HttpRequest Request
        {
            get
            {
                return ContextHttp.Request;
            }
        }
        #endregion


        #region Session对象
        public HttpSessionState Session
        {
            get
            {
                return ContextHttp.Session;
            }
        }

        #endregion

        #endregion

        #region 当前用户验证码
        /// <summary>
        /// 当前用户验证码
        /// </summary>
        public string CurrentUserVcode
        {
            get
            {

                return Session["ValidateCode"] as string;
            }

            set
            {
                Session["ValidateCode"] = value;
            }
        }
        #endregion


        #region 当前用户
        /// <summary>
        /// 当前用户
        /// </summary>
        public SYS_USER CurrentUser
        {
            get
            {

                return Session["Admin_User"] as SYS_USER;
            }

            set
            {
                Session["Admin_User"] = value;
                Session.Timeout = 600;
                if (value != null)
                {
                    HttpContext httpContext = System.Web.HttpContext.Current;
                    Hashtable userOnline = (Hashtable)httpContext.Application["Online"];
                    if (userOnline != null)
                    {
                        IDictionaryEnumerator ide = userOnline.GetEnumerator();
                        while (ide.MoveNext())
                        {
                            if (ide.Value != null && ide.Value.ToString() == value.USER_NAME && ide.Key.ToString() != Session.SessionID)
                            {
                                //Common.RecordLog.RecordInfo("ide.Key-1" + ide.Key);
                                userOnline[ide.Key] = "-1"; //标记为”-1“，就代表当前用户”身份过期“
                                break;
                            }
                        }
                    }
                    else
                    {
                        userOnline = new Hashtable();
                    }

                    userOnline[Session.SessionID] = value.USER_NAME;
                    httpContext.Application.Lock();
                    httpContext.Application["Online"] = userOnline;
                    httpContext.Application.UnLock();
                }
            }
        }
        #endregion

        #region 当前用户菜单权限
        /// <summary>
        /// 当前用户权限
        /// </summary>
        public List<SYS_MENU> UserMenuPermission
        {
            get
            {

                return Session["Admin_Permission"] as List<SYS_MENU>;
            }

            set
            {
                Session["Admin_Permission"] = value;
            }
        }
        #endregion

        #region 保存当前登录用户的用户名
        //cookie;
        /// <summary>
        /// 保存当前登录用户的用户名
        /// </summary>
        
        
        public string CurrentUserName
        {
            set
            {
                //value = Common.SecurityHelper.Encrypt(value.ToString());
                //HttpCookie cookie = new HttpCookie(Admin_Cookie_UserLoginName, value);
                //cookie.Expires = DateTime.Now.AddDays(1);
                //cookie.Path = Admin_Cookie_Path;
                //Response.Cookies.Add(cookie);

                HttpCookie tmpCooki = new HttpCookie("systemLoginName");
                tmpCooki.Value = value;

                tmpCooki.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(tmpCooki);
            }
            get
            {
                if (Request.Cookies["systemLoginName"] == null)
                {
                    return "";
                }
                else
                {
                    return Request.Cookies["systemLoginName"].Value;
                }
                //if (Request.Cookies[Admin_Cookie_UserLoginName] == null)
                //{
                //    return "";
                //}
                //else
                //{
                //    string strLoginName = Request.Cookies[Admin_Cookie_UserLoginName].Value;
                //    strLoginName = Common.SecurityHelper.DeEncrypt(strLoginName);
                //    return strLoginName;
                //}
            }
        }
        #endregion
    }
}