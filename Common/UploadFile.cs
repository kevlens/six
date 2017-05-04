using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Model;

namespace Common
{
    public class UploadFile
    {
        public AjaxMsgModel ToUpLoad(HttpFileCollectionBase files, AjaxMsgModel amm, int width, int height, string pathstr = "UpLoadImg")
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
            string fileAble = Path.GetExtension(upfile.FileName).ToLower();//文件后缀
            if (upfile == null || (fileAble != ".jpg" && fileAble != ".jpeg" && fileAble != ".png" && fileAble != "bmp"))
            {
                return amm;
            }
            //获取文件大小
            long contentLength = upfile.ContentLength;
            //文件不能大于10M
            if (contentLength > 1024 * 10240)
            {
                amm.Msg = "上传文件不能大于10M";
                return amm;
            }
            //要保存的文件路径
            //HttpRuntime.AppDomainAppPath 网站在服务器磁盘上的物理路径
            //任何于Request/HttpContext.Current等相关的方法, 都只能在有请求上下文或者页面时使用. 即在无请求上下文时,HttpContext.Current为null. 而HttpRuntime.AppDomainAppPath方法一直可用.
            string path = Path.Combine(HttpRuntime.AppDomainAppPath, "Content", pathstr);
            //string path = Path.Combine(HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath), "Content", "UpLoadImg");
            //要保存的文件名称
            string fileName = string.Format("{0}_{1}{2}", "Y", DateTime.Now.ToString("yyyyMMddHHmmssffff"), Path.GetExtension(upfile.FileName));
            //保存文件到指定的目录
            upfile.SaveAs(Path.Combine(path, fileName));

            //返回path
            amm = GetSmallImg(amm, path, fileName, width, height);
            amm.Data = "/Content/" + pathstr + "/" + fileName;
            return amm;
        }

        /// <summary>
        /// 生成缩略图 静态方法
        /// </summary>
        /// <param name="pathImageFrom"> 源图的路径(含文件名及扩展名) </param>
        /// <param name="pathImageTo"> 生成的缩略图所保存的路径(含文件名及扩展名)
        /// 注意：扩展名一定要与生成的缩略图格式相对应 </param>
        /// <param name="width"> 欲生成的缩略图 "画布" 的宽度(像素值) </param>
        /// <param name="height"> 欲生成的缩略图 "画布" 的高度(像素值) </param>
        public AjaxMsgModel GetSmallImg(AjaxMsgModel amm, string path, string fileName, int width, int height)
        {
            string pathImageFrom = path + "\\" + fileName;
            string pathImageTo = path + "\\" + fileName.Replace("Y", "I");
            Image imageFrom = null;

            try
            {
                imageFrom = Image.FromFile(pathImageFrom);
            }
            catch
            {
                return amm;
                //throw;
            }

            if (imageFrom == null)
            {
                return amm;
            }

            // 源图宽度及高度
            int imageFromWidth = imageFrom.Width;
            int imageFromHeight = imageFrom.Height;

            // 生成的缩略图实际宽度及高度
            int bitmapWidth = width;
            int bitmapHeight = height;

            // 生成的缩略图在上述"画布"上的位置
            int X = 0;
            int Y = 0;

            // 根据源图及欲生成的缩略图尺寸,计算缩略图的实际尺寸及其在"画布"上的位置
            if (bitmapHeight * imageFromWidth > bitmapWidth * imageFromHeight)
            {
                bitmapHeight = imageFromHeight * width / imageFromWidth;
                Y = (height - bitmapHeight) / 2;
            }
            else
            {
                bitmapWidth = imageFromWidth * height / imageFromHeight;
                X = (width - bitmapWidth) / 2;
            }

            // 创建画布
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);

            // 用白色清空
            g.Clear(Color.White);

            // 指定高质量的双三次插值法。执行预筛选以确保高质量的收缩。此模式可产生质量最高的转换图像。
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // 指定高质量、低速度呈现。
            g.SmoothingMode = SmoothingMode.HighQuality;

            // 在指定位置并且按指定大小绘制指定的 Image 的指定部分。
            g.DrawImage(imageFrom, new Rectangle(X, Y, bitmapWidth, bitmapHeight), new Rectangle(0, 0, imageFromWidth, imageFromHeight), GraphicsUnit.Pixel);

            try
            {
                //经测试 .jpg 格式缩略图大小与质量等最优
                bmp.Save(pathImageTo, ImageFormat.Jpeg);
                amm.Statu = AjaxStatu.ok;
                amm.Msg = "上传成功";
            }
            catch
            {
            }
            finally
            {
                //显示释放资源
                imageFrom.Dispose();
                bmp.Dispose();
                g.Dispose();
            }
            return amm;
        }



        public AjaxMsgModel ToUpLoadDoc(HttpFileCollectionBase files, AjaxMsgModel amm, string pathstr, string upfilename)
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
            string fileAble = Path.GetExtension(upfile.FileName).ToLower();//文件后缀
            if (upfile == null || (fileAble != ".doc" && fileAble != ".docx" && fileAble != ".xls" && fileAble != ".xlsx"))
            {
                return amm;
            }
            //获取文件大小
            long contentLength = upfile.ContentLength;
            //文件不能大于10M
            if (contentLength > 1024 * 102400)
            {
                amm.Msg = "上传文件不能大于100M";
                return amm;
            }
            //要保存的文件路径
            //HttpRuntime.AppDomainAppPath 网站在服务器磁盘上的物理路径
            //任何于Request/HttpContext.Current等相关的方法, 都只能在有请求上下文或者页面时使用. 即在无请求上下文时,HttpContext.Current为null. 而HttpRuntime.AppDomainAppPath方法一直可用.
            string path = Path.Combine(HttpRuntime.AppDomainAppPath, "Content", pathstr);
            FileHelper.CreateDirectory(path);
            //string path = Path.Combine(HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath), "Content", "UpLoadImg");
            //要保存的文件名称
            string fileName = string.Format("{0}{1}", upfilename, fileAble);
            //保存文件到指定的目录
            upfile.SaveAs(Path.Combine(path, fileName));

            //返回path
            amm = DocToSwf(amm, path, fileName);
            amm.Data = upfile.FileName;
            return amm;
        }


        public AjaxMsgModel ToUpLoadVideo(HttpFileCollectionBase files, AjaxMsgModel amm, string pathstr, string upfilename)
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
            string fileAble = Path.GetExtension(upfile.FileName).ToLower();//文件后缀
            if (upfile == null || (fileAble != ".mp4" && fileAble != ".flv"))
            {
                return amm;
            }
            //获取文件大小
            long contentLength = upfile.ContentLength;
            //文件不能大于10M
            if (contentLength > 1024 * 102400)
            {
                amm.Msg = "上传文件不能大于100M";
                return amm;
            }
            //要保存的文件路径
            //HttpRuntime.AppDomainAppPath 网站在服务器磁盘上的物理路径
            //任何于Request/HttpContext.Current等相关的方法, 都只能在有请求上下文或者页面时使用. 即在无请求上下文时,HttpContext.Current为null. 而HttpRuntime.AppDomainAppPath方法一直可用.
            string path = Path.Combine(HttpRuntime.AppDomainAppPath, "Content", pathstr);
            FileHelper.CreateDirectory(path);
            //string path = Path.Combine(HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath), "Content", "UpLoadImg");
            //要保存的文件名称
            string fileName = string.Format("{0}{1}", upfilename, fileAble);
            try
            {
                //保存文件到指定的目录
                upfile.SaveAs(Path.Combine(path, fileName));
                amm.Data = upfile.FileName;
                amm.Statu = AjaxStatu.ok;
                amm.Msg = "上传成功";
            }
            catch
            {
                amm.Statu = AjaxStatu.err;
                amm.Msg = "上传失败";
            }
            return amm;
        }

        #region 
        public AjaxMsgModel DocToSwf(AjaxMsgModel amm, string filePath, string fileName)
        {
            string swfFile = "error";
            string swfToolPath = HttpRuntime.AppDomainAppPath + "\\Content\\Rule\\swftools\\pdf2swf.exe";
            string hzName = Path.GetExtension(fileName);

            string docFilePath = filePath + "\\" + fileName;
            string pdfFilePath = filePath.Replace("\\Doc","\\Pdf");
            string pdfFileName = fileName.Replace(hzName, ".pdf");
            string swfFilePath = filePath.Replace("\\Doc", "\\Swf") +"\\";

            FileHelper.CreateDirectory(pdfFilePath);
            FileHelper.CreateDirectory(swfFilePath);

            if (FileHelper.IsExistFile(docFilePath))
            {
                if (hzName == ".doc" || hzName == ".docx")
                {
                    if (FileHelper.DocToPdf(docFilePath, pdfFilePath + "\\" + pdfFileName))
                    {
                        swfFile = FileHelper.PdfToSwf(swfToolPath, pdfFilePath, pdfFileName, swfFilePath);
                    }
                }
                if (hzName == ".xls" || hzName == ".xlsx")
                {
                    if (FileHelper.XlsToPdf(docFilePath, pdfFilePath + "\\" + pdfFileName, 4))
                    {
                        swfFile = FileHelper.PdfToSwf(swfToolPath, pdfFilePath, pdfFileName, swfFilePath);
                    }
                }
            }

            if (swfFile != "error")
            {
                amm.Statu = AjaxStatu.ok;
                amm.Msg = "上传成功";
            }
            else
            {
                amm.Statu = AjaxStatu.err;
                amm.Msg = "上传失败";
            }
            return amm;
        }
        #endregion
    }
}
