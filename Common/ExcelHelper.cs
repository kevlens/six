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
    public class ExcelHelper
    {
        public ExcelHelper()
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
                            amm.Statu = AjaxStatu.err;
                            amm.Msg = "表头名不能为空！";

                            return amm;
                        }
                        dt.Columns.Add(columnName.Trim(), typeof(string));
                       
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
                                if (readvalue.IndexOf("/") > -1)//如果是日期
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
        public static bool ToExcel(string savePath, string SheetName, string HeadName, IList listJob, string className)
        {
            try
            {

                DataTable table = ToDataTable(listJob, className);
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
                #endregion

                #region 日期行样式
                ICellStyle dateStyle = wk.CreateCellStyle();
                IDataFormat format = wk.CreateDataFormat();
                dateStyle.DataFormat = format.GetFormat("yyyy-MM-dd HH:mm:ss");
                #endregion
                Dictionary<string, string> excelDataMap = ReadXml(className, false);
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


        public static bool ToExcelDate(string savePath, string SheetName, string HeadName, IList listJob, string className)
        {
            try
            {

                DataTable table = ToDataTable(listJob, className);
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
                #endregion

                #region 日期行样式
                ICellStyle dateStyle = wk.CreateCellStyle();
                IDataFormat format = wk.CreateDataFormat();
                dateStyle.DataFormat = format.GetFormat("yyyy-MM-dd");
                #endregion
                Dictionary<string, string> excelDataMap = ReadXml(className, false);
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
                                cell.SetCellValue(Convert.ToDateTime(value).ToString("yyyy-MM-dd"));//循环往第二行的单元格中添加数据
                            }
                            cell.CellStyle = dateStyle;
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
        public static DataTable ToDataTable(IList list, string className)
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
                    else
                    {
                        table.Columns.Add(pi.Name, typeof(String));
                    }
                }

                table = ReplaceColumnsNameToExcel(table, className);

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
        public static DataTable ReplaceColumnsNameToExcel(DataTable dt, string className)
        {
            Dictionary<string, string> excelDataMap = ReadXml(className, false);
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

        public static Dictionary<string, string> ReadXml(string className, bool flag)
        {
            Dictionary<string, string> excelDataMap = new Dictionary<string, string>();
            //HttpRuntime.AppDomainAppPath 网站在服务器磁盘上的物理路径
            //任何于Request/HttpContext.Current等相关的方法, 都只能在有请求上下文或者页面时使用. 即在无请求上下文时,HttpContext.Current为null. 而HttpRuntime.AppDomainAppPath方法一直可用.
            string path = Path.Combine(HttpRuntime.AppDomainAppPath, "Content", "UpLoadExcel\\Excel_Data_Map.xml");
            //string path = Path.Combine(HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath), "Content", "UpLoadExcel\\Excel_Data_Map.xml");

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);

            //XmlNodeList listNodes = xmlDocument.SelectNodes("/datatable/dataname[@name='" + className + "']/item[@note='太原']");
            XmlNodeList listNodes = xmlDocument.SelectNodes("/datatable/dataname[@name='" + className + "']/item");
            foreach (XmlElement node in listNodes)
            {
                if (flag)
                {
                    excelDataMap.Add(node.GetAttribute("key"), node.GetAttribute("value"));
                }
                else
                {
                    excelDataMap.Add(node.GetAttribute("value"), node.GetAttribute("key"));
                }
            }
            return excelDataMap;

        }

        //public static string  trdd()
        //{
        //    return "p";
        //}

        #region wq

        public static string WriteData(DataTable dt, string templatefilename, string caption, int startrow, int startcol, string templateFilePath, string tempFilePath)
        {
            try
            {
                FileStream file = new FileStream(templateFilePath + templatefilename + ".xls", FileMode.Open, FileAccess.Read);
                HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);
                HSSFSheet tworksheet = (HSSFSheet)hssfworkbook.GetSheet("Sheet1");

                file.Close();
                HSSFCellStyle style = (HSSFCellStyle)hssfworkbook.CreateCellStyle();
                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                style.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                style.WrapText = true;

                //style.BorderBottom = (CellBorderType)NPOI.SS.UserModel.BorderStyle.THIN;
                //style.BorderLeft = (CellBorderType)NPOI.SS.UserModel.BorderStyle.THIN;
                //style.BorderRight = (CellBorderType)NPOI.SS.UserModel.BorderStyle.THIN;
                //style.BorderTop = (CellBorderType)NPOI.SS.UserModel.BorderStyle.THIN;

                HSSFFont font = (HSSFFont)hssfworkbook.CreateFont();
                font.FontName = "宋体";
                font.FontHeightInPoints = 10;
                style.SetFont(font);

                for (int i = startrow; i <= dt.Rows.Count + startrow - 1; i++)
                {
                    HSSFRow row = (HSSFRow)tworksheet.CreateRow(i - 1);
                    for (int j = startcol; j <= dt.Columns.Count + startcol - 1; j++)
                    {
                        HSSFCell cell = (HSSFCell)row.CreateCell(j - 1);
                        cell.SetCellValue(dt.Rows[i - startrow][j - startcol].ToString().Trim());
                        cell.CellStyle = style;
                    }
                }

                FileStream file1 = new FileStream(tempFilePath + templatefilename + ".xls", FileMode.Create);
                hssfworkbook.Write(file1);
                file1.Close();

                return file1.Name;
            }
            catch (Exception e)
            {
                return "";
            }
        }

        //public void OutputBinayStream(System.IO.FileInfo file, HttpContext context)
        //{
        //    #region Output Binary Stream
        //    context.Response.Clear();
        //    context.Response.Charset = "GB2312";
        //    context.Response.AddHeader("Content-Disposition", "attachment; filename=" + System.Web.HttpContext.Current.Server.UrlEncode(file.Name));
        //    context.Response.AddHeader("Content-Length", file.Length.ToString());
        //    context.Response.ContentType = "application/ms-excel";
        //    context.Response.WriteFile(file.FullName);
        //    context.Response.End();
        //    #endregion
        //}

        #endregion

        #region  动态转换成excel
        public static bool ToExcelDynamic(string savePath, string SheetName, string HeadName, DataTable table, Dictionary<string, string> excelDataMap)
        {
            try
            {
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
                #endregion

                #region 日期行样式
                ICellStyle dateStyle = wk.CreateCellStyle();
                IDataFormat format = wk.CreateDataFormat();
                dateStyle.DataFormat = format.GetFormat("yyyy-MM-dd HH:mm:ss");
                #endregion

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

                    foreach (var item in excelDataMap)
                    {
                        string columsName = item.Value;
                       
                        tb.SetColumnWidth(cellIndex, 16 * 256);//行宽8个汉字
                        ICell cell = row.GetCell(cellIndex, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                        cell.CellStyle = headStyle;
                        if (columsName == "DEPT_NAME")
                        {
                            cell.SetCellValue("单位名称");
                        }
                        else
                        {
                            cell.SetCellValue(table.Columns[columsName].ToString());//循环往第二行的单元格中添加数据
                        }
                        cellIndex++;
                    }
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    IRow row = tb.CreateRow(rowIndex + i);//创建一行
                    row.HeightInPoints = 20; //行高
                    int cellIndex = 0;//开始列索引

                    foreach (var item in excelDataMap)
                    {
                        string columsName = item.Value;
                        ICell cell = row.GetCell(cellIndex, MissingCellPolicy.CREATE_NULL_AS_BLANK); //在行中创建单元格
                      
                        cell.SetCellValue(table.Rows[i][columsName].ToString());//循环往第二行的单元格中添加数据
                        cell.CellStyle = stylerow;
                       
                        cellIndex++;
                    }
                }

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
        #endregion
    }
}