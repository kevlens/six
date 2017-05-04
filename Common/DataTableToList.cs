using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using Model;


namespace Common
{
    public class DataTableToList<T> where T : new()
    {
        #region DataTable转List
        /// <summary>  
        ///  DataTable转List
        /// </summary>  
        /// <param name="dt"></param>  
        /// <returns></returns>  
        public static AjaxMsgModel ConvertToList(DataTable dts, int rowIdex, AjaxMsgModel amm)
        {
            //错误集合
            List<TableToListErrorModel> errorList = new List<TableToListErrorModel>();
            // 定义集合  
            List<T> ts = new List<T>();

            // 获得此模型的类型  
            Type type = typeof(T);

            DataTable dt = ExcelExtHelper.ReplaceColumnsName(dts, type.Name);
            if (dt == null)
            {
                amm.Statu = AjaxStatu.err;
                amm.Msg = "导入的文件模板不正确";
                errorList.Add(
                new TableToListErrorModel()
                {
                    rowIndex = rowIdex,
                    columnIndex = 0,
                    errorInfo = "导入的文件模板不正确",
                    errorCause = "导入的文件模板不正确"
                });
                amm.Data = errorList;// ObjToJson.GetToJson(errorList);//转为JSON
                return amm;
            }

            //定义一个临时变量  
            string tempName = string.Empty;
            //遍历DataTable中所有的数据行  
            foreach (DataRow dr in dt.Rows)
            {
                rowIdex++;//计算行
                T t = new T();
                // 获得此模型的公共属性  
                PropertyInfo[] propertys = t.GetType().GetProperties();
                //遍历该对象的所有属性  
                foreach (PropertyInfo pi in propertys)
                {
                    Type pt = pi.PropertyType;

                    tempName = pi.Name;//将属性名称赋值给临时变量  
                    //检查DataTable是否包含此列（列名==对象的属性名）    
                    if (dt.Columns.Contains(tempName))
                    {
                        // 判断此属性是否有Setter  
                        if (!pi.CanWrite) continue;//该属性不可写，直接跳出  
                        //取值
                        object value = dr[tempName];
                        //判断
                        if (pt.Equals(value.GetType()))
                        {
                            //如果非空，则赋给对象的属性  
                            if (value != DBNull.Value)
                            {
                                try
                                {
                                    pi.SetValue(t, value, null);
                                }
                                catch (Exception)
                                {
                                    amm.Statu = AjaxStatu.err;
                                    errorList.Add(
                                    new TableToListErrorModel()
                                    {
                                        rowIndex = rowIdex,
                                        columnIndex = dt.Columns.IndexOf(tempName) + 1,
                                        errorInfo = "内容过多",
                                        errorCause = "内容过多"
                                    });
                                }
                            }
                        }
                        else
                        {
                            string fullName = pt.FullName;

                            if (fullName.Contains("System.String"))//文本型
                            {
                                //如果非空，则赋给对象的属性  
                                if (value != DBNull.Value)
                                {
                                    try
                                    {
                                        pi.SetValue(t, value.ToString(), null);
                                    }
                                    catch (Exception)
                                    {
                                        amm.Statu = AjaxStatu.err;
                                        errorList.Add(
                                        new TableToListErrorModel()
                                        {
                                            rowIndex = rowIdex,
                                            columnIndex = dt.Columns.IndexOf(tempName) + 1,
                                            errorInfo = "内容过多",
                                            errorCause = "内容过多"
                                        });
                                    }
                                }
                            }
                            if (fullName.Contains("System.Int16"))//数字型
                            {
                                //如果非空，则赋给对象的属性  
                                if (value != DBNull.Value)
                                {
                                    try
                                    {
                                        if (!fullName.Contains("System.Nullable") || value != "")//如果是必填项或不为空时
                                        {
                                            value = Convert.ToInt16(value);
                                            pi.SetValue(t, value, null);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        amm.Statu = AjaxStatu.err;
                                        //数字转换失败
                                        errorList.Add(
                                        new TableToListErrorModel()
                                        {
                                            rowIndex = rowIdex,
                                            columnIndex = dt.Columns.IndexOf(tempName) + 1,
                                            errorInfo = "数字转换失败",
                                            errorCause = "需要数字类型"
                                        });
                                    }
                                }
                            }
                            if (fullName.Contains("System.Int32"))//数字型
                            {
                                //如果非空，则赋给对象的属性  
                                if (value != DBNull.Value)
                                {
                                    try
                                    {
                                        if (!fullName.Contains("System.Nullable") || value != "")//如果是必填项或不为空时
                                        {
                                            value = Convert.ToInt32(value);
                                            pi.SetValue(t, value, null);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        amm.Statu = AjaxStatu.err;
                                        //数字转换失败
                                        errorList.Add(
                                        new TableToListErrorModel()
                                        {
                                            rowIndex = rowIdex,
                                            columnIndex = dt.Columns.IndexOf(tempName) + 1,
                                            errorInfo = "数字转换失败",
                                            errorCause = "需要数字类型"
                                        });
                                    }
                                }
                            }
                            if (fullName.Contains("System.Decimal"))//数字型
                            {
                                //如果非空，则赋给对象的属性  
                                if (value != DBNull.Value)
                                {
                                    try
                                    {
                                        if (!fullName.Contains("System.Nullable") || value != "")//如果是必填项或不为空时
                                        {
                                            value = Convert.ToDecimal(value);
                                            pi.SetValue(t, value, null);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        amm.Statu = AjaxStatu.err;
                                        //数字转换失败
                                        errorList.Add(
                                        new TableToListErrorModel()
                                        {
                                            rowIndex = rowIdex,
                                            columnIndex = dt.Columns.IndexOf(tempName) + 1,
                                            errorInfo = "数字转换失败",
                                            errorCause = "需要数字类型"
                                        });
                                    }
                                }
                            }
                            if (fullName.Contains("System.DateTime"))//日期型
                            {
                                //如果非空，则赋给对象的属性  
                                if (value != DBNull.Value)
                                {
                                    try
                                    {
                                        if (!fullName.Contains("System.Nullable") || value != "")//如果是必填项或不为空时
                                        {
                                            value = Convert.ToDateTime(value.ToString());
                                            pi.SetValue(t, value, null);
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        amm.Statu = AjaxStatu.err;
                                        //日期转换失败
                                        //excel日期列必须设置为日期格式才能正确转换
                                        errorList.Add(
                                        new TableToListErrorModel()
                                        {
                                            rowIndex = rowIdex,
                                            columnIndex = dt.Columns.IndexOf(tempName) + 1,
                                            errorInfo = "日期转换失败",
                                            errorCause = "需要日期类型，请设置该单元格格式为日期型或算定义为yyyy-MM-dd HH:mm:ss"
                                        });
                                    }
                                }
                            }
                        }

                    }
                }
                //对象添加到泛型集合中  
                ts.Add(t);
            }
            if (errorList.Count > 0)//如果有错误
            {
                amm.Statu = AjaxStatu.err;
                amm.Data = errorList;// ObjToJson.GetToJson(errorList);//转为JSON
            }
            else
            {
                amm.Statu = AjaxStatu.ok;
                amm.Data = ts;
            }
            return amm;

        }
        #endregion


    }
}
