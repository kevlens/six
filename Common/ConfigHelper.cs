using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Common
{
    public class ConfigHelper
    {
        public ConfigHelper() { }

        public static SerializableDictionary<string, string> ReadWorkshopCode()
        {
            //HttpRuntime.AppDomainAppPath 网站在服务器磁盘上的物理路径
            //任何于Request/HttpContext.Current等相关的方法, 都只能在有请求上下文或者页面时使用. 即在无请求上下文时,HttpContext.Current为null. 而HttpRuntime.AppDomainAppPath方法一直可用.
            string path = Path.Combine(HttpRuntime.AppDomainAppPath, "Content", "UpLoadExcel\\Workshop_Code.xml");
            //string paths = Path.Combine(HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath), "Content", "UpLoadExcel\\Workshop_Code.xml");
            try
            {
                return (SerializableDictionary<string, string>)XMLUtil.DeserializeFromXml(path, typeof(SerializableDictionary<string, string>));
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
