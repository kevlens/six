using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Common
{
    public static class XMLUtil
    {
        public static object DeserializeFromXml(string xmlPath, Type type)
        {
            try
            {
                object result = null;
                if (File.Exists(xmlPath))
                {
                    using (StreamReader sr = new StreamReader(xmlPath))
                    {
                        XmlSerializer xsa = new XmlSerializer(type);
                        result = xsa.Deserialize(sr);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                RecordLog.RecordError(xmlPath);
                RecordLog.RecordException(ex);
                return null;
            }
        }

        public static void SerializeToXml(object obj, Type type, string xmlPath, string xmlRootname)
        {
            try
            {
                if (obj != null && !string.IsNullOrEmpty(xmlPath))
                {
                    type = type != null ? type : obj.GetType();
                    using (StreamWriter sw = new StreamWriter(xmlPath))
                    {
                        XmlSerializer xsa = string.IsNullOrEmpty(xmlPath) ? new XmlSerializer(type)
                            : new XmlSerializer(type, new XmlRootAttribute(xmlRootname));
                        xsa.Serialize(sw, obj);
                    }
                }
            }
            catch (Exception ex)
            {
                RecordLog.RecordException(ex);
            }
        }
    }
}
