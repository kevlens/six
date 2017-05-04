using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Common
{
    public class ObjToJson
    {
        /// <summary>
        /// 将一个实例转换为JSON数据
        /// </summary>
        /// <param name="someClass">要转换的实例对象</param>
        /// <param name="IsGet">是否允许GET请求</param>
        /// <returns></returns>
        public static JsonResult GetToJson(object someClass, bool IsGet)
        {
            JsonResult jr = new JsonResult();
            jr.Data =someClass;
            if (IsGet)
            {
                jr.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            }
            return jr;
        }
        /// <summary>
        /// 将一个实例转换为JSON数据，带记录数
        /// </summary>
        /// <param name="someClass">要转换的实例对象</param>
        /// <param name="recordCount">总记录数</param>
        /// <param name="IsGet">是否允许GET请求</param>
        /// <returns></returns>
        public static JsonResult GetToJson(object someClass, int recordCount, bool IsGet)
        {
            JsonResult jr = new JsonResult()
            {
                Data = new
                {
                    total = recordCount,
                    rows = someClass
                }
            };
            if (IsGet)
            {
                jr.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            }
            return jr;
        }

        /// <summary>
        /// 将集合转为字段串
        /// </summary>
        /// <param name="someClass"></param>
        /// <returns></returns>
        public static string GetToJson(object someClass)
        {
            return JsonConvert.SerializeObject(someClass);
        }
        /// <summary>
        /// 将json字段串转为集合
        /// </summary>
        /// <param name="someClass"></param>
        /// <returns></returns>
        public static List<T> GetToJson<T>(string someString)
        {
            List<T> someClass = JsonConvert.DeserializeObject<List<T>>(someString);
            return someClass;
        }

        /// <summary>
        /// 将DataTable转为json
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <returns></returns>
        public static string GetDataTableToJson(DataTable dt)
        {
            return JsonConvert.SerializeObject(dt, new DataTableConverter());
        }
        /// <summary>
        /// 将一个实例转换为JSON数据
        /// </summary>
        /// <param name="someClass">要转换的实例对象</param>
        /// <param name="IsGet">是否允许GET请求</param>
        /// <returns></returns>
        public static ViewModel ViewModelToJson(object someClass, int total)
        {

            ViewModel viewModel = new ViewModel();
            viewModel.total = total;
            viewModel.rows = someClass;
            return viewModel;
        }
        /// <summary>
        /// 将一个实例转换为JSON数据
        /// </summary>
        /// <param name="someClass">要转换的实例对象</param>
        /// <param name="IsGet">是否允许GET请求</param>
        /// <returns></returns>
        public static ViewEditModel ViewEditModelToJson(object someClass, string index)
        {

            ViewEditModel viewModel = new ViewEditModel();
            viewModel.index = Convert.ToInt32(index);
            viewModel.row = someClass;
            return viewModel;
        }
        /// <summary>
        /// 将DataTable转为json
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <returns></returns>
        public static string GetDataTableToJson(DataTable dt, int recordCount)
        {
            return "{\"total\":" + recordCount + ",\"rows\":" + ObjToJson.GetDataTableToJson(dt) + "}";
        }
    }
}
