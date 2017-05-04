using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CalcGpsDis
    {
        /// <summary>
        /// 计算两点间距离,粗略算法
        /// </summary>
        /// <param name="wd1">纬度1</param>
        /// <param name="jd1">经度1</param>
        /// <param name="wd2">纬度2</param>
        /// <param name="jd2">经度3</param>
        /// <returns></returns>
        //public static double reGpsDis(double wd1, double jd1, double wd2, double jd2)
        //{
        //    return Math.Sqrt((jd1 - jd2) * 111120 * Math.Cos(wd2 * 180 / Math.PI) * (jd1 - jd2) * 111120 * Math.Cos(wd2 * 180 / Math.PI) + (wd1 - wd2) * 111120 * (wd1 - wd2) * 111120);
        //}

        //WGS-84   长轴半径
        //#define     EARTH_WGS84_A 6378137.0000
        //WGS-84   短轴半径
        //#define     EARTH_WGS84_B 6356752.3142
        //WGS-84   偏心率的平方
        //#define     EARTH_WGS84_E2 0.00669437999013
        //#define     EARTH_WGS84_MPM 1852.0
        //WGS-84   地球扁率
        //#define     EARTH_WGS84_FLATTENING 298.257223563
        //---------------------------------------------------------------------------
        public static double CalcGPSDis_RAD(double WD1, double JD1, double WD2, double JD2)
        {
          double EARTH_WGS84_A = 6378137.0000;
          double EARTH_WGS84_FLATTENING = 298.257223563;
          double D, dis;
          double tmpVal;
          double tmp1, tmp2;
          tmpVal = Math.Sin(WD1)*Math.Sin(WD2)+Math.Cos(WD1)*Math.Cos(WD2)*Math.Cos(JD1-JD2);
          D = Math.Acos(tmpVal);
          tmp1=(Math.Sin(WD1) + Math.Sin(WD2));
          tmp2=(Math.Sin(WD1) - Math.Sin(WD2));
          tmpVal = ((3 * Math.Sin(D) - D) * tmp1 * tmp1) / (1 + Math.Cos(D));
          tmpVal = tmpVal - ((3 * Math.Sin(D) + D)* tmp2 * tmp2) / (1 - Math.Cos(D));
          dis = EARTH_WGS84_A * D + (EARTH_WGS84_A / (4 * EARTH_WGS84_FLATTENING)) * tmpVal;
          return dis;
        }
        /// <summary>
        /// 计算两点间距离,精确算法
        /// </summary>
        /// <param name="wd1">纬度1</param>
        /// <param name="jd1">经度1</param>
        /// <param name="wd2">纬度2</param>
        /// <param name="jd2">经度3</param>
        /// <returns></returns>
        public static double reGpsDis(decimal WD1, decimal JD1, decimal WD2, decimal JD2)
        {
          return CalcGPSDis_RAD(Convert.ToDouble(WD1)*Math.PI/180, Convert.ToDouble(JD1)*Math.PI/180, Convert.ToDouble(WD2)*Math.PI/180, Convert.ToDouble(JD2)*Math.PI/180);
        }
       

    }
}
