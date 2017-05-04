using Common;
using Model;
using Oracle.ManagedDataAccess.Client;
using Web.Areas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Configuration;

namespace Web.DBMonitor
{
    public class DBMonitorBase
    {
        private string connectString;
        protected OperContext oc = OperContext.CurrentContext;
        protected List<PersonColorConfig> config = new List<PersonColorConfig>();
        protected object sync = new object();
        // planPhoneLis { get; set; }
        private OracleConnection conn;
        public OracleConnection CONNECTION
        {
            get
            {

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                return conn;
            }
        }
        public string ConnectString
        {
            get
            {
                return WebConfigurationManager.ConnectionStrings["Oracle"].ConnectionString;
            }
        }


        public DBMonitorBase()
        {
            conn = new OracleConnection(ConnectString);
        }
        protected T DataSetToEntity<T>(DataSet p_DataSet, int p_TableIndex)
        {
            if (p_DataSet == null || p_DataSet.Tables.Count < 0)
                return default(T);
            if (p_TableIndex > p_DataSet.Tables.Count - 1)
                return default(T);
            if (p_TableIndex < 0)
                p_TableIndex = 0;
            if (p_DataSet.Tables[p_TableIndex].Rows.Count <= 0)
                return default(T);
            DataRow p_Data = p_DataSet.Tables[p_TableIndex].Rows[0];
            // 返回值初始化
            T _t = (T)Activator.CreateInstance(typeof(T));
            PropertyInfo[] propertys = _t.GetType().GetProperties();
            foreach (PropertyInfo pi in propertys)
            {
                if (p_DataSet.Tables[p_TableIndex].Columns.IndexOf(pi.Name.ToUpper()) != -1 && p_Data[pi.Name.ToUpper()] != DBNull.Value)
                {
                    if (p_Data[pi.Name.ToUpper()].GetType().Name == typeof(double).Name)
                    {
                        pi.SetValue(_t, Convert.ToDecimal(p_Data[pi.Name.ToUpper()]), null);
                    }
                    else
                    {
                        pi.SetValue(_t, p_Data[pi.Name.ToUpper()], null);
                    }
                }
                else
                {
                    pi.SetValue(_t, null, null);
                }
            }
            return _t;
        }

        protected List<T> DataSetToEntityList<T>(DataSet p_DataSet, int p_TableIndex)
        {
            if (p_DataSet == null || p_DataSet.Tables.Count < 0)
                return default(List<T>);
            if (p_TableIndex > p_DataSet.Tables.Count - 1)
                return default(List<T>);
            if (p_TableIndex < 0)
                p_TableIndex = 0;
            if (p_DataSet.Tables[p_TableIndex].Rows.Count <= 0)
                return default(List<T>);
            DataTable p_Data = p_DataSet.Tables[p_TableIndex];
            // 返回值初始化
            List<T> result = new List<T>();
            for (int j = 0; j < p_Data.Rows.Count; j++)
            {
                T _t = (T)Activator.CreateInstance(typeof(T));
                PropertyInfo[] propertys = _t.GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    if (p_Data.Columns.IndexOf(pi.Name.ToUpper()) != -1 && p_Data.Rows[j][pi.Name.ToUpper()] != DBNull.Value)
                    {
                        pi.SetValue(_t, p_Data.Rows[j][pi.Name.ToUpper()], null);
                    }
                    else
                    {
                        pi.SetValue(_t, null, null);
                    }
                }
                result.Add(_t);
            }
            return result;
        }
    }
}