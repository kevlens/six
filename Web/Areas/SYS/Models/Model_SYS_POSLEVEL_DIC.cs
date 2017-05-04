using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.ModelExt;
using SxShWeb.Areas.ViewModels;
using Common;
using Model;

namespace SxShWeb.Areas.Models
{
    public partial class Model_SYS_POSLEVEL_DIC
    {
        public static List<VIEW_SYS_POSLEVEL_DIC> GetPosLevelDic()
        {
            return oc.BllSession.ISYS_POSLEVEL_DICService.Entities.OrderBy(u => u.DIC_ORDER)
                .Select(u => new VIEW_SYS_POSLEVEL_DIC
                {
                    DIC_ID = u.DIC_ID,
                    DIC_NAME = u.DIC_NAME
                }).ToList();
        }

        public static List<EasyUITreeNode> GetPosLevelDic(string DEPT_CODE, string PARENT_CODE)
        {
            List<SYS_DEPTANDMEMBER> listOrgRy = new List<SYS_DEPTANDMEMBER>();
            //获取级别
            List<SYS_POSLEVEL_DIC> posDicList = oc.BllSession.ISYS_POSLEVEL_DICService.Entities.OrderBy(u=>u.NOTE1).ThenBy(u => u.DIC_ORDER).ToList();
            if (posDicList.Count > 0) 
            {
                foreach (SYS_POSLEVEL_DIC pos in posDicList) 
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    { 
                        ORGRY_CODE=pos.DIC_ID,
                        PARENT_CODE=pos.NOTE1,
                        ORGRY_NAME=pos.DIC_NAME,
                        ICO = "icon-user_brown",
                        RYMOBILE = "",
                        STATE="0"
                    });
                }
            }
            List<string> dicPar = posDicList.Select(u => u.NOTE1).Distinct().ToList();
            Dictionary<string, string> dicNamePar = new Dictionary<string, string>();
            foreach (string temp in dicPar) 
            {
                if (!dicNamePar.ContainsKey(temp)) 
                {
                    if (temp.Equals("N")) dicNamePar.Add(temp, "其他");
                    if (temp.Equals("1")) dicNamePar.Add(temp, "段级");
                    if (temp.Equals("2")) dicNamePar.Add(temp,"车间");
                }
            }
            if (dicPar.Count > 0) 
            {
                foreach (string par in dicPar) 
                {
                    listOrgRy.Add(new SYS_DEPTANDMEMBER() {
                        ORGRY_CODE = par,
                        PARENT_CODE = PARENT_CODE,
                        ORGRY_NAME = dicNamePar[par],
                        ICO = "icon-org",
                        RYMOBILE = "",
                        STATE = "0"
                    });
                }
            }
            List<EasyUITreeNode> listTreeNodes = SYS_DEPTANDMEMBER.ConvertTreeNodes(listOrgRy, PARENT_CODE, DEPT_CODE, false);
            return listTreeNodes;
        }

        public static string GetPosLevelCheckedTree(string DEPT_CODE, string PARENT_CODE, bool isCheckAll) 
        {
            string strJson = string.Empty;
            List<SYS_DEPTANDMEMBER_TEMP> listOrgRy = new List<SYS_DEPTANDMEMBER_TEMP>();
            //获取人员
            List<SYS_MEMBER> listRyMenu = oc.BllSession.ISYS_MEMBERService.GetListByCondition<string>(m => m.DEL_FLAG == "0"
                && m.LOCATION_FLAG == "1" && m.DEPT_CODE.StartsWith(DEPT_CODE), m => m.MOBILE)
                .Select(mb => mb.ToPOCO()).ToList();
            //级别
            List<SYS_POSLEVEL_DIC> PosLevellist = oc.BllSession.ISYS_POSLEVEL_DICService.Entities.OrderBy(u => u.DIC_ORDER).ToList();
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
                                     (!PosLevellist.Select(u => u.DIC_ID).Contains(ry.POS_LEVEL) ? "1A" : ry.POS_LEVEL),  //如果没有归类(空或者在字典表不存在)，则默认到其他
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
            if (PosLevellist.Count > 0)
            {
                foreach (string parcode in parList)
                {
                    string deptcode = parcode.Substring(0, parcode.Length - 2);
                    string diccode = parcode.Substring(parcode.Length - 2);
                    if (PosLevellist.Where(u => u.DIC_ID.Equals(diccode)).Count() > 0)
                    {
                        SYS_POSLEVEL_DIC dic = PosLevellist.Where(u => u.DIC_ID.Equals(diccode)).FirstOrDefault();
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
            List<ZTreeNode> listTreeNodes = SYS_DEPTANDMEMBER_TEMP.ConvertZTreeNodes(listOrgRy, PARENT_CODE, DEPT_CODE, isCheckAll);
            strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return strJson;
        }

        public static List<EasyUITreeNode> GetWarnPosLevelTreeList(string DEPT_CODE, string PARENT_CODE) 
        {
            List<SYS_DEPTANDMEMBER> listOrgRy = new List<SYS_DEPTANDMEMBER>();
            //报警级别
            List<SYS_POSLEVEL_DIC> PosLevellist = oc.BllSession.ISYS_POSLEVEL_DICService.Entities.Where(u => u.NOTE1 != "N")
                .OrderBy(u => u.DIC_ORDER).ToList();
            List<string> posIdList = PosLevellist.Select(u => u.DIC_ID).Distinct().ToList();
            //获取人员
            List<SYS_MEMBER> listRyMenu = oc.BllSession.ISYS_MEMBERService.GetListByCondition<string>(m => m.DEL_FLAG == "0"
                && m.LOCATION_FLAG == "1" && m.DEPT_CODE.StartsWith(DEPT_CODE) && posIdList.Contains(m.POS_LEVEL), m => m.MOBILE)
                .Select(mb => mb.ToPOCO()).ToList();
            if (listRyMenu.Count > 0)
            {
                foreach (SYS_MEMBER ry in listRyMenu)
                {
                    string icon = "icon-On-line";
                    if (ry.MOBILE_STATE == "1")
                        icon = "icon-status_busy";
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = ry.MEMBER_ID,
                        PARENT_CODE = (ry.DEPT_CODE.Length >= 4 ? ry.DEPT_CODE.Substring(0, 4) : ry.DEPT_CODE) +
                                     (!PosLevellist.Select(u => u.DIC_ID).Contains(ry.POS_LEVEL) ? "1A" : ry.POS_LEVEL),  //如果没有归类(空或者在字典表不存在)，则默认到其他
                        ORGRY_NAME = ry.NAME,
                        ICO = icon,
                        RYMOBILE = ry.MOBILE,
                        STATE = "0"//关闭
                    });

                }
            }
            //获取资质
            List<SYS_DEPTANDMEMBER> listTemp = new List<SYS_DEPTANDMEMBER>();
            List<string> parList = listOrgRy.Select(u => u.PARENT_CODE).Distinct().ToList();
            if (PosLevellist.Count > 0)
            {
                foreach (string parcode in parList)
                {
                    string deptcode = parcode.Substring(0, parcode.Length - 2);
                    string diccode = parcode.Substring(parcode.Length - 2);
                    if (PosLevellist.Where(u => u.DIC_ID.Equals(diccode)).Count() > 0)
                    {
                        SYS_POSLEVEL_DIC dic = PosLevellist.Where(u => u.DIC_ID.Equals(diccode)).FirstOrDefault();
                        listTemp.Add(new SYS_DEPTANDMEMBER()
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

        public static string GetWarnPosLevelTreeStr(string DEPT_CODE, string PARENT_CODE, bool isCheckAll)
        {
            string strJson = string.Empty;
            List<SYS_DEPTANDMEMBER> listOrgRy = new List<SYS_DEPTANDMEMBER>();
            //报警级别
            List<SYS_POSLEVEL_DIC> PosLevellist = oc.BllSession.ISYS_POSLEVEL_DICService.Entities.Where(u => u.NOTE1 != "N")
                .OrderBy(u => u.DIC_ORDER).ToList();
            List<string> posIdList = PosLevellist.Select(u => u.DIC_ID).Distinct().ToList();
            //获取人员
            List<SYS_MEMBER> listRyMenu = oc.BllSession.ISYS_MEMBERService.GetListByCondition<string>(m => m.DEL_FLAG == "0"
                && m.LOCATION_FLAG == "1" && m.DEPT_CODE.StartsWith(DEPT_CODE) && posIdList.Contains(m.POS_LEVEL), m => m.MOBILE)
                .Select(mb => mb.ToPOCO()).ToList();
            if (listRyMenu.Count > 0)
            {
                foreach (SYS_MEMBER ry in listRyMenu)
                {
                    string icon = "icon-On-line";
                    if (ry.MOBILE_STATE == "1")
                        icon = "icon-status_busy";
                    listOrgRy.Add(new SYS_DEPTANDMEMBER()
                    {
                        ORGRY_CODE = ry.MEMBER_ID,
                        PARENT_CODE = (ry.DEPT_CODE.Length >= 4 ? ry.DEPT_CODE.Substring(0, 4) : ry.DEPT_CODE) +
                                     (!PosLevellist.Select(u => u.DIC_ID).Contains(ry.POS_LEVEL) ? "1A" : ry.POS_LEVEL),  //如果没有归类(空或者在字典表不存在)，则默认到其他
                        ORGRY_NAME = ry.NAME,
                        ICO = icon,
                        RYMOBILE = ry.MOBILE,
                        STATE = "0"//关闭
                    });

                }
            }
            //获取资质
            List<SYS_DEPTANDMEMBER> listTemp = new List<SYS_DEPTANDMEMBER>();
            List<string> parList = listOrgRy.Select(u => u.PARENT_CODE).Distinct().ToList();
            if (PosLevellist.Count > 0)
            {
                foreach (string parcode in parList)
                {
                    string deptcode = parcode.Substring(0, parcode.Length - 2);
                    string diccode = parcode.Substring(parcode.Length - 2);
                    if (PosLevellist.Where(u => u.DIC_ID.Equals(diccode)).Count() > 0)
                    {
                        SYS_POSLEVEL_DIC dic = PosLevellist.Where(u => u.DIC_ID.Equals(diccode)).FirstOrDefault();
                        listTemp.Add(new SYS_DEPTANDMEMBER()
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
            strJson = ObjToJson.GetToJson(listTreeNodes).Replace("Checked", "checked");
            return strJson;
        }
    }
}