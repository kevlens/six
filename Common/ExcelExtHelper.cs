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
    public class ExcelExtHelper
    {
        public ExcelExtHelper()
        {
        }

        #region 构造函数
        /// <summary>
        /// 工作薄
        /// </summary>
        //public HSSFWorkbook WorkBook { get; set; }
        ///// <summary>
        ///// 表
        ///// </summary>
        //public ISheet Sheet { get; set; }
        ///// <summary>
        ///// 路径
        ///// </summary>
        //public string ExcelPath { get; set; }
        //public ExcelHelper(string filePath)
        //{
        //    //把xls文件中的数据写入wk中
        //    using (FileStream fs = File.OpenRead(filePath))
        //    {
        //        WorkBook = new HSSFWorkbook(fs);
        //        Sheet = WorkBook.GetSheetAt(0);
        //        ExcelPath = filePath;
        //    }
        //}
        //public ExcelHelper(string path, string fileName)
        //{
        //    //把xls文件中的数据写入wk中
        //    using (FileStream fs = File.OpenRead(path + "/" + fileName + ".xls"))
        //    {
        //        WorkBook = new HSSFWorkbook(fs);
        //        Sheet = WorkBook.GetSheetAt(0);
        //        ExcelPath = path + "/" + fileName + ".xls";
        //    }
        //}
        //public ExcelHelper(string path, string fileName, string sheetName)
        //{
        //    using (FileStream fs = File.OpenRead(path + "/" + fileName + ".xls"))
        //    {
        //        WorkBook = new HSSFWorkbook(fs);
        //        Sheet = WorkBook.GetSheet(sheetName);
        //        ExcelPath = path + "/" + fileName + ".xls";
        //    }
        //}
        #endregion

        /// <summary>
        /// excel读取返回DataTable，开始列必须是第一列
        /// </summary>
        /// <param name="files">上传的文件</param>
        /// <param name="sheetIndex">要读取的工作表索引</param>
        /// <param name="rowIndex">开始行数</param>
        /// <param name="isHead">开始行是否是DataTable的列名</param>
        /// <returns></returns>
        public AjaxMsgModel ToDataTable(HttpFileCollection files, int sheetIndex, int rowIndex, AjaxMsgModel amm)
        {
            //得到上传的文件
            HttpPostedFile upfile = null;
            foreach (string file in files)
            {
                HttpPostedFile uploadFile = files[file] as HttpPostedFile;
                if (uploadFile != null && uploadFile.ContentLength > 0)
                {
                    upfile = uploadFile;

                }
            }
            string fileAble = Path.GetExtension(upfile.FileName);//文件后缀
            if (upfile == null || (fileAble != ".xls" && fileAble != ".xlsx"))
            {
                return amm;
            }
            //要保存的文件路径
            //HttpRuntime.AppDomainAppPath 网站在服务器磁盘上的物理路径
            //任何于Request/HttpContext.Current等相关的方法, 都只能在有请求上下文或者页面时使用. 即在无请求上下文时,HttpContext.Current为null. 而HttpRuntime.AppDomainAppPath方法一直可用.
            string path = Path.Combine(HttpRuntime.AppDomainAppPath, "Content", "UpLoadExcel");
            //string path = Path.Combine(HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath), "Content", "UpLoadExcel");
            //要保存的文件名称
            string fileName = string.Format("{0}_{1}{2}", Path.GetFileNameWithoutExtension(upfile.FileName), DateTime.Now.ToString("yyyyMMddHHmmss"), Path.GetExtension(upfile.FileName));
            //保存文件到指定的目录
            upfile.SaveAs(Path.Combine(path, fileName));

            //excel读取返回DataTable
            amm = ToDataTable(path + "\\" + fileName, sheetIndex, rowIndex, amm);

            return amm;
        }

        /// <summary>
        /// excel读取返回DataTable，开始列必须是第一列
        /// </summary>
        /// <param name="files">上传的文件</param>
        /// <param name="sheetIndex">要读取的工作表索引</param>
        /// <param name="rowIndex">开始行数</param>
        /// <param name="isHead">开始行是否是DataTable的列名</param>
        /// <returns></returns>
        ///
        /*
        public AjaxMsgModel ToDataTable(HttpFileCollectionBase files, int sheetIndex, int rowIndex, AjaxMsgModel amm)
        {
            //得到上传的文件
            HttpPostedFileBase upfile = null;
            foreach (string file in files)
            {
                HttpPostedFileBase uploadFile = files[file] as HttpPostedFileBase;
                if (uploadFile != null && uploadFile.ContentLength > 0)
                {
                    upfile = uploadFile;

                }
            }
            string fileAble = Path.GetExtension(upfile.FileName);//文件后缀
            if (upfile == null || (fileAble != ".xls" && fileAble != ".xlsx"))
            {
                return amm;
            }
            //要保存的文件路径
            //HttpRuntime.AppDomainAppPath 网站在服务器磁盘上的物理路径
            //任何于Request/HttpContext.Current等相关的方法, 都只能在有请求上下文或者页面时使用. 即在无请求上下文时,HttpContext.Current为null. 而HttpRuntime.AppDomainAppPath方法一直可用.
            string path = Path.Combine(HttpRuntime.AppDomainAppPath, "Content", "UpLoadExcel");
            //string path = Path.Combine(HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath), "Content", "UpLoadExcel");
            //要保存的文件名称
            string fileName = string.Format("{0}_{1}{2}", Path.GetFileNameWithoutExtension(upfile.FileName), DateTime.Now.ToString("yyyyMMddHHmmss"), Path.GetExtension(upfile.FileName));
            //保存文件到指定的目录
            upfile.SaveAs(Path.Combine(path, fileName));

            //excel读取返回DataTable
            amm = ToDataTable(path + "\\" + fileName, sheetIndex, rowIndex, amm);

            return amm;
        }
        */
        /// <summary>
        /// excel读取返回DataTable，开始列必须是第一列
        /// </summary>
        /// <param name="excelPath">excelPath路径</param>
        /// <param name="sheetIndex">要读取的工作表索引</param>
        /// <param name="rowIndex">开始行数</param>
        /// <param name="isHead">开始行是否是DataTable的列名</param>
        /// <returns></returns>
        public AjaxMsgModel ToDataTable(string excelPath, int sheetIndex, int rowIndex, AjaxMsgModel amm)
        {
            bool isHead = true;//第一行必须是表头
            try
            {
                DataTable dt = new DataTable(Path.GetFileNameWithoutExtension(excelPath) + "_Sheet" + sheetIndex);
                IWorkbook workbook;

                //workbook = new HSSFWorkbook(file);//创建对应文件
                try
                {
                    using (FileStream file = new FileStream(excelPath, FileMode.Open, FileAccess.Read))
                    {
                        workbook = new HSSFWorkbook(file);//创建对应文件EXCEL2003
                    }
                }
                catch (Exception ex)
                {
                    using (FileStream file = new FileStream(excelPath, FileMode.Open, FileAccess.Read))
                    {
                        workbook = new XSSFWorkbook(file);//创建对应文件EXCEL2007
                    }
                }
                if (File.Exists(excelPath))//读完即删除
                {
                    File.Delete(excelPath);
                }
                ISheet sheet = workbook.GetSheetAt(sheetIndex);//按索引获取工作表
                var rows = sheet.GetRowEnumerator();//获取工作表中所有行HSSFSheet.GetRow(rowIndex)获取某一行
                for (int i = 0; i < rowIndex; i++)//从第rowindex行开始读取
                {
                    rows.MoveNext();
                }
                IRow row = (IRow)rows.Current;
                try
                {
                    for (int i = 0; i < row.LastCellNum; i++)//给DataTable创建列
                    {
                        ICell cell = row.GetCell(i);
                        string columnName = isHead ? cell.ToString() : i.ToString();
                        if (columnName.Trim() == "")
                        {
                            //amm.Statu = AjaxStatu.err;
                            //amm.Msg = "表头名不能为空！";

                            //return amm;

                            columnName = "EXTNAME" + i.ToString();
                        }
                        try
                        {
                            dt.Columns.Add(columnName.Replace("\r", "").Replace("\n", "").Replace(" ","").Trim(), typeof(string));   //去除标题头回车，换行的情况
                        }
                        catch (Exception)
                        {
                            dt.Columns.Add(columnName.Trim() + i.ToString(), typeof(string));
                        }
                    }

                }
                catch (Exception)
                {
                    amm.Statu = AjaxStatu.err;
                    amm.Msg = "表头名不能为空或有重复！";

                    return amm;
                }
                if (!isHead)//如果第一行是列名则不加入DataTable
                {
                    DataRow first = dt.NewRow();
                    for (int i = 0; i < row.LastCellNum; i++)
                    {
                        ICell cell = row.GetCell(i);
                        first[i] = cell.ToString();
                    } dt.Rows.Add(first);
                }
                while (rows.MoveNext())
                {
                    row = (IRow)rows.Current;
                    DataRow dataRow = dt.NewRow();
                    for (int i = 0; i < row.LastCellNum; i++)
                    {
                        ICell cell = row.GetCell(i);
                        if (cell != null)
                        {
                            if (cell.CellType == CellType.Numeric)//如果是日期或数字
                            {
                                string readvalue = GetCellValue(cell);
                                if (readvalue.IndexOf("/") > -1 || readvalue.IndexOf("-") > 1)//如果是日期
                                {
                                    dataRow[i] = cell.DateCellValue.ToString("yyyy-MM-dd HH:mm:ss");
                                }
                                else
                                {
                                    dataRow[i] = readvalue;
                                }
                            }
                            else
                            {
                                dataRow[i] = GetCellValue(cell);
                            }
                            //dataRow[i] = cell.ToString();
                        }
                        else//如果是空白
                        {
                            dataRow[i] = "";
                        }
                        if (i == dt.Columns.Count - 1)
                        {
                            break;//如果行的列比表头多则不继续读取
                        }
                    }
                    dt.Rows.Add(dataRow);
                }
                amm.Data = removeEmpty(dt);
                amm.Statu = AjaxStatu.ok;
                amm.Msg = "读取文件内容成功！";
                return amm;
            }
            catch (Exception)
            {
                amm.Statu = AjaxStatu.err;
                amm.Msg = "读取文件内容失败！可能原因或为文件中没内容";
                return amm;
            }
        }
        //循环去除datatable中的空行
        protected DataTable removeEmpty(DataTable dt)
        {
            List<DataRow> removelist = new List<DataRow>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool rowdataisnull = true;
                for (int j = 0; j < dt.Columns.Count; j++)
                {

                    if (!string.IsNullOrEmpty(dt.Rows[i][j].ToString().Trim()))
                    {

                        rowdataisnull = false;
                    }

                }
                if (rowdataisnull)
                {
                    removelist.Add(dt.Rows[i]);
                }

            }
            for (int i = 0; i < removelist.Count; i++)
            {
                dt.Rows.Remove(removelist[i]);
            }
            return dt;
        }
        #region 创建xls文件
        /// <summary>
        /// 创建xls文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileName"></param>
        //public void Create(string path, string fileName, string sheetName)
        //{

        //    //创建工作薄
        //    WorkBook = new HSSFWorkbook();
        //    //创建一个表
        //    Sheet = WorkBook.CreateSheet(sheetName);
        //    using (FileStream fs = File.OpenWrite(path + "/" + fileName + ".xls")) //打开一个xls文件，如果没有则自行创建，如果存在myxls.xls文件则在创建是不要打开该文件！
        //    {
        //        WorkBook.Write(fs);   //向打开的这个xls文件中写入mySheet表并保存。
        //    }
        //}

        /// <summary>
        /// 合并单元格
        /// </summary>
        /// <param name="sheet">要合并单元格所在的sheet</param>
        /// <param name="rowstart">开始行的索引</param>
        /// <param name="rowend">结束行的索引</param>
        /// <param name="colstart">开始列的索引</param>
        /// <param name="colend">结束列的索引</param>
        public static void SetCellRangeAddress(ISheet sheet, int rowstart, int rowend, int colstart, int colend)
        {
            CellRangeAddress cellRangeAddress = new CellRangeAddress(rowstart, rowend, colstart, colend);
            sheet.AddMergedRegion(cellRangeAddress);
        }
        public static bool ToExcel(string savePath, string SheetName, string HeadName, IList listJob, string className, string note = "")
        {
            try
            {

                DataTable table = ToDataTable(listJob, className, note);
                List<int> dateCellIndex = new List<int>();//日期格式列
                bool header = true;
                //创建工作薄
                HSSFWorkbook wk = new HSSFWorkbook();
                //创建一个名称为mySheet的表
                ISheet tb = wk.CreateSheet(SheetName);
                #region 表头样式
                ICellStyle headStyle = wk.CreateCellStyle();
                headStyle.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.Yellow.Index;
                headStyle.Alignment = HorizontalAlignment.Center;
                IFont font = wk.CreateFont();
                font.FontName = "宋体";
                font.FontHeightInPoints = 12;
                font.Boldweight = 700;
                headStyle.SetFont(font);
                #endregion


                #region 行样式
                ICellStyle stylerow = wk.CreateCellStyle();
                stylerow.Alignment = HorizontalAlignment.Center;
                IFont fontrow = wk.CreateFont();
                fontrow.FontName = "宋体";
                fontrow.FontHeightInPoints = 12;
                stylerow.SetFont(fontrow);
                stylerow.WrapText = true;
                #endregion

                #region 日期行样式
                ICellStyle dateStyle = wk.CreateCellStyle();
                IDataFormat format = wk.CreateDataFormat();
                dateStyle.DataFormat = format.GetFormat("yyyy-MM-dd HH:mm:ss");
                stylerow.WrapText = true;
                #endregion

                #region 数字样式
                ICellStyle numStyle = wk.CreateCellStyle();
                numStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("0.00");
                //IDataFormat numformat = wk.CreateDataFormat();
                //numStyle.DataFormat = numformat.GetFormat("0.00");
                #endregion
                Dictionary<string, string> excelDataMap = ReadXml(className, false, note);
                //合并标题行
                /// <param name="sheet">要合并单元格所在的sheet</param>
                /// <param name="rowstart">开始行的索引</param>
                /// <param name="rowend">结束行的索引</param>
                /// <param name="colstart">开始列的索引</param>
                /// <param name="colend">结束列的索引</param>
                tb.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(0, 0, 0, excelDataMap.Keys.Count));

                IRow rowhead = tb.CreateRow(0);//创建一行
                rowhead.HeightInPoints = 25; //行高
                ICell cellhead = rowhead.GetCell(0, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                cellhead.CellStyle = headStyle;
                cellhead.SetCellValue(HeadName);//写入表头

                //SetCellRangeAddress(tb, 0, 0, 1, 20);
                int rowIndex = 1;
                if (header)
                {
                    IRow row = tb.CreateRow(rowIndex);//创建一行
                    rowIndex++;
                    row.HeightInPoints = 25; //行高
                    int cellIndex = 0;//开始列索引
                    #region 弃用
                    //for (int i = 0; i < table.Columns.Count; i++)
                    //{
                    //    if (!table.Columns[i].ToString().EndsWith("_wennull"))
                    //    {
                    //        if (table.Columns[i].DataType.ToString() == "System.DateTime")//日期型
                    //        {
                    //            tb.SetColumnWidth(cellIndex, 20 * 256);//行宽10个汉字
                    //            dateCellIndex.Add(cellIndex);
                    //        }
                    //        else
                    //        {
                    //            tb.SetColumnWidth(cellIndex, 16 * 256);//行宽8个汉字
                    //        }
                    //        ICell cell = row.GetCell(cellIndex, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                    //        cell.CellStyle = headStyle;
                    //        cell.SetCellValue(table.Columns[i].ToString());//循环往第二行的单元格中添加数据
                    //        cellIndex++;
                    //    }
                    //} 
                    #endregion
                    foreach (var item in excelDataMap)
                    {
                        string columsName = item.Value;
                        if (table.Columns[columsName].DataType.ToString() == "System.DateTime")//日期型
                        {
                            tb.SetColumnWidth(cellIndex, 20 * 256);//行宽10个汉字
                            dateCellIndex.Add(cellIndex);
                        }
                        else
                        {
                            tb.SetColumnWidth(cellIndex, 16 * 256);//行宽8个汉字
                        }
                        ICell cell = row.GetCell(cellIndex, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                        cell.CellStyle = headStyle;
                        cell.SetCellValue(table.Columns[columsName].ToString());//循环往第二行的单元格中添加数据
                        cellIndex++;
                    }
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    IRow row = tb.CreateRow(rowIndex + i);//创建一行
                    row.HeightInPoints = 20; //行高
                    int cellIndex = 0;//开始列索引
                    #region 弃用
                    //for (int c = 0; c < table.Columns.Count; c++)
                    //{
                    //    if (!table.Columns[c].ToString().EndsWith("_wennull"))
                    //    {
                    //        ICell cell = row.GetCell(cellIndex, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                    //        if (table.Columns[c].DataType.ToString() == "System.DateTime")//日期型
                    //        {
                    //            string value = table.Rows[i][c].ToString();
                    //            if (value != "")
                    //            {
                    //                cell.SetCellValue(Convert.ToDateTime(value).ToString("yyyy-MM-dd HH:mm:ss"));//循环往第二行的单元格中添加数据
                    //            }
                    //            cell.CellStyle = dateStyle;
                    //        }
                    //        else
                    //        {
                    //            cell.SetCellValue(table.Rows[i][c].ToString());//循环往第二行的单元格中添加数据
                    //            cell.CellStyle = stylerow;
                    //        }
                    //        cellIndex++;
                    //    }
                    //} 
                    #endregion

                    foreach (var item in excelDataMap)
                    {
                        string columsName = item.Value;
                        ICell cell = row.GetCell(cellIndex, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                        if (table.Columns[columsName].DataType.ToString() == "System.DateTime")//日期型
                        {
                            string value = table.Rows[i][columsName].ToString();
                            if (value != "")
                            {
                                cell.SetCellValue(Convert.ToDateTime(value).ToString("yyyy-MM-dd HH:mm:ss"));//循环往第二行的单元格中添加数据
                            }
                            cell.CellStyle = dateStyle;
                        }
                        else if (table.Columns[columsName].DataType.ToString() == "System.Decimal")
                        {
                            string value = table.Rows[i][columsName].ToString();
                            if (value != "")
                            {
                                cell.SetCellValue(Convert.ToDouble(value));//循环往第二行的单元格中添加数据
                            }
                            //cell.CellStyle = numStyle;//数字格式化，不启用
                        }
                        else
                        {
                            cell.SetCellValue(table.Rows[i][columsName].ToString());//循环往第二行的单元格中添加数据
                            cell.CellStyle = stylerow;
                        }
                        cellIndex++;
                    }
                }
                //foreach (int cellIndex in dateCellIndex)
                //{
                //    for (int y = table.Rows.Count; y < 500; y++)//至少设置500行格式
                //    {
                //        IRow row = tb.CreateRow(rowIndex + y);//创建一行
                //        row.HeightInPoints = 20; //行高
                //        ICell cell = row.GetCell(cellIndex, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                //        //cell.SetCellValue("");//循环往第二行的单元格中添加数据
                //        cell.CellStyle = dateStyle;
                //    }
                //}
                using (FileStream fs = File.OpenWrite(savePath)) //打开一个xls文件，如果没有则自行创建，如果存在myxls.xls文件则在创建是不要打开该文件！
                {
                    wk.Write(fs);   //向打开的这个xls文件中写入mySheet表并保存。
                }
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 将集合类转换成DataTable
        /// </summary>
        /// <param name="list">集合</param>
        /// <returns></returns>
        public static DataTable ToDataTable(IList list, string className, string note = "")
        {
            DataTable table = new DataTable();
            if (list.Count > 0)
            {
                System.Reflection.PropertyInfo[] propertys = list[0].GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    //result.Columns.Add(pi.Name);
                    string fullName = pi.PropertyType.FullName;
                    if (fullName.Contains("System.DateTime"))
                    {//日期型
                        table.Columns.Add(pi.Name, typeof(DateTime));
                    }
                    else if (fullName.Contains("System.Decimal"))
                    {//日期型
                        table.Columns.Add(pi.Name, typeof(Decimal));
                    }
                    else
                    {
                        table.Columns.Add(pi.Name, typeof(String));
                    }
                }

                table = ReplaceColumnsNameToExcel(table, className, note);

                for (int i = 0; i < list.Count; i++)
                {
                    DataRow row = table.NewRow();
                    for (int j = 0; j < propertys.Length; j++)
                    {
                        //string piName = propertys[j].Name;
                        object obj = propertys[j].GetValue(list[i], null);
                        row[j] = obj == null ? DBNull.Value : obj;
                    }
                    table.Rows.Add(row);
                    //ArrayList tempList = new ArrayList();
                    //foreach (PropertyInfo pi in propertys)
                    //{
                    //    object obj = pi.GetValue(list[i], null);
                    //    tempList.Add(obj);
                    //}
                    //object[] array = tempList.ToArray();
                    //table.LoadDataRow(array, true);
                }
            }
            return table;
        }
        //public void SetValue(int rowIndex, int columnIndex, string value)
        //{
        //    IRow row = Sheet.GetRow(rowIndex);  //读取当前行数据
        //    ICell cell = row.GetCell(columnIndex);
        //    cell.SetCellValue(value);
        //}
        public void SetValue(int rowIndex, int columnIndex)
        {


        }
        #endregion

        #region 方法
        /// <summary>
        /// 获取一行，如果没有则创建
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        //private IRow GetRowByExtend(int rowIndex)
        //{
        //    IRow row = Sheet.GetRow(rowIndex);
        //    if (row == null)
        //        row = Sheet.CreateRow(rowIndex);
        //    return row;
        //}
        private string GetCellValue(ICell cell)
        {
            if (cell == null)
                return string.Empty;
            switch (cell.CellType)
            {

                case CellType.Blank:
                    return string.Empty;
                case CellType.Boolean:
                    return cell.BooleanCellValue.ToString().Trim();
                case CellType.Error:
                    return cell.ErrorCellValue.ToString().Trim();
                case CellType.String:
                    return cell.StringCellValue.Trim();
                case CellType.Formula:
                    try
                    {
                        HSSFFormulaEvaluator e = new HSSFFormulaEvaluator(cell.Sheet.Workbook);
                        e.EvaluateInCell(cell);
                        return cell.ToString().Trim();
                    }
                    catch
                    {
                        return cell.NumericCellValue.ToString().Trim();
                    }
                case CellType.Numeric:
                case CellType.Unknown:
                default:
                    return cell.ToString().Trim();
            }
        }
        #endregion

        //用字段名替换EXCEL表头名
        public static DataTable ReplaceColumnsName(DataTable dt, string className)
        {
            Dictionary<string, string> excelDataMap = ReadXml(className, true);
            bool flag = false;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                string columnName = dt.Columns[i].ColumnName.Trim();//excel表头名
                if (excelDataMap.ContainsKey(columnName))//如果有此表头对应字段名
                {
                    flag = true;
                    dt.Columns[i].ColumnName = excelDataMap[columnName];//替换为数据库字段名
                }
            }
            //如果表头一个也不对
            return flag ? dt : null;
        }
        //用EXCEL表头名替换字段名
        public static DataTable ReplaceColumnsNameToExcel(DataTable dt, string className, string note = "")
        {
            Dictionary<string, string> excelDataMap = ReadXml(className, false, note);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                string columnName = dt.Columns[i].ColumnName.Trim();//数据库字段名
                if (excelDataMap.ContainsKey(columnName))//如果有此表头对应excel表头名
                {
                    dt.Columns[i].ColumnName = excelDataMap[columnName];//替换为excel表头名
                }
                #region 弃用
                else
                {
                    dt.Columns[i].ColumnName = dt.Columns[i].ColumnName + "_wennull";//替换为加特殊后缀的名称
                }
                #endregion
            }
            return dt;
        }

        public static Dictionary<string, string> ReadXml(string className, bool flag, string note="")
        {
            Dictionary<string, string> excelDataMap = new Dictionary<string, string>();
            //HttpRuntime.AppDomainAppPath 网站在服务器磁盘上的物理路径
            //任何于Request/HttpContext.Current等相关的方法, 都只能在有请求上下文或者页面时使用. 即在无请求上下文时,HttpContext.Current为null. 而HttpRuntime.AppDomainAppPath方法一直可用.
            string path = Path.Combine(HttpRuntime.AppDomainAppPath, "Content", "UpLoadExcel\\Excel_Data_Map.xml");
            //string path = Path.Combine(HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath), "Content", "UpLoadExcel\\Excel_Data_Map.xml");
            //以下沈阳局自动导计划专用D:\\Visual Studio 2012\\Projects\\code\\Platforms-gw\\Platforms\\Web
            //string path = Path.Combine("D:\\WebFile\\sygw", "Content", "UpLoadExcel\\Excel_Data_Map.xml");
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);

            XmlNodeList listNodes = xmlDocument.SelectNodes("/datatable/dataname[@name='" + className + "']/item");
            bool orderflag = false;//是否启用排序
            foreach (XmlElement node in listNodes)
            {
                if (flag)//导入
                {
                    if (excelDataMap.ContainsKey(node.GetAttribute("key")))
                    {
                        string xx = node.GetAttribute("key");
                    }
                    else
                    {
                        excelDataMap.Add(node.GetAttribute("key"), node.GetAttribute("value"));
                    }
                }
                else//导出
                {
                    string order = node.GetAttribute("order");
                    if (order != "")
                    {
                        orderflag = true;//启用排序
                    }
                    else
                    {
                        order = "9999";
                    }
                    if (note == "")
                    {
                        excelDataMap.Add(order + "#" + node.GetAttribute("value"), node.GetAttribute("key"));
                    }
                    else
                    {
                        if (node.GetAttribute("note").IndexOf(note)>-1)
                        {
                            if (node.GetAttribute("note").IndexOf("|") > -1)//如果属于共用字段
                            {
                                int j = 0;//所在位置
                                string[] notes = node.GetAttribute("note").Split('|');
                                for (int i = 0; i < notes.Length; i++)
                                {
                                    if (notes[i] == note)
                                    {
                                        j = i;
                                        break;
                                    }
                                }
                                try
                                {
                                   order = order.Split('|')[j];
                                }
                                catch (Exception)
                                {
                                }
                            }
                            excelDataMap.Add(order + "#" + node.GetAttribute("value"), node.GetAttribute("key"));
                        }
                    }
                }
            }
            if (!flag)//导出
            {
                if (orderflag)//导出时启用排序
                {
                    excelDataMap = excelDataMap.OrderBy(i => i.Key.Split('#')[0].Length).ThenBy(i => i.Key.Split('#')[0]).ToDictionary(o => o.Key.Split('#')[1], p => p.Value);
                }
                else
                {
                    excelDataMap = excelDataMap.ToDictionary(o => o.Key.Split('#')[1], p => p.Value);
                }
            }
            return excelDataMap;

        }

        #region 模板导出
        /// <summary>
        /// 
        /// </summary>
        /// <param name="savePath"></param>
        /// <param name="mbPath"></param>
        /// <param name="listJob"></param>
        /// <param name="className"></param>
        /// <param name="startRow">从第几行开始写入</param>
        /// <param name="startCell">从第几列开始写入</param>
        /// <param name="note"></param>
        /// <returns></returns>
        public static bool ToMbExcel(string savePath, string mbPath, IList listJob, string className, int startRow, int startCell, string note = "", string HeadName = "", int rowHeight = 20)
        {
            try
            {
                DataTable table = ExcelExtHelper.ToDataTable(listJob, className, note);
                
                Dictionary<string, string> excelDataMap = ReadXml(className, false, note);

                IWorkbook workbook;

                try
                {
                    using (FileStream file = new FileStream(mbPath, FileMode.Open, FileAccess.Read))
                    {
                        workbook = new HSSFWorkbook(file);//创建对应文件EXCEL2003
                    }
                }
                catch (Exception ex)
                {
                    using (FileStream file = new FileStream(mbPath, FileMode.Open, FileAccess.Read))
                    {
                        workbook = new XSSFWorkbook(file);//创建对应文件EXCEL2007
                    }
                }

                ISheet sheet = workbook.GetSheetAt(0);
                if (HeadName != "")
                {
                    IRow rowhead = sheet.GetRow(0);
                    ICell cellhead = rowhead.GetCell(0);
                    cellhead.SetCellValue(HeadName);//写入表头
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    IRow row = sheet.CreateRow(i + startRow - 1);
                    row.HeightInPoints = rowHeight; //行高
                    int cellIndex = startCell;//开始列索引

                    foreach (var item in excelDataMap)
                    {
                        string columsName = item.Value;
                        ICell cell = row.GetCell(cellIndex, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                        if (table.Columns[columsName].DataType.ToString() == "System.DateTime")//日期型
                        {
                            string value = table.Rows[i][columsName].ToString();
                            if (value != "")
                            {
                                cell.SetCellValue(Convert.ToDateTime(value).ToString("yyyy-MM-dd HH:mm:ss"));//循环往第二行的单元格中添加数据
                            }
                            //cell.CellStyle = dateStyle;
                        }
                        else
                        {
                            cell.SetCellValue(table.Rows[i][columsName].ToString());//循环往第二行的单元格中添加数据
                            //cell.CellStyle = stylerow;
                        }
                        cellIndex++;
                    }
                }



                using (MemoryStream ms = new MemoryStream())
                {
                    using (FileStream fs = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(fs);
                    }
                }

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        #endregion




        #region 单表模板导出
        /// <summary>
        /// 
        /// </summary>
        /// <param name="savePath"></param>
        /// <param name="mbPath"></param>
        /// <param name="dataList"></param>
        /// <returns></returns>
        public static bool ToSingleMbExcel(string savePath, string mbPath, List<SingleMb> dataList)
        {
            try
            {

                IWorkbook workbook;

                try
                {
                    using (FileStream file = new FileStream(mbPath, FileMode.Open, FileAccess.Read))
                    {
                        workbook = new HSSFWorkbook(file);//创建对应文件EXCEL2003
                    }
                }
                catch (Exception ex)
                {
                    using (FileStream file = new FileStream(mbPath, FileMode.Open, FileAccess.Read))
                    {
                        workbook = new XSSFWorkbook(file);//创建对应文件EXCEL2007
                    }
                }

                ISheet sheet = workbook.GetSheetAt(0);
                ICellStyle cellStyle = workbook.CreateCellStyle();
                cellStyle.WrapText = true;//换行
                foreach (SingleMb item in dataList)
                {
                    IRow row = sheet.GetRow(item.rowIndex-1);
                    if (row == null)
                    {
                        row = sheet.CreateRow(item.rowIndex-1);
                    }

                    ICell cell = row.GetCell(item.cellIndex-1, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                    //cell.CellStyle = cellStyle;
                    cell.SetCellValue(item.value);//循环往第二行的单元格中添加数据
                }

                using (MemoryStream ms = new MemoryStream())
                {
                    using (FileStream fs = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(fs);
                    }
                }

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool ToSingleMbExcels(string savePath, string mbPath, List<SingleMb> dataList, string gwdcode, int rownum)
        {
            try
            {

                IWorkbook workbook;

                try
                {
                    using (FileStream file = new FileStream(mbPath, FileMode.Open, FileAccess.Read))
                    {
                        workbook = new HSSFWorkbook(file);//创建对应文件EXCEL2003
                    }
                }
                catch (Exception ex)
                {
                    using (FileStream file = new FileStream(mbPath, FileMode.Open, FileAccess.Read))
                    {
                        workbook = new XSSFWorkbook(file);//创建对应文件EXCEL2007
                    }
                }

                #region 样式
                HSSFCellStyle style = (HSSFCellStyle)workbook.CreateCellStyle();
                style.WrapText = true;

                style.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                style.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                style.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                style.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;

                HSSFFont font = (HSSFFont)workbook.CreateFont();
                //font.FontName = "宋体";
                font.FontName = "Arial Narrow";
                font.FontHeightInPoints = 9;
                style.SetFont(font);

                HSSFFont fontSmall = (HSSFFont)workbook.CreateFont();
                fontSmall.FontName = "Arial Narrow";
                fontSmall.FontHeightInPoints = 8;
                #endregion


                ISheet sheet = workbook.GetSheetAt(0);
                ICellStyle cellStyle = workbook.CreateCellStyle();
                cellStyle.WrapText = true;//换行
                foreach (SingleMb item in dataList)
                {
                    IRow row = sheet.GetRow(item.rowIndex - 1);
                    if (row == null)
                    {
                        row = sheet.CreateRow(item.rowIndex - 1);
                    }

                    ICell cell = row.GetCell(item.cellIndex - 1, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                    //cell.CellStyle = cellStyle;
                    cell.SetCellValue(item.value);//循环往第二行的单元格中添加数据
                }
                #region 插入图片
                string gwdgz = gwdcode;
                string imageFilePath = HttpContext.Current.Server.MapPath("/Content/TASK/images/");

                if (System.IO.File.Exists(imageFilePath + gwdgz + ".png"))
                {
                    byte[] bytes = System.IO.File.ReadAllBytes(imageFilePath + gwdgz + ".png");
                    //int pictureIdx = myWorkbook.AddPicture(bytes, HSSFWorkbook.PICTURE_TYPE_JPEG);
                    int pictureIdx = workbook.AddPicture(bytes, NPOI.SS.UserModel.PictureType.PNG);


                    // Create the drawing patriarch.  This is the top level container for all shapes. 
                    HSSFPatriarch patriarch = (HSSFPatriarch)sheet.CreateDrawingPatriarch();

                    //add a picture
                    //dx1：起始单元格的x偏移量，如例子中的255表示直线起始位置距A1单元格左侧的距离；
                    //dy1：起始单元格的y偏移量，如例子中的125表示直线起始位置距A1单元格上侧的距离；
                    //dx2：终止单元格的x偏移量，如例子中的1023表示直线起始位置距C3单元格左侧的距离；
                    //dy2：终止单元格的y偏移量，如例子中的150表示直线起始位置距C3单元格上侧的距离；
                    //col1：起始单元格列序号，从0开始计算；
                    //row1：起始单元格行序号，从0开始计算，如例子中col1=0,row1=0就表示起始单元格为A1；
                    //col2：终止单元格列序号，从0开始计算；
                    //row2：终止单元格行序号，从0开始计算，如例子中col2=2,row2=2就表示起始单元格为C3；
                    HSSFClientAnchor anchor = new HSSFClientAnchor(0, 0, 0, 0, 13, 0, 14, 4);
                    HSSFPicture pict = (HSSFPicture)patriarch.CreatePicture(anchor, pictureIdx);

                    //anchor = new HSSFClientAnchor(0, 0, 0, 0, 13, 11, 15, 14);
                    //HSSFPicture pict1 = (HSSFPicture)patriarch.CreatePicture(anchor, pictureIdx);
                    //pict.Resize();
                }

                #endregion

                #region  放入问题表格边框
                for (int i = 23; i < rownum - 1; i++)
                {
                    for (int j = 0; j <= 13; j++)
                    {
                        sheet.GetRow(i).GetCell(j).CellStyle = style;
                        if (j == 0)
                        {
                            sheet.GetRow(i).GetCell(j).CellStyle.SetFont(fontSmall);
                        }
                    }
                }
                #endregion

                using (MemoryStream ms = new MemoryStream())
                {
                    using (FileStream fs = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(fs);
                    }
                }

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        #endregion


        #region 示例备份
        /*
        //创建一个常用的xls文件
        private void button3_Click(object sender, EventArgs e)
        {
            IWorkbook wb = new HSSFWorkbook();
            //创建表 
            ISheet sh = wb.CreateSheet("zhiyuan");
            //设置单元的宽度 
            sh.SetColumnWidth(0, 15 * 256);
            sh.SetColumnWidth(1, 35 * 256);
            sh.SetColumnWidth(2, 15 * 256);
            sh.SetColumnWidth(3, 10 * 256);
            int i = 0;
            #region 练习合并单元格
            sh.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(0, 0, 0, 3));

            //CellRangeAddress（）该方法的参数次序是：开始行号，结束行号，开始列号，结束列号。

            IRow row0 = sh.CreateRow(0);
            row0.Height = 20 * 20;
            ICell icell1top0 = row0.CreateCell(0);
            icell1top0.CellStyle = Getcellstyle(wb, stylexls.头);
            icell1top0.SetCellValue("标题合并单元");
            #endregion
            i++;
            #region 设置表头
            IRow row1 = sh.CreateRow(1);
            row1.Height = 20 * 20;

            ICell icell1top = row1.CreateCell(0);
            icell1top.CellStyle = Getcellstyle(wb, stylexls.头);
            icell1top.SetCellValue("网站名");

            ICell icell2top = row1.CreateCell(1);
            icell2top.CellStyle = Getcellstyle(wb, stylexls.头);
            icell2top.SetCellValue("网址");

            ICell icell3top = row1.CreateCell(2);
            icell3top.CellStyle = Getcellstyle(wb, stylexls.头);
            icell3top.SetCellValue("百度快照");

            ICell icell4top = row1.CreateCell(3);
            icell4top.CellStyle = Getcellstyle(wb, stylexls.头);
            icell4top.SetCellValue("百度收录");
            #endregion

            using (FileStream stm = File.OpenWrite(@"c:/myMergeCell.xls"))
            {
                wb.Write(stm);
                MessageBox.Show("提示：创建成功！");
            }
        }



        #region 定义单元格常用到样式的枚举
        public enum stylexls
        {
            头,
            url,
            时间,
            数字,
            钱,
            百分比,
            中文大写,
            科学计数法,
            默认
        }
        #endregion


        #region 定义单元格常用到样式
        static ICellStyle Getcellstyle(IWorkbook wb, stylexls str)
        {
            ICellStyle cellStyle = wb.CreateCellStyle();

            //定义几种字体 
            //也可以一种字体，写一些公共属性，然后在下面需要时加特殊的 
            IFont font12 = wb.CreateFont();
            font12.FontHeightInPoints = 10;
            font12.FontName = "微软雅黑";


            IFont font = wb.CreateFont();
            font.FontName = "微软雅黑";
            //font.Underline = 1;下划线 


            IFont fontcolorblue = wb.CreateFont();
            fontcolorblue.Color = HSSFColor.OLIVE_GREEN.BLUE.index;
            fontcolorblue.IsItalic = true;//下划线 
            fontcolorblue.FontName = "微软雅黑";


            //边框 
            cellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.DOTTED;
            cellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.HAIR;
            cellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.HAIR;
            cellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.DOTTED;
            //边框颜色 
            cellStyle.BottomBorderColor = HSSFColor.OLIVE_GREEN.BLUE.index;
            cellStyle.TopBorderColor = HSSFColor.OLIVE_GREEN.BLUE.index;

            //背景图形，我没有用到过。感觉很丑 
            //cellStyle.FillBackgroundColor = HSSFColor.OLIVE_GREEN.BLUE.index; 
            //cellStyle.FillForegroundColor = HSSFColor.OLIVE_GREEN.BLUE.index; 
            cellStyle.FillForegroundColor = HSSFColor.WHITE.index;
            // cellStyle.FillPattern = FillPatternType.NO_FILL; 
            cellStyle.FillBackgroundColor = HSSFColor.BLUE.index;

            //水平对齐 
            cellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.LEFT;

            //垂直对齐 
            cellStyle.VerticalAlignment = VerticalAlignment.CENTER;

            //自动换行 
            cellStyle.WrapText = true;

            //缩进;当设置为1时，前面留的空白太大了。希旺官网改进。或者是我设置的不对 
            cellStyle.Indention = 0;

            //上面基本都是设共公的设置 
            //下面列出了常用的字段类型 
            switch (str)
            {
                case stylexls.头:
                    // cellStyle.FillPattern = FillPatternType.LEAST_DOTS; 
                    cellStyle.SetFont(font12);
                    break;
                case stylexls.时间:
                    IDataFormat datastyle = wb.CreateDataFormat();

                    cellStyle.DataFormat = datastyle.GetFormat("yyyy/mm/dd");
                    cellStyle.SetFont(font);
                    break;
                case stylexls.数字:
                    cellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("0.00");
                    cellStyle.SetFont(font);
                    break;
                case stylexls.钱:
                    IDataFormat format = wb.CreateDataFormat();
                    cellStyle.DataFormat = format.GetFormat("￥#,##0");
                    cellStyle.SetFont(font);
                    break;
                case stylexls.url:
                    fontcolorblue.Underline = 1;
                    cellStyle.SetFont(fontcolorblue);
                    break;
                case stylexls.百分比:
                    cellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("0.00%");
                    cellStyle.SetFont(font);
                    break;
                case stylexls.中文大写:
                    IDataFormat format1 = wb.CreateDataFormat();
                    cellStyle.DataFormat = format1.GetFormat("[DbNum2][$-804]0");
                    cellStyle.SetFont(font);
                    break;
                case stylexls.科学计数法:
                    cellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("0.00E+00");
                    cellStyle.SetFont(font);
                    break;
                case stylexls.默认:
                    cellStyle.SetFont(font);
                    break;
            }
            return cellStyle;


        }
         * */
        #endregion
       
    }

    public class SingleMb{

        public int rowIndex { get; set; }
        public int cellIndex { get; set; }
        public string value { get; set; }
    }
}