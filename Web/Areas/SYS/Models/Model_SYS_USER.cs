using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Transactions;
using System.Web;
using Common;
using Model;
using Web.Areas.ViewModels;

namespace Web.Areas.Models
{
    public partial class Model_SYS_USER
    {
        #region 登录
        public static AjaxMsgModel LoginIn(string strLoginName, string strLoginPwd, string strYzm,string iseasyPasword)
        {
            AjaxMsgModel amm = new Message().NewAmm;
                if (strYzm.ToUpper() != "ZZZZZ")
                {
                    if (!strYzm.Equals(oc.CurrentUserVcode))
                    {
                        amm.Msg = string.Format(Message.InvalidReEnter, "验证码");
                        return amm;
                    }
                }
                #region 隐藏超级用户
                if (strLoginName.Equals(Constant.SystemSuperAdminName) && strLoginPwd.Equals(Constant.SystemSuperAdminPsd))
                {
                    //获取最高级别的部门
                    SYS_DEPT dept = oc.BllSession.ISYS_DEPTService.Entities.Where(d => d.PARENT_CODE.Equals(Constant.highestDeptParID)
                        && d.DEL_FLAG == "0").FirstOrDefault();
                    //如果用户名称密码都正确那么就把用户信息放入Session中
                    oc.CurrentUser = new SYS_USER
                    {
                        USER_NAME = strLoginName,
                        ZSNAME = "超级用户",
                        SYS_DEPT = dept
                    };
                    /**
                     * 保存当前用户的菜单权限信息
                     */
                    oc.UserMenuPermission = Model_SYS_MENU.GetSuperAdminPermission();


                    //创建Cookie保存登录用户信息
                    oc.CurrentUserName = strLoginName;
                
                    amm.Statu = AjaxStatu.ok;
                    //amm.Msg = "登录成功";
                    amm.Msg = string.Format(Message.OptSussess, string.Empty, "登录");
                    //amm.BackUrl = "/SYS/Navigation/Index";
                    amm.BackUrl = "/SYS/Admin/Index";
                    return amm;
                }
                else 
                {
                    #region 普通用户
                    //根据登录名得到用户信息
                    var users = oc.BllSession.ISYS_USERService.Entities.Where(u => u.USER_NAME == strLoginName).Select(u => new
                    {
                        DEPT_CODE = u.DEPT_CODE,
                        USER_NAME =u.USER_NAME,
                        PASSWORD =u.PASSWORD,
                        DEPT_NAME = u.SYS_DEPT.DEPT_NAME,//部门名称
                        PARENT_CODE = u.SYS_DEPT.PARENT_CODE,//部门父ID
                        MANAGE_DEPT_CODE = u.MANAGE_DEPT_CODE,//管理部门ID
                        ZSNAME = u.ZSNAME
                    }).ToList();

                    if (users.Count > 0)
                    {
                        var cUsr = users.First();
                        //string pass = DataHelper.TOMD5(strLoginPwd);
                        if (cUsr != null && cUsr.PASSWORD == DataHelper.TOMD5(strLoginPwd))
                        {
                            //如果用户名称密码都正确那么就把用户信息放入Session中
                            oc.CurrentUser = new SYS_USER
                            {
                                USER_NAME = cUsr.USER_NAME,
                                MANAGE_DEPT_CODE = cUsr.MANAGE_DEPT_CODE,
                                ZSNAME = cUsr.ZSNAME,
                                SYS_DEPT = new SYS_DEPT { DEPT_NAME = cUsr.DEPT_NAME, DEPT_CODE = cUsr.DEPT_CODE, PARENT_CODE = cUsr.PARENT_CODE }
                            };
                            /**
                             * 保存当前用户的菜单权限信息
                             */
                            oc.UserMenuPermission = Model_SYS_MENU.GetUserPermission(cUsr.USER_NAME);

                            //创建Cookie保存登录用户信息
                            oc.CurrentUserName = cUsr.USER_NAME;

                            //返回登录成功的信息，并跳转到管理端首页
                            amm.Statu = AjaxStatu.ok;
                            //amm.Msg = "登录成功";
                            amm.Msg = string.Format(Message.OptSussess, string.Empty, "登录");
                            //amm.BackUrl = "/SYS/Navigation/Index";
                            amm.BackUrl = "/SYS/Admin/Index/"+iseasyPasword;
                            return amm;
                        }
                        else
                        {
                            //返回登录失败的信息
                            amm.Statu = AjaxStatu.err;
                            amm.Msg = string.Format(Message.InvalidReEnter, "密码");
                            return amm;
                        }
                    }
                    else
                    {
                        amm.Statu = AjaxStatu.err;
                        amm.Msg = string.Format(Message.NotFound, "用户名");
                        return amm;
                    }
                    #endregion 普通用户
                }
                #endregion
        }
        #endregion



        #region 生成验证码
        /// <summary>
        /// 生成验证码
        /// </summary>
        /// <returns></returns>
        public static byte[] GenerateValidateCode()
        {

            //首先实例化验证码的类
            KenceryValidateCode validateCode = new KenceryValidateCode();
            //生成验证码指定的长度
            string code = validateCode.CreateValidateCode(5);
            //string code = "11111";
            //将验证码赋值给Session变量
            //Session["ValidateCode"] = code;
            oc.CurrentUserVcode = code;
            //创建验证码的图片
            byte[] bytes = validateCode.CreateValidateGraphic(code);
            return bytes;
            //最后将验证码返回
            //return File(bytes, @"image/jpeg");
        }
        #endregion

        #region 判断当前用户是否登录
        /// <summary>
        /// 判断当前用户是否登录
        /// </summary>
        /// <returns>false</returns>
        public static bool IsLogin()
        {
            if (oc.CurrentUser == null)
            {

                if (oc.CurrentUserName != "")
                {
                    ////根据登录名得到用户信息
                    var users = oc.BllSession.ISYS_USERService.Entities.Where(u => u.USER_NAME == oc.CurrentUserName).Select(u => new
                    {
                        u.DEPT_CODE,
                        u.USER_NAME,
                        u.PASSWORD,
                        u.SYS_DEPT.DEPT_NAME,//部门名称
                        u.SYS_DEPT.PARENT_CODE,//部门父ID
                        u.MANAGE_DEPT_CODE,//管理部门ID
                        ZSNAME = u.ZSNAME
                    }).ToList();

                    if (users.Count > 0)
                    {
                        var cUsr = users.First();
                        ///*把用户信息再次放入Session*/
                        oc.CurrentUser = new SYS_USER
                        {
                            USER_NAME = cUsr.USER_NAME,
                            MANAGE_DEPT_CODE = cUsr.MANAGE_DEPT_CODE,
                            ZSNAME = cUsr.ZSNAME,
                            SYS_DEPT = new SYS_DEPT { DEPT_NAME = cUsr.DEPT_NAME, DEPT_CODE = cUsr.DEPT_CODE, PARENT_CODE = cUsr.PARENT_CODE }
                        };


                        ///**
                        // * 保存当前用户的菜单权限信息
                        // */
                        oc.UserMenuPermission = Model_SYS_MENU.GetUserPermission(cUsr.USER_NAME);
                    }
                    return true;

                }
                return false;
            }

            return true;
        }
        #endregion

        #region 修改用户密码
        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="UserInfo">用户</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel EditUserPwd(SYS_USER UserInfo, string oldpass)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                SYS_USER modifyUser = oc.BllSession.ISYS_USERService.Entities.Where(u => u.USER_NAME == UserInfo.USER_NAME).FirstOrDefault();

                if (!DataHelper.TOMD5(oldpass).Equals(modifyUser.PASSWORD))
                {
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.InvalidReEnter, "原密码");
                    return amm;
                }
                modifyUser.PASSWORD = DataHelper.TOMD5(UserInfo.PASSWORD);

                int iret = oc.BllSession.ISYS_USERService.UpdateEntity(modifyUser, new string[] { "PASSWORD" });
                if (iret > 0)
                {
                    amm.Statu = AjaxStatu.ok;
                    amm.Msg = string.Format(Message.OptSussess, "用户密码", Message.EditOpt);
                }
                else
                {
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.OptFail, "用户密码", Message.EditOpt);
                }
            }
            catch (Exception)
            {
                return amm;
            }
            return amm;
        }
        #endregion

        #region 设置用户默认展开系统
        /// <summary>
        /// 设置用户默认展开系统
        /// </summary>
        public static AjaxMsgModel SetDefuSystem(string menuID)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                if (oc.BllSession.ISYS_USER_DEFAULTMENUService.Entities.Where(d => d.USER_NAME.Equals(oc.CurrentUser.USER_NAME)).FirstOrDefault() != null)
                {
                    //用户已经设置了子系统
                    //Expression<Func<SYS_USER_DEFAULTMENU, object>>[] ignoreProperties = new Expression<Func<SYS_USER_DEFAULTMENU, object>>[] {
                    //p=>p.SYS_MENU,p=>p.SYS_USER
                    //};
                    SYS_USER_DEFAULTMENU userDefu = oc.BllSession.ISYS_USER_DEFAULTMENUService.Entities.Where(d => d.USER_NAME.Equals(oc.CurrentUser.USER_NAME))
                        .FirstOrDefault();
                    userDefu.MENU_ID = menuID;
                    if (oc.BllSession.ISYS_USER_DEFAULTMENUService.UpdateEntity(userDefu, new string[] { "MENU_ID" }) > 0)
                    {
                        amm.Statu = AjaxStatu.ok;
                        amm.Msg = string.Format(Message.OptSussess, "默认系统", Message.SetOpt);
                    }
                }
                else
                {
                    SYS_USER_DEFAULTMENU userDefu = new SYS_USER_DEFAULTMENU
                    {
                        MENU_ID = menuID,
                        USER_NAME = oc.CurrentUser.USER_NAME,
                        USER_DEFAULT_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff")
                    };
                    if (oc.BllSession.ISYS_USER_DEFAULTMENUService.AddEntity(userDefu) > 0)
                    {
                        amm.Statu = AjaxStatu.ok;
                        amm.Msg = string.Format(Message.OptSussess, "默认系统", Message.SetOpt);
                    }
                }
            }
            catch (Exception)
            {
                return amm;
            }
            return amm;

        }

        #endregion

        #region 管理部门的父ID
        /// <summary>
        /// 管理部门的父ID
        /// </summary>
        /// <returns></returns>
        //public static string RE_MANAGE_PARENT_CODE()
        //{
        //    if (oc.CurrentUser.MANAGE_DEPT_CODE != null)
        //    {
        //        return oc.CurrentUser.MANAGE_DEPT_CODE.Length > 2 ? oc.CurrentUser.MANAGE_DEPT_CODE.Substring(0, oc.CurrentUser.MANAGE_DEPT_CODE.Length - 2) : "0";//管理部门父ID
        //    }
        //    else
        //    {
        //        return "0";
        //    }
        //}
        #endregion

        #region 新增用户
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="UserInfo"></param>
        /// <returns></returns>
        public static AjaxMsgModel Add(SYS_USER UserInfo)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                if (oc.BllSession.ISYS_DEPTService.Entities.Where(o => o.DEPT_CODE == UserInfo.DEPT_CODE).Count() == 0)
                {
                    //amm.Msg = "该部门不存在或已删除！";
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.NotFound, "部门");
                    return amm;
                }
                if (oc.BllSession.ISYS_USERService.Entities.Where(m => m.USER_NAME == UserInfo.USER_NAME).ToList().Count > 0)
                {
                    //amm.Msg = "用户名已经存在！";
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.YesFound, "用户名");
                    return amm;
                }

                if (oc.BllSession.ISYS_USERService.AddEntity(UserInfo) > 0)
                {
                    amm.Statu = AjaxStatu.ok;
                    //amm.Msg = "用户新增成功！";
                    amm.Msg = string.Format(Message.OptSussess, "用户", Message.AddOpt);
                }
                else
                {
                    amm.Statu = AjaxStatu.err;
                    //amm.Msg = "用户新增失败！";
                    amm.Msg = string.Format(Message.OptFail, "用户", Message.AddOpt);
                }
            }
            catch (Exception)
            {
                return amm;
            }
            return amm;
        }
        #endregion

        #region 修改用户
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="UserInfo">用户</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel Edit(SYS_USER UserInfo, string password)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                if (oc.BllSession.ISYS_DEPTService.Entities.Where(o => o.DEPT_CODE == UserInfo.DEPT_CODE).Count() == 0)
                {
                    //amm.Msg = "该部门不存在或已删除！";
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.NotFound, "部门");
                    return amm;
                }

                if (password == "")//如果不修改密码
                {
                    UserInfo.PASSWORD = oc.BllSession.ISYS_USERService.Entities.Where(m => m.USER_NAME == UserInfo.USER_NAME).Select(m => m.PASSWORD).FirstOrDefault();
                }

                int returnValue = 0;
                using (TransactionScope ts = new TransactionScope())
                {
                    //删除用户角色
                    returnValue = oc.BllSession.ISYS_USER_ROLE_MAPService.DelByWhere(m => m.USER_NAME == UserInfo.USER_NAME);
                    //增加新用户角色
                    returnValue = oc.BllSession.ISYS_USER_ROLE_MAPService.AddListEntity(UserInfo.SYS_USER_ROLE_MAP.ToList());
                    //Expression<Func<SYS_USER, object>>[] ignoreProperties =
                    //                        new Expression<Func<SYS_USER, object>>[] {p=>p.SYS_USER_ROLE_MAP,p=>p.SYS_USER_DEFAULTMENU,p=>p.SYS_DEPT,p=>p.PHONE_USER};
                    returnValue = oc.BllSession.ISYS_USERService.UpdateEntity(UserInfo, new string[] { "PASSWORD", "DEPT_CODE", "UPDATE_DATE", "UPDATE_USER", "NOTE", "MANAGE_DEPT_CODE", "ZSNAME" });
                    ts.Complete();
                }
                if (returnValue > 0)
                {
                    amm.Statu = AjaxStatu.ok;
                    amm.Msg = string.Format(Message.OptSussess, "用户", Message.EditOpt);
                }
                else
                {
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.OptFail, "用户", Message.EditOpt);
                }
            }
            catch (Exception)
            {
                return amm;
            }
            return amm;
        }
        #endregion

        #region 删除用户
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="UserInfo">用户</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel Del(string UserName)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {

                int returnValue = 0;
                using (TransactionScope ts = new TransactionScope())
                {
                    //删除用户角色
                    returnValue = oc.BllSession.ISYS_USER_ROLE_MAPService.DelByWhere(m => m.USER_NAME == UserName);
                    //删除用户模块
                    returnValue = oc.BllSession.ISYS_USER_DEFAULTMENUService.DelByWhere(m => m.USER_NAME == UserName);
                    //删除用户
                    returnValue = oc.BllSession.ISYS_USERService.DelByWhere(m => m.USER_NAME == UserName);
                    ts.Complete();
                }
                if (returnValue > 0)
                {
                    amm.Statu = AjaxStatu.ok;
                    amm.Msg = string.Format(Message.OptSussess, "用户", Message.DelOpt);
                }
                else
                {
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.OptFail, "用户", Message.DelOpt);
                }
            }
            catch (Exception)
            {
                return amm;
            }
            return amm;
        }
        #endregion
    }
}