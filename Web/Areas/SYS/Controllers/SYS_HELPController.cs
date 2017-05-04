using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.Attributes;
using Web.Controllers;
using Common;
using Web.Areas.Models;
using Model;

namespace Web.Areas.SYS.Controllers
{
    public class SYS_HELPController : BaseController
    {
        //
        // GET: /SYS/SYS_HELP/
        //[AjaxRequest]
        //[Description("帮助文档")]
        //[HttpGet]
        //[Skip]
        //public ActionResult Index(string id)
        //{
        //    return View(id);
        //}

        [AjaxRequest]
        [Description("帮助文档")]
        [HttpGet]
        [Skip]
        public ActionResult Index()
        {
            return View();
        }

        [AjaxRequest]
        [Description("编辑帮助文档")]
        [HttpGet]
        [Skip]
        public ActionResult IndexEdit()
        {
            return View();
        }

        [HttpPost]
        [AjaxRequest]
        [Skip]
        [Description("保存文档")]
        [ValidateInput(false)]
        public ActionResult Save(string id) 
        {
            try
            {
                string sysMenuID = id.Split('_')[0];
                string Order = id.Split('_')[1];
                string content = Request["editor"];
                SYS_MENU_HELPCONTENT menuhelp = new SYS_MENU_HELPCONTENT {
                    CONTENT_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                    MENU_ID=sysMenuID,
                    CONTENT_ORDER = Order,
                    HELP_CONTENT=content,
                    UPDATE_USER=oc.CurrentUser.USER_NAME,
                    UPDATE_DATE=DateTime.Now
                };
                return PackagingAjaxmsg(Model_SYS_MENU_HELPCONTENT.Save(menuhelp)); 
            }
            catch (Exception)
            {
                return PackagingAjaxmsg(new Message().NewAmm);
            }
        }

        [HttpGet]
        [AjaxRequest]
        [Skip]
        [Description("根据所选系统联动所有系统顺序")]
        public ActionResult GetSysOrderByMenuID(string id)
        {
            var list = oc.BllSession.ISYS_MENU_HELPCONTENTService.Entities
                .Where(s=>s.MENU_ID.Equals(id))
                .Select(s => new { id = s.CONTENT_ORDER, text = s.CONTENT_ORDER }).Distinct();
            return Content(ObjToJson.GetToJson(list));
        }
        
        [HttpGet]
        [AjaxRequest]
        [Skip]
        [Description("根据所选系统,顺序获取已有文档内容")]
        public string GetContentByMenuandOrder(string id)
        {
            string menuID = id.Split('_')[0];
            string order = id.Split('_')[1];
            if (order.Equals("0")) 
            {
                return string.Empty;
            }
            string helps = oc.BllSession.ISYS_MENU_HELPCONTENTService
                .Entities.Where(h => h.MENU_ID.Equals(menuID) && h.CONTENT_ORDER.Equals(order))
                .Select(h=>h.HELP_CONTENT).ToList()[0].ToString();
            return helps;
        }

        [HttpGet]
        [AjaxRequest]
        [Skip]
        [Description("根据所选系统获取文档内容")]
        public string GetContentByMenu(string id)
        {
            if (id.Equals("DEFAULT"))
            {
                return "<p>没有查看此系统的权限</p>";
            }
            else 
            {
                List<SYS_MENU_HELPCONTENT> helps = oc.BllSession.ISYS_MENU_HELPCONTENTService.Entities
                    .Where(h => h.MENU_ID.Equals(id)).OrderBy(h => h.CONTENT_ORDER).ToList();
                if (helps.Count == 0)
                {
                    return "<p>请联系系统管理员，为您上传系统帮助文档</p>";
                }
                else 
                {
                    string helpContent=string.Empty;
                    foreach (SYS_MENU_HELPCONTENT help in helps) 
                    {
                        helpContent += help.HELP_CONTENT;
                    }
                    return helpContent;
                }
            }
            
        }
        
    }
}
