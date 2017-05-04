using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Common;
using Model;

namespace Web.Areas.Models
{
    public partial class Model_SYS_MENU_HELPCONTENT
    {
        public static AjaxMsgModel Save(SYS_MENU_HELPCONTENT menuhelp)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                if (menuhelp.CONTENT_ORDER.Equals("0"))
                {
                    //新增
                    string insertOrder = (oc.BllSession.ISYS_MENU_HELPCONTENTService.Entities.Where(h => h.MENU_ID.Equals(menuhelp.MENU_ID)).Count()
                            + 1).ToString();
                    menuhelp.CONTENT_ORDER = insertOrder;
                    if (oc.BllSession.ISYS_MENU_HELPCONTENTService.AddEntity(menuhelp) > 0)
                    {
                        amm.Statu = AjaxStatu.ok;
                        amm.Msg = string.Format(Message.OptSussess, "帮助文档", Message.AddOpt);
                    }
                    else
                    {
                        amm.Statu = AjaxStatu.err;
                        amm.Msg = string.Format(Message.OptFail, "帮助文档", Message.AddOpt);
                    }

                }
                else 
                {
                    //修改
                   // Expression<Func<SYS_MENU_HELPCONTENT, object>>[] ignoreProperties =
                   //new Expression<Func<SYS_MENU_HELPCONTENT, object>>[] { 
                   //   p=>p.SYS_MENU
                   // };
                    string contentID = oc.BllSession.ISYS_MENU_HELPCONTENTService.Entities
                        .Where(h => h.MENU_ID.Equals(menuhelp.MENU_ID) && h.CONTENT_ORDER.Equals(menuhelp.CONTENT_ORDER)).FirstOrDefault().CONTENT_ID;
                    menuhelp.CONTENT_ID = contentID;
                    if (oc.BllSession.ISYS_MENU_HELPCONTENTService.UpdateEntity(menuhelp, new string[] { "MENU_ID", "HELP_CONTENT", "CONTENT_ORDER",
                    "UPDATE_DATE","UPDATE_USER"}) > 0)
                    {
                        amm.Statu = AjaxStatu.ok;
                        amm.Msg = string.Format(Message.OptSussess, "帮助文档", Message.EditOpt);
                    }
                    else
                    {
                        amm.Statu = AjaxStatu.err;
                        amm.Msg = string.Format(Message.OptFail, "帮助文档", Message.EditOpt);
                    }
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