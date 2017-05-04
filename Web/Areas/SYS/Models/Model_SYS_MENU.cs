using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using Common;
using Model;

namespace Web.Areas.Models
{
    public partial class Model_SYS_MENU
    {
        #region 根据用户名得到对应的权限信息
        /// <summary>
        /// 根据用户编号得到对应的权限信息
        /// </summary>
        /// <param name="USER_NAME">用户名</param>
        /// <returns>权限集合</returns>
        public static List<SYS_MENU> GetUserPermission(string USER_NAME)
        {
            //获取不显示的菜单编号(集合)
            List<SYS_MENU> AllMenu = oc.BllSession.ISYS_MENUService.Entities.ToList();
            List<string> noShowIDtemp = AllMenu.Where(u=>(!string.IsNullOrEmpty(u.ISSHOW_FLAG) && u.ISSHOW_FLAG.Equals("0")))
                .Select(u => u.MENU_ID).ToList();
            List<string> noShowIDs = new List<string>();
            foreach (string menuid in noShowIDtemp) 
            {
                List<string> noShowTempIDList = AllMenu.Where(u => u.MENU_ID.StartsWith(menuid)).Select(u=>u.MENU_ID).ToList();
                noShowIDs.AddRange(noShowTempIDList);
            }

            //--根据用户名得到角色编号(集合)
            List<string> listRoleId = oc.BllSession.ISYS_USER_ROLE_MAPService.Entities.Where(u => u.USER_NAME == USER_NAME)
                .Select(u => u.ROLE_ID).ToList();
            #region 原写法
            //根据角色编号得到菜单权限编号(集合)
            //List<string> listMenuIds = oc.BllSession.ISYS_ROLE_MENU_MAPService.Entities.Where(rp => listRoleId.Contains(rp.ROLE_ID)
            //    && !noShowIDs.Contains(rp.MENU_ID))
            //    .Select(rp => rp.MENU_ID).ToList();

            ////根据权限编号得到权限的具体信息
            //List<SYS_MENU> listMenu = oc.BllSession.ISYS_MENUService.Entities.Where(p => listMenuIds.Contains(p.MENU_ID) && !noShowIDs.Contains(p.MENU_ID))
            //    .ToList().Select(u => u.ToPOCO()).ToList();


            ////根据角色编号得到菜单按纽权限编号(集合)
            //List<string> listMenuOptIds = oc.BllSession.ISYS_ROLE_MENUOPT_MAPService.Entities.Where(rp => listRoleId.Contains(rp.ROLE_ID))
            //    .Select(rp => rp.MENUOPT_ID).ToList();
            ////根据权限编号得到权限的具体信息
            //List<SYS_MENU> listBM = oc.BllSession.ISYS_MENUOPTService.Entities.Where(p => listMenuOptIds.Contains(p.MENUOPT_ID) && !noShowIDs.Contains(p.MENU_ID)).ToList()
            //                        .Select(u => new SYS_MENU
            //                        {
            //                            MENU_ID = u.MENUOPT_ID,
            //                            AREA = u.AREA,
            //                            CONTROLLER = u.CONTROLLER,
            //                            ACTION = u.ACTION,
            //                            MENU_NAME = u.MENUOPT_NAME,
            //                            C_ICO = u.C_ICO,
            //                            MENU_LEVEL = 100,
            //                            PARENT_ID = "100"
            //                        }).ToList();

            //listMenu.AddRange(listBM);
            #endregion
            #region 新写法
            //根据角色编号得到菜单权限编号(集合)
            
            List<SYS_ROLE_MENU_MAP> listMenus = oc.BllSession.ISYS_ROLE_MENU_MAPService.Entities.ToList();
            List<string> listMenuIds = (from menuMap in listMenus
                                        join roleid in listRoleId on menuMap.ROLE_ID equals roleid
                                        select menuMap.MENU_ID).Distinct().ToList();
            for (int i = 0; i < noShowIDs.Count; i++)
            {
                if (listMenuIds.Contains(noShowIDs[i]))
                {
                    listMenuIds.Remove(noShowIDs[i]);
                }
            }



            //根据权限编号得到权限的具体信息
            List<SYS_MENU> listsysMenus = oc.BllSession.ISYS_MENUService.Entities.ToList();
            List<SYS_MENU> listMenu_temp =
                (from sys_menu in listsysMenus
                 join menuid in listMenuIds on sys_menu.MENU_ID equals menuid
                 select sys_menu).ToList();

            List<SYS_MENU> listMenu = new List<SYS_MENU>();
            SYS_MENU modelMenu = new SYS_MENU();
            for (int i = 0; i < listMenu_temp.Count; i++)
            {
                modelMenu = listMenu_temp[i];
                if (!noShowIDs.Contains(modelMenu.MENU_ID))
                {
                    listMenu.Add(modelMenu);
                }
            }


            //根据角色编号得到菜单按纽权限编号(集合)
            List<SYS_ROLE_MENUOPT_MAP> listmMenuoptMaps = oc.BllSession.ISYS_ROLE_MENUOPT_MAPService.Entities.ToList();
            List<string> listMenuOptIds = (from menuopt in listmMenuoptMaps
                                           join roleid in listRoleId on menuopt.ROLE_ID equals roleid
                                           select menuopt.MENUOPT_ID).Distinct().ToList();



            //根据权限编号得到权限的具体信息

            List<SYS_MENUOPT> listmenuopt = oc.BllSession.ISYS_MENUOPTService.Entities.ToList();
            List<SYS_MENU> listBM_temp = (from u in listmenuopt
                                          join menuoptid in listMenuOptIds on u.MENUOPT_ID equals menuoptid
                                          select new SYS_MENU
                                          {
                                              MENU_ID = u.MENUOPT_ID,
                                              AREA = u.AREA,
                                              CONTROLLER = u.CONTROLLER,
                                              ACTION = u.ACTION,
                                              MENU_NAME = u.MENUOPT_NAME,
                                              C_ICO = u.C_ICO,
                                              MENU_LEVEL = 100,
                                              PARENT_ID = "100"
                                          }).ToList();

            List<SYS_MENU> listBM = new List<SYS_MENU>();
            for (int i = 0; i < listBM_temp.Count; i++)
            {
                modelMenu = listBM_temp[i];
                if (!noShowIDs.Contains(modelMenu.MENU_ID))
                {
                    listBM.Add(modelMenu);
                }
            }
            listMenu.AddRange(listBM);
            
            #endregion
            

            return listMenu.OrderBy(u => u.MENU_ID).ToList();
        }

        #endregion
        #region  获取隐藏超级用户权限
        /// <summary>
        /// 隐藏超级用户权限
        /// </summary>
        /// <returns></returns>
        public static List<SYS_MENU> GetSuperAdminPermission()
        {
            //获取所有菜单
            List<SYS_MENU> listMenu = oc.BllSession.ISYS_MENUService.Entities.ToList();
            List<SYS_MENU> listthreemenu = listMenu.Where(m => m.MENU_LEVEL == Constant.threeMenuLevel).Select(m => m.ToPOCO()).ToList();
            foreach (SYS_MENU menu in listthreemenu) 
            {
                //手动添加三级菜单权限
                if (menu.MENU_LEVEL==Constant.threeMenuLevel) 
                {
                    SYS_MENU menuopt_add = new SYS_MENU
                    {
                        MENU_ID = menu+"001",
                        AREA = menu.AREA,
                        CONTROLLER = menu.CONTROLLER,
                        ACTION = "Add",
                        MENU_NAME = menu.MENU_NAME+Message.AddOpt,
                        C_ICO = menu.C_ICO,
                        MENU_LEVEL = 100,
                        PARENT_ID = "100"
                    };
                    listMenu.Add(menuopt_add);
                    SYS_MENU menuopt_list = new SYS_MENU
                    {
                        MENU_ID = menu + "002",
                        AREA = menu.AREA,
                        CONTROLLER = menu.CONTROLLER,
                        ACTION = "List",
                        MENU_NAME = menu.MENU_NAME + Message.ReadOpt,
                        C_ICO = menu.C_ICO,
                        MENU_LEVEL = 100,
                        PARENT_ID = "100"
                    };
                    listMenu.Add(menuopt_list);
                    SYS_MENU menuopt_edit = new SYS_MENU
                    {
                        MENU_ID = menu + "003",
                        AREA = menu.AREA,
                        CONTROLLER = menu.CONTROLLER,
                        ACTION = "Edit",
                        MENU_NAME = menu.MENU_NAME + Message.EditOpt,
                        C_ICO = menu.C_ICO,
                        MENU_LEVEL = 100,
                        PARENT_ID = "100"
                    };
                    listMenu.Add(menuopt_edit);
                    SYS_MENU menuopt_del = new SYS_MENU
                    {
                        MENU_ID = menu + "004",
                        AREA = menu.AREA,
                        CONTROLLER = menu.CONTROLLER,
                        ACTION = "Del",
                        MENU_NAME = menu.MENU_NAME + Message.DelOpt,
                        C_ICO = menu.C_ICO,
                        MENU_LEVEL = 100,
                        PARENT_ID = "100"
                    };
                    listMenu.Add(menuopt_del);
                }
            }
            return listMenu.OrderBy(u => u.MENU_ID).ToList();
        }
        #endregion 
        #region 判断当前用户是否有访问当前请求的权限
        /// <summary>
        /// 判断当前用户是否有访问当前请求的权限
        /// </summary>
        /// <param name="areaName">区域名</param>
        /// <param name="controllerName">控制制名</param>
        /// <param name="actionName">action方法名</param>
        /// <param name="httpmethod">http请求的方式</param>
        /// <returns>true：有权限 false无权限</returns>
        public static bool HasPermission(string areaName, string controllerName
            , string actionName, HttpMethod httpmethod)
        {
            bool flag = true;
            if (oc.UserMenuPermission == null)
            {
                flag = Model_SYS_USER.IsLogin();
            }
            if (flag)
            {
                var listP = from per in oc.UserMenuPermission
                            where
                            string.Equals(per.AREA, areaName, StringComparison.CurrentCultureIgnoreCase)
                        && string.Equals(per.CONTROLLER, controllerName, StringComparison.CurrentCultureIgnoreCase)
                        && string.Equals(per.ACTION, actionName, StringComparison.CurrentCultureIgnoreCase)
                            //&& per.pFormMethod == (int)httpmethod
                            select per;

                return listP.Count() > 0;
            }
            return flag;

        }
        #endregion
        public static AjaxMsgModel MenuOPT(List<SYS_MENU> menuThree, string List, string Opt)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                List<string> menuThreeIDList=menuThree.Select(u=>u.MENU_ID).ToList();
                //获取已经存在的
                List<string> ExistMenuOpt = oc.BllSession.ISYS_MENUOPTService.Entities.Where(m => menuThreeIDList.Contains(m.MENU_ID))
                    .Select(m => m.MENUOPT_ID).ToList();
                int insertCount = 0;
                if (List.Equals("true")) 
                {
                    insertCount = menuThree.Count();
                }
                if (Opt.Equals("true")) 
                {
                    insertCount += menuThree.Count() * 3;
                }
                if (ExistMenuOpt.Count() != insertCount)
                {
                    foreach (SYS_MENU menu in menuThree)
                    {
                        using (TransactionScope ts = new TransactionScope()) 
                        {
                            if (List.Equals("true"))
                            {
                                if (!ExistMenuOpt.Contains(menu.MENU_ID + "-002"))
                                {
                                    SYS_MENUOPT temp = new SYS_MENUOPT
                                    {
                                        MENUOPT_ID = menu.MENU_ID + "-002",
                                        MENUOPT_NAME = "查看",
                                        MENU_ID = menu.MENU_ID,
                                        C_ICO = "icon-list",
                                        AREA = menu.AREA,
                                        CONTROLLER = menu.CONTROLLER,
                                        ACTION = "List",
                                        NOTE = menu.MENU_NAME + "查看"
                                    };
                                    int l = oc.BllSession.ISYS_MENUOPTService.AddEntity(temp);
                                }
                            }
                            if (Opt.Equals("true"))
                            {
                                if (!ExistMenuOpt.Contains(menu.MENU_ID + "-001"))
                                {
                                    SYS_MENUOPT temp = new SYS_MENUOPT
                                    {
                                        MENUOPT_ID = menu.MENU_ID + "-001",
                                        MENUOPT_NAME = "添加",
                                        MENU_ID = menu.MENU_ID,
                                        C_ICO = "icon-add",
                                        AREA = menu.AREA,
                                        CONTROLLER = menu.CONTROLLER,
                                        ACTION = "Add",
                                        NOTE = menu.MENU_NAME + "添加"
                                    };
                                    int a = oc.BllSession.ISYS_MENUOPTService.AddEntity(temp);
                                }
                                if (!ExistMenuOpt.Contains(menu.MENU_ID + "-003"))
                                {
                                    SYS_MENUOPT temp = new SYS_MENUOPT
                                    {
                                        MENUOPT_ID = menu.MENU_ID + "-003",
                                        MENUOPT_NAME = "编辑",
                                        MENU_ID = menu.MENU_ID,
                                        C_ICO = "icon-edit",
                                        AREA = menu.AREA,
                                        CONTROLLER = menu.CONTROLLER,
                                        ACTION = "Edit",
                                        NOTE = menu.MENU_NAME + "编辑"
                                    };
                                    int e = oc.BllSession.ISYS_MENUOPTService.AddEntity(temp);
                                }
                                if (!ExistMenuOpt.Contains(menu.MENU_ID + "-004"))
                                {
                                    SYS_MENUOPT temp = new SYS_MENUOPT
                                    {
                                        MENUOPT_ID = menu.MENU_ID + "-004",
                                        MENUOPT_NAME = "删除",
                                        MENU_ID = menu.MENU_ID,
                                        C_ICO = "icon-del",
                                        AREA = menu.AREA,
                                        CONTROLLER = menu.CONTROLLER,
                                        ACTION = "Del",
                                        NOTE = menu.MENU_NAME + "删除"
                                    };
                                    int d = oc.BllSession.ISYS_MENUOPTService.AddEntity(temp);
                                }
                            }
                            ts.Complete();
                            amm.Statu = AjaxStatu.ok;
                            amm.Msg = string.Format(Message.OptSussess, "菜单操作", Message.AddOpt);
                        }
                    }
                }
                else 
                {
                    //数据库中已经存在该二级菜单下的所有opt数据
                    amm.Statu = AjaxStatu.ok;
                    amm.Msg = string.Format(Message.OptSussess, "菜单操作", Message.AddOpt);
                }
            }
            catch (Exception)
            {
                return amm;
            }
            return amm;
        }
    }
}