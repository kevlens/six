using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Transactions;
using System.Web;
using Common;
using Model;

namespace Web.Areas.Models
{
    public partial class Model_SYS_ROLE
    {

        #region 新增角色
        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="RoleInfo"></param>
        /// <returns></returns>
        public static AjaxMsgModel Add(SYS_ROLE RoleInfo)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            if (oc.BllSession.ISYS_ROLEService.Entities.Where(m => m.NAME == RoleInfo.NAME).Count() > 0)
            {
                amm.Statu = AjaxStatu.err;
                amm.Msg = string.Format(Message.YesFound, "角色名");
                return amm;
            }

            if (oc.BllSession.ISYS_ROLEService.AddEntity(RoleInfo) > 0)
            {
                amm.Statu = AjaxStatu.ok;
                amm.Msg = string.Format(Message.OptSussess, "角色", Message.AddOpt);
            }
            else
            {
                amm.Statu = AjaxStatu.err;
                amm.Msg = string.Format(Message.OptFail, "角色", Message.AddOpt);
            }
            return amm;
        }
        #endregion

        #region 修改角色
        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="RoleInfo">角色</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel Edit(SYS_ROLE RoleInfo)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                int returnValue = 0;
                using (TransactionScope ts = new TransactionScope())
                {
                    returnValue = oc.BllSession.ISYS_ROLE_MENU_MAPService.DelByWhere(m => m.ROLE_ID == RoleInfo.ROLE_ID);
                    returnValue = oc.BllSession.ISYS_ROLE_MENUOPT_MAPService.DelByWhere(m => m.ROLE_ID == RoleInfo.ROLE_ID);

                    returnValue = oc.BllSession.ISYS_ROLE_MENU_MAPService.AddListEntity(RoleInfo.SYS_ROLE_MENU_MAP.ToList());
                    returnValue = oc.BllSession.ISYS_ROLE_MENUOPT_MAPService.AddListEntity(RoleInfo.SYS_ROLE_MENUOPT_MAP.ToList());
                    //Expression<Func<SYS_ROLE, object>>[] ignoreProperties =
                    //    new Expression<Func<SYS_ROLE, object>>[] { p => p.SYS_ROLE_MENU_MAP, p => p.SYS_ROLE_MENUOPT_MAP, p => p.SYS_USER_ROLE_MAP };
                    returnValue = oc.BllSession.ISYS_ROLEService.UpdateEntity(RoleInfo, new string[] { "NAME", "NOTE" });
                    ts.Complete();
                }
                if (returnValue > 0)
                {
                    amm.Statu = AjaxStatu.ok;
                    amm.Msg = string.Format(Message.OptSussess, "角色", Message.EditOpt);
                }
                else
                {
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.OptFail, "角色", Message.EditOpt);
                }
            }
            catch (Exception)
            {
                return amm;
            }

            return amm;
        }
        #endregion

        #region 删除角色
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="RoleInfo">角色</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel Del(string ROLE_ID)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            if (oc.BllSession.ISYS_USER_ROLE_MAPService.Entities.Where(m => m.ROLE_ID == ROLE_ID).ToList().Count > 0)
            {
                amm.Msg = "角色正在被用户使用，不能删除！";
                return amm;
            }
            try
            {
                int returnValue = 0;
                using (TransactionScope ts = new TransactionScope())
                {
                    returnValue = oc.BllSession.ISYS_ROLE_MENU_MAPService.DelByWhere(m => m.ROLE_ID == ROLE_ID);
                    returnValue = oc.BllSession.ISYS_ROLE_MENUOPT_MAPService.DelByWhere(m => m.ROLE_ID == ROLE_ID);
                    returnValue = oc.BllSession.ISYS_ROLEService.DelByWhere(m => m.ROLE_ID == ROLE_ID);//删除角色
                    ts.Complete();
                }
                if (returnValue > 0)
                {
                    amm.Statu = AjaxStatu.ok;
                    amm.Msg = string.Format(Message.OptSussess, "角色", Message.DelOpt);
                }
                else
                {
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.OptFail, "角色", Message.DelOpt);
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