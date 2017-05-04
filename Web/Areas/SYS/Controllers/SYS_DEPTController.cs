using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Transactions;
using System.Web.Mvc;
using AutoMapper;
using Common;
using Common.Attributes;
using Model;
using SxShWeb.Areas.Models;
using SxShWeb.Areas.ViewModels;
using SxShWeb.Controllers;

namespace SxShWeb.Areas.SYS.Controllers
{
    public class SYS_DEPTController : BaseController
    {
        #region 查看部门
        [AjaxRequest]
        [Description("查看部门")]
        [HttpGet]
        public ActionResult Index()
        {
            string ControllerUrl = "/api/SYS/SYS_DEPT/";
            var viewModel = new
            {
                Permission = new//权限
                {
                    a_list = Model_SYS_MENU.HasPermission("SYS", "SYS_DEPT", "List", Common.HttpMethod.Post),
                    a_add = Model_SYS_MENU.HasPermission("SYS", "SYS_DEPT", "Add", Common.HttpMethod.Post),
                    a_edit = Model_SYS_MENU.HasPermission("SYS", "SYS_DEPT", "Edit", Common.HttpMethod.Get),
                    a_del = Model_SYS_MENU.HasPermission("SYS", "SYS_DEPT", "Del", Common.HttpMethod.Get),
                    a_excelin = oc.CurrentUser.USER_NAME=="sxsh"?true:false
                    //a_excelout = Model_SYS_MENU.HasPermission("SYS", "SYS_DEPT", "List", Common.HttpMethod.Post)
                },
                resx = new
                {
                    listTitle = "您没有【查看部门】权限",
                    addTitle = "您没有【新增部门】权限",
                    editTitle = "您没有【编辑部门】权限！",
                    deleteTitle = "您没有【删除部门】权限！"
                },
                urls = new//请求URL
                {
                    save = ControllerUrl + "Save",
                    list = ControllerUrl + "List",
                    edit = ControllerUrl + "Edit",
                    del = ControllerUrl + "Del",
                    //writexls = ControllerUrl + "WirteExcel",
                    readxls = ControllerUrl + "ReadXls",
                    dataGgridName = "data_grid",//列表ID
                    dataGgridType = "treegrid",//列表类型
                    dataAddName = "data_add",//增加窗口
                    //titleName="sss",
                    dataFormName = "DataForm",//提交表单
                },
                searchForm = new VIEW_SYS_DEPT()//查询
                {
                },
                addForm = new VIEW_SYS_DEPT()
                { //添加修改
                },
                extForm = new//扩展类
                {
                    extA = Model_SYS_DEPT.GetMyORGNoGQTree(oc.CurrentUser.SYS_DEPT.DEPT_CODE, oc.CurrentUser.SYS_DEPT.PARENT_CODE),//部门列表
                    extB = new List<EasyUIComBoBoxNode>() { new EasyUIComBoBoxNode(){id="0",text="单位"},new EasyUIComBoBoxNode(){id="1",text="部门"}}
                }
            };
            return View(viewModel);
        } 
        #endregion


        #region 导入EXCEL
        [HttpPost]
        [Skip]
        public ActionResult ReadXls()
        {
            //本功能只支持一次全部部门和人员导入，不适合追加和修改


            AjaxMsgModel amm = new Message().NewAmm;
            amm.Msg = "导入文件格式不正确！";

            #region 第一步EXCEL转DT
            int rowindex = 2;//开始行
            int sheetindex = 0;//工作表索引
            amm = new ExcelExtHelper().ToDataTable(System.Web.HttpContext.Current.Request.Files, sheetindex, rowindex, amm);
            if (amm.Statu == AjaxStatu.err)//如果转DT不成功
            {
                return ObjToJson.GetToJson(amm, true);
            }
            DataTable dt = amm.Data as DataTable;
            amm.Data = null;
            #endregion

            #region 第二步DT转LIST

            amm = DataTableToList<VIEW_SYS_DEPT>.ConvertToList(dt, rowindex, amm);//转换为LIST集合
            if (amm.Statu == AjaxStatu.err)//如果转LIST不成功
            {
                return ObjToJson.GetToJson(amm, true);
            }
            List<VIEW_SYS_DEPT> list_VIEW_SYS_DEPT = amm.Data as List<VIEW_SYS_DEPT>;
            amm.Data = null;
            #endregion

            #region 第三步业务判断并插入数据库
            List<SYS_DEPT> list_SYS_DEPT = new List<SYS_DEPT>();
            List<SYS_MEMBER> list_SYS_MEMBER = new List<SYS_MEMBER>();
            Dictionary<string, string> DeptCodeMap = new Dictionary<string, string>();
            Dictionary<string, string> MemberIntelligenceMap = new Dictionary<string, string>();
            List<SYS_INTELLIGENCE_DIC> lisMI = oc.BllSession.ISYS_INTELLIGENCE_DICService.Entities.ToList();
            foreach (SYS_INTELLIGENCE_DIC item in lisMI)
            {
                MemberIntelligenceMap.Add(item.DIC_NAME, item.DIC_ID);
            }
            //错误集合
            //List<TableToListErrorModel> errorList = new List<TableToListErrorModel>();
            //int rowline = 0;
            if (list_VIEW_SYS_DEPT.Count > 0)
            {
                try
                {
                    //局
                    List<VIEW_SYS_DEPT> listDEPT = list_VIEW_SYS_DEPT.Where(u=>u.DEPT_NAME!="" && u.DEPT_CODE!="").GroupBy(u => new { u.DEPT_NAME, u.DEPT_CODE })
                                 .Select(g => new VIEW_SYS_DEPT { DEPT_CODE = g.Key.DEPT_CODE, DEPT_NAME = g.Key.DEPT_NAME }).ToList();

                    if (listDEPT.Count > 0)
                    {
                        foreach (VIEW_SYS_DEPT jgs in listDEPT)
                        {
                            if (oc.BllSession.ISYS_DEPTService.Entities.Where(u => u.DEPT_CODE == jgs.DEPT_CODE).Count() == 0)
                            {//如果数据库无此部门编码则添加
                                list_SYS_DEPT.Add(new SYS_DEPT()//局
                                {
                                    DEPT_CODE = jgs.DEPT_CODE,
                                    DEPT_NAME = jgs.DEPT_NAME,
                                    PARENT_CODE = "0",
                                    DEPT_ORDER = 0,
                                    DEL_FLAG = "0",
                                    STATUS_FLAG = "0",
                                    C_ICO = "icon-DepartMent",
                                    DEPT_FLAG = 0
                                });
                            }
                            DeptCodeMap.Add(jgs.DEPT_NAME, jgs.DEPT_CODE);
                        }
                    }

                    //工务段
                    List<VIEW_SYS_DEPT> listDEPT_GWD = list_VIEW_SYS_DEPT.Where(u => u.DEPT_NAME != "" && u.DEPT_CODE != "" && u.GWD_NAME != "" && u.GWD_CODE != "")
                                            .GroupBy(u => new { u.DEPT_NAME, u.DEPT_CODE, u.GWD_NAME, u.GWD_CODE })
                                 .Select(g => new VIEW_SYS_DEPT { DEPT_NAME = g.Key.DEPT_NAME, GWD_NAME = g.Key.GWD_NAME, GWD_CODE = g.Key.GWD_CODE }).ToList();

                    if (listDEPT_GWD.Count > 0)
                    {
                        foreach (VIEW_SYS_DEPT gwd in listDEPT_GWD)
                        {
                            if (oc.BllSession.ISYS_DEPTService.Entities.Where(u => u.DEPT_CODE == gwd.GWD_CODE).Count() == 0)
                            {//如果数据库无此部门编码则添加
                                list_SYS_DEPT.Add(new SYS_DEPT()//段
                                {
                                    DEPT_CODE = gwd.GWD_CODE,
                                    DEPT_NAME = gwd.GWD_NAME,
                                    PARENT_CODE = gwd.GWD_CODE.Substring(0, 2),
                                    DEPT_ORDER = 0,
                                    DEL_FLAG = "0",
                                    STATUS_FLAG = "0",
                                    C_ICO = "icon-DepartMent",
                                    DEPT_FLAG = 0
                                });
                            }
                            DeptCodeMap.Add(gwd.DEPT_NAME + "_" + gwd.GWD_NAME, gwd.GWD_CODE);
                        }
                    }

                    //虚拟目录列
                    List<VIEW_SYS_DEPT> listDEPT_XN = list_VIEW_SYS_DEPT.Where(u => u.DEPT_NAME != "" && u.DEPT_CODE != "" && u.GWD_NAME != "" && u.GWD_CODE != "" && u.XN_NAME != "")
                                .OrderBy(u => u.GWD_CODE).GroupBy(u => new { u.DEPT_NAME, u.DEPT_CODE, u.GWD_NAME, u.GWD_CODE, u.XN_NAME })
                                 .Select(g => new VIEW_SYS_DEPT { DEPT_NAME = g.Key.DEPT_NAME, GWD_NAME = g.Key.GWD_NAME, XN_NAME = g.Key.XN_NAME, GWD_CODE = g.Key.GWD_CODE }).ToList();

                    if (listDEPT_XN.Count > 0)
                    {
                        string gwdcode = "";
                        int i = 1;
                        foreach (VIEW_SYS_DEPT xn in listDEPT_XN)
                        {
                            if (gwdcode != xn.GWD_CODE)//如果是新父级，则重新编号
                            {
                                i = 1;
                                gwdcode = xn.GWD_CODE;
                            }
                            string xnNum = i < 10 ? "0" + i.ToString() : i.ToString();
                            string xncode = xn.GWD_CODE + xnNum;
                            if (oc.BllSession.ISYS_DEPTService.Entities.Where(u => u.DEPT_CODE == xncode).Count() == 0)
                            {//如果数据库无此部门编码则添加
                                list_SYS_DEPT.Add(new SYS_DEPT()//虚拟目录列
                                {
                                    DEPT_CODE = xn.GWD_CODE + xnNum,
                                    DEPT_NAME = xn.XN_NAME,
                                    PARENT_CODE = xn.GWD_CODE,
                                    DEPT_ORDER = 0,
                                    DEL_FLAG = "0",
                                    STATUS_FLAG = "0",
                                    C_ICO = "icon-DepartMent",
                                    DEPT_FLAG = 0
                                });
                            }
                            DeptCodeMap.Add(xn.DEPT_NAME + "_" + xn.GWD_NAME + "_" + xn.XN_NAME, xn.GWD_CODE + xnNum);
                            i++;
                        }
                    }

                    //车间
                    List<VIEW_SYS_DEPT> listDEPT_CJ = list_VIEW_SYS_DEPT.Where(u => u.DEPT_NAME != "" && u.DEPT_CODE != "" && u.GWD_NAME != "" && u.GWD_CODE != "" && u.XN_NAME != "" && u.CJ_NAME != "")
                                    .OrderBy(u => u.XN_NAME).GroupBy(u => new { u.DEPT_NAME, u.DEPT_CODE, u.GWD_NAME, u.GWD_CODE, u.XN_NAME, u.CJ_NAME })
                                 .Select(g => new VIEW_SYS_DEPT { DEPT_NAME = g.Key.DEPT_NAME, GWD_NAME = g.Key.GWD_NAME, XN_NAME = g.Key.XN_NAME, CJ_NAME = g.Key.CJ_NAME }).ToList();

                    if (listDEPT_CJ.Count > 0)
                    {
                        string xnname = "";
                        int j = 1;
                        foreach (VIEW_SYS_DEPT cj in listDEPT_CJ)
                        {
                            try
                            {
                                if (xnname != cj.XN_NAME)//如果是新父级，则重新编号
                                {
                                    j = 1;
                                    xnname = cj.XN_NAME;
                                }
                                string cjNum = j < 10 ? "0" + j.ToString() : j.ToString();
                                string cjcode = DeptCodeMap[cj.DEPT_NAME + "_" + cj.GWD_NAME + "_" + cj.XN_NAME] + cjNum;
                                if (oc.BllSession.ISYS_DEPTService.Entities.Where(u => u.DEPT_CODE == cjcode).Count() == 0)
                                {//如果数据库无此部门编码则添加
                                    list_SYS_DEPT.Add(new SYS_DEPT()//车间
                                    {
                                        DEPT_CODE = DeptCodeMap[cj.DEPT_NAME + "_" + cj.GWD_NAME + "_" + cj.XN_NAME] + cjNum,
                                        DEPT_NAME = cj.CJ_NAME,
                                        PARENT_CODE = DeptCodeMap[cj.DEPT_NAME + "_" + cj.GWD_NAME + "_" + cj.XN_NAME],
                                        DEPT_ORDER = 0,
                                        DEL_FLAG = "0",
                                        STATUS_FLAG = "0",
                                        C_ICO = "icon-DepartMent",
                                        DEPT_FLAG = 0
                                    });
                                }
                                DeptCodeMap.Add(cj.DEPT_NAME + "_" + cj.GWD_NAME + "_" + cj.XN_NAME + "_" + cj.CJ_NAME, DeptCodeMap[cj.DEPT_NAME + "_" + cj.GWD_NAME + "_" + cj.XN_NAME] + cjNum);
                                j++;
                            }
                            catch (Exception ex)
                            {
                                string a = cj.CJ_NAME;
                                throw ex;
                            }
                            
                        }
                    }
                    //工区
                    List<VIEW_SYS_DEPT> listDEPT_GQ = list_VIEW_SYS_DEPT.Where(u => u.DEPT_NAME != "" && u.DEPT_CODE != "" && u.GWD_NAME != "" && u.GWD_CODE != "" && u.XN_NAME != "" && u.GQ_NAME != "" && u.CJ_NAME != "")
                                                      .OrderBy(u => u.CJ_NAME).GroupBy(u => new { u.DEPT_NAME, u.DEPT_CODE, u.GWD_NAME, u.GWD_CODE, u.XN_NAME, u.GQ_NAME, u.CJ_NAME })
                                 .Select(g => new VIEW_SYS_DEPT { DEPT_NAME = g.Key.DEPT_NAME, GWD_NAME = g.Key.GWD_NAME, XN_NAME = g.Key.XN_NAME, GQ_NAME = g.Key.GQ_NAME, CJ_NAME = g.Key.CJ_NAME }).ToList();

                    if (listDEPT_GQ.Count > 0)
                    {
                        string cjname = "";
                        int m = 1;
                        foreach (VIEW_SYS_DEPT gq in listDEPT_GQ)
                        {
                            if (cjname != gq.CJ_NAME)//如果是新父级，则重新编号
                            {
                                m = 1;
                                cjname = gq.CJ_NAME;
                            }

                            string gqNum = m < 10 ? "0" + m.ToString() : m.ToString();
                            string gqcode = DeptCodeMap[gq.DEPT_NAME + "_" + gq.GWD_NAME + "_" + gq.XN_NAME + "_" + gq.CJ_NAME] + gqNum;
                            if (oc.BllSession.ISYS_DEPTService.Entities.Where(u => u.DEPT_CODE == gqcode).Count() == 0)
                            {//如果数据库无此部门编码则添加
                                list_SYS_DEPT.Add(new SYS_DEPT()//车间
                                {
                                    DEPT_CODE = DeptCodeMap[gq.DEPT_NAME + "_" + gq.GWD_NAME + "_" + gq.XN_NAME + "_" + gq.CJ_NAME] + gqNum,
                                    DEPT_NAME = gq.GQ_NAME,
                                    PARENT_CODE = DeptCodeMap[gq.DEPT_NAME + "_" + gq.GWD_NAME + "_" + gq.XN_NAME + "_" + gq.CJ_NAME],
                                    DEPT_ORDER = 0,
                                    DEL_FLAG = "0",
                                    STATUS_FLAG = "0",
                                    C_ICO = "icon-org",
                                    DEPT_FLAG=0
                                });
                            }
                            DeptCodeMap.Add(gq.DEPT_NAME + "_" + gq.GWD_NAME + "_" + gq.XN_NAME + "_" + gq.CJ_NAME + "_" + gq.GQ_NAME, DeptCodeMap[gq.DEPT_NAME + "_" + gq.GWD_NAME + "_" + gq.XN_NAME + "_" + gq.CJ_NAME] + gqNum);
                            m++;
                        }
                    }

                    //人员
                    List<VIEW_SYS_DEPT> listDEPT_RY = list_VIEW_SYS_DEPT.Where(u => u.NAME != null && u.MOBILE != null && u.NAME != "" && u.MOBILE != "").ToList();
                    int n = 0;
                    foreach (VIEW_SYS_DEPT member in listDEPT_RY)
                    {
                        if (oc.BllSession.ISYS_MEMBERService.Entities.Where(u => u.MOBILE == member.MOBILE).Count() == 0)
                        {//如果数据库无此手机号则添加
                            list_SYS_MEMBER.Add(new SYS_MEMBER()//车间
                            {
                                MEMBER_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff")+n.ToString(),
                                DEPT_CODE = DeptCodeMap[getCode(member)],
                                NAME = member.NAME,
                                MOBILE = member.MOBILE,
                                INTELLIGENCE = member.INTELLIGENCE==""?"": MemberIntelligenceMap[member.INTELLIGENCE],
                                UPDATE_DATE = DateTime.Now,
                                UPDATE_USER = oc.CurrentUser.USER_NAME,
                                DEL_FLAG = "0",
                                LOCATION_FLAG = "1",
                                JOB=member.JOB
                            });
                        }
                        n++;
                    }
                }
                catch (Exception e)
                {
                    amm.Msg = "解析错误或资质名称不匹配";
                    amm.Statu = AjaxStatu.err;
                }
            }
            if (amm.Statu == AjaxStatu.err)//如果不存在
            {
                //amm.Data = errorList;
                return ObjToJson.GetToJson(amm, true);
            }
            //业务判断并插入数据库 

            int returnValue = 0;
            using (TransactionScope ts = new TransactionScope())
            {
                returnValue = oc.BllSession.ISYS_DEPTService.AddListEntity(list_SYS_DEPT);
                returnValue = returnValue + oc.BllSession.ISYS_MEMBERService.AddListEntity(list_SYS_MEMBER);
                ts.Complete();
            }
            if (list_SYS_DEPT.Count == 0 && list_SYS_MEMBER.Count == 0)
            {
                returnValue = 1;
            }
            if (returnValue > 0)
            {
                amm.Statu = AjaxStatu.ok;
                amm.Msg = "导入成功部门" + list_SYS_DEPT.Count + "-人员" + list_SYS_MEMBER.Count;
            }
            else
            {
                amm.Statu = AjaxStatu.err;
                amm.Msg = "导入失败";
            }
            return ObjToJson.GetToJson(amm, true);
            #endregion
        }
        private string getCode(VIEW_SYS_DEPT member)
        {
            string key = "";
            if (member.DEPT_NAME != "")
            {
                key = member.DEPT_NAME;
            }
            if (member.GWD_NAME != "")
            {
                if (key != "")
                {
                    key += "_";
                }
                key += member.GWD_NAME;
            }
            if (member.XN_NAME != "")
            {
                if (key != "")
                {
                    key += "_";
                }
                key += member.XN_NAME;
            }
            if (member.CJ_NAME != "")
            {
                if (key != "")
                {
                    key += "_";
                }
                key += member.CJ_NAME;
            }
            if (member.GQ_NAME != "")
            {
                if (key != "")
                {
                    key += "_";
                }
                key += member.GQ_NAME;
            }
            return key;
        }
        #endregion
    }

    public class SYS_DEPTApiController : BaseApiController
    {
        #region 查看我的组织机构除工区树
        [System.Web.Http.HttpPost]
        public List<Model.ModelExt.EasyUITreeNode> GetMyORGNoGQTree(VIEW_SYS_DEPT data)
        {
            return Model_SYS_DEPT.GetMyORGNoGQTree(oc.CurrentUser.SYS_DEPT.DEPT_CODE, oc.CurrentUser.SYS_DEPT.PARENT_CODE);//部门列表
        } 
        #endregion

        #region 查询
        [HttpPost]//查询
        public List<EasyUIDEPTTree> List(VIEW_SYS_DEPT data)
        {
            string dept_code = oc.CurrentUser.SYS_DEPT.DEPT_CODE;
            string parent_code = oc.CurrentUser.SYS_DEPT.PARENT_CODE;
            //查询条件
            if (data !=null && data.PARENT_CODE != null && data.PARENT_CODE != "")
            {
                dept_code = data.PARENT_CODE;
                if (dept_code.Length > 2)
                {
                    parent_code = dept_code.Substring(0, dept_code.Length - 2);
                }
            }
            //if (dept_code == "01")
            //{
            //    dept_code = "0101";
            //    parent_code = "01";
            //}
            Expression<Func<SYS_DEPT, bool>> slamda = m => m.DEL_FLAG == "0" && (m.PARENT_CODE.StartsWith(dept_code) || m.DEPT_CODE == dept_code);
            string strJson = string.Empty;
            //获得组织
            List<SYS_DEPT> listOrgMenu = oc.BllSession.ISYS_DEPTService.Entities.Where(slamda).OrderBy(m => m.DEPT_ORDER).ThenBy(m=>m.DEPT_CODE)
                                                .ToList().Select(org => org.ToPOCO()).ToList();
            List<EasyUIDEPTTree> listTreeNodes = SYS_DEPT.ConvertTreeNodes(listOrgMenu, parent_code, dept_code);
            return listTreeNodes;
        }
        #endregion

        #region 修改
        [HttpPost]
        public AjaxMsgModel Edit(VIEW_SYS_DEPT data)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                SYS_DEPT member = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.DEPT_CODE == data.DEPT_CODE).OrderBy(m => m.DEPT_CODE).FirstOrDefault();

                if (member != null)
                {
                    Mapper.CreateMap<SYS_DEPT, VIEW_SYS_DEPT>();
                    VIEW_SYS_DEPT vm = Mapper.Map<SYS_DEPT, VIEW_SYS_DEPT>(member);
                    amm.Statu = AjaxStatu.ok;
                    amm.Data = vm;
                    return amm;
                }
                else
                {
                    amm.Msg = string.Format(Message.NotFound, "部门");
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
        public AjaxMsgModel Save(VIEW_SYS_DEPT data)
        {
            try
            {
                Mapper.CreateMap<VIEW_SYS_DEPT, SYS_DEPT>();
                SYS_DEPT u = Mapper.Map<VIEW_SYS_DEPT, SYS_DEPT>(data);


                //最后一个DEPT_CODE
                var lastCode = oc.BllSession.ISYS_DEPTService.Entities.Where(m => m.PARENT_CODE == data.PARENT_CODE).OrderByDescending(m => m.DEPT_CODE).Select(m => new { m.DEPT_CODE }).FirstOrDefault();
                int lastCodeId = 1;
                if (lastCode != null)
                {
                    lastCodeId = int.Parse(lastCode.DEPT_CODE.Substring(data.PARENT_CODE.Length, 2)) + 1;
                }
                string codeNum = lastCodeId < 10 ? "0" + lastCodeId.ToString() : lastCodeId.ToString();
                
                u.DEL_FLAG = "0";
                u.STATUS_FLAG="0";
                u.C_ICO = data.PARENT_CODE.Length == 8 ? "icon-org" : "icon-DepartMent";

                if (u.DEPT_CODE == null || u.DEPT_CODE == "")
                {
                    u.DEPT_CODE = data.PARENT_CODE + codeNum;
                    u.DEPT_ORDER = 1;
                    return Model_SYS_DEPT.Add(u);
                }
                else
                {
                    string newDeptCode = data.PARENT_CODE + codeNum;
                    return Model_SYS_DEPT.Edit(u, u.DEPT_CODE, newDeptCode);
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
        public AjaxMsgModel Del(VIEW_SYS_DEPT data)
        {
            return Model_SYS_DEPT.Del(data.DEPT_CODE);
        }
        #endregion
    }
}
