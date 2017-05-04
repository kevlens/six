using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using Common.Attributes;
using Model;
using SxShWeb.Areas;


namespace SxShWeb.Controllers
{
    public class BaseController : Controller
    {
        #region Request.Form 危险验证
        //[ValidateInput(false)]
        //public override ActionResult Insert(InformationInfo info)
        //{
        //    info.Editor = CurrentUser.Name;
        //    info.EditTime = DateTime.Now;

        //    return base.(info);
        //}

        //[ValidateInput(false)]
        //public override ActionResult Update(string id, FormCollection formValues)
        //{
        //    return base.Update(id, formValues);
        //} 
        #endregion

        #region UI层与Service之间操作的上下文
        protected OperContext oc = OperContext.CurrentContext;
        #endregion

        #region 把ajax返回值封装成json格式返回
        /// <summary>
        /// 把ajax返回值封装成json格式返回
        /// </summary>
        /// <param name="statu">Ajax 状态</param>
        /// <param name="msg">Ajax 信息</param>
        /// <param name="data">Ajax 数据</param>
        /// <param name="backurl">调用后的链接</param>
        /// <returns>json格式的Ajax数据</returns>
        public JsonResult PackagingAjaxmsg(AjaxStatu statu, string msg
            , object data = null, string backurl = "")
        {
            AjaxMsgModel amm = new AjaxMsgModel
            {
                BackUrl = backurl,
                Data = data,
                Msg = msg,
                Statu = statu
            };

            JsonResult ajaxRes = new JsonResult();
            ajaxRes.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            ajaxRes.Data = amm;
            return ajaxRes;
        }
        #endregion

        #region 把ajax返回值封装成json格式返回
        /// <summary>
        /// 把ajax返回值封装成json格式返回
        /// </summary>
        /// <param name="statu">Ajax 状态</param>
        /// <param name="msg">Ajax 信息</param>
        /// <param name="data">Ajax 数据</param>
        /// <param name="backurl">调用后的链接</param>
        /// <returns>json格式的Ajax数据</returns>
        public JsonResult PackagingAjaxmsg(AjaxMsgModel amm)
        {
            JsonResult ajaxRes = new JsonResult();
            ajaxRes.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            ajaxRes.Data = amm;
            return ajaxRes;
        }
        #endregion

        #region 重定向方法(ajax和link)
        /// <summary>
        /// 重定向方法(ajax和link)
        /// </summary>
        /// <param name="url">重定向的url</param>
        /// <param name="action">产生重定向的action方法</param>
        /// <returns>JSONRESULT REDIRECTRESULT</returns>
        public ActionResult Redirect(string url, ActionDescriptor action, AjaxStatu ajaxStatu = AjaxStatu.noperm)
        {
            //如果是Ajax请求没有权限，那么就返回Json消息
            if (action.IsDefined(typeof(Common.Attributes.AjaxRequestAttribute), false)
                || action.ControllerDescriptor.IsDefined(typeof(Common.Attributes.AjaxRequestAttribute), false))
            {
                if (ajaxStatu == AjaxStatu.nologin)
                {
                    return PackagingAjaxmsg(AjaxStatu.nologin, Message.NotLogin, null, url);
                }else if (ajaxStatu == AjaxStatu.none)
                {
                    return PackagingAjaxmsg(AjaxStatu.nologin, Message.NotNone, null, url);
                }
                else
                {

                    string strAction = action.GetDescription();
                    string strController = action.ControllerDescriptor.GetDescription();
                    string msg = string.Format(Message.OptNoPermission, strAction);
                    return PackagingAjaxmsg(AjaxStatu.noperm, msg, null, null);
                }

            }
            else//如果是超链接或表单
            {
                return new RedirectResult(url);
            }

        }
        #endregion

        #region 下载文件
        [HttpGet]
        public ActionResult DownloadExcel(string id)
        {
            string fileName = id;
            string path = Path.Combine(Server.MapPath(Request.ApplicationPath), "Content", "UpLoadExcel");
            string savePath = path + "\\" + fileName + ".xls";


            if (System.IO.File.Exists(savePath))//下载即删除
            {
                string filePath = savePath;
                FileStream fs = new FileStream(filePath, FileMode.Open);
                byte[] bytes = new byte[(int)fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                fs.Close();
                Response.Charset = "UTF-8";
                Response.ContentEncoding = System.Text.Encoding.GetEncoding("UTF-8");
                Response.ContentType = "application/octet-stream";

                string filenameurl = fileName.Replace(" ", "") + ".xls";
                string UserAgent = Request.ServerVariables["http_user_agent"].ToLower();
                //解决IE和firefox文件名乱码问题
                if (UserAgent.IndexOf("firefox") == -1) //如果不是火狐浏览器
                {
                    //IE需要编码
                    //加上HttpUtility.UrlEncode()方法，防止文件下载时，文件名乱码，（保存到磁盘上的文件名称应为“中文名.xls”）
                    filenameurl = HttpUtility.UrlEncode(filenameurl, System.Text.Encoding.UTF8);//设置编码
                }

                Response.AddHeader("Content-Disposition", "attachment; filename=" + filenameurl);
                Response.BinaryWrite(bytes);
                Response.Flush();
                Response.End();
                System.IO.File.Delete(savePath);
            }
            return new EmptyResult();

        }
        #endregion

        #region 下载Pdf文件
        [HttpGet]
        public ActionResult DownloadPdf(string id)
        {
            string fileName = id;
            string path = Path.Combine(Server.MapPath(Request.ApplicationPath), "Content", "UpLoadExcel");
            string savePath = path + "\\" + fileName + ".pdf";


            if (System.IO.File.Exists(savePath))//下载即删除
            {
                string filePath = savePath;
                FileStream fs = new FileStream(filePath, FileMode.Open);
                byte[] bytes = new byte[(int)fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                fs.Close();
                Response.Charset = "UTF-8";
                Response.ContentEncoding = System.Text.Encoding.GetEncoding("UTF-8");
                Response.ContentType = "application/octet-stream";

                string filenameurl = fileName.Replace(" ", "") + ".pdf";
                string UserAgent = Request.ServerVariables["http_user_agent"].ToLower();
                //解决IE和firefox文件名乱码问题
                if (UserAgent.IndexOf("firefox") == -1) //如果不是火狐浏览器
                {
                    //IE需要编码
                    //加上HttpUtility.UrlEncode()方法，防止文件下载时，文件名乱码，（保存到磁盘上的文件名称应为“中文名.xls”）
                    filenameurl = HttpUtility.UrlEncode(filenameurl, System.Text.Encoding.UTF8);//设置编码
                }

                Response.AddHeader("Content-Disposition", "attachment; filename=" + filenameurl);
                Response.BinaryWrite(bytes);
                Response.Flush();
                Response.End();
                System.IO.File.Delete(savePath);
            }
            return new EmptyResult();

        }
        #endregion
        #region 下载模板文件不删除
        [HttpGet]
        public ActionResult DownMbExcel(string id)
        {
            string fileName = id;
            string path = Path.Combine(Server.MapPath(Request.ApplicationPath), "Content", "UpLoadExcel");
            string savePath = path + "\\" + fileName + ".xls";


            if (System.IO.File.Exists(savePath))//下载不删除
            {
                string filePath = savePath;
                FileStream fs = new FileStream(filePath, FileMode.Open);
                byte[] bytes = new byte[(int)fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                fs.Close();
                Response.Charset = "UTF-8";
                Response.ContentEncoding = System.Text.Encoding.GetEncoding("UTF-8");
                Response.ContentType = "application/octet-stream";

                string filenameurl = fileName.Replace(" ", "") + ".xls";
                string UserAgent = Request.ServerVariables["http_user_agent"].ToLower();
                //解决IE和firefox文件名乱码问题
                if (UserAgent.IndexOf("firefox") == -1) //如果不是火狐浏览器
                {
                    //IE需要编码
                    //加上HttpUtility.UrlEncode()方法，防止文件下载时，文件名乱码，（保存到磁盘上的文件名称应为“中文名.xls”）
                    filenameurl = HttpUtility.UrlEncode(filenameurl, System.Text.Encoding.UTF8);//设置编码
                }

                Response.AddHeader("Content-Disposition", "attachment; filename=" + filenameurl);
                Response.BinaryWrite(bytes);
                Response.Flush();
                Response.End();
            }
            return new EmptyResult();

        }
        #endregion


        #region 下载图片音视频文件
        [HttpGet]
        public ActionResult DownPicFile(string fileName,string fileUrl)
        {
            string savePath = Server.MapPath(Request.ApplicationPath) + fileUrl.Replace("/Content", "Content").Replace("/", "\\");

            if (System.IO.File.Exists(savePath))
            {
                string filePath = savePath;
                FileStream fs = new FileStream(filePath, FileMode.Open);
                byte[] bytes = new byte[(int)fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                fs.Close();
                Response.Charset = "UTF-8";
                Response.ContentEncoding = System.Text.Encoding.GetEncoding("UTF-8");
                Response.ContentType = "application/octet-stream";

                string filenameurl = fileName + Path.GetExtension(savePath);
                string UserAgent = Request.ServerVariables["http_user_agent"].ToLower();
                //解决IE和firefox文件名乱码问题
                if (UserAgent.IndexOf("firefox") == -1) //如果不是火狐浏览器
                {
                    //IE需要编码
                    //加上HttpUtility.UrlEncode()方法，防止文件下载时，文件名乱码，（保存到磁盘上的文件名称应为“中文名.xls”）
                    filenameurl = HttpUtility.UrlEncode(filenameurl, System.Text.Encoding.UTF8);//设置编码
                }

                Response.AddHeader("Content-Disposition", "attachment; filename=" + filenameurl);
                Response.BinaryWrite(bytes);
                Response.Flush();
                Response.End();
            }
            return new EmptyResult();

        }
        #endregion
    }
}
