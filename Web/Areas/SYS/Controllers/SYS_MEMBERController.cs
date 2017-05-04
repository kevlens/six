using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Common;
using Common.Attributes;
using Model;
using Web.Areas.Models;
using Web.Areas.ViewModels;
using Web.Controllers;

namespace Web.Areas.SYS.Controllers
{
    public class SYS_MEMBERController : BaseController
    {
        //
        // GET: /SYS/SYS_MEMBER/

        #region 查看人员
        [AjaxRequest]
        [Description("查看人员")]
        [HttpGet]
        public ActionResult Index()
        {
            string ControllerUrl = "/api/SYS/SYS_MEMBER/";
            var viewModel = new
            {
                Permission = new//权限
                {
                    a_list = Model_SYS_MENU.HasPermission("SYS", "SYS_MEMBER", "List", HttpMethod.Post),
                    a_add = Model_SYS_MENU.HasPermission("SYS", "SYS_MEMBER", "Add", HttpMethod.Post),
                    a_edit = Model_SYS_MENU.HasPermission("SYS", "SYS_MEMBER", "Edit", HttpMethod.Get),
                    a_del = Model_SYS_MENU.HasPermission("SYS", "SYS_MEMBER", "Del", HttpMethod.Get),
                    //a_excelin = Model_SYS_MENU.HasPermission("SYS", "SYS_MEMBER", "List", HttpMethod.Post),
                    a_excelout = Model_SYS_MENU.HasPermission("SYS", "SYS_MEMBER", "List", HttpMethod.Post),
                },
                resx = new
                {
                    listTitle = "您没有【查看人员】权限",
                    addTitle = "您没有【新增人员】权限",
                    editTitle = "您没有【编辑人员】权限！",
                    deleteTitle = "您没有【删除人员】权限！",
                },
                urls = new//请求URL
                {
                    save = ControllerUrl + "Save",
                    list = ControllerUrl + "List",
                    edit = ControllerUrl + "Edit",
                    del = ControllerUrl + "Del",
                    writexls = ControllerUrl + "WirteExcel",
                    //readxls = ControllerUrl + "ReadXls",
                    dataGgridName = "data_grid",//列表ID
                    dataGgridType = "datagrid",//列表类型
                    dataAddName = "data_add",//增加窗口
                    dataFormName = "DataForm",//提交表单
                },
                searchForm = new VIEW_SYS_MEMBER()//查询
                {
                },
                addForm = new VIEW_SYS_MEMBER()
                { //添加修改
                },
                extForm = new//扩展类
                {
                    extA = Model_SYS_DEPT.GetMyDEPTTree(oc.CurrentUser.SYS_DEPT.DEPT_CODE, oc.CurrentUser.SYS_DEPT.PARENT_CODE),//部门列表
                    extB = Model_SYS_INTELLIGENCE_DIC.GetIntelligenceDic(),//资质
                    //extC = Model_SYS_POSLEVEL_DIC.GetPosLevelDic(oc.CurrentUser.SYS_DEPT.DEPT_CODE,oc.CurrentUser.SYS_DEPT.PARENT_CODE),//级别
                    extC = Model_SYS_POSLEVEL_DIC.GetPosLevelDic(),//级别
                    extE = new List<EasyUIComBoBoxNode>()//手机状态
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
            AjaxMsgModel amm = new Message().NewAmm;
            amm.Msg = "导入文件格式不正确！";

            #region 第一步EXCEL转DT
            int rowindex = 2;//开始行
            int sheetindex = 0;//工作表索引
            amm = new ExcelHelper().ToDataTable(System.Web.HttpContext.Current.Request.Files, sheetindex, rowindex, amm);
            if (amm.Statu == AjaxStatu.err)//如果转DT不成功
            {
                return ObjToJson.GetToJson(amm, true);
            }
            DataTable dt = amm.Data as DataTable;
            amm.Data = null;
            #endregion

            #region 第二步DT转LIST
            amm = DataTableToList<SYS_MEMBER>.ConvertToList(dt, rowindex, amm);//转换为LIST集合
            if (amm.Statu == AjaxStatu.err)//如果转LIST不成功
            {
                return ObjToJson.GetToJson(amm, true);
            }
            List<SYS_MEMBER> list_SYS_MEMBER = amm.Data as List<SYS_MEMBER>;
            amm.Data = null;
            #endregion

            #region 第三步业务判断并插入数据库

            //错误集合
            List<TableToListErrorModel> errorList = new List<TableToListErrorModel>();
            int rowline = 0;
            foreach (SYS_MEMBER member in list_SYS_MEMBER)
            {
                rowline++;
                if (member.NAME == "")//如果没有姓名
                {
                    amm.Statu = AjaxStatu.err;
                    errorList.Add(
                    new TableToListErrorModel()
                    {
                        rowIndex = rowindex + rowline,
                        columnIndex = 0,//dt.Columns.IndexOf(tempName) + 1
                        errorInfo = "姓名必须输入",
                        errorCause = "姓名必须输入"
                    });
                }

            }
            if (amm.Statu == AjaxStatu.err)//如果不存在
            {
                amm.Data = errorList;
                return ObjToJson.GetToJson(amm, true);
            }
            //业务判断并插入数据库 
            return ObjToJson.GetToJson(Model_SYS_MEMBER.AddList(list_SYS_MEMBER), true);
            #endregion
        }
        #endregion

        #region 获取用户所属权限下的部门资质人员树
        [HttpPost]
        [AjaxRequest]
        [Skip]
        [Description("获取用户所属权限下的部门资质人员树")]
        public ActionResult GetORGMemberIntelligenceCheckedTree()
        {
            bool isCheckAll = false;
            isCheckAll = Model_SYS_MENU.HasPermission("Scripts", "SYS_MEMBER_POS2", "List", HttpMethod.Get);
            return Content(Model_SYS_MEMBER.GetORGMemberIntelligenceCheckedTree(oc.CurrentUser.SYS_DEPT.DEPT_CODE, oc.CurrentUser.SYS_DEPT.PARENT_CODE, isCheckAll));
        }
        #endregion

        #region 获取级别人员树
        [HttpPost]
        [AjaxRequest]
        [Skip]
        [Description("获取级别人员树树")]
        public ActionResult GetPosLevelCheckedTree()
        {
            bool isCheckAll = false;
            isCheckAll = Model_SYS_MENU.HasPermission("Scripts", "SYS_MEMBER_POS3", "List", HttpMethod.Get);
            return Content(Model_SYS_POSLEVEL_DIC.GetPosLevelCheckedTree(oc.CurrentUser.SYS_DEPT.DEPT_CODE, oc.CurrentUser.SYS_DEPT.PARENT_CODE, isCheckAll));
        }
        #endregion
    }

    public class SYS_MEMBERApiController : BaseApiController
    {
        #region 查询
        [HttpPost]//查询
        public ViewModel List(VIEW_SYS_MEMBER data)
        {
            int pageSize = int.Parse(data.rows);
            int pageIndex = int.Parse(data.page);
            string sort = data.sort;
            string order = data.order;

            //查询条件
            IQueryable<SYS_MEMBER> SYS_MEMBEREntity = oc.BllSession.ISYS_MEMBERService.Entities;
            if (!string.IsNullOrEmpty(data.MOBILE))
            {
                SYS_MEMBEREntity = SYS_MEMBEREntity.Where(u => u.MOBILE.Contains(data.MOBILE) && u.DEL_FLAG == "0");
            }
            else
            {
                if (data.DEPT_CODE != null && data.DEPT_CODE != "")
                {
                    SYS_MEMBEREntity = SYS_MEMBEREntity.Where(u => u.DEPT_CODE.StartsWith(data.DEPT_CODE) && u.DEL_FLAG == "0");
                }
                else
                {
                    SYS_MEMBEREntity = SYS_MEMBEREntity.Where(u => u.DEPT_CODE.StartsWith(oc.CurrentUser.SYS_DEPT.DEPT_CODE) && u.DEL_FLAG == "0");
                }
            }
            int total = 0;

            total = SYS_MEMBEREntity.Count();
            var listMEMBER = SYS_MEMBEREntity.OrderBy(u => u.DEPT_CODE)
                                                       .Skip(pageSize * (pageIndex - 1)).Take(pageSize).Select(mb =>
                                                        new
                                                        {
                                                            MEMBER_ID = mb.MEMBER_ID,
                                                            deptname = mb.SYS_DEPT.DEPT_NAME,
                                                            depticon = mb.SYS_DEPT.C_ICO,
                                                            deptcode = mb.SYS_DEPT.DEPT_CODE,
                                                            name = mb.NAME,
                                                            mobile = mb.MOBILE,
                                                            update = mb.UPDATE_DATE,
                                                            upuser = mb.UPDATE_USER,
                                                            job = mb.JOB,
                                                            phone = mb.PHONE,
                                                            loctionflag = mb.LOCATION_FLAG,
                                                            intelligence=mb.SYS_INTELLIGENCE_DIC.DIC_NAME,
                                                            poslevel = mb.SYS_POSLEVEL_DIC.DIC_NAME,
                                                            state = mb.MOBILE_STATE
                                                        }
                                                        ).ToList();

            //return ObjToJson.GetToJson(listMenu, total, true);
            return ObjToJson.ViewModelToJson(listMEMBER, total);
        }
        #endregion

        #region 修改
        [HttpPost]
        public AjaxMsgModel Edit(VIEW_SYS_MEMBER data)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            try
            {
                SYS_MEMBER member = oc.BllSession.ISYS_MEMBERService.Entities.Where(m => m.DEL_FLAG == "0" && m.MEMBER_ID == data.MEMBER_ID).OrderBy(m => m.UPDATE_DATE).FirstOrDefault();

                if (member != null)
                {
                    Mapper.CreateMap<SYS_MEMBER, VIEW_SYS_MEMBER>();
                    VIEW_SYS_MEMBER vm = Mapper.Map<SYS_MEMBER, VIEW_SYS_MEMBER>(member);
                    vm.LOCATION_FLAG_EXT = vm.LOCATION_FLAG == "1" ? true : false;
                    amm.Statu = AjaxStatu.ok;
                    amm.Data = vm;
                    return amm;
                }
                else
                {
                    amm.Msg = string.Format(Message.NotFound, "人员");
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
        public AjaxMsgModel Save(VIEW_SYS_MEMBER data)
        {
            try
            {
                Mapper.CreateMap<VIEW_SYS_MEMBER, SYS_MEMBER>();
                SYS_MEMBER u = Mapper.Map<VIEW_SYS_MEMBER, SYS_MEMBER>(data);

                u.UPDATE_DATE = DateTime.Now;
                u.UPDATE_USER = oc.CurrentUser.USER_NAME;
                u.DEL_FLAG = "0";
                u.LOCATION_FLAG = data.LOCATION_FLAG_EXT ? "1" : "0";

                if (u.MEMBER_ID == null || u.MEMBER_ID == "")
                {
                    u.MEMBER_ID = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                    u.MOBILE_STATE = "0";//新增手机默认正常状态
                    return Model_SYS_MEMBER.Add(u);
                }
                else
                {
                    return Model_SYS_MEMBER.Edit(u);
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
        public AjaxMsgModel Del(VIEW_SYS_MEMBER data)
        {
            return Model_SYS_MEMBER.Del(data.MEMBER_ID);
        }
        #endregion

        #region 导出EXCEL
        [HttpPost]
        public AjaxMsgModel WirteExcel(VIEW_SYS_MEMBER data)
        {
            AjaxMsgModel amm = new Message().NewAmm;
            //查询条件
            IQueryable<SYS_MEMBER> SYS_MEMBEREntity = oc.BllSession.ISYS_MEMBERService.Entities;
            if (data.DEPT_CODE != null && data.DEPT_CODE != "")
            {
                SYS_MEMBEREntity = SYS_MEMBEREntity.Where(u => u.DEPT_CODE.StartsWith(data.DEPT_CODE) && u.DEL_FLAG == "0");
            }
            else
            {
                SYS_MEMBEREntity = SYS_MEMBEREntity.Where(u => u.DEPT_CODE.StartsWith(oc.CurrentUser.SYS_DEPT.DEPT_CODE) && u.DEL_FLAG == "0");
            }
            if (SYS_MEMBEREntity.Count() > 0)
            {

                List<VIEW_SYS_MEMBER> list_SYS_MEMBER = SYS_MEMBEREntity.OrderBy(u => u.DEPT_CODE)
                                                           .Select(mb => new VIEW_SYS_MEMBER
                                                            {
                                                                MEMBER_ID = mb.MEMBER_ID,
                                                                DEPT_NAME = mb.SYS_DEPT.DEPT_NAME,
                                                                C_ICO = mb.SYS_DEPT.C_ICO,
                                                                DEPT_CODE = mb.SYS_DEPT.DEPT_CODE,
                                                                NAME = mb.NAME,
                                                                MOBILE = mb.MOBILE,
                                                                UPDATE_DATE = mb.UPDATE_DATE,
                                                                UPDATE_USER = mb.UPDATE_USER,
                                                                JOB = mb.JOB,
                                                                PHONE = mb.PHONE,
                                                                LOCATION_FLAG = mb.LOCATION_FLAG=="1"?"是":"否",
                                                                DIC_NAME = mb.SYS_INTELLIGENCE_DIC.DIC_NAME
                                                            }
                                                            ).ToList();

                string sheetName = "人员";
                string path = Path.Combine(HttpContext.Current.Server.MapPath("~/Content/"), "UpLoadExcel");
                string fileName = string.Format("{0}_{1}", "ry", DateTime.Now.ToString("yyyyMMddHHmmssfff"));
                string savePath = path + "\\" + fileName + ".xls";

                if (ExcelHelper.ToExcel(savePath, sheetName, "人员信息", list_SYS_MEMBER, "SYS_MEMBER"))
                {
                    amm.Statu = AjaxStatu.ok;
                    amm.Msg = "导出成功！";
                    amm.BackUrl = "/Base/DownloadExcel/" + fileName;
                }
            }
            else
            {
                amm.Msg = "没有数据，无法导出！";
            }
            return amm;
        }
        #endregion

    }
}
