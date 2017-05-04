using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Common
{
    public class WebUtility
    {
        /// <summary>
        /// 将字符串转换为日期类型
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>日期</returns>
        public static DateTime? ParseDate(string str)
        {
            DateTime result;

            if (DateTime.TryParse(str, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将字符串转换为小数类型
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>小数</returns>
        public static decimal ParseDecimal(string str)
        {
            decimal result;
            return decimal.TryParse(str, out result) ? result : 0;
        }

        /// <summary>
        /// 将字符串转换为整数类型
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>整数</returns>
        public static int ParseInt(string str)
        {
            decimal result;

            return decimal.TryParse(str, out result) ? Convert.ToInt32(result) : 0;
        }

        /// <summary>
        /// 获取格式化布尔值
        /// </summary>
        public static string FormatBool(object data)
        {
            if (Convert.ToBoolean(data))
                return "<font size=3 face='wingdings 2'>P</font>";
            else
                return "<font size=3 face='wingdings 2'>O</font>";
        }

        /// <summary>
        /// 获取格式化布尔值
        /// </summary>
        public static string FormatBool2(object data)
        {
            if (Convert.ToBoolean(data))
                return "<font size=3 face='wingdings 2'>P</font>";
            else
                return "";
        }

        /// <summary>
        /// 获取格式化日期
        /// </summary>
        /// <param name="obj">日期</param>
        /// <returns>格式化后的日期</returns>
        public static string FormatDate(object obj)
        {
            if (obj == null)
                return "";
            else
                return Convert.ToDateTime(obj).ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// 获取格式化日期时间
        /// </summary>
        /// <param name="obj">日期时间</param>
        /// <returns>格式化后的日期时间</returns>
        public static string FormatDateTime(object obj)
        {
            if (obj == null)
                return "";
            else
                return Convert.ToDateTime(obj).ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// 获取格式化的日期时间  yyyy-MM-dd HH:mm
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string FormatDateTimeForGateAuth(object obj)
        {
            if (obj == null)
                return "";
            else
                return Convert.ToDateTime(obj).ToString("yyyy-MM-dd HH:mm");
        }

        /// <summary>
        /// 获取格式化的时间
        /// </summary>
        /// <param name="obj">时间</param>
        /// <returns>格式化的时间</returns>
        public static string FormateTime(object obj)
        {
            if (obj == null)
                return "";
            else
                return Convert.ToDateTime(obj).ToString("HH:mm:ss");
        }

        /// <summary>
        /// 获取格式化内容
        /// </summary>
        /// <param name="obj">内容</param>
        /// <returns>格式化后的内容</returns>
        public static string FormatMultLine(object obj)
        {
            if (obj == null)
                return "";
            else
                return HttpUtility.HtmlEncode(obj.ToString()).Replace("\r\n", "<br>").Replace(" ", "&nbsp;");
        }


        /// <summary>
        /// 取得必填项错误说明
        /// </summary>
        /// <param name="field">字段</param>
        /// <returns>错误说明</returns>
        public static string ErrorMessageRequired(string field)
        {
            string fieldCN = field;
            string fieldEN = field;
            if (field.Contains("/"))
            {
                fieldCN = field.Split('/')[0];
                fieldEN = field.Split('/')[1];
            }

            return "请输入" + fieldCN + "！/" + fieldEN + " is required!";
        }

        /// <summary>
        /// 取得数字输入项错误说明
        /// </summary>
        /// <param name="field">字段</param>
        /// <returns>错误说明</returns>
        public static string ErrorMessageInt(string field)
        {
            string fieldCN = field;
            string fieldEN = field;
            if (field.Contains("/"))
            {
                fieldCN = field.Split('/')[0];
                fieldEN = field.Split('/')[1];
            }

            return fieldCN + "必须为整数！/" + fieldEN + " must be integer!";
        }

        /// <summary>
        /// 取得小数输入项错误说明
        /// </summary>
        /// <param name="field">字段</param>
        /// <returns>错误说明</returns>
        public static string ErrorMessageDecimal(string field)
        {
            string fieldCN = field;
            string fieldEN = field;
            if (field.Contains("/"))
            {
                fieldCN = field.Split('/')[0];
                fieldEN = field.Split('/')[1];
            }

            return fieldCN + "必须为小数！/" + fieldEN + " must be decimal!";
        }

        /// <summary>
        /// 取得日期输入项错误说明
        /// </summary>
        /// <param name="field">字段</param>
        /// <returns>错误说明</returns>
        public static string ErrorMessageDateTime(string field)
        {
            string fieldCN = field;
            string fieldEN = field;
            if (field.Contains("/"))
            {
                fieldCN = field.Split('/')[0];
                fieldEN = field.Split('/')[1];
            }

            return fieldCN + "必须为日期！/" + fieldEN + " must be date!";
        }

        /// <summary>
        /// 获取格式化金额
        /// </summary>
        /// <param name="obj">金额</param>
        /// <returns>格式化后的金额</returns>
        public static string FormatMoney(object obj)
        {
            return Convert.ToDecimal(obj).ToString("#,##0.00");
        }

        /// <summary>
        /// 获取格式化金额
        /// </summary>
        /// <param name="obj">金额</param>
        /// <returns>格式化后的金额</returns>
        public static string FormatMoneyEdit(object obj)
        {
            return Convert.ToDecimal(obj).ToString("0.##");
        }

        /// <summary>
        /// 获取格式化整数
        /// </summary>
        /// <param name="obj">整数</param>
        /// <returns>格式化后的整数</returns>
        public static string FormatIntEdit(object obj)
        {
            if (Convert.ToInt32(obj) == 0)
            {
                return string.Empty;
            }
            else
            {
                return obj.ToString();
            }
        }

        /// <summary>
        /// 获取Cookie
        /// </summary>
        /// <param name="name">名称</param>
        /// <returns>值</returns>
        public static string GetCookie(string name)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[name];
            if (cookie != null)
            {
                return cookie.Value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 设置Cookie
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="value">值</param>
        public static void SetCookie(string name, string value)
        {
            HttpCookie cookie = new HttpCookie(name);
            cookie.Value = value;
            cookie.Expires = DateTime.MaxValue;
            HttpContext.Current.Response.AppendCookie(cookie);
        }

    }
}
