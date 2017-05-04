using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Common;
using Common.Attributes;
using Model;
using Model.ModelExt;
using Web.Areas.Models;
using Web.Areas.ViewModels;
using Web.Controllers;

namespace Web.Areas.SYS.Controllers
{
    public class SYS_ROLEController : BaseController
    {
        //
        // GET: /SYS/SYS_ROLE/

        #region 查看角色
        [AjaxRequest]
        [Description("查看角色")]
        [HttpGet]
        public ActionResult Index()
        {
            string ControllerUrl = "/api/SYS/SYS_ROLE/";
            var viewModel = new
            {
                Permission = new//权限
                {
                    a_list = Model_SYS_MENU.HasPermission("SYS", "SYS_ROLE", "List", HttpMethod.Post),
                    a_add = Model_SYS_MENU.HasPermission("SYS", "SYS_ROLE", "Add", HttpMethod.Post),
                    a_edit = Model_SYS_MENU.HasPermission("SYS", "SYS_ROLE", "Edit", HttpMethod.Get),
                    a_del = Model_SYS_MENU.HasPermission("SYS", "SYS_ROLE", "Del", HttpMethod.Get),
                },
                resx = new
                {
                    listTitle = "您没有【查看角色】权限",
                    addTitle = "您没有【新增角色】权限",
                    editTitle = "您没有【编辑角色】权限！",
                    deleteTitle = "您没有【删除角色】权限！"
                },
                urls = new//请求URL
                {
                    save = ControllerUrl + "Save",
                    list = ControllerUrl + "List",
                    edit = ControllerUrl + "Edit",
                    del = ControllerUrl + "Del",
                    menuTree = ControllerUrl + "GetMyMenuListTree",
                    //writexls = ControllerUrl + "writexls",
                    dataGgridName = "data_grid",//列表ID
                    dataGgridType = "datagrid",//列表类型
                    dataAddName = "data_add",//增加窗口
                    dataFormName = "DataForm",//提交表单
                },
                searchForm = new VIEW_SYS_ROLE()//查询
                {
                },
                addForm = new VIEW_SYS_ROLE()
                { //添加修改
                },
                extForm = new//扩展类
                {
                    extA = oc.UserMenuPermission.Where(m => m.MENU_LEVEL > 3).Select(u => new { id = u.MENU_ID, text = u.MENU_NAME }).ToList(),
                    extB = new List<string>()
                }
            };
            return View(viewModel);
        }
        #endregion


        #region 保存角色
        [HttpPost]
        [AjaxRequest]
        [Skip]
        [Description("保存角色")]
        [ValidateInput(false)]
        public ActionResult Save()
        {
            try
            {

                string name = Request["name"].ToString();
                string note = Request["note"].ToString();
                string upid = Request["upid"].ToString();
                string menu = "";
                if (Request["menu"] != null)
                {
                    menu = Request["menu"].ToString();
                }
                string role_id = upid;
                if (role_id == "")//如果是新增加
                {
                    //最后一个role_id
                    var lastCode = oc.BllSession.ISYS_ROLEService.Entities.OrderByDescending(m => m.ROLE_ID).Select(m => new { m.ROLE_ID }).FirstOrDefault();
                    int lastCodeId = 1;
                    if (lastCode != null)
                    {
                        lastCodeId = int.Parse(lastCode.ROLE_ID) + 1;
                    }
                    string codeNum = lastCodeId < 10 ? "00" + lastCodeId.ToString() : lastCodeId.ToString();
                    codeNum = codeNum.Length == 2 ? "0" + codeNum : codeNum;
                    role_id = codeNum;
                }
                List<SYS_ROLE_MENU_MAP> listRoleMenu = new List<SYS_ROLE_MENU_MAP>();//菜单
                List<string> listMenuId = new List<string>();//菜单ID
                //List<string> listChildMenuId = new List<string>();//子菜单ID
                List<SYS_ROLE_MENUOPT_MAP> listRoleMenuOpt = new List<SYS_ROLE_MENUOPT_MAP>();//操作
                //List<string> listMenuOptId = new List<string>();//操作ID

                if (menu != "")
                {
                    string[] menuid = menu.Split(',');
                    for (int i = 0; i < menuid.Length; i++)
                    {
                        listMenuId.Add(menuid[i]);
                        listRoleMenuOpt.Add(new SYS_ROLE_MENUOPT_MAP()
                        {
                            ROLE_MENUOPT_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff") + menuid[i] + i.ToString(),
                            ROLE_ID = role_id,
                            MENUOPT_ID = menuid[i]
                        });
                        if (menuid[i].IndexOf('-') > -1)//菜单ID不为父菜单时，
                        {
                            string pMenuId = menuid[i].Substring(0, 2);//父菜单ID
                            if (listMenuId.IndexOf(pMenuId) == -1)//如果没有父菜单ID
                            {
                                listMenuId.Add(pMenuId);//加入父菜单ID
                                listRoleMenu.Add(new SYS_ROLE_MENU_MAP()
                                {
                                    ROLE_MENU_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff") + pMenuId + i.ToString(),
                                    ROLE_ID = role_id,
                                    MENU_ID = pMenuId
                                });
                            }
                            pMenuId = menuid[i].Substring(0, 4);//父菜单ID
                            if (listMenuId.IndexOf(pMenuId) == -1)//如果没有父菜单ID
                            {
                                listMenuId.Add(pMenuId);//加入父菜单ID
                                listRoleMenu.Add(new SYS_ROLE_MENU_MAP()
                                {
                                    ROLE_MENU_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff") + pMenuId + i.ToString(),
                                    ROLE_ID = role_id,
                                    MENU_ID = pMenuId
                                });
                            }
                            if (menuid[i].Length > 8)
                            {
                                pMenuId = menuid[i].Substring(0, 6);//父菜单ID
                                if (listMenuId.IndexOf(pMenuId) == -1)//如果没有父菜单ID
                                {
                                    listMenuId.Add(pMenuId);//加入父菜单ID
                                    listRoleMenu.Add(new SYS_ROLE_MENU_MAP()
                                    {
                                        ROLE_MENU_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff") + pMenuId + i.ToString(),
                                        ROLE_ID = role_id,
                                        MENU_ID = pMenuId
                                    });
                                }
                                pMenuId = menuid[i].Substring(0, 8);//父菜单ID
                                if (listMenuId.IndexOf(pMenuId) == -1)//如果没有父菜单ID
                                {
                                    listMenuId.Add(pMenuId);//加入父菜单ID
                                    listRoleMenu.Add(new SYS_ROLE_MENU_MAP()
                                    {
                                        ROLE_MENU_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff") + pMenuId + i.ToString(),
                                        ROLE_ID = role_id,
                                        MENU_ID = pMenuId
                                    });
                                }
                            }
                        }
                    }
                }

                /*
                if (menu != "")
                {
                    string[] menuid = menu.Split(',');
                    for (int i = 0; i < menuid.Length; i++)
                    {
                        listMenuId.Add(menuid[i]);
                        if (Constant.GISOneMenu.Split(',').Contains(menuid[i]))
                        {
                            continue;
                        }
                        if (menuid[i].Length > 4)//菜单ID不为父菜单时，
                        {
                            string pMenuId = menuid[i].Substring(0, 2);//父菜单ID
                            if (listMenuId.IndexOf(pMenuId) == -1)//如果没有父菜单ID
                            {
                                listMenuId.Add(pMenuId);//加入父菜单ID
                            }
                            pMenuId = menuid[i].Substring(0, 4);//父菜单ID
                            if (listMenuId.IndexOf(pMenuId) == -1)//如果没有父菜单ID
                            {
                                listMenuId.Add(pMenuId);//加入父菜单ID
                            }
                        }
                        //string look = Request["look" + menuid[i]].ToString();
                        //listMenuOptId.Add(look);//操作菜单
                    }
                    //List<string> listTwoMenuId = menuid.ToList();
                    //    //if (listTwoMenuId.IndexOf("2") > -1)
                    //    //{
                    //    //    listTwoMenuId.Remove("2");
                    //    //}
                    //listChildMenuId = oc.BllSession.ISYS_MENUService.Entities.Where(m => listTwoMenuId.Contains(m.PARENT_ID)).Select(m => m.MENU_ID).ToList();
                    //listMenuId.AddRange(listChildMenuId);//加入子菜单ID
                }
                
                int x = 1;
                foreach (string item in listMenuId)
                {
                    listRoleMenu.Add(
                        new SYS_ROLE_MENU_MAP()
                        {
                            ROLE_MENU_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff") + item + x.ToString(),
                            MENU_ID = item,
                            ROLE_ID = role_id
                        }
                        );
                    x++;
                }
                foreach (string item in listMenuOptId)
                {
                    string menuid = item.Replace("look", "").Replace("opt", "");
                    //if (menuid != "2")
                    //{
                    List<string> listThereMenuId = listChildMenuId.Where(m => m.StartsWith(menuid)).ToList();
                    foreach (string thereMenuId in listThereMenuId)
                    {
                        listRoleMenuOpt.Add(
                            new SYS_ROLE_MENUOPT_MAP()
                            {
                                ROLE_MENUOPT_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff") + thereMenuId + "1",
                                MENUOPT_ID = thereMenuId + "-002",
                                ROLE_ID = role_id
                            }
                            );
                        int m = 5;
                        //扩展导入导出时再修改
                        /*
                        if (thereMenuId == "10201")//如果是问题库，加导出
                        {
                            listRoleMenuOpt.Add(
                                new SYS_ROLE_MENUOPT_MAP()
                                {
                                    ROLE_MENUOPT_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff") + thereMenuId + "6",
                                    MENUOPT_ID = thereMenuId + "-006",
                                    ROLE_ID = role_id
                                }
                                );
                            m = 6;//加导入
                        }
                        
                        if (item.IndexOf("opt") > -1)//如果是操作权限
                        {
                            for (int i = 2; i < m; i++)
                            {
                                listRoleMenuOpt.Add(
                                    new SYS_ROLE_MENUOPT_MAP()
                                    {
                                        ROLE_MENUOPT_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff") + thereMenuId + i.ToString(),
                                        MENUOPT_ID = thereMenuId + "-00" + (i==2?1:i),
                                        ROLE_ID = role_id
                                    }
                                    );
                            }
                        }
                    }
                    //}
                }*/
                SYS_ROLE u = new SYS_ROLE()
                {
                    ROLE_ID = role_id,
                    NAME = name,
                    NOTE = note,
                    SYS_ROLE_MENU_MAP = listRoleMenu,
                    SYS_ROLE_MENUOPT_MAP = listRoleMenuOpt
                };
                if (upid == "")
                {
                    return PackagingAjaxmsg(Model_SYS_ROLE.Add(u));
                }
                else
                {
                    u.ROLE_ID = upid;
                    return PackagingAjaxmsg(Model_SYS_ROLE.Edit(u));
                }

            }
            catch (Exception)
            {

                return PackagingAjaxmsg(new Message().NewAmm);
            }
        }
        #endregion

        /*
        #region 修改角色
        [HttpGet]
        [AjaxRequest]
        [Description("修改角色")]
        public JsonResult Edit(string id)
        {
            string roleid = id;

            try
            {
                if (oc.BllSession.ISYS_ROLEService.Entities.Where(u => u.ROLE_ID == roleid).ToList().Count > 0)
                {
                    //菜单权限
                    List<string> listMenuId = oc.BllSession.ISYS_ROLE_MENU_MAPService.Entities.Where(u => u.ROLE_ID == roleid && u.MENU_ID.Length < 7).Select(u => u.MENU_ID).ToList();
                    string menustr = "";// "001,003";
                    foreach (string item in listMenuId)
                    {
                        menustr += item + ",";
                    }
                    //操作权限
                    List<string> listMenuOptId = oc.BllSession.ISYS_ROLE_MENUOPT_MAPService.Entities.Where(u => u.ROLE_ID == roleid && u.MENUOPT_ID.EndsWith("004")).Select(u => u.MENUOPT_ID).ToList();
                    string menuoptstr = "";//
                    foreach (string item in listMenuOptId)
                    {
                        menuoptstr += item.Substring(0, 6) + ",";
                    }
                    var role = oc.BllSession.ISYS_ROLEService.Entities.Where(u => u.ROLE_ID == roleid).OrderBy(u => u.ROLE_ID)
                        .Select(u =>
                            new
                            {
                                roleid = u.ROLE_ID,
                                name = u.NAME,
                                note = u.NOTE,
                                menu = menustr,
                                lookopt = menuoptstr//GIS监控特殊ID为2，没有过滤
                            }
                            ).FirstOrDefault();
                    return ObjToJson.GetToJson(role, true);
                }
                else
                {
                    AjaxMsgModel amm = new Message().NewAmm;
                    amm.Msg = string.Format(Message.NotFound, "角色");
                    return PackagingAjaxmsg(amm);
                }
            }
            catch (Exception)
            {
                return PackagingAjaxmsg(new Message().NewAmm);
            }
        }
        #endregion
        */
    }


    public class SYS_ROLEApiController : BaseApiController
    {

        #region 查看我的导航菜单树
        [System.Web.Http.HttpPost]
        public List<EasyUITreeNode> GetMyMenuListTree()
        {
            List<string> listMuenId = oc.UserMenuPermission
                //.Where(u=>!Constant.GISTwoMenu.Split(',').Contains(u.MENU_ID))
                .Select(u => u.MENU_ID).ToList();
            //获得组织
            List<SYS_MENU> listMenu = oc.BllSession.ISYS_MENUService.Entities.Where(m => listMuenId.Contains(m.MENU_ID) && m.MENU_LEVEL <= 3).OrderBy(m => m.MENU_ID).OrderBy(m => m.MENU_ORDER).ToList();
            return SYS_MENU.ConvertTreeNodes(listMenu, "0");
        }
        #endregion

        #region 查询
        [HttpPost]//查询
        public ViewModel List(VIEW_SYS_ROLE data)
        {
            int pageSize = int.Parse(data.rows);
            int pageIndex = int.Parse(data.page);
            string sort = data.sort;
            string order = data.order;

            //查询条件

            IQueryable<SYS_ROLE> SYS_ROLEEntity = oc.BllSession.ISYS_ROLEService.Entities;
            if (data.NAME != null && data.NAME != "")
            {
                SYS_ROLEEntity = SYS_ROLEEntity.Where(u => u.NAME.IndexOf(data.NAME) > -1);
            }
            int total = 0;
            total = SYS_ROLEEntity.Count();
            var listROLE = SYS_ROLEEntity.OrderBy(u => u.ROLE_ID)
                            .Skip(pageSize * (pageIndex - 1)).Take(pageSize)
                         .Select(mb => new
                         {
                             ROLE_ID = mb.ROLE_ID,
                             name = mb.NAME,
                             note = mb.NOTE
                         }).ToList();
            return ObjToJson.ViewModelToJson(listROLE, total);
        }
        #endregion

        #region 修改
        [HttpPost]
        public AjaxMsgModel Edit(VIEW_SYS_ROLE data)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                /*
                //获取不显示list以及opt radio的关于GIS的menu id
                List<string> ListNoShowlistOptId = new List<string>();
                ListNoShowlistOptId.AddRange(Constant.GISOneMenu.Split(',').ToList());
                VIEW_SYS_ROLE role = oc.BllSession.ISYS_ROLEService.Entities.Where(u => u.ROLE_ID == data.ROLE_ID).OrderBy(u => u.ROLE_ID)
                        .Select(u =>
                            new VIEW_SYS_ROLE
                            {
                                ROLE_ID = u.ROLE_ID,
                                NAME = u.NAME,
                                NOTE = u.NOTE,
                                NoShowlistOptId = ListNoShowlistOptId
                            }
                            ).FirstOrDefault();

                if (role != null)
                {
                    List<string> listMenuId = oc.BllSession.ISYS_ROLE_MENU_MAPService.Entities.Where(u => u.ROLE_ID == data.ROLE_ID && u.MENU_ID.Length < 7).Select(u => u.MENU_ID).ToList();
                    role.MenuId = listMenuId;
                    List<string> listMenuOptId = oc.BllSession.ISYS_ROLE_MENUOPT_MAPService.Entities.Where(u => u.ROLE_ID == data.ROLE_ID && u.MENUOPT_ID.EndsWith("004")).Select(u => u.MENUOPT_ID.Substring(0, 6)).ToList();

                    role.MenuOptId = listMenuOptId;
                    amm.Statu = AjaxStatu.ok;
                    amm.Data = role;
                    return amm;
                }
                else
                {
                    amm.Msg = string.Format(Message.NotFound, "角色");
                    return amm;
                }*/

                VIEW_SYS_ROLE role = oc.BllSession.ISYS_ROLEService.Entities.Where(u => u.ROLE_ID == data.ROLE_ID).OrderBy(u => u.ROLE_ID)
                        .Select(u =>
                            new VIEW_SYS_ROLE
                            {
                                ROLE_ID = u.ROLE_ID,
                                NAME = u.NAME,
                                NOTE = u.NOTE
                            }
                            ).FirstOrDefault();

                if (role != null)
                {
                    List<string> listMenuId = oc.BllSession.ISYS_ROLE_MENU_MAPService.Entities.Where(u => u.ROLE_ID == data.ROLE_ID).Select(u => u.MENU_ID).ToList();
                    role.MenuId = listMenuId;
                    List<string> listMenuOptId = oc.BllSession.ISYS_ROLE_MENUOPT_MAPService.Entities.Where(u => u.ROLE_ID == data.ROLE_ID).Select(u => u.MENUOPT_ID).ToList();
                    role.MenuOptId = listMenuOptId;
                    amm.Statu = AjaxStatu.ok;
                    amm.Data = role;
                    return amm;
                }
                else
                {
                    amm.Msg = string.Format(Message.NotFound, "角色");
                    return amm;
                }
            }
            catch (Exception)
            {
                return amm;
            }
        }
        #endregion

        #region 删除
        [HttpPost]
        public AjaxMsgModel Del(VIEW_SYS_ROLE data)
        {
            return Model_SYS_ROLE.Del(data.ROLE_ID);
        }
        #endregion

    }
}
