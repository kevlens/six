using log4net;
using log4net.Layout;
using log4net.Layout.Pattern;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class LogImplement
    {
        private ILog logger;

        public LogImplement(ILog log)
        {
            this.logger = log;
        }

        public void Debug(object message)
        {
            this.logger.Debug(message);
        }

        public void Debug(object message, Exception e)
        {
            this.logger.Debug(message, e);
        }

        public void Warming(object message)
        {
            this.logger.Warn(message);
        }

        public void Warming(object message, Exception e)
        {
            this.logger.Warn(message, e);
        }

        public void Error(object message)
        {
            this.logger.Error(message);
        }

        public void Error(object message, Exception e)
        {
            this.logger.Error(message, e);
        }

        public void Info(object message)
        {
            this.logger.Info(message);
        }

        public void Info(object message, Exception e)
        {
            this.logger.Info(message, e);
        }
    }

    public class LogFactory
    {
        static LogFactory()
        {
            FileInfo configFile = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"log4net.config");

            log4net.Config.XmlConfigurator.Configure(configFile);
        }

        public static LogImplement GetLogger(Type type)
        {
            return new LogImplement(LogManager.GetLogger(type));
        }

        public static LogImplement GetLogger(string str)
        {
            return new LogImplement(LogManager.GetLogger(str));
        }
    }
    public class RecordLog
    {
        public static void RecordException(Exception e)
        {
            LogImplement log = LogFactory.GetLogger("Error");

            log.Error(e.Message + e.StackTrace);
        }
        public static void RecordInfo(Type t, string e)
        {
            LogImplement log = LogFactory.GetLogger(t);

            log.Info(e);
        }
        public static void RecordInfo(string e)
        {
            LogImplement log = LogFactory.GetLogger("Info");

            log.Info(e);
        }
        public static void RecordError(string e)
        {
            LogImplement log = LogFactory.GetLogger("Error");

            log.Error(e);
        }
        public static void RecordError(Type t, string e)
        {
            LogImplement log = LogFactory.GetLogger(t);

            log.Error(e);
        }

        public static void RecordWarn(string e)
        {
            LogImplement log = LogFactory.GetLogger("Warn");

            log.Warming(e);
        }

        public static void RecordDBInfo(object e)
        {
            LogImplement log = LogFactory.GetLogger("myLogger");

            log.Info(e);
        }
    }
    class MyLayout : PatternLayout
    {
        public MyLayout()
        {
            this.AddConverter("property", typeof(MyMessagePatternConverter));
        }
    }
    /// <summary>
    /// 包含了所有的自定字段属性
    /// </summary>
    public class LogContent
    {
        /// <summary>
        /// 日志ID
        /// </summary>
        public string Log_ID { get; set; }
        /// <summary>
        /// 事件类型 均为3
        /// </summary>
        public int Event_Type { get; set; }

        /// <summary>
        /// 日志分类描述，自定义
        /// </summary>
        public string EventCategory { get; set; }


        /// <summary>
        /// 日志分类号
        /// </summary>
        public int Event_ID { get; set; }

        /// <summary>
        /// 计算机IP
        /// </summary>
        public string ComputerName { get; set; }

        /// <summary>
        /// 计算机Mac 地址
        /// </summary>
        public string Mac_Address { get; set; }

        /// <summary>
        /// 系统登陆用户
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Rier
        /// </summary>
        public string SourceType { get; set; }

        /// <summary>
        /// Rier Recorder audit
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 日志描述信息
        /// </summary>
        public string Description { get; set; }

    }

    public class MyMessagePatternConverter : PatternLayoutConverter
    {

        protected override void Convert(System.IO.TextWriter writer, log4net.Core.LoggingEvent loggingEvent)
        {

            if (Option != null)
            {

                // Write the value for the specified key

                WriteObject(writer, loggingEvent.Repository, LookupProperty(Option, loggingEvent));

            }

            else
            {

                // Write all the key value pairs

                WriteDictionary(writer, loggingEvent.Repository, loggingEvent.GetProperties());

            }

            //if (Option != null)

            //{

            //    // Write the value for the specified key

            //    WriteObject(writer, loggingEvent.Repository, loggingEvent.LookupProperty(Option));

            //}

            //else

            //{

            //    // Write all the key value pairs

            //    WriteDictionary(writer, loggingEvent.Repository, loggingEvent.GetProperties());

            //}

        }



        /// <summary>

        /// 通过反射获取传入的日志对象的某个属性的值

        /// </summary>

        /// <param name="property"></param>

        /// <returns></returns>

        private object LookupProperty(string property, log4net.Core.LoggingEvent loggingEvent)
        {

            object propertyValue = string.Empty;



            PropertyInfo propertyInfo = loggingEvent.MessageObject.GetType().GetProperty(property);

            if (propertyInfo != null)

                propertyValue = propertyInfo.GetValue(loggingEvent.MessageObject, null);



            return propertyValue;

        }

    }
}
