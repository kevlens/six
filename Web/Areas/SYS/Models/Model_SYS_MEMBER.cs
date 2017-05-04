using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Common;
using Model;
using Model.ModelExt;

namespace SxShWeb.Areas.Models
{
    public partial class Model_SYS_MEMBER
    {
        #region 获取所有组织与人员树
        /// <summary>
        /// 获取所有组织与人员树
        /// </summary>
        /// <returns></returns>
        public static string GetORGandRYTree()
        {
            string strJson = string.Empty;
            List<SYS_DEPTANDMEMBER> listOrgRy = new List<SYS_DEPTANDMEMBER>();
            //获取人员
            List<SYS_MEMBER> listRyMenu = oc.BllSession.ISYS_MEMBERService.GetListByCondition<string>(m => m.DEL_FLAG == "0" && m.LOCATION_FLAG == "1", m => m.MOBILE).Select(mb => mb.ToPOCO()).ToList();
            if (listRyMenu.Count > 0)
            {
                foreach (SYS_MEMBER ry in listRyMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = ry.MOBILE,
                        PARENT_CODE = ry.DEPT_CODE,
                        ORGRY_NAME = ry.NAME,
                        ICO = "icon-Off-line",
                        RYMOBILE = ry.MOBILE,
                        STATE = "0"//关闭
                    });
                }
            }
            //获得组织
            List<SYS_DEPT> listMenu = oc.BllSession.ISYS_DEPTService.GetListByCondition<string>(m => m.DEL_FLAG == "0", m => m.DEPT_CODE)
                .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE).Select(mb => mb.ToPOCO()).ToList();
            if (listMenu.Count > 0)
            {
                foreach (SYS_DEPT org in listMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = org.DEPT_CODE,
                        PARENT_CODE = org.PARENT_CODE,
                        ORGRY_NAME = org.DEPT_NAME,
                        ICO = org.C_ICO,
                        RYMOBILE = "",
                        STATE = org.STATUS_FLAG//0关闭
                    });
                }
            }
            List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgRy, "0", "", false);
            //return  ObjToJson.GetToJson(listTreeNodes, true);
            strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return strJson;
        }
        #endregion


        #region 获取用户对应部门组织树
        /// <summary>
        /// 获取用户对应部门组织树
        /// </summary>
        /// <returns></returns>
        public static string GetMyORGandRYTree(string DEPT_CODE, string PARENT_CODE, bool isCheckAll)
        {
            string strJson = string.Empty;
            List<SYS_DEPTANDMEMBER_TEMP> listOrgRy = new List<SYS_DEPTANDMEMBER_TEMP>();
            //获取人员
            List<SYS_MEMBER> listRyMenu = oc.BllSession.ISYS_MEMBERService.GetListByCondition<string>(m => m.DEL_FLAG == "0" && m.LOCATION_FLAG == "1" && m.DEPT_CODE.StartsWith(DEPT_CODE), m => m.MOBILE).Select(mb => mb.ToPOCO()).ToList();
            if (listRyMenu.Count > 0)
            {
                foreach (SYS_MEMBER ry in listRyMenu)
                {
                    string icon = "icon-Off-line";
                    if (ry.MOBILE_STATE == "1")
                        icon = "icon-status_busy";
                    listOrgRy.Add(new SYS_DEPTANDMEMBER_TEMP()
                    {
                        ORGRY_CODE = ry.MOBILE,
                        PARENT_CODE = ry.DEPT_CODE,
                        ORGRY_NAME = ry.NAME,
                        ICO = icon,
                        RYMOBILE = ry.MOBILE,
                        STATE = "0"//关闭
                    });
                }
            }
            //获得组织
            //List<SYS_ORG> listMenu = oc.BllSession.ISYS_ORGService.GetListByCondition<string>(m => m.DEL_FLAG == "0", m => m.DEPT_CODE).Select(mb => mb.ToPOCO()).ToList();
            List<SYS_DEPT> listMenu = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && (m.PARENT_CODE.StartsWith(DEPT_CODE) || m.DEPT_CODE == DEPT_CODE))
                .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE).ToList();
            if (listMenu.Count > 0)
            {
                foreach (SYS_DEPT org in listMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER_TEMP()
                    {
                        ORGRY_CODE = org.DEPT_CODE,
                        PARENT_CODE = org.PARENT_CODE,
                        ORGRY_NAME = org.DEPT_NAME,
                        ICO = org.C_ICO,
                        RYMOBILE = "",
                        STATE = org.STATUS_FLAG//0关闭
                    });
                }
            }
            //List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgRy, PARENT_CODE, DEPT_CODE, isCheckAll);
            List<ZTreeNode> listTreeNodes = SYS_DEPTANDMEMBER_TEMP.ConvertZTreeNodes(listOrgRy, PARENT_CODE, DEPT_CODE, isCheckAll);
            strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");

            return strJson;
        }
        public static string GetMyORGandRYTree_Two(string DEPT_CODE, string PARENT_CODE, bool isCheckAll)
        {
            string strJson = string.Empty;
            List<SYS_DEPTANDMEMBER> listOrgRy = new List<SYS_DEPTANDMEMBER>();
            //获取人员
            List<SYS_MEMBER> listRyMenu = oc.BllSession.ISYS_MEMBERService.GetListByCondition<string>(m => m.DEL_FLAG == "0" && m.LOCATION_FLAG == "1" && m.DEPT_CODE.StartsWith(DEPT_CODE), m => m.MOBILE).Select(mb => mb.ToPOCO()).ToList();
            if (listRyMenu.Count > 0)
            {
                foreach (SYS_MEMBER ry in listRyMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = ry.MOBILE,
                        PARENT_CODE = ry.DEPT_CODE,
                        ORGRY_NAME = ry.NAME,
                        ICO = "icon-Off-line",
                        RYMOBILE = ry.MOBILE,
                        STATE = "0"//关闭
                    });
                }
            }
            //获得组织
            //List<SYS_ORG> listMenu = oc.BllSession.ISYS_ORGService.GetListByCondition<string>(m => m.DEL_FLAG == "0", m => m.DEPT_CODE).Select(mb => mb.ToPOCO()).ToList();
            List<SYS_DEPT> listMenu = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && (m.PARENT_CODE.StartsWith(DEPT_CODE) || m.DEPT_CODE == DEPT_CODE))
                .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE).ToList();
            if (listMenu.Count > 0)
            {
                foreach (SYS_DEPT org in listMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = org.DEPT_CODE,
                        PARENT_CODE = org.PARENT_CODE,
                        ORGRY_NAME = org.DEPT_NAME,
                        ICO = org.C_ICO,
                        RYMOBILE = "",
                        STATE = org.STATUS_FLAG//0关闭
                    });
                }
            }
            //List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgRy, PARENT_CODE, DEPT_CODE, isCheckAll);
            List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgRy, PARENT_CODE, DEPT_CODE, isCheckAll);
            strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");

            return strJson;
        }
        

        #endregion

        #region 获取用户对应部门组织树(包括车辆)
        /// <summary>
        /// 获取用户对应部门组织树
        /// </summary>
        /// <returns></returns>
        public static string GetMyORGandRYTreeWithCar(string DEPT_CODE, string PARENT_CODE, bool isCheckAll)
        {
            string strJson = string.Empty;
            List<SYS_DEPTANDMEMBER> listOrgRy = new List<SYS_DEPTANDMEMBER>();
            //获取人员
            List<SYS_MEMBER> listRyMenu = oc.BllSession.ISYS_MEMBERService.GetListByCondition<string>(m => m.DEL_FLAG == "0" && m.LOCATION_FLAG == "1" && m.DEPT_CODE.StartsWith(DEPT_CODE), m => m.MOBILE).Select(mb => mb.ToPOCO()).ToList();
            if (listRyMenu.Count > 0)
            {
                foreach (SYS_MEMBER ry in listRyMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = ry.MOBILE,
                        PARENT_CODE = ry.DEPT_CODE,
                        ORGRY_NAME = ry.NAME,
                        ICO = "icon-Off-line",
                        RYMOBILE = ry.MOBILE,
                        STATE = "0"//关闭
                    });
                }
            }
            //获取车辆
            List<CAR_BDATA_CAR> listCar = oc.BllSession.ICAR_BDATA_CARService.GetListByCondition<string>(m => m.DEPT_CODE.StartsWith(DEPT_CODE), m => m.CAR_NO).Select(mb => mb.ToPOCO()).ToList();
            if (listRyMenu.Count > 0)
            {
                foreach (CAR_BDATA_CAR ry in listCar)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = ry.CAR_NO,
                        PARENT_CODE = ry.DEPT_CODE,
                        ORGRY_NAME = ry.CAR_LICENSENO,
                        ICO = "car-Off-line",
                        RYMOBILE = ry.CAR_NO,
                        STATE = "0"//关闭
                    });
                }
            }
            //获得组织
            //List<SYS_ORG> listMenu = oc.BllSession.ISYS_ORGService.GetListByCondition<string>(m => m.DEL_FLAG == "0", m => m.DEPT_CODE).Select(mb => mb.ToPOCO()).ToList();
            List<SYS_DEPT> listMenu = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && (m.PARENT_CODE.StartsWith(DEPT_CODE) || m.DEPT_CODE == DEPT_CODE))
                .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE).ToList();
            if (listMenu.Count > 0)
            {
                foreach (SYS_DEPT org in listMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = org.DEPT_CODE,
                        PARENT_CODE = org.PARENT_CODE,
                        ORGRY_NAME = org.DEPT_NAME,
                        ICO = org.C_ICO,
                        RYMOBILE = "",
                        STATE = org.STATUS_FLAG//0关闭
                    });
                }
            }
            List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgRy, PARENT_CODE, DEPT_CODE, isCheckAll);
            //return  ObjToJson.GetToJson(listTreeNodes, true);
            strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return strJson;
        }
        #endregion

        #region 获取用户对应部门组织树
        /// <summary>
        /// 获取用户对应部门组织树
        /// </summary>
        /// <returns></returns>
        public static List<EasyUITreeNode> GetMyDEPTandRYTree(string DEPT_CODE, string PARENT_CODE)
        {
            string strJson = string.Empty;
            List<SYS_DEPTANDMEMBER> listOrgRy = new List<SYS_DEPTANDMEMBER>();
            //获取人员
            List<SYS_MEMBER> listRyMenu = oc.BllSession.ISYS_MEMBERService.GetListByCondition<string>(m => m.DEL_FLAG == "0" && m.LOCATION_FLAG == "1" && m.DEPT_CODE.StartsWith(DEPT_CODE), m => m.MOBILE).Select(mb => mb.ToPOCO()).ToList();
            if (listRyMenu.Count > 0)
            {
                foreach (SYS_MEMBER ry in listRyMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = ry.MOBILE,
                        PARENT_CODE = ry.DEPT_CODE,
                        ORGRY_NAME = ry.NAME,
                        ICO = "icon-On-line",
                        RYMOBILE = ry.MOBILE,
                        STATE = "0"//关闭
                    });
                }
            }

            //获得组织
            //List<SYS_ORG> listMenu = oc.BllSession.ISYS_ORGService.GetListByCondition<string>(m => m.DEL_FLAG == "0", m => m.DEPT_CODE).Select(mb => mb.ToPOCO()).ToList();
            List<SYS_DEPT> listMenu = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && (m.PARENT_CODE.StartsWith(DEPT_CODE) || m.DEPT_CODE == DEPT_CODE))
                .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE).ToList();
            if (listMenu.Count > 0)
            {
                foreach (SYS_DEPT org in listMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = org.DEPT_CODE,
                        PARENT_CODE = org.PARENT_CODE,
                        ORGRY_NAME = org.DEPT_NAME,
                        ICO = org.C_ICO,
                        RYMOBILE = "",
                        STATE = org.STATUS_FLAG//0关闭
                    });
                }
            }
            List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgRy, PARENT_CODE, DEPT_CODE, false);
            //return  ObjToJson.GetToJson(listTreeNodes, true);
            //strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return listTreeNodes;
        }
        #endregion

        #region 获取用户对应部门组织树(包括车辆)
        /// <summary>
        /// 获取用户对应部门组织树
        /// </summary>
        /// <returns></returns>
        public static List<EasyUITreeNode> GetMyDEPTandRYTreeWithCar(string DEPT_CODE, string PARENT_CODE)
        {
            string strJson = string.Empty;
            List<SYS_DEPTANDMEMBER> listOrgRy = new List<SYS_DEPTANDMEMBER>();
            //获取车辆
            List<CAR_BDATA_CAR> listCar = oc.BllSession.ICAR_BDATA_CARService.GetListByCondition<string>(m => m.DEPT_CODE.StartsWith(DEPT_CODE), m => m.CAR_NO).Select(mb => mb.ToPOCO()).ToList();
            if (listCar.Count > 0)
            {
                foreach (CAR_BDATA_CAR ry in listCar)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = ry.CAR_NO,
                        PARENT_CODE = ry.DEPT_CODE,
                        ORGRY_NAME = ry.CAR_LICENSENO,
                        ICO = "car-Off-line",
                        RYMOBILE = ry.CAR_NO,
                        STATE = "0"//关闭
                    });
                }
            }
            //获得组织
            //List<SYS_ORG> listMenu = oc.BllSession.ISYS_ORGService.GetListByCondition<string>(m => m.DEL_FLAG == "0", m => m.DEPT_CODE).Select(mb => mb.ToPOCO()).ToList();
            List<SYS_DEPT> listMenu = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && (m.PARENT_CODE.StartsWith(DEPT_CODE) || m.DEPT_CODE == DEPT_CODE))
                .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE).ToList();
            if (listMenu.Count > 0)
            {
                foreach (SYS_DEPT org in listMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = org.DEPT_CODE,
                        PARENT_CODE = org.PARENT_CODE,
                        ORGRY_NAME = org.DEPT_NAME,
                        ICO = org.C_ICO,
                        RYMOBILE = "",
                        STATE = org.STATUS_FLAG//0关闭
                    });
                }
            }
            List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgRy, PARENT_CODE, DEPT_CODE, false);
            //return  ObjToJson.GetToJson(listTreeNodes, true);
            //strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return listTreeNodes;
        }
        #endregion

        #region 新增人员
        /// <summary>
        /// 新增人员
        /// </summary>
        /// <param name="UserInfo"></param>
        /// <returns></returns>
        public static AjaxMsgModel Add(SYS_MEMBER UserInfo)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                if (oc.BllSession.ISYS_DEPTService.Entities.Where(o => o.DEPT_CODE == UserInfo.DEPT_CODE).Count() == 0)
                {
                    amm.Msg = string.Format(Message.NotFound, "部门");
                    return amm;
                }
                if (oc.BllSession.ISYS_MEMBERService.Entities.Where(m => m.DEL_FLAG == "0" && m.MOBILE == UserInfo.MOBILE).Count() > 0)
                {
                    //amm.Msg = "手机号码已经存在！";
                    amm.Msg = string.Format(Message.YesFound, "手机号码");
                    return amm;
                }

                if (oc.BllSession.ISYS_MEMBERService.AddEntity(UserInfo) > 0)
                {
                    amm.Statu = AjaxStatu.ok;
                    amm.Msg = string.Format(Message.OptSussess, "人员", Message.AddOpt);
                }
                else
                {
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.OptFail, "人员", Message.AddOpt);
                }
            }
            catch (Exception)
            {
                return amm;
            }
            return amm;
        }
        #endregion

        #region 修改人员
        /// <summary>
        /// 修改人员
        /// </summary>
        /// <param name="UserInfo">用户</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel Edit(SYS_MEMBER UserInfo)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                if (oc.BllSession.ISYS_DEPTService.Entities.Where(o => o.DEPT_CODE == UserInfo.DEPT_CODE).Count() == 0)
                {
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.NotFound, "部门");
                    return amm;
                }
                if (oc.BllSession.ISYS_MEMBERService.Entities.Where(u => u.DEL_FLAG == "0" && u.MEMBER_ID != UserInfo.MEMBER_ID && u.MOBILE == UserInfo.MOBILE).Count() > 0)
                {
                    amm.Msg = string.Format(Message.YesFound, "手机号码");
                    return amm;
                }
                //Expression<Func<SYS_MEMBER, object>>[] ignoreProperties =
                //    new Expression<Func<SYS_MEMBER, object>>[] {
                //   p=>p.SYS_DEPT,p=>p.GATE_BDATA_CARD,p=>p.GATE_JOB_PLAN,p=>p.PHONE_USER,p=>p.JOB_JOB_PLAN};

                if (oc.BllSession.ISYS_MEMBERService.UpdateEntity(UserInfo, new string[] { "NAME", "MOBILE", "JOB",
                "PHONE","NOTE","UPDATE_DATE","DEPT_CODE","UPDATE_USER","DEL_FLAG","LOCATION_FLAG","INTELLIGENCE","POS_LEVEL","MOBILE_STATE"}) > 0)
                {
                    amm.Statu = AjaxStatu.ok;
                    amm.Msg = string.Format(Message.OptSussess, "人员", Message.EditOpt);
                }
                else
                {
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = string.Format(Message.OptFail, "人员", Message.EditOpt);
                }
            }
            catch (Exception)
            {
                return amm;
            }
            return amm;
        }
        #endregion

        #region 逻辑删除人员
        /// <summary>
        /// 逻辑删除人员
        /// </summary>
        /// <param name="MEMBERID">删除人员ID</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel Del(string MEMBERID)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                SYS_MEMBER member = oc.BllSession.ISYS_MEMBERService.Entities.Where(m => m.DEL_FLAG == "0" && m.MEMBER_ID == MEMBERID).OrderBy(m => m.UPDATE_DATE).FirstOrDefault();

                if (member != null)
                {
                    member.DEL_FLAG = "1";
                    int iret = oc.BllSession.ISYS_MEMBERService.UpdateEntity(member, new string[] { "DEL_FLAG" });
                    if (iret > 0)//oc.BllSession.ISYS_MEMBERService.DelByWhere(m => m.MEMBER_ID == MEMBERID) > 0
                    {
                        amm.Statu = AjaxStatu.ok;
                        amm.Msg = string.Format(Message.OptSussess, "人员", Message.DelOpt);
                    }
                    else
                    {
                        amm.Statu = AjaxStatu.err;
                        amm.Msg = string.Format(Message.OptFail, "人员", Message.DelOpt);
                    }
                }
                else
                {
                    amm.Msg = string.Format(Message.NotFound, "人员");
                }
                return amm;
            }
            catch (Exception)
            {
                return amm;
            }
        }
        #endregion

        #region 批量导入人员
        /// <summary>
        /// 批量导入人员
        /// </summary>
        /// <returns></returns>
        public static AjaxMsgModel AddList(List<SYS_MEMBER> list)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            amm.Statu = AjaxStatu.ok;
            amm.Msg = "人员导入成功！";
            //try
            //{
            //    int i = 0;
            //    foreach (SYS_MEMBER member in list)
            //    {
            //        member.MEMBER_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff") + i;
            //        i++;
            //    }
            //    if (oc.BllSession.ISYS_MEMBERService.AddListEntity(list) > 0)
            //    {
            //        amm.Statu = AjaxStatu.ok;
            //        amm.Msg = "人员导入成功！";
            //    }
            //    else
            //    {
            //        amm.Statu = AjaxStatu.err;//这一行要加，因为验证时已更改
            //        amm.Msg = "人员导入失败！";
            //    }
            //}
            //catch (Exception)
            //{
            //    return amm;
            //}
            return amm;
        }
        #endregion

        #region 获取用户对应部门组织工务段树
        /// <summary>
        /// 获取用户对应部门组织树
        /// </summary>
        /// <returns></returns>
        public static string GetMyORDeptTree(string DEPT_CODE, string PARENT_CODE, bool isCheckAll)
        {
            string strJson = string.Empty;
            List<SYS_DEPTANDMEMBER_TEMP> listOrgRy = new List<SYS_DEPTANDMEMBER_TEMP>();
            List<SYS_DEPT> listMenu = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && m.DEPT_CODE.Length <= 8 && (m.PARENT_CODE.StartsWith(DEPT_CODE) || m.DEPT_CODE == DEPT_CODE))
    .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE).ToList();
            if (listMenu.Count > 0)
            {
                foreach (SYS_DEPT org in listMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER_TEMP()
                    {
                        ORGRY_CODE = org.DEPT_CODE,
                        PARENT_CODE = org.PARENT_CODE,
                        ORGRY_NAME = org.DEPT_NAME,
                        ICO = org.C_ICO,
                        RYMOBILE = "",
                        STATE = org.STATUS_FLAG//0关闭
                    });
                }
            }
            List<ZTreeNode> listTreeNodes = SYS_DEPTANDMEMBER_TEMP.ConvertZTreeNodes(listOrgRy, PARENT_CODE, DEPT_CODE, isCheckAll);
            strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return strJson;
        }
        #endregion

        #region 气象监测树
        /// <summary>
        /// 获取气象监测组织机构树
        /// </summary>
        /// <param name="DEPT_CODE"></param>
        /// <param name="PARENT_CODE"></param>
        /// <param name="isCheckAll"></param>
        /// <returns></returns>
        public static string GetWeatherDeptTree(string DEPT_CODE, string PARENT_CODE, bool isCheckAll)
        {
            string strJson = string.Empty;
            List<SYS_DEPTANDMEMBER_TEMP> listOrgRy = new List<SYS_DEPTANDMEMBER_TEMP>();
            List<SYS_DEPT> listMenu = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && m.DEPT_CODE.Length <= 8 && (m.PARENT_CODE.StartsWith(DEPT_CODE) || m.DEPT_CODE == DEPT_CODE))
    .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE).ToList();
            if (listMenu.Count > 0)
            {
                foreach (SYS_DEPT org in listMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER_TEMP()
                    {
                        ORGRY_CODE = org.DEPT_CODE,
                        PARENT_CODE = org.PARENT_CODE,
                        ORGRY_NAME = org.DEPT_NAME,
                        ICO = org.C_ICO,
                        RYMOBILE = "",
                        STATE = org.STATUS_FLAG//0关闭
                    });
                }
            }
            List<ZTreeNode> listTreeNodes = SYS_DEPTANDMEMBER_TEMP.ConvertZTreeNodes(listOrgRy, PARENT_CODE, DEPT_CODE, isCheckAll);
            strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return strJson;
        }

        /// <summary>
        /// 获取气象监测线名树
        /// </summary>
        /// <param name="DEPT_CODE"></param>
        /// <param name="PARENT_CODE"></param>
        /// <returns></returns>
        public static string GetWeatherLineTree(string DEPT_CODE, string PARENT_CODE)
        {
            Dictionary<string, string> deptDict = new Dictionary<string, string>();
            if (DEPT_CODE.Length == 2)
            {
                IQueryable<SYS_DEPT> dic = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && m.DEPT_CODE.Length <= 4);
                foreach (var item in dic)
                {
                    deptDict.Add(item.DEPT_CODE, item.DEPT_NAME);
                }
            }
            string strJson = string.Empty;
            List<SYS_DEPTANDMEMBER_TEMP> listorgHost = new List<SYS_DEPTANDMEMBER_TEMP>();
            //获取主机
            List<BROKENRAIL_BDATA_SECTION> listHost = oc.BllSession.IBROKENRAIL_BDATA_SECTIONService
                .GetListByCondition<string>(g => g.DEPT_CODE.StartsWith(DEPT_CODE), g => g.SECTION_ID).ToList();

            listHost = listHost.OrderBy(o => o.START_MILE).ToList();
            //cwb
            List<BROKENRAIL_BDATA_DEVICE> listDevice = oc.BllSession.IBROKENRAIL_BDATA_DEVICEService.Entities.Where(o => o.TYPE == "主机").ToList();
            if (listHost.Count > 0)
            {
                foreach (BROKENRAIL_BDATA_SECTION host in listHost)
                {
                    string head = string.Empty;
                    if (DEPT_CODE.Length == 2)
                        head = deptDict[host.DEPT_CODE];
                    listorgHost.Add(new SYS_DEPTANDMEMBER_TEMP
                    {
                        ORGRY_CODE = host.SECTION_ID,
                        PARENT_CODE = host.LINE_NAME,
                        ORGRY_NAME = host.SECTION_NAME,
                        ICO = "icon-drive",
                        RYMOBILE = head + "(" + GetToKDESC(host.START_MILE) + "~" + GetToKDESC(host.END_MILE) + ")",
                        STATE = "0",
                        //cwb
                        // PHONE = host.SECTION_ID//oc.BllSession.IBROKENRAIL_BDATA_DEVICEService.Entities.Where(o => o.SECTION_ID == host.SECTION_ID && o.TYPE == "主机").FirstOrDefault().POINT_NO
                        PHONE = listDevice.Where(o => o.SECTION_ID == host.SECTION_ID).FirstOrDefault().POINT_NO
                    });
                }
            }
            List<string> line = oc.BllSession.IBROKENRAIL_BDATA_SECTIONService.Entities.Select(o => o.LINE_NAME).Distinct().ToList();
            IQueryable<T_JOB_LINE> listLineMenu = oc.BllSession.IT_JOB_LINEService.Entities.Where(o => o.LINE_DEPTCODE.Contains(DEPT_CODE));
            foreach (var item in listLineMenu)
            {
                if (!line.Contains(item.LINE_NAME))
                    line.Insert(line.Count, item.LINE_NAME);
            }
            SYS_DEPT dept = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && m.DEPT_CODE == DEPT_CODE).FirstOrDefault();
            //List<SYS_DEPT> listMenu = oc.BllSession.ISYS_DEPTService.Entities
            //    .Where(m => m.DEL_FLAG == "0" && (m.PARENT_CODE.StartsWith(DEPT_CODE) || m.DEPT_CODE == DEPT_CODE))
            //    .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE).ToList();
            if (dept != null)
            {
                listorgHost.Add(new SYS_DEPTANDMEMBER_TEMP()
                {
                    ORGRY_CODE = dept.DEPT_CODE,
                    PARENT_CODE = dept.PARENT_CODE,
                    ORGRY_NAME = dept.DEPT_NAME,
                    ICO = "icon-DepartMent",
                    RYMOBILE = "",
                    STATE = "0"//0关闭
                });
                if (listLineMenu.Count() > 0)
                {
                    foreach (var org in line)
                    {

                        listorgHost.Add(new SYS_DEPTANDMEMBER_TEMP()
                        {
                            ORGRY_CODE = org,
                            PARENT_CODE = DEPT_CODE,
                            ORGRY_NAME = org,
                            ICO = "icon-DepartMent",
                            RYMOBILE = "",
                            STATE = "0"//0关闭
                        });
                    }
                }
            }
            List<ZTreeNode> listTreeNodes = SYS_DEPTANDMEMBER_TEMP.ConvertZTreeNodes(listorgHost, PARENT_CODE, DEPT_CODE, true);
            strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return strJson;
        }
        public static string GetToKDESC(decimal? dec)
        {
            if (dec == null)
            {
                return "&nbsp&nbsp";
            }
            else
            {
                string stringdec = Convert.ToDecimal(dec).ToString("f3");
                return "K" + stringdec.Split('.')[0] + "+" + stringdec.Split('.')[1].PadRight(3, '0');
            }
        }

        public static string GetToKDESC(string dec)
        {
            if (string.IsNullOrEmpty(dec))
            {
                return "&nbsp&nbsp";
            }
            else
            {
                string stringdec = Convert.ToDecimal(dec).ToString("f3");
                return "K" + stringdec.Split('.')[0] + "+" + stringdec.Split('.')[1].PadRight(3, '0');
            }
        }
        #endregion

        #region 获取汽车树
        public static string GetCarTree(string DEPT_CODE, string PARENT_CODE, bool isCheckAll)
        {
            string strJson = string.Empty;
            List<SYS_DEPTANDMEMBER> listOrgRy = new List<SYS_DEPTANDMEMBER>();
            //获取人员
            List<CAR_BDATA_CAR> listCarMenu = oc.BllSession.ICAR_BDATA_CARService.GetListByCondition<string>(m => m.DEPT_CODE.StartsWith(DEPT_CODE), m => m.CAR_NO).Select(mb => mb.ToPOCO()).ToList();
            if (listCarMenu.Count > 0)
            {
                foreach (CAR_BDATA_CAR ry in listCarMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = ry.CAR_NO,
                        PARENT_CODE = ry.DEPT_CODE,
                        ORGRY_NAME = ry.CAR_LICENSENO,
                        ICO = "car-Off-line",
                        RYMOBILE = ry.CAR_NO,
                        STATE = "0"//关闭
                    });
                }
            }
            //获得组织
            //List<SYS_ORG> listMenu = oc.BllSession.ISYS_ORGService.GetListByCondition<string>(m => m.DEL_FLAG == "0", m => m.DEPT_CODE).Select(mb => mb.ToPOCO()).ToList();
            List<SYS_DEPT> listMenu = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && (m.PARENT_CODE.StartsWith(DEPT_CODE) || m.DEPT_CODE == DEPT_CODE))
                .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE).ToList();
            if (listMenu.Count > 0)
            {
                foreach (SYS_DEPT org in listMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = org.DEPT_CODE,
                        PARENT_CODE = org.PARENT_CODE,
                        ORGRY_NAME = org.DEPT_NAME,
                        ICO = org.C_ICO,
                        RYMOBILE = "",
                        STATE = org.STATUS_FLAG//0关闭
                    });
                }
            }
            List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgRy, PARENT_CODE, DEPT_CODE, isCheckAll);
            //return  ObjToJson.GetToJson(listTreeNodes, true);
            strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return strJson;
        }
        public static string GetCarTree_TWO(string DEPT_CODE, string PARENT_CODE, bool isCheckAll)
        {
            string strJson = string.Empty;
            List<SYS_DEPTANDMEMBER_TEMP> listOrgRy = new List<SYS_DEPTANDMEMBER_TEMP>();
            //获取人员
            List<CAR_BDATA_CAR> listCarMenu = oc.BllSession.ICAR_BDATA_CARService.GetListByCondition<string>(m => m.DEPT_CODE.StartsWith(DEPT_CODE), m => m.CAR_NO).Select(mb => mb.ToPOCO()).ToList();
            if (listCarMenu.Count > 0)
            {
                foreach (CAR_BDATA_CAR ry in listCarMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER_TEMP()
                    {
                        ORGRY_CODE = ry.CAR_NO,
                        PARENT_CODE = ry.DEPT_CODE,
                        ORGRY_NAME = ry.CAR_LICENSENO,
                        ICO = "car-Off-line",
                        RYMOBILE = ry.CAR_NO,
                        STATE = "0"//关闭
                    });
                }
            }
            //获得组织
            //List<SYS_ORG> listMenu = oc.BllSession.ISYS_ORGService.GetListByCondition<string>(m => m.DEL_FLAG == "0", m => m.DEPT_CODE).Select(mb => mb.ToPOCO()).ToList();
            List<SYS_DEPT> listMenu = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && (m.PARENT_CODE.StartsWith(DEPT_CODE) || m.DEPT_CODE == DEPT_CODE))
                .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE).ToList();
            if (listMenu.Count > 0)
            {
                foreach (SYS_DEPT org in listMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER_TEMP()
                    {
                        ORGRY_CODE = org.DEPT_CODE,
                        PARENT_CODE = org.PARENT_CODE,
                        ORGRY_NAME = org.DEPT_NAME,
                        ICO = org.C_ICO,
                        RYMOBILE = "",
                        STATE = org.STATUS_FLAG//0关闭
                    });
                }
            }
            List<ZTreeNode> listTreeNodes = SYS_DEPTANDMEMBER_TEMP.ConvertZTreeNodes(listOrgRy, PARENT_CODE, DEPT_CODE, isCheckAll);
            //return  ObjToJson.GetToJson(listTreeNodes, true);
            strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return strJson;
        }
        #endregion

        #region 获取用户所属权限下的部门资质人员树
        public static string GetORGMemberIntelligenceCheckedTree(string DEPT_CODE, string PARENT_CODE, bool isCheckAll)
        {
            string strJson = string.Empty;
            List<SYS_DEPTANDMEMBER_TEMP> listOrgRy = new List<SYS_DEPTANDMEMBER_TEMP>();

            //获取人员
            List<SYS_MEMBER> listRyMenu = oc.BllSession.ISYS_MEMBERService.GetListByCondition<string>(m => m.DEL_FLAG == "0"
                && m.LOCATION_FLAG == "1" && m.DEPT_CODE.StartsWith(DEPT_CODE), m => m.MOBILE)
                .Select(mb => mb.ToPOCO()).ToList();
            //资质
            List<SYS_INTELLIGENCE_DIC> intelDIClist = oc.BllSession.ISYS_INTELLIGENCE_DICService.Entities.OrderBy(u => u.DIC_ORDER).ToList();
            if (listRyMenu.Count > 0)
            {
                foreach (SYS_MEMBER ry in listRyMenu)
                {
                    string icon = "icon-Off-line";
                    if (ry.MOBILE_STATE == "1")
                        icon = "icon-status_busy";
                    listOrgRy.Add(new SYS_DEPTANDMEMBER_TEMP()
                    {
                        ORGRY_CODE = ry.MOBILE,
                        PARENT_CODE = (ry.DEPT_CODE.Length >= 4 ? ry.DEPT_CODE.Substring(0, 4) : ry.DEPT_CODE) +
                                     (!intelDIClist.Select(u => u.DIC_ID).Contains(ry.INTELLIGENCE) ? "0A" : ry.INTELLIGENCE),  //如果没有归类(空或者在字典表不存在)，则默认到其他
                        ORGRY_NAME = ry.NAME,
                        ICO = icon,
                        RYMOBILE = ry.MOBILE,
                        STATE = "0"//关闭
                    });

                }
            }
            //获取资质
            List<SYS_DEPTANDMEMBER_TEMP> listTemp = new List<SYS_DEPTANDMEMBER_TEMP>();
            List<string> parList = listOrgRy.Select(u => u.PARENT_CODE).Distinct().ToList();
            if (intelDIClist.Count > 0)
            {
                foreach (string parcode in parList)
                {
                    string deptcode = parcode.Substring(0, parcode.Length - 2);
                    string diccode = parcode.Substring(parcode.Length - 2);
                    if (intelDIClist.Where(u => u.DIC_ID.Equals(diccode)).Count() > 0)
                    {
                        SYS_INTELLIGENCE_DIC dic = intelDIClist.Where(u => u.DIC_ID.Equals(diccode)).FirstOrDefault();
                        listTemp.Add(new SYS_DEPTANDMEMBER_TEMP()
                        {
                            ORGRY_CODE = parcode,
                            PARENT_CODE = deptcode,
                            ORGRY_NAME = dic.DIC_NAME,
                            ICO = dic.DIC_ICON,
                            ORDER = dic.DIC_ORDER,
                            RYMOBILE = string.Empty,//parcode,
                            STATE = "0" //关闭
                        });
                    }
                }
            }
            listOrgRy.AddRange(listTemp.OrderBy(u => u.ORDER));

            //获得组织
            List<SYS_DEPT> listMenu = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0"
                && (m.PARENT_CODE.StartsWith(DEPT_CODE) || m.DEPT_CODE == DEPT_CODE)
                && m.DEPT_CODE.Length <= 4)
                .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE).ToList();
            if (listMenu.Count > 0)
            {
                foreach (SYS_DEPT org in listMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER_TEMP()
                    {
                        ORGRY_CODE = org.DEPT_CODE,
                        PARENT_CODE = org.PARENT_CODE,
                        ORGRY_NAME = org.DEPT_NAME,
                        ICO = org.C_ICO,
                        RYMOBILE = "",
                        STATE = org.STATUS_FLAG//0关闭
                    });
                }
            }
            //List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgRy, PARENT_CODE, DEPT_CODE, true);
            List<ZTreeNode> listTreeNodes = SYS_DEPTANDMEMBER_TEMP.ConvertZTreeNodes(listOrgRy, PARENT_CODE, DEPT_CODE, isCheckAll);
            strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return strJson;
        }
        #endregion

        public static List<EasyUITreeNode> GetMyDdeptandMemberTree(string DEPT_CODE, string PARENT_CODE)
        {
            string strJson = string.Empty;
            List<SYS_DEPTANDMEMBER> listOrgRy = new List<SYS_DEPTANDMEMBER>();
            //获取人员
            List<SYS_MEMBER> listRyMenu = oc.BllSession.ISYS_MEMBERService.GetListByCondition<string>(m => m.DEL_FLAG == "0" && m.LOCATION_FLAG == "1" && m.DEPT_CODE.StartsWith(DEPT_CODE), m => m.MOBILE).Select(mb => mb.ToPOCO()).ToList();
            if (listRyMenu.Count > 0)
            {
                foreach (SYS_MEMBER ry in listRyMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = ry.MEMBER_ID,
                        PARENT_CODE = ry.DEPT_CODE,
                        ORGRY_NAME = ry.NAME,
                        ICO = "icon-On-line",
                        RYMOBILE = ry.MOBILE,
                        STATE = "0"//关闭
                    });
                }
            }

            //获得组织
            List<SYS_DEPT> listMenu = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEL_FLAG == "0" && (m.PARENT_CODE.StartsWith(DEPT_CODE) || m.DEPT_CODE == DEPT_CODE))
                .OrderBy(m => m.DEPT_ORDER).ThenBy(m => m.DEPT_CODE).ToList();
            if (listMenu.Count > 0)
            {
                foreach (SYS_DEPT org in listMenu)
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = org.DEPT_CODE,
                        PARENT_CODE = org.PARENT_CODE,
                        ORGRY_NAME = org.DEPT_NAME,
                        ICO = org.C_ICO,
                        RYMOBILE = "",
                        STATE = org.STATUS_FLAG//0关闭
                    });
                }
            }
            List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgRy, PARENT_CODE, DEPT_CODE, false);
            return listTreeNodes;
        }
    }
}