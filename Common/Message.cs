using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Common
{
    public class Message
    {
        AjaxMsgModel amm = new AjaxMsgModel
        {
            Statu = AjaxStatu.err,
            Msg = "信息不正确！",
            Data = null,
            BackUrl = null
        };

        public AjaxMsgModel NewAmm { get { return amm; } }
        /// <summary>
        /// 信息不存在，{0}不存在！
        /// </summary>
        public static string NotFound = "{0}不存在！";

        /// <summary>
        /// 信息存在，{0}已存在！
        /// </summary>
        public static string YesFound = "{0}已存在！";

        /// <summary>
        /// 信息关联替换，该{0}下已经有{1}，暂不能更换隶属{0}！
        /// </summary>
        public static string NotReplace = "该{0}下已经有{1}，暂不能更换隶属{0}！";

        /// <summary>
        /// 信息关联删除，请先删除此{0}的{1}！
        /// </summary>
        public static string DelFirst = "请先删除此{0}的{1}！";

        /// <summary>
        /// 信息正在被使用，{0}正在被用户使用，不能{1}！
        /// </summary>
        public static string IsBeingUsed = "{0}正在被用户使用，不能{1}！";

        /// <summary>
        /// 信息无效，{0}不正确！请重新操作！
        /// </summary>
        public static string InvalidReEnter = "{0}不正确！请重新操作！";

        /// <summary>
        /// 信息操作成功，{0}{1}成功！
        /// </summary>
        public static string OptSussess = "{0}{1}成功！";

        /// <summary>
        /// 信息操作失败，{0}{1}失败！
        /// </summary>
        public static string OptFail = "{0}{1}失败！";

        /// <summary>
        /// 操作没有权限，您没有<br/>【{0}】<br/>的权限！
        /// </summary>
        public static string OptNoPermission = "您没有<br/>【{0}】<br/>的权限！";

        /// <summary>
        ///信息传入失败，{0}没有传入！ 
        /// </summary>
        public static string ParGetFail = "{0}没有传入！";

        /// <summary>
        /// 信息两次输入不匹配，两次输入的{0}不匹配！
        /// </summary>
        public static string MisMatch = "两次输入的{0}不匹配！";

        /// <summary>
        /// 操作增加，添加
        /// </summary>
        public static string AddOpt = "添加";

        /// <summary>
        /// 操作编辑，编辑
        /// </summary>
        public static string EditOpt = "编辑";

        /// <summary>
        /// 操作删除，删除
        /// </summary>
        public static string DelOpt = "删除";

        /// <summary>
        /// 操作转换，转换
        /// </summary>
        public static string ConvertOpt = "转换";

        /// <summary>
        /// 操作读取，读取
        /// </summary>
        public static string ReadOpt = "读取";

        /// <summary>
        /// 参数传入，
        /// </summary>
        public static string ParIntoOpt = "传入";

        /// <summary>
        /// 设置
        /// </summary>
        public static string SetOpt = "设置";

        /// <summary>
        /// 授权
        /// </summary>
        public static string GateAuthOpt = "授权";

        /// <summary>
        /// 废弃
        /// </summary>
        public static string GateCardAbandonOpt = "废弃";

        /// <summary>
        /// 解除废弃
        /// </summary>
        public static string GateCardUnAbandonOpt = "解除废弃";

        /// <summary>
        /// 解绑
        /// </summary>
        public static string GateCardUnBind = "解绑";

        /// <summary>
        /// 信息过多，{0}过多
        /// </summary>
        public static string TooLarge = "{0}过多";
        /// <summary>
        /// 导入
        /// </summary>
        public static string ExcelIn = "导入";

        /// <summary>
        /// 信息需要某种类型，需要{0}类型{1}
        /// </summary>
        public static string PropertyTypeIsNeeded = "需要{0}类型{1}";

        /// <summary>
        /// For Login,您还没有登录或登录已超时，请重新登录！
        /// </summary>
        public static string NotLogin = "您还没有登录或登录已超时，请重新登录！";
        /// <summary>
        /// For Login,您的用户名已经在其他地方登录，请重新登录！
        /// </summary>
        public static string NotNone = "您的用户名已经在其他地方登录，请重新登录！";
        /// <summary>
        /// 信息操作失败，{0}{1}失败！
        /// </summary>
        public static string OptRepeatFail = "{0}{1}失败！材料编码不能重复！";

        /// <summary>
        /// LKJ信息重复，{0}{1}失败！
        /// </summary>
        public static string LKJOptRepeatFail = "{0}{1}失败！信息不能重复！";

        /// <summary>
        /// 操作提示，提示
        /// </summary>
        public static string SendOpt = "提示";
    }
}
