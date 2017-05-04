using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Reflection;
using System.Collections;
using System.Xml;
using System.Data.Entity;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using Model;


namespace Common
{
    public class ColorHelper
    {
        public ColorHelper()
        {}

        public static Dictionary<string, string> ReadXml(string DEPT_CODE, string plantype)
        {
            string deptcodeName = "DEPT_" + DEPT_CODE + "_" + plantype;
            Dictionary<string, string> colorDataMap = new Dictionary<string, string>();
            //HttpRuntime.AppDomainAppPath 网站在服务器磁盘上的物理路径
            //任何于Request/HttpContext.Current等相关的方法, 都只能在有请求上下文或者页面时使用. 即在无请求上下文时,HttpContext.Current为null. 而HttpRuntime.AppDomainAppPath方法一直可用.
            string path = Path.Combine(HttpRuntime.AppDomainAppPath, "Content", "UpLoadExcel\\Plan_ColorTime_Map.xml");
            //string path = Path.Combine(HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath), "Content", "UpLoadExcel\\Plan_ColorTime_Map.xml");

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);

            //XmlNodeList listNodes = xmlDocument.SelectNodes("/datatable/dataname[@deptcode='" + deptcodeName + "']/item[@plantype='" + plantype + "']");
            XmlNodeList listNodes = xmlDocument.SelectNodes("/datatable/element/dataname[@deptcode='" + deptcodeName + "']/item");

            foreach (XmlElement node in listNodes)
            {
                colorDataMap.Add(node.GetAttribute("key"), node.GetAttribute("value"));
            }
            return colorDataMap;

        }
        public static Dictionary<string, string> ReadRailTemperature(string DEPT_CODE)
        {
            Dictionary<string, string> colorDataMap = new Dictionary<string, string>();
            string p = HttpContext.Current.Server.MapPath("~");
            string path = Path.Combine(p, "Content", "UpLoadExcel\\Rail_Temperature_Color.xml");

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);

            //XmlNodeList listNodes = xmlDocument.SelectNodes("/datatable/dataname[@deptcode='" + deptcodeName + "']/item[@plantype='" + plantype + "']");
            XmlNodeList listNodes = xmlDocument.SelectNodes("/datatable/element/dataname[@deptcode='" + DEPT_CODE + "']/item");

            foreach (XmlElement node in listNodes)
            {
                colorDataMap.Add(node.GetAttribute("key"), node.GetAttribute("value"));
            }
            return colorDataMap;

        }
        public static PersonColorConfig ReadPersonColor(string DEPT_CODE)
        {
            string path = Path.Combine(HttpContext.Current.Server.MapPath("~"), "Content", "UpLoadExcel\\Plan_ColorPerson_Map_"+DEPT_CODE+".xml");
            try
            {
                return (PersonColorConfig)XMLUtil.DeserializeFromXml(path, typeof(PersonColorConfig));
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static List<PersonColorConfig> ReadPersonColorList(string DEPT_CODE)
        {
            string path = Path.Combine(HttpContext.Current.Server.MapPath("~"), "Content", "UpLoadExcel\\Plan_ColorPerson_Map_" + DEPT_CODE + ".xml");
            try
            {
                return (List<PersonColorConfig>)XMLUtil.DeserializeFromXml(path, typeof(List<PersonColorConfig>));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Dictionary<string, string> ReadDeptSectionTime(string DEPT_CODE)
        {
            Dictionary<string, string> timeMapDic = new Dictionary<string, string>();
            string tempPath = HttpContext.Current.Server.MapPath("~");
            string path = Path.Combine(tempPath, "Content", "UpLoadExcel\\Gate_DeptSectionTime_Map.xml");

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlNodeList deptNodes = xmlDoc.SelectNodes("/datatable/element/dataname[@deptcode='" + DEPT_CODE + "']/item");
            foreach (XmlElement node in deptNodes)
            {
                timeMapDic.Add(node.GetAttribute("key"), node.GetAttribute("value"));
            }
            return timeMapDic;
        }
    }
}