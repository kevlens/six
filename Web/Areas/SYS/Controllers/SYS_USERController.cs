using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using AutoMapper;
using Common;
using Common.Attributes;
using Model;
using SxShWeb.Areas.Models;
using SxShWeb.Areas.ViewModels;
using SxShWeb.Controllers;
using System.Data.Entity;

namespace SxShWeb.Areas.SYS.Controllers
{
    public class SYS_USERController : BaseController
    {
        //
        // GET: /SYS/SYS_USER/

        #region 查看用户
        [AjaxRequest]
        [Description("查看用户")]
        [HttpGet]
        public ActionResult Index()
        {
            string ControllerUrl = "/api/SYS/SYS_USER/";
            var viewModel = new
            {
                Permission = new//权限
                {
                    a_list = Model_SYS_MENU.HasPermission("SYS", "SYS_USER", "List", Common.HttpMethod.Post),
                    a_add = Model_SYS_MENU.HasPermission("SYS", "SYS_USER", "Add", Common.HttpMethod.Post),
                    a_edit = Model_SYS_MENU.HasPermission("SYS", "SYS_USER", "Edit", Common.HttpMethod.Get),
                    a_del = Model_SYS_MENU.HasPermission("SYS", "SYS_USER", "Del", Common.HttpMethod.Get),
                },
                resx = new
                {
                    listTitle = "您没有【查看用户】权限",
                    addTitle = "您没有【新增用户】权限",
                    editTitle = "您没有【编辑用户】权限！",
                    deleteTitle = "您没有【删除用户】权限！"
                },
                urls = new//请求URL
                {
                    save = ControllerUrl + "Save",
                    list = ControllerUrl + "List",
                    edit = ControllerUrl + "Edit",
                    del = ControllerUrl + "Del",
                    //writexls = ControllerUrl + "writexls",
                    dataGgridName = "data_grid",//列表ID
                    dataGgridType = "datagrid",//列表类型
                    dataAddName = "data_add",//增加窗口
                    dataFormName = "DataForm",//提交表单
                },
                searchForm = new VIEW_SYS_USER()//查询
                {
                },
                addForm = new VIEW_SYS_USER()
                { //添加修改
                },
                extForm = new//扩展类
                {
                    extA = Model_SYS_DEPT.GetMyORGTree(oc.CurrentUser.SYS_DEPT.DEPT_CODE, oc.CurrentUser.SYS_DEPT.PARENT_CODE),
                    extB = oc.BllSession.ISYS_ROLEService.Entities.Select(r => new { ROLE_ID = r.ROLE_ID, NAME = r.NAME }).OrderBy(r => r.ROLE_ID).ToList(),
                    extC = new List<string>(),
                    //extD = Model_SYS_DEPT.GetMyORGTree(oc.CurrentUser.SYS_DEPT.DEPT_CODE, oc.CurrentUser.SYS_DEPT.PARENT_CODE, 1)
                    extD = Model_SYS_DEPT.GetMyORGTree(oc.CurrentUser.SYS_DEPT.DEPT_CODE.Substring(0, 2), "0", 1)
                }
                //,viewSettings = new { }
            };
            return View(viewModel);
        } 
        #endregion

        [Skip]
        [AjaxRequest]
        [HttpPost]
        [Description("查看我的组织机构树")]
        public ActionResult GetMyORGTree()
        {
            return Content(Model_SYS_DEPT.GetMyORGNoZsTree(oc.CurrentUser.SYS_DEPT.DEPT_CODE, oc.CurrentUser.SYS_DEPT.PARENT_CODE));
        }
    }

    
    public class SYS_USERApiController : BaseApiController
    {
        #region 查询
        [HttpPost]//查询
        public ViewModel List(VIEW_SYS_USER data)
        {
            int pageSize = int.Parse(data.rows);
            int pageIndex = int.Parse(data.page);
            string sort = data.sort;
            string order = data.order;
            //查询条件
            Expression<Func<SYS_USER, bool>> slamda = u => u.DEPT_CODE.StartsWith(oc.CurrentUser.SYS_DEPT.DEPT_CODE);

            if (data.DEPT_CODE != null && data.DEPT_CODE != "")
            {
                slamda = u => u.DEPT_CODE.StartsWith(data.DEPT_CODE);
            }
            int total = 0;

            total = oc.BllSession.ISYS_USERService.Entities.Where(slamda).Count();
            var listMenus = oc.BllSession.ISYS_USERService.Entities.Include("SYS_USER_ROLE_MAP").Where(slamda).OrderBy(u => u.DEPT_CODE)
                                                       .Skip(pageSize * (pageIndex - 1)).Take(pageSize).Select(mb =>
                                                        new
                                                        {
                                                            deptcode = mb.DEPT_CODE,
                                                            deptname = mb.SYS_DEPT.DEPT_NAME,
                                                            depticon = mb.SYS_DEPT.C_ICO,
                                                            username = mb.USER_NAME,
                                                            zsname = mb.ZSNAME,
                                                            uptime = mb.UPDATE_DATE,
                                                            upuser = mb.UPDATE_USER,
                                                            mb.SYS_USER_ROLE_MAP
                                                        }
                                                        ).ToList();
            List<UserRoleModel> listMenu = new List<UserRoleModel>();

            foreach (var item in listMenus)
            {
                string rolename = string.Empty;
                foreach (var itemx in item.SYS_USER_ROLE_MAP)
                {
                    if (rolename != "")
                    {
                        rolename += ",";
                    }
                    rolename += itemx.SYS_ROLE.NAME;
                }
                listMenu.Add(new UserRoleModel
                {
                    deptcode = item.deptcode,
                    deptname = item.deptname,
                    USER_NAME = item.username,
                    ZSNAME = item.zsname,
                    uptime = item.uptime,
                    upuser = item.upuser,
                    rolename = rolename,
                    depticon = item.depticon

                });
            }

            return ObjToJson.ViewModelToJson(listMenu, total);
        }
        #endregion

        #region 修改
        [HttpPost]
        public AjaxMsgModel Edit(VIEW_SYS_USER data)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                SYS_USER member = oc.BllSession.ISYS_USERService.Entities.Where(m => m.USER_NAME == data.USER_NAME).OrderBy(m => m.USER_NAME).FirstOrDefault();

                if (member != null)
                {
                    Mapper.CreateMap<SYS_USER, VIEW_SYS_USER>();
                    VIEW_SYS_USER vm = Mapper.Map<SYS_USER, VIEW_SYS_USER>(member);
                    vm.ISUP_FLAG_EXT = "edit";
                    List<string> listRoleId = oc.BllSession.ISYS_USER_ROLE_MAPService.Entities.Where(u => u.USER_NAME == data.USER_NAME).Select(u => u.ROLE_ID).ToList();
                    vm.ROLE_EXT = listRoleId;

                    amm.Statu = AjaxStatu.ok;
                    amm.Data = vm;
                    return amm;
                }
                else
                {
                    amm.Msg = string.Format(Message.NotFound, "用户");
                    return amm;
                }
            }
            catch (Exception)
            {
                return amm;
            }
        }
        #endregion

        #region 保存
        [HttpPost]
        [ValidateInput(false)]
        public AjaxMsgModel Save(VIEW_SYS_USER data)
        {
            try
            {
                if (!string.IsNullOrEmpty(data.MANAGE_DEPT_CODE) && data.MANAGE_DEPT_CODE != "null")
                {
                    if (oc.BllSession.ISYS_DEPTService.Entities.Where(o => o.DEPT_CODE == data.MANAGE_DEPT_CODE && o.DEPT_FLAG==1).Count() == 0)
                    {
                        AjaxMsgModel amm = new Message().NewAmm;
                        amm.Statu = AjaxStatu.err;
                        amm.Msg = "用户所在部门选择不正确！";
                        return amm;
                    }
                }
                Mapper.CreateMap<VIEW_SYS_USER, SYS_USER>();
                SYS_USER u = Mapper.Map<VIEW_SYS_USER, SYS_USER>(data);

                string role_id = "";
                if (data.ROLE_EXT.Count>0)
                {
                    role_id = data.ROLE_EXT[0];
                }
                List<SYS_USER_ROLE_MAP> listRole = new List<SYS_USER_ROLE_MAP>();
                if (!string.IsNullOrEmpty(role_id) && role_id != "null")
                {
                    string[] roleid = role_id.Split(',');
                    for (int i = 0; i < roleid.Length; i++)
                    {
                        listRole.Add(
                            new SYS_USER_ROLE_MAP()
                            {
                                ROLE_ID = roleid[i],
                                USER_NAME = data.USER_NAME,
                                USER_ROLE_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff") + i.ToString()
                            }
                        );
                    }
                }

                if (u.PASSWORD != null)
                {
                    u.PASSWORD = DataHelper.TOMD5(u.PASSWORD);
                }
                else
                {
                    u.PASSWORD = "";
                }
                u.UPDATE_DATE = DateTime.Now;
                u.UPDATE_USER = oc.CurrentUser.USER_NAME;
                u.SYS_USER_ROLE_MAP = listRole;

                if (data.ISUP_FLAG_EXT==null || data.ISUP_FLAG_EXT=="")
                {
                    return Model_SYS_USER.Add(u);
                }
                else
                {
                    return Model_SYS_USER.Edit(u, u.PASSWORD);
                }
            }
            catch (Exception)
            {
                return new Message().NewAmm;
            }
        }
        #endregion

        #region 删除
        [HttpPost]
        public AjaxMsgModel Del(VIEW_SYS_USER data)
        {
            return Model_SYS_USER.Del(data.USER_NAME);
        }
        #endregion
    }
}
