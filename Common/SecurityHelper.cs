using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace Common
{
    public class SecurityHelper
    {
        #region 加密
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="userInfo">用户信息</param>
        /// <returns>加密字符串</returns>
        public static string Encrypt(string userInfo)
        {
            //第一：将用户数据存入票据对象
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, "天津电务段", DateTime.Now, DateTime.Now.AddMinutes(10), true, userInfo);

            //第二:将票据对象加密成字符串
            string security = FormsAuthentication.Encrypt(ticket);
            return security;
        }
        #endregion

        #region 解密
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="encryptStr">加密字符串</param>
        /// <returns>用户数据</returns>
        public static string DeEncrypt(string encryptStr)
        {

            //将加密字符串解释成票据对象
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(encryptStr);
            return ticket.UserData;
        }
        #endregion
    }
}
