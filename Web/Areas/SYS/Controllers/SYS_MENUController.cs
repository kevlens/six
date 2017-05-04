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
using Model.ModelExt;

namespace Web.Areas.SYS.Controllers
{
    public class SYS_MENUController : BaseController
    {
        //
        // GET: /SYS/SYS_MENU/
        [AjaxRequest]
        [Description("新增模块")]
        [HttpGet]
        [Skip]
        public ActionResult Index()
        {
            return View();
        }

        #region 查看我的导航菜单树
        [HttpGet]
        [Skip]
        public ActionResult GetMyMenuListTree()
        {
            List<string> listMuenId = oc.UserMenuPermission
                .Where(u => string.IsNullOrEmpty(u.GIS_ORDER)).Select(u => u.MENU_ID).ToList();
            List<SYS_MENU> listMenu = oc.BllSession.ISYS_MENUService.Entities
                .Where(m => listMuenId.Contains(m.MENU_ID) && m.MENU_LEVEL < 3
                )
                .OrderBy(m => m.MENU_ID).OrderBy(m => m.MENU_ORDER).ToList();
            return Content(ObjToJson.GetToJson(SYS_MENU.ConvertTreeNodes(listMenu, "0")));
        }
        #endregion

        [HttpPost]
        [Skip]
        public JsonResult MenuOPT(string id, string List, string Opt)
        {
            try
            {
                if (!string.IsNullOrEmpty(id))
                {
                    List<SYS_MENU> ThreemenuList = oc.BllSession.ISYS_MENUService
                                            .Entities.Where(m => m.MENU_LEVEL == Constant.threeMenuLevel
                                            && m.PARENT_ID.Equals(id)).ToList();
                    return PackagingAjaxmsg(Model_SYS_MENU.MenuOPT(ThreemenuList, List, Opt));
                }
                return PackagingAjaxmsg(new Message().NewAmm);
            }
            catch (Exception)
            {
                return PackagingAjaxmsg(new Message().NewAmm);
            }
        }
    }
}
