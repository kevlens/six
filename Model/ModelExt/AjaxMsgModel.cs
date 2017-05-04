using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AjaxMsgModel
    {
        public AjaxMsgModel()
        {
            BackUrl = "";
        }
        //信息状态
        public AjaxStatu Statu { set; get; }
        //提示信息
        public string Msg { set; get; }
        //返回网址
        public string BackUrl { set; get; }
        //用户数据
        public object Data { set; get; }
    }
    //转换错误信息
    public class TableToListErrorModel
    {
        public int rowIndex { set; get; }//错误行
        public int columnIndex { set; get; }//错误列
        public string errorInfo { set; get; }//信息
        public string errorCause { set; get; }//原因
        public string station { set; get; }//站名
    }
    //解析关键字段错误信息
    public class ConvertErrorModel
    {
        public string titleName { set; get; }//表头
        public string errorCause { set; get; }//原因
        public string content { set; get; }//备注
    }
    public enum AjaxStatu
    {
        ok = 1,//成功
        err = 2,//失败
        none = 3,
        nologin = 4,
        noperm = 5
    }
}
