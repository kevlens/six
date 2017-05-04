using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Common;
using Common.Attributes;
using Model;
using Model.ModelExt;

namespace Web.Areas.Models
{
    public partial class Model_SYS_DEPT
    {
        #region 得到我的组织机构集合
        public static List<EasyUITreeNode> GetMyDEPTTree(string DEPT_CODE, string PARENT_CODE, int DEPT_FLAG = 0)
        {
            //string strJson = string.Empty;
            //获得组织
            List<SYS_DEPTANDMEMBER> listOrgMenu = oc.BllSession.ISYS_DEPTService.Entities
                .Where(m => m.DEL_FLAG == "0" && m.DEPT_FLAG == DEPT_FLAG && (m.PARENT_CODE.StartsWith(DEPT_CODE)
                    || m.DEPT_CODE == DEPT_CODE)).OrderBy(m => m.DEPT_ORDER).ThenBy(m=>m.DEPT_CODE)
                                                .Select(org => new SYS_DEPTANDMEMBER
                                                {
                                                    ORGRY_CODE = org.DEPT_CODE,
                                                    PARENT_CODE = org.PARENT_CODE,
                                                    ORGRY_NAME = org.DEPT_NAME,
                                                    ICO = org.C_ICO,
                                                    RYMOBILE = "",
                                                    STATE = org.STATUS_FLAG//0关闭
                                                })
                                                .ToList();
            if (DEPT_FLAG == 1)
            {
                listOrgMenu = GetDeptTree(listOrgMenu);
            }
            List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgMenu, PARENT_CODE, DEPT_CODE,false);
            //strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return listTreeNodes;
        } 
        #endregion

        #region 查看我的组织机构包含工区树
        /// <summary>
        /// 获取组织机构树
        /// </summary>
        /// <returns>PARENT_CODE所在部门的父ID</returns>
        [Skip]
        [AjaxRequest]
        public static List<EasyUITreeNode> GetMyORGTree(string DEPT_CODE, string PARENT_CODE, int DEPT_FLAG = 0)
        {
            //string strJson = string.Empty;
            //获得组织
            IQueryable <SYS_DEPT> listOrg = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && m.DEPT_FLAG == DEPT_FLAG && (m.PARENT_CODE.StartsWith(DEPT_CODE) || m.DEPT_CODE == DEPT_CODE));
            

            List<SYS_DEPTANDMEMBER> listOrgMenu = listOrg.OrderBy(m => m.DEPT_ORDER).ThenBy(m=>m.DEPT_CODE)
                                                .Select(org => new SYS_DEPTANDMEMBER
                                                {
                                                    ORGRY_CODE = org.DEPT_CODE,
                                                    PARENT_CODE = org.PARENT_CODE,
                                                    ORGRY_NAME = org.DEPT_NAME,
                                                    ICO = org.C_ICO,
                                                    RYMOBILE = "",
                                                    STATE = org.STATUS_FLAG//0关闭
                                                })
                                                .ToList();
            if (DEPT_FLAG == 1)
            {
              listOrgMenu = GetDeptTree(listOrgMenu);
            }
            List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgMenu, PARENT_CODE, DEPT_CODE, false);
            //strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return listTreeNodes;
        }
        #endregion

        public static List<SYS_DEPTANDMEMBER> GetDeptTree(List<SYS_DEPTANDMEMBER> listOrgMenu)
        {

            List<string> deptcodeList = new List<string>();
            foreach (SYS_DEPTANDMEMBER item in listOrgMenu)
            {
                string deptcode = item.ORGRY_CODE;
                deptcodeList.Add(deptcode);
                if (deptcode.Length > 8)//工区
                {
                    deptcodeList.Add(deptcode.Substring(0, 8));
                }
                if (deptcode.Length > 6)//车间
                {
                    deptcodeList.Add(deptcode.Substring(0, 6));
                }
                if (deptcode.Length > 4)//虚拟车间
                {
                    deptcodeList.Add(deptcode.Substring(0, 4));
                }
                if (deptcode.Length > 2)//局
                {
                    deptcodeList.Add(deptcode.Substring(0, 2));
                }
            }
            List<SYS_DEPTANDMEMBER>  listOrg = oc.BllSession.ISYS_DEPTService.Entities.Where(m => deptcodeList.Contains(m.DEPT_CODE))
                                             .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE)
                                            .Select(org => new SYS_DEPTANDMEMBER
                                            {
                                                ORGRY_CODE = org.DEPT_CODE,
                                                PARENT_CODE = org.PARENT_CODE,
                                                ORGRY_NAME = org.DEPT_NAME,
                                                ICO = org.C_ICO,
                                                RYMOBILE = "",
                                                STATE = org.STATUS_FLAG//0关闭
                                            })
                                            .ToList();
            return listOrg;
        }

        #region 查看我的组织机构除工区树
        /// <summary>
        /// 获取组织机构树
        /// </summary>
        /// <returns>PARENT_CODE所在部门的父ID</returns>
        [Skip]
        [AjaxRequest]
        public static List<EasyUITreeNode> GetMyORGNoGQTree(string DEPT_CODE, string PARENT_CODE, int DEPT_FLAG=0)
        {
            string strJson = string.Empty;
            //获得组织
            List<SYS_DEPTANDMEMBER> listOrgMenu = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && m.C_ICO == "icon-DepartMent" && m.DEPT_FLAG==DEPT_FLAG && (m.PARENT_CODE.StartsWith(DEPT_CODE) || m.DEPT_CODE == DEPT_CODE))
                .OrderBy(m => m.DEPT_ORDER).ThenBy(m=>m.DEPT_CODE)
                                                .Select(org => new SYS_DEPTANDMEMBER
                                                {
                                                    ORGRY_CODE = org.DEPT_CODE,
                                                    PARENT_CODE = org.PARENT_CODE,
                                                    ORGRY_NAME = org.DEPT_NAME,
                                                    ICO = org.C_ICO,
                                                    RYMOBILE = "",
                                                    STATE = org.STATUS_FLAG//0关闭
                                                })
                                                .ToList();
            if (DEPT_FLAG == 1)
            {
                listOrgMenu = GetDeptTree(listOrgMenu);
            }
            List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgMenu, PARENT_CODE, DEPT_CODE, false);
            //strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return listTreeNodes;
        }
        #endregion


        #region 查看我的组织机构包含路局除工区树
        /// <summary>
        /// 获取组织机构树
        /// </summary>
        /// <returns>PARENT_CODE所在部门的父ID</returns>
        [Skip]
        [AjaxRequest]
        public static List<EasyUITreeNode> GetMyORGAllNoGQTree(string DEPT_CODE, string PARENT_CODE, int DEPT_FLAG = 0)
        {
            string strJson = string.Empty;
            //获得组织
            List<SYS_DEPTANDMEMBER> listOrgMenu = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && m.C_ICO == "icon-DepartMent" && m.DEPT_FLAG == DEPT_FLAG && !m.PARENT_CODE.EndsWith("00") && (m.PARENT_CODE.StartsWith(DEPT_CODE) || m.DEPT_CODE == DEPT_CODE || m.DEPT_CODE == DEPT_CODE.Substring(0, 2) || m.DEPT_CODE == (DEPT_CODE.Length >= 6 ? DEPT_CODE.Substring(0, 4) : DEPT_CODE)))
                .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE)
                                                .Select(org => new SYS_DEPTANDMEMBER
                                                {
                                                    ORGRY_CODE = org.DEPT_CODE,
                                                    PARENT_CODE = org.PARENT_CODE,
                                                    ORGRY_NAME = org.DEPT_NAME,
                                                    ICO = org.C_ICO,
                                                    RYMOBILE = "",
                                                    STATE = org.STATUS_FLAG//0关闭
                                                })
                                                .ToList();
            if (DEPT_FLAG == 1)
            {
                listOrgMenu = GetDeptTree(listOrgMenu);
            }
            List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgMenu, "0", DEPT_CODE, false);
            //strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return listTreeNodes;
        }
        #endregion

        #region 查看我的组织机构只包含段
        /// <summary>
        /// 获取组织机构树
        /// </summary>
        /// <returns>PARENT_CODE所在部门的父ID</returns>
        [Skip]
        [AjaxRequest]
        public static List<EasyUITreeNode> GetMyOnlyTree(string DEPT_CODE, string PARENT_CODE, int DEPT_FLAG = 0)
        {
            string strJson = string.Empty;
            //获得组织
            IQueryable<SYS_DEPT> list = null;
            if (DEPT_CODE.Length == 2)
                list = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && m.C_ICO == "icon-DepartMent" && m.DEPT_CODE.Length <= 4 && (m.DEPT_CODE == DEPT_CODE || m.DEPT_CODE.StartsWith(DEPT_CODE)))
                   .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE);
            else
                list = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && m.C_ICO == "icon-DepartMent" && m.DEPT_CODE.Length <= 4 && (m.DEPT_CODE == DEPT_CODE || m.PARENT_CODE == "0"))
                .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE);
            List<SYS_DEPTANDMEMBER> listOrgMenu = list
                                                .Select(org => new SYS_DEPTANDMEMBER
                                                {
                                                    ORGRY_CODE = org.DEPT_CODE,
                                                    PARENT_CODE = org.PARENT_CODE,
                                                    ORGRY_NAME = org.DEPT_NAME,
                                                    ICO = org.C_ICO,
                                                    RYMOBILE = "",
                                                    STATE = org.STATUS_FLAG//0关闭
                                                })
                                                .ToList();
            if (DEPT_FLAG == 1)
            {
                listOrgMenu = GetDeptTree(listOrgMenu);
            }
            List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgMenu, "0", DEPT_CODE, false);
            //strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return listTreeNodes;
        }
        #endregion


        #region 获取用户组织机构树不显示段直属部门
        /// <summary>
        /// 获取用户组织机构树不显示段直属部门
        /// </summary>
        /// <returns>PARENT_CODE所在部门的父ID</returns>
        [Skip]
        [AjaxRequest]
        public static string GetMyORGNoZsTree(string DEPT_CODE, string PARENT_CODE, int DEPT_FLAG = 0)
        {
            string strJson = string.Empty;
            //获得组织
            List<SYS_DEPTANDMEMBER> listOrgMenu = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && m.DEPT_FLAG == DEPT_FLAG && (m.PARENT_CODE.StartsWith(DEPT_CODE) || m.DEPT_CODE == DEPT_CODE))
                .OrderBy(m => m.DEPT_ORDER).ThenBy(m=>m.DEPT_CODE)
                                                .Select(org => new SYS_DEPTANDMEMBER
                                                {
                                                    ORGRY_CODE = org.DEPT_CODE,
                                                    PARENT_CODE = org.PARENT_CODE,
                                                    ORGRY_NAME = org.DEPT_NAME,
                                                    ICO = org.C_ICO,
                                                    RYMOBILE = "",
                                                    STATE = org.STATUS_FLAG//0关闭
                                                })
                                                .ToList();
            if (DEPT_FLAG == 1)
            {
                listOrgMenu = GetDeptTree(listOrgMenu);
            }
            List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgMenu, PARENT_CODE, DEPT_CODE, false);
            strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return strJson;
        }
        #endregion

        #region 新增部门
        /// <summary>
        /// 新增部门
        /// </summary>
        /// <param name="UserInfo"></param>
        /// <returns></returns>
        public static AjaxMsgModel Add(SYS_DEPT orgInfo)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                if (oc.BllSession.ISYS_DEPTService.Entities.Where(o => o.DEPT_CODE == orgInfo.PARENT_CODE).Count() == 0)
                {
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.NotFound, "隶属部门");
                    return amm;
                }
                if (oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEPT_NAME == orgInfo.DEPT_NAME && m.PARENT_CODE == orgInfo.PARENT_CODE).ToList().Count > 0)
                {
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.YesFound, "部门名称");
                    return amm;
                }

                if (oc.BllSession.ISYS_DEPTService.AddEntity(orgInfo) > 0)
                {
                    amm.Statu = AjaxStatu.ok;
                    amm.Msg = string.Format(Message.OptSussess, "部门", Message.AddOpt);
                }
                else
                {
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.OptFail, "部门", Message.AddOpt);
                }
            }
            catch (Exception)
            {
                return amm;
            }
            return amm;
        }
        #endregion


        #region 修改部门
        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="orgInfo">用户</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel Edit(SYS_DEPT orgInfo, string upid, string newDeptCode)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                if (oc.BllSession.ISYS_DEPTService.Entities.Where(o => o.DEPT_CODE == orgInfo.PARENT_CODE).Count() == 0)
                {
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.NotFound, "隶属部门");
                    return amm;
                }
                SYS_DEPT org = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEPT_CODE == upid).OrderBy(m => m.DEPT_CODE).FirstOrDefault();
                if (org.PARENT_CODE == orgInfo.PARENT_CODE)//如果在同一级下则修改
                {
                    orgInfo.DEPT_CODE = org.DEPT_CODE;

                    if (oc.BllSession.ISYS_DEPTService.Entities.Where(u => u.DEPT_CODE != orgInfo.DEPT_CODE && u.DEPT_NAME == orgInfo.DEPT_NAME && u.PARENT_CODE == orgInfo.PARENT_CODE).ToList().Count > 0)
                    {
                        amm.Statu = AjaxStatu.err;
                        amm.Msg = string.Format(Message.YesFound, "部门名称");
                        return amm;
                    }
                   // Expression<Func<SYS_DEPT, object>>[] ignoreProperties =
                   //     new Expression<Func<SYS_DEPT, object>>[] {
                   //p=>p.SYS_MEMBER,p=>p.SYS_USER,p=>p.JOB_PLAN_APPROVAL,p=>p.GATE_BDATA_CARD,p=>p.GATE_BDATA_CLIENT,
                   //     p=>p.GATE_BDATA_GATE,p=>p.GATE_JOB_PLAN, p=>p.TOOL_BDATE_STOREHOURSE,p=>p.TOOL_JOB_PLAN,
                   //     p=>p.TOOL_JOB_PLAN_IMPORT,p=>p.TOOL_TOOLMNG_INOUT,p=>p.RULE_PROBLEM,
                   //     p=>p.RULE_PROBLEM_BLAME};

                    if (oc.BllSession.ISYS_DEPTService.UpdateEntity(orgInfo, new string[] { "DEPT_NAME", "PARENT_CODE", "C_ICO",
                    "STATUS_FLAG","DEL_FLAG","NOTE","DEPT_FLAG"}) > 0)
                    {
                        amm.Statu = AjaxStatu.ok;
                        amm.Msg = string.Format(Message.OptSussess, "部门", Message.EditOpt);
                    }
                    else
                    {
                        amm.Statu = AjaxStatu.err;
                        amm.Msg = string.Format(Message.OptFail, "部门", Message.EditOpt);
                    }
                }
                else//如果更换级别则先删后加
                {
                    if (oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.PARENT_CODE == upid).Count() > 0)
                    {
                        amm.Statu = AjaxStatu.err;
                        amm.Msg = "该部门下已经有下属部门，暂不能更换隶属部门！";

                        return amm;
                    }
                    if (oc.BllSession.ISYS_MEMBERService.Entities.Where(m => m.DEL_FLAG == "0" && m.DEPT_CODE == upid).Count() > 0)
                    {
                        amm.Statu = AjaxStatu.err;
                        amm.Msg = "该部门下已经有人员，暂不能更换隶属部门！";

                        return amm;
                    }
                    if (oc.BllSession.ISYS_USERService.Entities.Where(m => m.DEPT_CODE == upid).Count() > 0)
                    {
                        amm.Statu = AjaxStatu.err;
                        amm.Msg = "该部门下已经有用户，暂不能更换隶属部门！";

                        return amm;
                    }
                    if (oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEPT_NAME == orgInfo.DEPT_NAME && m.PARENT_CODE == orgInfo.PARENT_CODE).ToList().Count > 0)
                    {
                        amm.Statu = AjaxStatu.err;
                        amm.Msg = string.Format(Message.YesFound, "部门名称");
                        return amm;
                    }
                    int a = oc.BllSession.ISYS_DEPTService.DelByWhere(m => m.DEPT_CODE == upid);//删除原来的
                    if (a > 0)
                    {
                        orgInfo.DEPT_CODE = newDeptCode;//更换新的编码
                        if (oc.BllSession.ISYS_DEPTService.AddEntity(orgInfo) > 0)
                        {
                            amm.Statu = AjaxStatu.ok;
                            amm.Msg = string.Format(Message.OptSussess, "部门", Message.EditOpt);
                        }
                        else
                        {
                            amm.Statu = AjaxStatu.err;
                            amm.Msg = string.Format(Message.OptFail, "部门", Message.EditOpt);
                        }
                    }
                    else
                    {
                        amm.Statu = AjaxStatu.err;
                        amm.Msg = string.Format(Message.OptFail, "部门", Message.EditOpt);
                        return amm;
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


        #region 逻辑删除部门
        /// <summary>
        /// 逻辑删除部门
        /// </summary>
        /// <param name="DEPTCODE">逻辑删除部门ID</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel Del(string DEPTCODE)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                if (oc.BllSession.ISYS_DEPTService.Entities.Where(o => o.DEPT_CODE == DEPTCODE).Count() == 0)
                {
                    amm.Msg = string.Format(Message.NotFound, "部门");
                    return amm;
                }
                if (oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && m.PARENT_CODE == DEPTCODE).Count() > 0)
                {
                    amm.Msg = "请先删除此部门的下属部门！";

                    return amm;
                }

                if (oc.BllSession.ISYS_MEMBERService.Entities.Where(m => m.DEL_FLAG == "0" && m.DEPT_CODE == DEPTCODE).Count() > 0)
                {
                    amm.Msg = "请先删除此部门的下属人员！";

                    return amm;
                }
                if (oc.BllSession.ISYS_USERService.Entities.Where(m => m.DEPT_CODE == DEPTCODE).Count() > 0)
                {
                    amm.Msg = "请先删除此部门的下属用户！";

                    return amm;
                }
                //以下三行是逻辑删除使用
                SYS_DEPT user = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEPT_CODE == DEPTCODE).OrderBy(m => m.DEPT_CODE).FirstOrDefault();
                user.DEL_FLAG = "1";
                if (oc.BllSession.ISYS_DEPTService.UpdateEntity(user, new string[] { "DEL_FLAG" }) > 0)
                //int a = oc.BllSession.ISYS_DEPTService.DelByWhere(m => m.DEPT_CODE == DEPTCODE);
                //if (a > 0)
                {
                    amm.Statu = AjaxStatu.ok;
                    amm.Msg = string.Format(Message.OptSussess, "部门", Message.DelOpt);
                }
                else
                {
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.OptFail, "部门", Message.DelOpt);
                }
            }
            catch (Exception)
            {
                return amm;
            }
            return amm;
        }
        #endregion

        #region 根据部门编号获取部门：段-车间-工区信息

        /// <summary>
        /// 根据部门编号获取部门：段-车间-工区信息
        /// </summary>
        /// <param name="dept_code">部门编码</param>
        /// <param name="deptList">部门列表</param>
        /// <returns>段-车间-工区</returns>
        public static string GetDeptInfo(string dept_code, List<SYS_DEPT> deptList)
        {
            string deptInfo = ",,";
            if (dept_code.Length <= 4)
            {
                deptInfo = deptList.Where(o => o.DEPT_CODE == dept_code).FirstOrDefault().DEPT_NAME + ",,";
            }
            else if (dept_code.Length == 6)
            {
                deptInfo = deptList.Where(o => o.DEPT_CODE == dept_code.Substring(0, 4)).FirstOrDefault().DEPT_NAME +
                           ",,";
            }
            else if (dept_code.Length == 8)
            {
                deptInfo = deptList.Where(o => o.DEPT_CODE == dept_code.Substring(0, 4)).FirstOrDefault().DEPT_NAME +
                           "," +
                           deptList.Where(o => o.DEPT_CODE == dept_code.Substring(0, 8)).FirstOrDefault().DEPT_NAME
                           + ",";
            }
            else if (dept_code.Length == 10)
            {
                deptInfo = deptList.Where(o => o.DEPT_CODE == dept_code.Substring(0, 4)).FirstOrDefault().DEPT_NAME +
                           "," +
                           deptList.Where(o => o.DEPT_CODE == dept_code.Substring(0, 8)).FirstOrDefault().DEPT_NAME
                           + "," + deptList.Where(o => o.DEPT_CODE == dept_code).FirstOrDefault().DEPT_NAME;
            }
            return deptInfo;
        }

        #endregion
    }
}