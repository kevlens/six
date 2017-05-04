using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Linq.Expressions;
using System.Collections;
using Common;
using System.Transactions;
using System.Threading.Tasks;
using Model;
using SxShWeb.Controllers;
using SxShWeb.Areas.ViewModels;
using System.ComponentModel;
using Newtonsoft.Json;
using Model.ModelExt;

namespace SxShWeb.Areas.SYS.Controllers
{
    public class BaseInfoApiController : BaseApiController
    {
        private List<SYS_DEPT> deptList = new List<SYS_DEPT>();
        private List<SYS_MEMBER> memberList = new List<SYS_MEMBER>();
        private object deptobj = new object();
        private object memberobj = new object();
        #region UI层与Service之间操作的上下文
        protected OperContext oc = OperContext.CurrentContext;
        #endregion

        [HttpPost]
        public IEnumerable<object> GetDeptInfo([FromBody]string dept_code)
        {
            deptList = new List<SYS_DEPT>();
            if (GetDept(dept_code))
            {
                deptList.Distinct();
                var list = deptList.Select(o =>
                    new
                    {
                        DEPT_CODE = o.DEPT_CODE,
                        DEPT_NAME = o.DEPT_NAME,
                        PARENT_CODE = o.PARENT_CODE,
                        STATUS_FLAG = o.STATUS_FLAG,
                        DEL_FLAG = o.DEL_FLAG,
                        NOTE = o.NOTE,
                        DEPT_ORDER = o.DEPT_ORDER,
                    });
                return list;
            }
            return null;
        }
        private bool GetDept(string code)
        {
            try
            {
                lock (deptobj)
                {
                    deptList.AddRange(oc.BllSession.ISYS_DEPTService.Entities.Where(o => o.DEPT_CODE == code));
                    var list = oc.BllSession.ISYS_DEPTService.Entities.Where(o => o.PARENT_CODE == code);
                    deptList.AddRange(list);
                    if (list.Count() > 0)
                    {
                        foreach (var item in list)
                        {
                            GetDept(item.DEPT_CODE);
                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                RecordLog.RecordException(ex);
                return false;
            }
        }


        [HttpPost]
        [Description("获取记录仪基础数据")]
        public IEnumerable<object> GetENFORCEMENT_BDATAInfo([FromBody] string dept_code)
        {
            return oc.BllSession.IENFORCEMENT_BDATAService.Entities.Where(o => o.DEPT_CODE.StartsWith(dept_code))
                 .Select(o => new
                 {
                     DEPT_CODE = o.DEPT_CODE,
                     DEVICE_CODE = o.DEVICE_CODE,
                     PKID = o.PKID,
                     NAME = o.NAME,
                     PHONE = o.PHONE
                 });
        }

        [HttpPost]
        [Description("获取人员基础信息")]
        public IEnumerable<object> GetMemberInfo([FromBody]string dept_code)
        {
            memberList = new List<SYS_MEMBER>();
            if (GetMember(dept_code))
            {
                memberList.Distinct();
                var list = memberList.Select(o =>
                    new
                    {
                        MEMBER_ID = o.MEMBER_ID,
                        NAME = o.NAME,
                        MOBILE = o.MOBILE,
                        JOB = o.JOB,
                        PHONE = o.PHONE,
                        NOTE = o.NOTE,
                        DEPT_CODE = o.DEPT_CODE,
                        DEL_FLAG = o.DEL_FLAG,
                        LOCATION_FLAG = o.LOCATION_FLAG,
                        INTELLIGENCE = o.INTELLIGENCE,
                    });
                return list;
            }
            return null;
        }
        private bool GetMember(string code)
        {
            try
            {
                lock (memberobj)
                {
                    memberList.AddRange(oc.BllSession.ISYS_MEMBERService.Entities.Where(o => o.DEPT_CODE == code));
                    var list = oc.BllSession.ISYS_DEPTService.Entities.Where(o => o.PARENT_CODE == code);

                    if (list.Count() > 0)
                    {
                        foreach (var item in list)
                        {
                            memberList.AddRange(oc.BllSession.ISYS_MEMBERService.Entities.Where(o => o.DEPT_CODE == item.DEPT_CODE));
                            GetMember(item.DEPT_CODE);
                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                RecordLog.RecordException(ex);
                return false;
            }

        }

        [HttpPost]
        public bool SendDownIdToServer(string id)
        {

            return false;
        }
        [HttpPost]
        public IEnumerable<T_MOBILEFILE> GetDownInfo([FromBody]string datas)
        {
            string[] t = datas.Split('|');

            Dictionary<string, List<T_MOBILEFILE>> list = new Dictionary<string, List<T_MOBILEFILE>>();
            if (Constant.DownList.TryGetValue(t[0], out list))
            {
                List<T_MOBILEFILE> fileList = new List<T_MOBILEFILE>();
                if (list.TryGetValue(t[1], out fileList))
                {
                    return fileList;
                }
            }
            return null;
        }
        [HttpPost]
        [Description("获取人员和记录仪下载的文件")]
        public IEnumerable<T_MOBILEFILE> GetDownFileInfo([FromBody]string data)
        {
            string[] t = data.Split('|');
            DateTime sdate = Convert.ToDateTime(t[1]);
            DateTime edate = Convert.ToDateTime(t[2]);
            string dept_code = t[0];
            memberList = new List<SYS_MEMBER>();
            List<string> phone = new List<string>();
            if (!string.IsNullOrEmpty(dept_code))
            {

                var enforcePhone = oc.BllSession.IENFORCEMENT_BDATAService.Entities.Where(o => o.DEPT_CODE.StartsWith(dept_code))
                    .Select(o => o.PHONE).Distinct().ToList();
                var memberPhone = oc.BllSession.ISYS_MEMBERService.Entities.Where(o => o.DEPT_CODE.StartsWith(dept_code))
                    .Select(o => o.MOBILE).Distinct().ToList();

                phone = enforcePhone.Concat(memberPhone).Distinct().ToList();
                var list = oc.BllSession.IT_MOBILEFILEService.Entities
                    .Where(o => o.时间 > sdate
                        && o.时间 <= edate && phone.Contains(o.手机号));
                return list;
            }
            //if (GetMember(t[0]))
            //{
            //    memberList.Distinct();
            //    phone = memberList.Select(o=>o.MOBILE).ToList();
            //    var list = oc.BllSession.IT_MOBILEFILEService.Entities
            //        .Where(o => o.时间 > sdate
            //            && o.时间 <= edate && phone.Contains(o.手机号));

            //    return list;
            //}
            return null;
        }

        [HttpPost]
        [Description("通过手机号获取拼音码-车站名")]
        public IEnumerable<object> GetStationInfoByPhone([FromBody] string phone)
        {
            if (string.IsNullOrEmpty(phone)) return null;
            var member = oc.BllSession.ISYS_MEMBERService.Entities.Where(o => o.MOBILE == phone && o.DEL_FLAG.Equals("0")).FirstOrDefault();
            if (member != null)
            {
                var dept = oc.BllSession.ISYS_DEPTService.Entities.Where(o => o.DEPT_CODE == member.DEPT_CODE).FirstOrDefault();
                if (dept != null)
                {
                    string resultCode = string.Empty;
                    if (dept.DEPT_CODE.Length == 2)
                    {
                        resultCode = dept.DEPT_CODE;
                        return oc.BllSession.IT_GIS_STATIONService.Entities.Where(o => o.工务段编码.StartsWith(resultCode))
                                .ToList().Select(o => new
                                {
                                    PKID = o.车站编码,
                                    pymSTATIONAME = SpellCode.GetSpellCode(o.车站) + "-" + o.车站
                                }).DistinctBy(o => o.pymSTATIONAME).OrderBy(o => o.pymSTATIONAME);
                    }
                    else
                    {
                        int count = -1;
                        resultCode = dept.DEPT_CODE;
                        do
                        {
                            try
                            {
                                count = oc.BllSession.IT_GIS_STATIONService.Entities.Where(o => o.工务段编码.StartsWith(resultCode)).Count();
                                if (count > 0)
                                {
                                    return oc.BllSession.IT_GIS_STATIONService.Entities.Where(o => o.工务段编码.StartsWith(resultCode))
                                                .ToList().Select(o => new
                                                {
                                                    PKID = o.车站编码,
                                                    pymSTATIONAME = SpellCode.GetSpellCode(o.车站) + "-" + o.车站
                                                }).DistinctBy(o => o.pymSTATIONAME).OrderBy(o => o.pymSTATIONAME);
                                }
                                dept = oc.BllSession.ISYS_DEPTService.Entities.Where(o => o.DEPT_CODE == dept.PARENT_CODE).FirstOrDefault();
                                resultCode = dept.DEPT_CODE;
                            }
                            catch (Exception ex)
                            {
                                RecordLog.RecordError("[手机获取车站]：" + ex.ToString());
                                return null;
                            }
                        } while (count <= 0);
                    }
                }
            }
            return null;
        }

        [HttpPost]
        [Description("接收添乘计划数据")]
        public ResponseObject PostTrainInfo(object data)
        {
            ResponseObject result = new ResponseObject()
            {
                Result = "SUCCESS",
                Msg = string.Empty
            };
            try
            {
                TrainRequest trainReq=JsonConvert.DeserializeObject<TrainRequest>(data.ToString());
                if (trainReq != null)
                {
                    JOB_PLAN_TRAIN jobPlanTrain;
                    AutoMapper.Mapper.CreateMap<TrainRequest, JOB_PLAN_TRAIN>();
                    JOB_PLAN_TRAIN modelJobPlanTrain= AutoMapper.Mapper.Map<TrainRequest, JOB_PLAN_TRAIN>(trainReq);
                    jobPlanTrain = oc.BllSession.IJOB_PLAN_TRAINService.Entities.Where(o => o.PKID == modelJobPlanTrain.PKID).FirstOrDefault();
                    var memberEntity = oc.BllSession.ISYS_MEMBERService.Entities.Where(o => o.MOBILE == modelJobPlanTrain.PHONE).FirstOrDefault();
                    if (memberEntity != null)
                    {
                        modelJobPlanTrain.DEPT_CODE = memberEntity.DEPT_CODE;
                        modelJobPlanTrain.PHONENAME = memberEntity.NAME;
                        var deptEntity = oc.BllSession.ISYS_DEPTService.Entities.Where(o => o.DEPT_CODE == modelJobPlanTrain.DEPT_CODE).FirstOrDefault();
                        if (deptEntity != null)
                        {
                            modelJobPlanTrain.DEPT_NAME = deptEntity.DEPT_NAME;
                        }
                        modelJobPlanTrain.ADDTIME = DateTime.Now;

                        string train_area_fromto = modelJobPlanTrain.TRAIN_BEGIN + "-" + modelJobPlanTrain.TRAIN_END;
                        string train_area_tofrom = modelJobPlanTrain.TRAIN_END + "-" + modelJobPlanTrain.TRAIN_BEGIN;
                        modelJobPlanTrain.TRAIN_AREA = train_area_fromto;
                        var isExist=oc.BllSession.IJOB_PLAN_TRAINService.Entities.Where(o=>o.TRAIN_AREA==train_area_fromto).FirstOrDefault();
                        if (isExist == null)
                            modelJobPlanTrain.TRAIN_AREA = train_area_tofrom;
                        if (jobPlanTrain == null)
                            {
                                //新增
                                oc.BllSession.IJOB_PLAN_TRAINService.AddEntity(modelJobPlanTrain);
                                result.Result = "SUCCESS";
                            }
                            else
                            {
                                //修改
                                Expression<Func<JOB_PLAN_TRAIN, object>>[] jobPlanTrain_items_ignoreProperties = new Expression<Func<JOB_PLAN_TRAIN, object>>[] 
                            {
                                p=>p.CHECK_MAN,
                                p=>p.DEMO,
                                p=>p.MONITOR_SIT
                            };
                                oc.BllSession.IJOB_PLAN_TRAINService.UpdateEntity(modelJobPlanTrain, jobPlanTrain_items_ignoreProperties);
                                result.Result = "SUCCESS";
                            }
                    }
                    else
                    {
                        result.Msg = "该人员不存在请核实";
                        result.Result="FAIL";
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Result = "FAIL";
                result.Msg = ex.InnerException.ToString();
            }
            return result;
        }
    }

    #region 辅助类
    [Description("获取汉字字符串的拼音首字母")]
    class SpellCode
    {
        /// <summary>
        /// 在指定的字符串列表CnStr中检索符合拼音索引字符串
        /// </summary>
        /// <param name="CnStr">汉字字符串</param>
        /// <returns>相对应的汉语拼音首字母串</returns>
        public static string GetSpellCode(string CnStr)
        {

            string strTemp = "";

            int iLen = CnStr.Length;

            int i = 0;

            for (i = 0; i <= iLen - 1; i++)
            {

                strTemp += GetCharSpellCode(CnStr.Substring(i, 1));

            }

            return strTemp;

        }

        /// <summary>
        /// 得到一个汉字的拼音第一个字母，如果是一个英文字母则直接返回大写字母
        /// </summary>
        /// <param name="CnChar">单个汉字</param>
        /// <returns>单个大写字母</returns>
        private static string GetCharSpellCode(string CnChar)
        {

            long iCnChar;

            byte[] ZW = System.Text.Encoding.Default.GetBytes(CnChar);

            //如果是字母，则直接返回

            if (ZW.Length == 1)
            {

                return CnChar.ToUpper();

            }

            else
            {

                // get the array of byte from the single char

                int i1 = (short)(ZW[0]);

                int i2 = (short)(ZW[1]);

                iCnChar = i1 * 256 + i2;

            }

            // iCnChar match the constant

            if ((iCnChar >= 45217) && (iCnChar <= 45252))
            {

                return "A";

            }

            else if ((iCnChar >= 45253) && (iCnChar <= 45760))
            {

                return "B";

            }
            else if ((iCnChar >= 45761) && (iCnChar <= 46317))
            {

                return "C";

            }
            else if ((iCnChar >= 46318) && (iCnChar <= 46825))
            {

                return "D";

            }
            else if ((iCnChar >= 46826) && (iCnChar <= 47009))
            {

                return "E";

            }
            else if ((iCnChar >= 47010) && (iCnChar <= 47296))
            {

                return "F";

            }
            else if ((iCnChar >= 47297) && (iCnChar <= 47613))
            {

                return "G";

            }
            else if ((iCnChar >= 47614) && (iCnChar <= 48118))
            {

                return "H";

            }
            else if ((iCnChar >= 48119) && (iCnChar <= 49061))
            {

                return "J";

            }
            else if ((iCnChar >= 49062) && (iCnChar <= 49323))
            {

                return "K";

            }
            else if ((iCnChar >= 49324) && (iCnChar <= 49895))
            {

                return "L";

            }
            else if ((iCnChar >= 49896) && (iCnChar <= 50370))
            {

                return "M";

            }
            else if ((iCnChar >= 50371) && (iCnChar <= 50613))
            {

                return "N";

            }
            else if ((iCnChar >= 50614) && (iCnChar <= 50621))
            {

                return "O";

            }
            else if ((iCnChar >= 50622) && (iCnChar <= 50905))
            {

                return "P";

            }
            else if ((iCnChar >= 50906) && (iCnChar <= 51386))
            {

                return "Q";

            }
            else if ((iCnChar >= 51387) && (iCnChar <= 51445))
            {

                return "R";

            }
            else if ((iCnChar >= 51446) && (iCnChar <= 52217))
            {

                return "S";

            }
            else if ((iCnChar >= 52218) && (iCnChar <= 52697))
            {

                return "T";

            }
            else if ((iCnChar >= 52698) && (iCnChar <= 52979))
            {

                return "W";

            }
            else if ((iCnChar >= 52980) && (iCnChar <= 53640))
            {

                return "X";

            }
            else if ((iCnChar >= 53689) && (iCnChar <= 54480))
            {

                return "Y";

            }
            else if ((iCnChar >= 54481) && (iCnChar <= 55289))
            {

                return "Z";

            }
            else

                return (CnChar);

        }
    }
    class PYM_STATIONAME
    {
        public string pymSTATIONAME { get; set; }
    }
    public static class MyEnumerableExtensions
    {
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
            (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element))) { yield return element; }
            }
        }
    }

    #region 添乘辅助类
    public class TrainRequest
    {
        //主键
        public string PKID { get; set; }
        //手机号
        public string PHONE { get; set; }
        //添乘时间
        public DateTime JOB_TIME { get; set; }
        //车次
        public string TRAINS { get; set; }
        //车型
        public string TRAIN_TYPE { get; set; }
        //机车号
        public string TRAIN_NUM { get; set; }
        //添乘类型
        public string JOB_TYPE { get; set; }
        //发车时间
        public DateTime BEGIN_TIME { get; set; }
        //抵达时间
        public DateTime END_TIME { get; set; }
        //开始车站
        public string TRAIN_BEGIN { get; set; }
        //抵达车站
        public string TRAIN_END { get; set; }
        //司机
        public string DRIVER { get; set; }
    }

    public class ResponseObject
    {
        public string Msg { get; set; }
        public string Result { get; set; }
    }
    #endregion

    #endregion

}
