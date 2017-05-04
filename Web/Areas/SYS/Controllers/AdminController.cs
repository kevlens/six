using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using Model;
using Common.Attributes;
using System.ComponentModel;
using Web.Controllers;
using Model.ModelExt;
using Web.Areas.Models;
using System.Configuration;
using System.Linq.Expressions;
using System.Threading;

namespace Web.Areas.SYS.Controllers
{
    public class AdminController : BaseController
    {
        private bool inflag = false;
        private bool outflag = false;
        private string[] cardArray = new string[7] { "00000E51", "00000E52", "00000E53", "0000E50", "00000101", "00000E27", "00000E49" };
        //
        // GET: /SYS/Admin/

        [Skip]
        [HttpGet]
        public ActionResult Index(string id)
        {
            ViewBag.title = "工务安全防控管理平台";
            #region 判断是否是锦州车辆段
            //bool isJzcld = false;//判断是否是锦州车辆段
            //try
            //{
            //    isJzcld = Convert.ToBoolean(ConfigurationManager.AppSettings["isjzcld"]);
            //}
            //catch (Exception)
            //{
            //}
            //if (isJzcld)
            //{
            //    ViewBag.logo = Model_SYS_MENU.HasPermission("FIVET", "FIVET_INFO", "List", HttpMethod.Post) ? "5t" : "jy";//锦州车辆段专用，为解决同一个段不同LOGO;
            //    ViewBag.title = "智慧锦辆铁路安全防控管理平台";
            //} 
            #endregion
            ViewBag.warntab = "";//2017-02-15增加
            if (Model_SYS_MENU.HasPermission("WARN", "JOB", "WARNJOB", Common.HttpMethod.Post))
            {
                ViewBag.warntab += "|WARNJOB|";//施工计划报警
            }
            if (Model_SYS_MENU.HasPermission("WARN", "RAIN", "WARNRAIN", Common.HttpMethod.Post))
            {
                ViewBag.warntab += "|WARNRAIN|";//出巡报警
            }
            if (Model_SYS_MENU.HasPermission("WARN", "CONFIR", "WARNCONFIR", Common.HttpMethod.Post))
            {
                ViewBag.warntab += "|WARNCONFIR|";//确认车报警
            }
            if (Model_SYS_MENU.HasPermission("WARN", "RAIL", "WARNRAIL", Common.HttpMethod.Post))
            {
                ViewBag.warntab += "|WARNRAIL|";//断轨报警
            }
            if (Model_SYS_MENU.HasPermission("WARN", "CAR", "WARNCAR", Common.HttpMethod.Post))
            {
                ViewBag.warntab += "|WARNCAR|";//汽车超速
            }
            if (Model_SYS_MENU.HasPermission("WARN", "GATE", "WARNGATE", Common.HttpMethod.Post))
            {
                ViewBag.warntab += "|WARNGATE|";//门禁报警
            }
            if (Model_SYS_MENU.HasPermission("WARN", "PROTECTEDNET", "WARNPROTECTEDNET", Common.HttpMethod.Post))
            {
                ViewBag.warntab += "|WARNPROTECTEDNET|";//护网监控报警
            }
            if (Model_SYS_MENU.HasPermission("WARN", "WATER", "WARNWATER", Common.HttpMethod.Post))
            {
                ViewBag.warntab += "|WARNWATER|";//水位报警
            }
            ViewBag.CurrentUser = oc.CurrentUser.ZSNAME + "(" + oc.CurrentUser.USER_NAME+")";
            ViewBag.IsEasyPasWord = id;
            return View();
        } 
        
        /// <summary>
        /// 获取用户子系统导航(所有)
        /// </summary>
        /// <returns></returns>
        [Skip]
        [AjaxRequest]
        [HttpGet]
        public ActionResult GetMyZeroMenu()
        {
            string strJson = "[]";
            List<SYS_MENU> listMenu = oc.BllSession.ISYS_MENUService.Entities
                .Where(m => m.PARENT_ID.Equals(Constant.systemParID)).OrderBy(m => m.MENU_ORDER).ToList();// oc.BllSession.ISYS_MENUService.Entities.ToList();//.GetListByCondition<decimal?>(null, ma => ma.MENU_LEVEL).Select(mb => mb.ToPOCO()).ToList();
            //2015-11-06 新增不显示菜单
            listMenu=listMenu.Where(u=>string.IsNullOrEmpty(u.ISSHOW_FLAG)||(!string.IsNullOrEmpty(u.ISSHOW_FLAG)&&!u.ISSHOW_FLAG.Equals("0"))).ToList();
            //List<string> showlistMenu=listMenu.Select(u=>u.MENU_ID).ToList();
            if (listMenu.Count > 0)
            {
                List<EasyUITreeNode> listTreeNodes = SYS_MENU.ConvertTreeNodes(listMenu, Constant.systemParID);
                //获取用户拥有权限的子系统
                List<string> hasPermissionSyss = oc.UserMenuPermission.Where(u => u.PARENT_ID.Equals(Constant.systemParID)).OrderBy(u => u.MENU_ORDER)
                    .Select(u => u.MENU_ID).ToList();
                //获取用户默认子系统
                string defuMenuID = GetDefuMenu();
                foreach (EasyUITreeNode node in listTreeNodes) 
                {
                    if (node.id.Equals(defuMenuID))
                    {
                        node.isdefu = "Y";
                    }
                    else 
                    {
                        node.isdefu = "N";
                    }
                    if (hasPermissionSyss.Contains(node.id))
                    {
                        node.haspermission = "Y";
                    }
                    else 
                    {
                        node.haspermission = "N";
                    }
                }
                strJson = ObjToJson.GetToJson(listTreeNodes.OrderByDescending(m=>m.haspermission)).Replace("Checked", "checked");
            }
            return Content(strJson);
        }

        private string GetDefuMenu()
        {
            string resu = string.Empty;
            //获取用户拥有权限的子系统
            List<string> hasPermissionSyss = oc.UserMenuPermission.Where(u => u.PARENT_ID.Equals(Constant.systemParID)).OrderBy(u => u.MENU_ORDER)
                .Select(u => u.MENU_ID).ToList();
            if(hasPermissionSyss.Count>0)
            {
                SYS_USER_DEFAULTMENU userDefu = oc.BllSession.ISYS_USER_DEFAULTMENUService.Entities.Where(u => u.USER_NAME.Equals(oc.CurrentUser.USER_NAME)).FirstOrDefault();
                string defuSetting = Constant.defuOneMenuParID;
                if (userDefu != null)
                {
                    if (hasPermissionSyss.Contains(userDefu.MENU_ID))
                    {
                        resu = userDefu.MENU_ID;
                    }
                    else
                    {
                        if (hasPermissionSyss.Contains(defuSetting))
                        {
                            resu = defuSetting;
                        }
                        else
                        {
                            resu = hasPermissionSyss[0];
                        }
                    }
                }
                else 
                {
                    if (hasPermissionSyss.Contains(defuSetting))
                    {
                        resu = defuSetting;
                    }
                    else
                    {
                        resu = hasPermissionSyss[0];
                    }
                }
            }
            
            return resu;
        }

        /// <summary>
        /// 获取用户默认的一级导航
        /// </summary>
        /// <returns></returns>
        [Skip]
        [AjaxRequest]
        [HttpGet]
        public ActionResult GetMyOneMenu()
        {
            string strJson = "[]";
            //获取用户默认子系统menuid
            string defuMenuID = GetDefuMenu();
            if (!string.IsNullOrEmpty(defuMenuID)) 
            {
                SYS_MENU parMenu = oc.BllSession.ISYS_MENUService.Entities.Where(u => u.MENU_ID.Equals(defuMenuID)).FirstOrDefault();
                string defuMenu = string.Empty;
                try
                {
                    if (!string.IsNullOrEmpty(parMenu.DEFMENU_ID))
                    {
                        defuMenu = parMenu.DEFMENU_ID.Substring(0, 4);
                    }
                }
                catch 
                {
                    defuMenu = string.Empty;
                }
                
                List<SYS_MENU> listMenu = oc.UserMenuPermission.Where(m => m.PARENT_ID.Equals(defuMenuID)
                    //&& !Constant.PersonLocationMenuID.Split(',').Contains(m.MENU_ID)
               && string.IsNullOrEmpty(m.GIS_ORDER)).OrderBy(m => m.MENU_ORDER).ToList();
                //.OrderByDescending(m => m.GIS_ORDER).ThenBy(m => m.MENU_ORDER).ToList();
                if (listMenu.Count > 0)
                {
                    if (string.IsNullOrEmpty(defuMenu)) 
                    {
                        defuMenu = listMenu[0].MENU_ID;
                    }
                    List<EasyUITreeNode> listTreeNodes = SYS_MENU.ConvertTreeNodes(listMenu, defuMenuID);
                    foreach (EasyUITreeNode node in listTreeNodes) 
                    {
                        if (node.id.Equals(defuMenu))
                        {
                            node.isdefuopen = "Y";
                        }
                        else 
                        {
                            node.isdefuopen = "N";
                        }
                    }
                    strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
                }
            }
            return Content(strJson);
        }

        /// <summary>
        /// 根据用户选择的子系统获取一级导航
        /// </summary>
        /// <returns></returns>
        [Skip]
        [AjaxRequest]
        [HttpGet]
        public ActionResult GetMySelectOneMenu(string id)
        {
            string strJson = "[]";
            SYS_MENU parMenu = oc.BllSession.ISYS_MENUService.Entities.Where(u => u.MENU_ID.Equals(id)).FirstOrDefault();
            string defuMenu = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(parMenu.DEFMENU_ID))
                {
                    defuMenu = parMenu.DEFMENU_ID.Substring(0, 4);
                }
            }
            catch
            {
                defuMenu = string.Empty;
            }
            List<SYS_MENU> listMenu = oc.UserMenuPermission.Where(m => m.PARENT_ID.Equals(id)
                //&& !Constant.PersonLocationMenuID.Split(',').Contains(m.MENU_ID)
                //.OrderByDescending(m => m.GIS_ORDER).ThenBy(m => m.MENU_ORDER).ToList();
                 && string.IsNullOrEmpty(m.GIS_ORDER)).OrderBy(m => m.MENU_ORDER).ToList();
            if (listMenu.Count > 0)
            {
                if (string.IsNullOrEmpty(defuMenu))
                {
                    defuMenu = listMenu[0].MENU_ID;
                }
                List<EasyUITreeNode> listTreeNodes = SYS_MENU.ConvertTreeNodes(listMenu, id);
                foreach (EasyUITreeNode node in listTreeNodes)
                {
                    if (node.id.Equals(defuMenu))
                    {
                        node.isdefuopen = "Y";
                    }
                    else
                    {
                        node.isdefuopen = "N";
                    }
                }
                strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            }
            return Content(strJson);
        }

        /// <summary>
        /// 获取二三级导航
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Skip]
        [AjaxRequest]
        [HttpGet]
        public ActionResult GetMyMenu(string id)
        {
            string strJson = "[]";
            //if (Constant.GISMenuID.Split(',').Contains(id))
            //{
            //    //如果是获取GIS二级菜单
            //    List<SYS_MENU> listMenu = oc.BllSession.ISYS_MENUService.Entities
            //        .Where(m => m.MENU_LEVEL != Constant.MyMenuLevel && m.PARENT_ID.StartsWith(id))
            //        .OrderBy(m => m.MENU_ORDER).ToList();// oc.BllSession.ISYS_MENUService.Entities.ToList();//.GetListByCondition<decimal?>(null, ma => ma.MENU_LEVEL).Select(mb => mb.ToPOCO()).ToList();
            //    if (listMenu.Count > 0)
            //    {
            //        List<EasyUITreeNode> listTreeNodes = SYS_MENU.ConvertTreeNodes(listMenu, id);
            //        strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            //    }
            //}
            //else 
            //{

            //根据选择的一级菜单找对应模块默认打开的三级页面
            string parID = id.Substring(0, 2);
            SYS_MENU parMenu = oc.BllSession.ISYS_MENUService.Entities.Where(u => u.MENU_ID.Equals(parID)).FirstOrDefault();
            string twoMenuID = string.Empty;
            string threeMenuID=string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(parMenu.DEFMENU_ID))
                {
                    twoMenuID = parMenu.DEFMENU_ID.Substring(0, 6);
                    threeMenuID = parMenu.DEFMENU_ID.Substring(0, 8);
                }
            }
            catch 
            {
                twoMenuID = string.Empty;
                threeMenuID = string.Empty;
            }
            
            List<SYS_MENU> listMenu = oc.UserMenuPermission.Where(m => m.MENU_LEVEL != Constant.MyMenuLevel && m.PARENT_ID.StartsWith(id)).OrderBy(m=>m.MENU_LEVEL)
                .ThenBy(m => m.MENU_ORDER).ToList();// oc.BllSession.ISYS_MENUService.Entities.ToList();//.GetListByCondition<decimal?>(null, ma => ma.MENU_LEVEL).Select(mb => mb.ToPOCO()).ToList();
            if (listMenu.Count > 0)
            {
                if (string.IsNullOrEmpty(twoMenuID)) 
                {
                    SYS_MENU firstThreeMenu = listMenu.Where(u => u.MENU_LEVEL == 3).FirstOrDefault();
                    if (firstThreeMenu != null) 
                    {
                        twoMenuID = firstThreeMenu.MENU_ID.Substring(0, 6);
                        threeMenuID = firstThreeMenu.MENU_ID;
                    }
                }
                List<EasyUITreeNode> listTreeNodes = SYS_MENU.ConvertTreeNodes(listMenu, id);
                foreach (EasyUITreeNode node in listTreeNodes) 
                {
                    if (node.id.Equals(twoMenuID))
                    {
                        node.isdefuopen = "Y";
                    }
                    else
                    {
                        node.isdefuopen = "N";
                    }
                    foreach (EasyUITreeNode Childnode in node.children) 
                    {
                        if (Childnode.id.Equals(threeMenuID))
                        {
                            Childnode.isdefuopen = "Y";
                        }
                        else
                        {
                            Childnode.isdefuopen = "N";
                        }
                    }
                }
                strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            }
            //}
            
            return Content(strJson);
        }

        /// <summary>
        /// 设置默认展示系统
        /// </summary>
        /// <param name="systemId"></param>
        /// <returns></returns>
        [HttpPost]
        [Skip]
        [AjaxRequest]
        [Description("设置默认系统")]
        public JsonResult SetDefuSystem(string id) 
        {
            try
            {
                if (!string.IsNullOrEmpty(id))
                {
                    return PackagingAjaxmsg(Model_SYS_USER.SetDefuSystem(id));
                }
                return PackagingAjaxmsg(new Message().NewAmm);
            }
            catch (Exception)
            {
                return PackagingAjaxmsg(new Message().NewAmm);
            }
        }

        #region 修改密码
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Skip]
        [AjaxRequest]
        [Description("修改密码")]
        public JsonResult EditPass()
        {
            if (Request.Form["txtoldpass"] == null || Request.Form["txtnewpass"] == null || Request.Form["txtrepass"] == null)
            {
                return PackagingAjaxmsg(AjaxStatu.err, string.Format(Message.ParGetFail, "密码"));
            }
            string txtoldpass = Request["txtoldpass"].ToString();
            string txtnewpass = Request["txtnewpass"].ToString();
            string txtrepass = Request["txtrepass"].ToString();
            if (txtnewpass != txtrepass)
            {
                return PackagingAjaxmsg(AjaxStatu.err, string.Format(Message.MisMatch, "新密码"));
            }
            SYS_USER user = new SYS_USER
            {
                USER_NAME = oc.CurrentUser.USER_NAME,
                PASSWORD = txtnewpass
            };
            AjaxMsgModel amm = Model_SYS_USER.EditUserPwd(user, txtoldpass);
            return PackagingAjaxmsg(amm);
        }
        #endregion

        ///// <summary>
        ///// 根据搜索条件获取用户子系统
        ///// </summary>
        ///// <returns></returns>
        //[Skip]
        //[AjaxRequest]
        //[HttpGet]
        //public ActionResult SearchMyZeroMenu(string id)
        //{
        //    string strJson = "[]";
        //    List<SYS_MENU> listMenu = oc.UserMenuPermission
        //        .Where(m => m.PARENT_ID.Equals(Constant.systemParID) && m.MENU_ID.Equals(id)
        //        ).OrderBy(m => m.MENU_ORDER).ToList();// oc.BllSession.ISYS_MENUService.Entities.ToList();//.GetListByCondition<decimal?>(null, ma => ma.MENU_LEVEL).Select(mb => mb.ToPOCO()).ToList();
        //    if (listMenu.Count > 0)
        //    {
        //        List<EasyUITreeNode> listTreeNodes = SYS_MENU.ConvertTreeNodes(listMenu, Constant.systemParID);
        //        strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
        //    }
        //    return Content(strJson);
        //}
        [Skip]
        [AjaxRequest]
        [HttpGet]
        public ActionResult Dg(string id)
        {
            try
            {
                BROKENRAIL_SECTION_STATUS section = oc.BllSession.IBROKENRAIL_SECTION_STATUSService.Entities.Where(o => o.SECTION_ID == id).FirstOrDefault().ToPOCO();
                if (section != null)
                {
                    section.POINT_NO = "18734537924_4";
                    section.MILEAGE_START = "K13+700~K15+000";
                    section.MILEAGE_END = "13.700";
                    section.IS_SHOW = "1";
                    section.RECORD_TIME = DateTime.Now;
                    section.SECTION_STATUS = "钢轨异常";
                    Expression<Func<BROKENRAIL_SECTION_STATUS, object>>[] ignoreProperties =
                                            new Expression<Func<BROKENRAIL_SECTION_STATUS, object>>[] { p => p.BROKENRAIL_BDATA_SECTION };
                    oc.BllSession.IBROKENRAIL_SECTION_STATUSService.UpdateEntity(section,ignoreProperties);
                }

                return Content(id);

            }
            catch (Exception ex)
            {
                RecordLog.RecordError(ex.ToString());
                return null;
            }
        }
        [Skip]
        [AjaxRequest]
        [HttpGet]
        public ActionResult Hf(string id)
        {
            try
            {
                BROKENRAIL_SECTION_STATUS section = oc.BllSession.IBROKENRAIL_SECTION_STATUSService.Entities.Where(o => o.SECTION_ID == id).FirstOrDefault().ToPOCO();
                if (section != null)
                {
                    section.POINT_NO = "18734537924_4";
                    section.MILEAGE_START = "K13+700~K15+000";
                    section.MILEAGE_END = "13.700";
                    section.IS_SHOW = "1";
                    section.RECORD_TIME = DateTime.Now;
                    section.SECTION_STATUS = "钢轨恢复";
                    Expression<Func<BROKENRAIL_SECTION_STATUS, object>>[] ignoreProperties =
                                            new Expression<Func<BROKENRAIL_SECTION_STATUS, object>>[] { p => p.BROKENRAIL_BDATA_SECTION };
                    oc.BllSession.IBROKENRAIL_SECTION_STATUSService.UpdateEntity(section, ignoreProperties);
                }

                return Content(id);

            }
            catch (Exception ex)
            {
                RecordLog.RecordError(ex.ToString());
                return null;
            }
        }
        [Skip]
        [AjaxRequest]
        [HttpGet]
        public ActionResult Zc(string id)
        {
            try
            {
                BROKENRAIL_SECTION_STATUS section = oc.BllSession.IBROKENRAIL_SECTION_STATUSService.Entities.Where(o => o.SECTION_ID == id).FirstOrDefault().ToPOCO();
                if (section != null)
                {
                    section.POINT_NO = "13834549024";
                    section.MILEAGE_START = "K190+681~K192+240";
                    section.MILEAGE_END = "191.200";
                    section.IS_SHOW = "1";
                    section.RECORD_TIME = DateTime.Now;
                    section.SECTION_STATUS = "正常";
                    Expression<Func<BROKENRAIL_SECTION_STATUS, object>>[] ignoreProperties =
                                            new Expression<Func<BROKENRAIL_SECTION_STATUS, object>>[] { p => p.BROKENRAIL_BDATA_SECTION };
                    oc.BllSession.IBROKENRAIL_SECTION_STATUSService.UpdateEntity(section, ignoreProperties);
                }

                return Content(id);

            }
            catch (Exception ex)
            {
                RecordLog.RecordError(ex.ToString());
                return null;
            }
        }
        [Skip]
        [AjaxRequest]
        [HttpGet]
        public ActionResult ClearRain(string id)
        {
            #region 主机正常状态

            try
            {
                oc.BllSession.IT_RAINWARNService.DelByWhere(o => o.编号 == id && o.时间 > DateTime.Today);
            }
            catch (Exception)
            {

            }
            #endregion

            return Content(id);
        }

        [Skip]
        [AjaxRequest]
        [HttpGet]
        public ActionResult ClearGW(string id)
        {
            #region 主机正常状态
            try
            {
                oc.BllSession.IT_GWDETAILService.DelByWhere(o => o.手机号 == id && o.时间 > DateTime.Today);
            }
            catch (Exception)
            {

            }
            #endregion

            return Content(id);
        }

        [Skip]
        [AjaxRequest]
        [HttpGet]
        public ActionResult Gate(string id)
        {
            switch (id)
            {
                #region 授权1分钟
                case "授权1":
                    GATE_GATEMNG_AUTHHISTORY modelsq = new GATE_GATEMNG_AUTHHISTORY
                    {
                        HISTORY_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                        TIMEENABLE_FLAG = "1",
                        TIME_BEGIN = DateTime.Now,
                        TIME_END = DateTime.Now.AddHours(1),
                        GATE_NO = "13934145874",
                    };
                    oc.BllSession.IGATE_GATEMNG_AUTHHISTORYService.AddEntity(modelsq);

                    GATE_GATEMNG_STATE gatesq = new GATE_GATEMNG_STATE
                    {
                        STATE_ID = DateTime.Now.ToString("yyyyMMddHHmmss"),
                        GATE_NO = "13934145874",
                        STATE_FLAG = "0",
                        STATE_TIME = DateTime.Now,
                        GATELOCK_FLAG = "0",
                        GATEMAGNETS_FLAG = "0",
                        READCARD_FLAG = "0",

                    };
                    oc.BllSession.IGATE_GATEMNG_STATEService.AddEntity(gatesq);
                    break;
                #endregion
                #region 授权5分钟
                case "授权5":
                    GATE_GATEMNG_AUTHORIZATION modelsq5 = new GATE_GATEMNG_AUTHORIZATION
                    {
                        AUTHORIZATION_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                        AUTHORIZATIONTIME_BEGIN = DateTime.Now,
                        AUTHORIZATIONTIME_END = DateTime.Now.AddMinutes(5),
                        GATE_NO = "13934145874",
                    };
                    oc.BllSession.IGATE_GATEMNG_AUTHORIZATIONService.AddEntity(modelsq5);

                    GATE_GATEMNG_STATE gatesq5 = new GATE_GATEMNG_STATE
                    {
                        GATE_NO = "13934145874",
                        STATE_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                        STATE_FLAG = "0",
                        STATE_TIME = DateTime.Now,
                        GATELOCK_FLAG = "0",
                        GATEMAGNETS_FLAG = "0",
                        READCARD_FLAG = "0"
                    };
                    oc.BllSession.IGATE_GATEMNG_STATEService.AddEntity(gatesq5);
                    break;
                #endregion
                #region 开门
                case "开门":
                    GATE_GATEMNG_STATE gatezckm = new GATE_GATEMNG_STATE
                    {
                        GATE_NO = "13934145874",
                        STATE_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                        STATE_FLAG = "1",
                        STATE_TIME = DateTime.Now,
                        GATELOCK_FLAG = "1",
                        GATEMAGNETS_FLAG = "1",
                        READCARD_FLAG = "0"
                    };
                    oc.BllSession.IGATE_GATEMNG_STATEService.AddEntity(gatezckm);
                    break;
                #endregion

                #region 关门
                case "关门":
                    GATE_GATEMNG_STATE gategm = new GATE_GATEMNG_STATE
                    {
                        GATE_NO = "13934145874",
                        STATE_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                        STATE_FLAG = "0",
                        STATE_TIME = DateTime.Now,
                        GATELOCK_FLAG = "0",
                        GATEMAGNETS_FLAG = "0",
                        READCARD_FLAG = "0"
                    };
                    oc.BllSession.IGATE_GATEMNG_STATEService.AddEntity(gategm);
                    break;
                #endregion

                #region 无卡开门
                case "无卡开门":
                    GATE_GATEMNG_WARNING wkjr = new GATE_GATEMNG_WARNING
                    {
                        WARNING_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                        GATE_NO = "13934145874",
                        WARNING_INFO = "无卡开门",
                        WARNING_TYPE = "二级",
                        WARNING_LOG = "5AA52000B92113934145874F150422014235E00600000000000000000000000000000048F9000000E8",
                        WARNING_TIME = DateTime.Now
                    };
                    oc.BllSession.IGATE_GATEMNG_WARNINGService.AddEntity(wkjr);
                    break;
                #endregion
                #region 无卡靠近
                case "无卡靠近":
                    GATE_GATEMNG_WARNING wkkj = new GATE_GATEMNG_WARNING
                    {
                        WARNING_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                        GATE_NO = "13934145874",
                        WARNING_INFO = "无卡靠近",
                        WARNING_TYPE = "三级",
                        WARNING_LOG = "5AA52000B92113934145874F150422014235E00600000000000000000000000000000048F9000000E8",
                        WARNING_TIME = DateTime.Now
                    };
                    oc.BllSession.IGATE_GATEMNG_WARNINGService.AddEntity(wkkj);
                    break;
                #endregion
                #region 开门超时
                case "开门超时":
                    GATE_GATEMNG_WARNING kmcs = new GATE_GATEMNG_WARNING
                    {
                        WARNING_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                        GATE_NO = "13934145874",
                        WARNING_INFO = "开门超时",
                        WARNING_TYPE = "一级",
                        WARNING_LOG = "5AA52000B92113934145874F150422014235E00600000000000000000000000000000048F9000000E8",
                        WARNING_TIME = DateTime.Now
                    };
                    oc.BllSession.IGATE_GATEMNG_WARNINGService.AddEntity(kmcs);
                    break;
                #endregion
                #region 电池电量
                case "电池电量":
                    GATE_GATEMNG_WARNING dcdl = new GATE_GATEMNG_WARNING
                    {
                        WARNING_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                        GATE_NO = "13934145874",
                        WARNING_INFO = "电池电量低于警戒值",
                        //WARNING_TYPE = "二级",
                        WARNING_LOG = "5AA52000B92113934145874F150422014235E00600000000000000000000000000000048F9000000E8",
                        WARNING_TIME = DateTime.Now
                    };
                    oc.BllSession.IGATE_GATEMNG_WARNINGService.AddEntity(dcdl);
                    break;
                #endregion
                case "进门":
                    if (!inflag && !outflag)
                    {
                        inflag = true;
                        for (int i = 0; i < 7; i++)
                        {
                            GATE_GATEMNG_INOUT inmodel = new GATE_GATEMNG_INOUT
                            {
                                INOUT_ID = DateTime.Now.ToString("yyyyMMddHHmmss"),
                                GATE_NO = "13934145874",
                                CARD_NO = cardArray[i],
                                INOUT_TIME = DateTime.Now,
                                INOUT_FLAG = "0",
                                READCARD_FLAG = "2",
                                INOUT_STATE = "2"
                            };
                            oc.BllSession.IGATE_GATEMNG_INOUTService.AddEntity(inmodel);
                            Thread.Sleep(1000);
                        }
                        inflag = false;
                    }
                    break;
                case "出门":
                    if (!inflag && !outflag)
                    {
                        outflag = true;
                        for (int i = 0; i < 7; i++)
                        {
                            GATE_GATEMNG_INOUT outmodel = new GATE_GATEMNG_INOUT
                            {
                                INOUT_ID = DateTime.Now.ToString("yyyyMMddHHmmss"),
                                GATE_NO = "13934145874",
                                CARD_NO = cardArray[i],
                                INOUT_TIME = DateTime.Now,
                                INOUT_FLAG = "1",
                                READCARD_FLAG = "2",
                                INOUT_STATE = "2"
                            };
                            oc.BllSession.IGATE_GATEMNG_INOUTService.AddEntity(outmodel);
                            Thread.Sleep(1000);
                        }
                        outflag = false;
                    }
                    break;
            }
            return Content(id);
        }

    }
}
