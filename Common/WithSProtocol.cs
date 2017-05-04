using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class WithSProtocol
    {
        #region 反转
        private static string GetConvertPhoneNo(string PhoneNo)
        {
            PhoneNo += "F";
            string convertGateNo = string.Empty;
            string[] gateArray = new string[6];
            for (int i = 0; i < 6; i++)
            {
                gateArray[i] = PhoneNo.Substring(2 * i, 2);
            }
            foreach (string s in gateArray)
            {
                convertGateNo += new string(s.Reverse().ToArray());
            }
            return convertGateNo;
        }
        #endregion

        #region 连续下载白名单
        public static byte[] toGatePerson(string cardCode, string starttime, string endtime)
        {
            byte[] TmpCF = new byte[80];

            TmpCF[0] = Convert.ToByte("CF", 16);
            TmpCF[1] = Convert.ToByte("60", 16);
            TmpCF[2] = Convert.ToByte("05", 16);

            TmpCF[3] = Convert.ToByte("03", 16);//增加名单标志
            TmpCF[4] = Convert.ToByte("80", 16);//1	b7=1:最后一条 b6-b0:序号
            // 一条：80 00000DF40115040215471504030147

            //两条：00 00000DF40115040215471504030147 81 00000DF40115040215471504030147

            //三条：00 00000DF40115040215471504030147 01 00000DF40115040215471504030147 82 00000DF40115040215471504030147

            //四条：00 00000DF40115040215471504030147 01 00000DF40115040215471504030147 02 00000DF40115040215471504030147 83 00000DF40115040215471504030147


            byte[] doorCodeS = strToToHexByte(cardCode);
            Array.Copy(doorCodeS, 0, TmpCF, 5, 4);

            TmpCF[9] = Convert.ToByte("01", 16);//时间段启用标志(0-不启用,1-启用)

            //string starttime = System.DateTime.Now.ToString("ddHHmm");//BCD码
            TmpCF[10] = Convert.ToByte(starttime.Substring(0, 2), 16);
            TmpCF[11] = Convert.ToByte(starttime.Substring(2, 2), 16);
            TmpCF[12] = Convert.ToByte(starttime.Substring(4, 2), 16);
            TmpCF[13] = Convert.ToByte(starttime.Substring(6, 2), 16);
            TmpCF[14] = Convert.ToByte(starttime.Substring(8, 2), 16);

            //string endtime = System.DateTime.Now.ToString("ddHHmm");
            TmpCF[15] = Convert.ToByte(endtime.Substring(0, 2), 16);
            TmpCF[16] = Convert.ToByte(endtime.Substring(2, 2), 16);
            TmpCF[17] = Convert.ToByte(endtime.Substring(4, 2), 16);
            TmpCF[18] = Convert.ToByte(endtime.Substring(6, 2), 16);
            TmpCF[19] = Convert.ToByte(endtime.Substring(8, 2), 16);



            for (int i = 20; i < 79; i++)
            {
                TmpCF[i] = Convert.ToByte("0", 16);
            }

            TmpCF[79] = CalcCheckSum(TmpCF, 78);//校验和


            string CFstr = byteToHexStr(TmpCF, 80);
            byte[] arrByteCFstr = System.Text.Encoding.Default.GetBytes(CFstr);
            //以上CF

            byte[] Tmp = new byte[160];
            Array.Copy(arrByteCFstr, 0, Tmp, 0, 160);
            byte[] Dest = new byte[160];
            int j = HexToSms(Tmp, Dest, 160);
            //160转140

            byte[] Tmpxx = new byte[140];
            Array.Copy(Dest, 0, Tmpxx, 0, 140);
            string mm = byteToHexStr(Tmpxx, 140);
            byte[] arrBytemm = System.Text.Encoding.Default.GetBytes(mm);
            //140转280
            return arrBytemm;
        }
        #endregion

        #region 门禁打包
        public static byte[] toCF(string typeCode)
        {
            byte[] TmpCF = new byte[80];

            TmpCF[0] = Convert.ToByte("CF", 16);
            TmpCF[1] = Convert.ToByte("60", 16);
            TmpCF[2] = Convert.ToByte(typeCode, 16);
            for (int i = 3; i < 79; i++)
            {
                TmpCF[i] = Convert.ToByte("0", 16);
            }

            TmpCF[79] = CalcCheckSum(TmpCF, 78);//校验和

            string CFstr = byteToHexStr(TmpCF, 80);
            byte[] arrByteCFstr = System.Text.Encoding.Default.GetBytes(CFstr);
            //以上CF

            byte[] Tmp = new byte[160];
            Array.Copy(arrByteCFstr, 0, Tmp, 0, 160);
            byte[] Dest = new byte[160];
            int j = HexToSms(Tmp, Dest, 160);
            //160转140

            byte[] Tmpxx = new byte[140];
            Array.Copy(Dest, 0, Tmpxx, 0, 140);
            string mm = byteToHexStr(Tmpxx, 140);
            byte[] arrBytemm = System.Text.Encoding.Default.GetBytes(mm);
            //140转280
            return arrBytemm;
        }
        #endregion

        #region 索要白名单
        public static byte[] getPerson()
        {
            byte[] TmpCF = new byte[80];

            TmpCF[0] = Convert.ToByte("CF", 16);
            TmpCF[1] = Convert.ToByte("FF", 16);
            TmpCF[2] = Convert.ToByte("60", 16);
            TmpCF[3] = Convert.ToByte("05", 16);
            for (int i = 4; i < 79; i++)
            {
                TmpCF[i] = Convert.ToByte("0", 16);
            }

            TmpCF[79] = CalcCheckSum(TmpCF, 78);//校验和

            string CFstr = byteToHexStr(TmpCF, 80);
            byte[] arrByteCFstr = System.Text.Encoding.Default.GetBytes(CFstr);
            //以上CF

            byte[] Tmp = new byte[160];
            Array.Copy(arrByteCFstr, 0, Tmp, 0, 160);
            byte[] Dest = new byte[160];
            int j = HexToSms(Tmp, Dest, 160);
            //160转140

            byte[] Tmpxx = new byte[140];
            Array.Copy(Dest, 0, Tmpxx, 0, 140);
            string mm = byteToHexStr(Tmpxx, 140);
            byte[] arrBytemm = System.Text.Encoding.Default.GetBytes(mm);
            //140转280
            return arrBytemm;
        }
        #endregion

        #region A8授权
        public static byte[] ToA8(string xnh)
        {
            string resultxx = "A8A8A8A8A8A80001A800" + xnh + "FA800" + xnh + "FA80013800351500FA800139345300518A800FFFFFFFFFFF8A80013754888600F000000000000000000000000000000000000000000000000";
            byte[] arrByteCFstr = System.Text.Encoding.Default.GetBytes(resultxx);


            byte[] Tmp = new byte[160];
            Array.Copy(arrByteCFstr, 0, Tmp, 0, 160);
            byte[] Dest = new byte[160];
            int j = HexToSms(Tmp, Dest, 160);
            //160转140

            byte[] Tmpxx = new byte[140];
            Array.Copy(Dest, 0, Tmpxx, 0, 140);
            string mm = byteToHexStr(Tmpxx, 140);
            byte[] arrBytemm = System.Text.Encoding.Default.GetBytes(mm);
            //140转280
            return arrBytemm;
        }
        #endregion

        #region 打包5AA5
        /// <summary>
        /// 打包5AA5
        /// </summary>
        /// <param name="arrBytemm"></param>
        /// <param name="fsphone">虚拟号</param>
        /// <param name="bagcode"></param>
        /// <returns></returns>
        public static byte[] byteToFiveA(byte[] arrBytemm, string fsphone, string bagcode)
        {
            byte[] TmpDsix = new byte[322];
            TmpDsix[0] = Convert.ToByte("5A", 16);
            TmpDsix[1] = Convert.ToByte("A5", 16);
            TmpDsix[2] = Convert.ToByte("5A", 16);
            TmpDsix[3] = Convert.ToByte("A5", 16);

            TmpDsix[4] = Convert.ToByte("D6", 16);

            //发送方手机号
            //string fsphone = "3157134273F2";
            fsphone = "3157134273F2";
            byte[] fsphonearray = System.Text.Encoding.ASCII.GetBytes(fsphone);  //数组array为对应的ASCII数组     

            Array.Copy(fsphonearray, 0, TmpDsix, 5, 12);

            //协议标识PID/2
            TmpDsix[17] = Encoding.ASCII.GetBytes("0")[0];
            TmpDsix[18] = Encoding.ASCII.GetBytes("0")[0];

            //编码方式DCS(00－7Bit、08－双字节（USC2）、F6－8Bit)/2
            TmpDsix[19] = Encoding.ASCII.GetBytes("0")[0];
            TmpDsix[20] = Encoding.ASCII.GetBytes("0")[0];

            //短信服务时间(年 月 日 时 分 秒 时区各占两字节)/14
            string dssj = System.DateTime.Now.ToString("yyMMddHHmmss");

            byte[] dssjarray = System.Text.Encoding.ASCII.GetBytes(dssj);  //数组array为对应的ASCII数组     

            Array.Copy(dssjarray, 0, TmpDsix, 21, 12);

            TmpDsix[33] = Encoding.ASCII.GetBytes("0")[0];
            TmpDsix[34] = Encoding.ASCII.GetBytes("0")[0];

            //短信内容长度/2
            TmpDsix[35] = Encoding.ASCII.GetBytes("A")[0];
            TmpDsix[36] = Encoding.ASCII.GetBytes("0")[0];

            //短信体/280

            Array.Copy(arrBytemm, 0, TmpDsix, 37, 280);
            //校验和/1
            byte[] arrBytemmX = new byte[313];

            Array.Copy(TmpDsix, 4, arrBytemmX, 0, 313);
            TmpDsix[317] = CalcCheckSum(arrBytemmX, 313);
            //包序号/4
            byte[] codearray = System.Text.Encoding.ASCII.GetBytes(bagcode);  //数组array为对应的ASCII数组     

            Array.Copy(codearray, 0, TmpDsix, 318, 4);
            //TmpDsix[318] = Encoding.ASCII.GetBytes("1")[0];
            //TmpDsix[319] = Encoding.ASCII.GetBytes("2")[0];
            //TmpDsix[320] = Encoding.ASCII.GetBytes("E")[0];
            //TmpDsix[321] = Encoding.ASCII.GetBytes("F")[0];
            string FIvestr = byteToHexStr(TmpDsix, 322);
            return TmpDsix;
        }
        #endregion

        #region 数组转换
        /// <summary>
        /// 字符串转16进制字节数组
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        private static byte[] strToToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        /// <summary>
        /// 字节数组转字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="receiveNumber"></param>
        /// <returns></returns>
        public static string byteToHexStr(byte[] bytes, int receiveNumber)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < receiveNumber; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        }
        /// <summary>
        /// 8位转7位
        /// </summary>
        /// <param name="Source"></param>
        /// <param name="Dest"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public static int HexToSms(byte[] Source, byte[] Dest, int Count)
        {
            int i, j = 0;
            for (i = 0; i < Count; i++)
            {
                if (i % 8 == 7)
                    continue;
                Dest[j] = (byte)(Source[i] >> (i % 8) | (i < Count - 1 ? Source[i + 1] : 0) << (7 - i % 8));
                j += 1;
            }
            return j;
        }
        /// <summary>
        /// 7位转8位
        /// </summary>
        /// <param name="Source"></param>
        /// <param name="Dest"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public static int SmsToHex(byte[] Source, byte[] Dest, int Count)
        {
            int i, j = 0;
            for (i = 0; i < Count; i++)
            {
                Dest[i] = (byte)(Source[j] << (i % 8) & 0x7F | (i % 8 == 0 ? 0 : Source[j - 1] >> (8 - i % 8)));
                if (i % 8 == 7)
                    continue;
                j += 1;
            }
            return Count;
        }
        /// <summary>
        /// 校验和
        /// </summary>
        /// <param name="Buff"></param>
        /// <param name="nLen"></param>
        /// <returns></returns>
        public static byte CalcCheckSum(byte[] Buff, int nLen)
        {
            int Sum = 0;
            for (int i = 0; i < nLen; i++)
                Sum += Buff[i];
            Sum = Sum & 0xFF;
            Sum = ~Sum + 1;
            return (byte)Sum;
        }
        #endregion

        #region 报文各内容的字节转换为字符后的长度
        public struct ProContentLength
        {
            public const string ProBaoTouType_5AA5 = "5AA5";
            public const string ProBaoTouType_CF = "CF60";

            public const int CFProStrLen = 160;//CF报文总长度
            public const int CFProByteLen = 80;//CF报文BYTE长度
            public const int CFdaijiequStrLen = 10;//CF报文待截取长度
            public const int CFshijianduanqiyongStrLen = 2;//CF时间段是否启用标志
            public const int CFnianyuerishifenStrLen = 10;//Cf 年月日时分
            public const int CFbaotouStrLen = 4;//CF包头长度 (CF60)
            public const int CFgongnengStrLen = 2;//CF报文功能码长度
            public const int CFProStrLen09 = 280;//CF(09)报文总长度
            public const int CFProByteLen09 = 140;//CF(09)报文总长度

            public const int CFdaijiequStrLen09Before = 8;//CF(09)报文从前面截取长度
            public const int CFdaijiequStrLen09End = 12;//CF(09)报文从后面截取长度
            public const int CFinoutsStrLen = 260;//CF 出入记录集
            public const int CFinoutStrLen = 26;//CF 出入记录集中每一条出入记录长度

            public const int FiveAAFiveProStrLen = 82;//5AA5报文总长度
            public const int FiveAAFiveProByteLen = 41;//5AA5报文BYTE长度
            public const int daijiequStrLen = 12;//包头+数据域长度+命令字

            public const int baotouStrLen = 4; //包头
            public const int shujuyuchangduStrLen = 4; //数据域长度
            public const int shujuyuStrLen = 64; //数据域
            public const int baoxuhaoStrLen = 8; //包序号
            public const int leijiajiaoyanheStrLen = 2; //累加校验和
            public const int minglingziStrLen = 4;  //命令字
            public const int menhaoStrLen = 12;//门号
            public const int nianuerishifenmiaoStrLen = 12;//年月日时分秒

            public const int shujuleixingStrLen = 2;//数据类型
            public const int xuhao = 2;//序号

            public const int baojingleixingStrLen = 2; //报警类型
            public const int E0yuliuStrLen = 30;//E0 预留

            public const int mencizhuangtaiStrLen = 2;//门磁状态
            public const int mensuozhuangtaiStrLen = 2;//门锁状态
            public const int dukaqizhuangtaiStrLen = 2;//读卡器状态
            public static int mimasuoStrLen = 2; //密码锁状态
            public static int keyongmimazushu = 2; //可用密码组数
            public const int B0yuliuStrLen = 12;//B0 预留
            public const int dianyuanzhuangtaiStrLen = 6;//电源状态

            public const int dukaqimenhaoStrLen = 2; //读卡器门号
            public const int jiluleiixngStrLen = 2;  //记录类型
            public const int kahaoStrLen = 8;//卡号
            public const int shukashijainStrLen = 12;//刷卡时间
            public const int shukabiaozhiStrLen = 2;//刷卡标志
            public const int B7yuliuStrLen = 6;//B7 预留

            
        }
        #endregion

        #region 624转312
        private static string DoubleConvert(string before)
        {
            string after = string.Empty;
            for (int i = 0; i < before.Length / 2; i++)
            {
                after += HexToStr(before.Substring(i * 2, 2));
            }
            return after;
        }
        #endregion

        #region 16进制转为ASCII码字符
        public static string HexToStr(string mHex)
        {
            byte[] vBytes = new byte[mHex.Length / 2];
            for (int i = 0; i < mHex.Length; i += 2)
            {
                if (!byte.TryParse(mHex.Substring(i, 2), NumberStyles.HexNumber, null, out vBytes[i / 2]))
                    vBytes[i / 2] = 0;
            }
            return ASCIIEncoding.Default.GetString(vBytes);
        }
        #endregion
        
        /// <summary>
        /// 计算5AA5 string 型的msg 的校验和 
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool CalcStringCheckFiveAAFiveSum(string msg)
        {
            byte[] ByteMSG =strToToHexByte(msg);
            bool resu = false;
            byte nowSum = ByteMSG[ProContentLength.FiveAAFiveProByteLen - 1];
            byte[] calcMSG = new byte[ProContentLength.FiveAAFiveProByteLen - 1];
            Array.Copy(ByteMSG, calcMSG, ProContentLength.FiveAAFiveProByteLen - 1);
            byte calcSum = WithSProtocol.CalcCheckSum(calcMSG, ProContentLength.FiveAAFiveProByteLen - 1);
            if (calcSum == nowSum)
            {
                resu = true;
            }
            return resu;
        }

        /// <summary>
        /// 计算CF string 型的msg 的校验和 
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool CalcStringCheckCFSum(string msg)
        {
            byte[] ByteMSG = strToToHexByte(msg);
            bool resu = false;
            byte nowSum = ByteMSG[ProContentLength.CFProByteLen - 1];
            byte[] calcMSG = new byte[ProContentLength.CFProByteLen - 1];
            Array.Copy(ByteMSG, calcMSG, ProContentLength.CFProByteLen - 1);
            byte calcSum = WithSProtocol.CalcCheckSum(calcMSG, ProContentLength.CFProByteLen - 1);
            if (calcSum == nowSum)
            {
                resu = true;
            }
            return resu;
        }

        public static bool CalcStringCheckCF09Sum(string msg)
        {
            byte[] ByteMSG = strToToHexByte(msg);
            bool resu = false;
            byte nowSum = ByteMSG[ProContentLength.CFProByteLen09 - 1];
            byte[] calcMSG = new byte[ProContentLength.CFProByteLen09 - 1];
            Array.Copy(ByteMSG, calcMSG, ProContentLength.CFProByteLen09 - 1);
            byte calcSum = WithSProtocol.CalcCheckSum(calcMSG, ProContentLength.CFProByteLen09 - 1);
            if (calcSum == nowSum)
            {
                resu = true;
            }
            return resu;
        } 
        /// <summary>
        /// 报文数据类型
        /// </summary>
        public struct ProDataType 
        {
            public const string warningPro = "E0"; //报警类型
            public const string statePro = "B0";//门禁状态
            public const string inoutPro = "B7";//读卡
            public const string CFAuthBackPro = "05";//CF 返回白名单功能码
            public const string CFManyInoutPro = "09";//CF 打包十条出入记录
        }

        /// <summary>
        /// 根据警报code获取警报info
        /// </summary>
        /// <param name="warnCode"></param>
        /// <returns></returns>
        public static string GetWarnInfoByCode(string warnCode)
        {
            string resu = string.Empty;
            switch (warnCode)
            {
                case "01":
                    //resu = "感应到有人靠近通道门";
                    resu = "无卡靠近";
                    break;
                case "02":
                    //resu = "感应到有人靠近通道门,在预定时间内,无读卡记录";
                    resu = "无卡开门";
                    break;
                case "03":
                    //resu = "有刷卡记录,卡无权限,通道门打开";
                    resu = "无卡开门";
                    break;
                case "04":
                    //resu = "有刷卡记录,卡有权限,但未到施工时间,通道门打开";
                    resu = "无卡开门";
                    break;
                case "05":
                    //resu = "无刷卡记录(钥匙开门),通道门打开";
                    resu = "开门超时";
                    break;
                case "06":
                    //resu = "通道门开启时间超过预定时间";
                    resu = "开门超时";
                    break;
                case "08":
                    //resu = "卡有权限且有开门动作，但锁没打开";
                    resu = "门锁故障";
                    break;
                case "80":
                    resu = "电池电量低于警戒值";
                    break;
                default: break;
            }
            return resu;
        }
        /// <summary>
        /// 将string 转换为 datetime
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime ConvertStrToDateTime(string datetime)
        {
            return Convert.ToDateTime(DateTime.Now.Year.ToString().Substring(0,2) + datetime.Substring(0, 2) + "-" + datetime.Substring(2, 2) + "-"
                                + datetime.Substring(4, 2) + " " + datetime.Substring(6, 2) + ":"
                                + datetime.Substring(8, 2) + ":"+ datetime.Substring(10, 2));
        }
        /// <summary>
        /// 根据门磁状态code　获取门磁状态数据
        /// </summary>
        /// <param name="GateMagnetsCode"></param>
        /// <returns></returns>
        public static string GetGateMagnetsInfoByCode(string GateMagnetsCode)
        {
            string resu = string.Empty;
            switch (GateMagnetsCode)
            {
                case "00":
                    resu = Constant.Gate_GateMagnetsType.closeValue;
                    break;
                case "FE":
                    resu = Constant.Gate_GateMagnetsType.openValue;
                    break;
                default: break;
            }
            return resu;
        }
        /// <summary>
        /// 根据门锁状态code　获取门锁状态数据
        /// </summary>
        /// <param name="GateMagnetsCode"></param>
        /// <returns></returns>
        public static string GetGateLockInfoByCode(string GateLockCode)
        {
            string resu = string.Empty;
            switch (GateLockCode)
            {
                case "00":
                    resu = Constant.Gate_GateLockType.closeValue;
                    break;
                case "FE":
                    resu = Constant.Gate_GateLockType.openValue;
                    break;
                default: break;
            }
            return resu;
        }
        /// <summary>
        /// 根据读卡器状态code　获取读卡器状态数据
        /// </summary>
        /// <param name="GateMagnetsCode"></param>
        /// <returns></returns>
        public static string GetReadCardInfoByCode(string ReadCardCode)
        {
            string resu = string.Empty;
            switch (ReadCardCode)
            {
                case "00":
                    resu = Constant.Gate_ReadCardType.nomalValue;
                    break;
                case "FE":
                    resu = Constant.Gate_ReadCardType.abnomalValue;
                    break;
                default: break;
            }
            return resu;
        }

        /// <summary>
        /// 密码锁状态
        /// </summary>
        /// <param name="CodeLockCode"></param>
        /// <returns></returns>
        public static string GetCodeLockInfoByCode(string CodeLockCode)
        {
            string resu = string.Empty;
            switch (CodeLockCode)
            {
                case "00":
                    resu = Constant.Gate_CodeLockType.nomalValue;
                    break;
                case "FE":
                    resu = Constant.Gate_CodeLockType.abnomalValue;
                    break;
                default: break;
            }
            return resu;
        }
        /// <summary>
        /// 根据读卡器门号获取出入记录
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string GetInputFlagByCode(string code)
        {
            string resu = string.Empty;
            switch (code)
            {
                case "01":
                    resu = Constant.Gate_GateInOut.OutFlag;
                    break;
                case "02":
                    resu = Constant.Gate_GateInOut.InFlag;
                    break;
                default: break;
            }
            return resu;
        }
        /// <summary>
        /// 刷卡标志
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string GetReadCardFlagByCode(string code)
        {
            string resu = string.Empty;
            switch (code)
            {
                case "00":
                    resu = Constant.Gate_ReadCardFlag.nomalValue;
                    break;
                case "01":
                    resu = Constant.Gate_ReadCardFlag.openValue;
                    break;
                case "02":
                    resu = Constant.Gate_ReadCardFlag.opencloseValue;
                    break;
                default: break;
            }
            return resu;
        }
        /// <summary>
        /// 记录类型
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string GetInoutStateByCode(string code)
        {
            string resu = string.Empty;
            switch (code)
            {
                case "00":
                    resu = Constant.Gate_InoutState.nomalValue;
                    break;
                case "01":
                    resu = Constant.Gate_InoutState.noInTimeValue;
                    break;
                case "02":
                    resu = Constant.Gate_InoutState.noFindCardValue;
                    break;
                default: break;
            }
            return resu;
        }
        /// <summary>
        /// 时间段启用标志
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string GetCFTimeEnableFlagByCode(string code)
        {
            string resu = string.Empty;
            switch (code)
            {
                case "00":
                    resu = Constant.Gate_TimeEnableType.unenableValue;
                    break;
                case "01":
                    resu = Constant.Gate_TimeEnableType.enableValue;
                    break;
                default: break;
            }
            return resu;
        }

        #region 智能机短信生成
        public static string GetInfo(string phone, string content, string ip, int port, int type)
        {
            //string phone = "13564789521";
            //string ip = "221.204.213.61"; int port = 8012; int type = 1;
            //string content = "上道命令号:12345678时间:20160528101050";
            string msgID = "00000000000000000000";
            if (type == 3) 
            {
                msgID = content.Split('_')[1];
                content = content.Split('_')[0];
            }
            
            byte[] linebyte = System.Text.Encoding.GetEncoding("GBK").GetBytes(content);
            if (linebyte.Length > 114)
            {
                RecordLog.RecordInfo("报警内容超出114:" + content);
            }

            byte[] TmpCF = new byte[6];
            TmpCF[0] = (byte)Convert.ToInt32(ip.Split('.')[0]);
            TmpCF[1] = (byte)Convert.ToInt32(ip.Split('.')[1]);
            TmpCF[2] = (byte)Convert.ToInt32(ip.Split('.')[2]);
            TmpCF[3] = (byte)Convert.ToInt32(ip.Split('.')[3]);
            TmpCF[4] = (byte)(port);
            TmpCF[5] = (byte)(port >> 8);

            byte[] Tmp = new byte[4];
            Tmp[0] = (byte)(type);
            Tmp[1] = (byte)(type >> 8);
            Tmp[2] = (byte)(type >> 16);
            Tmp[3] = (byte)(type >> 24);

            string sendMsgx = "DA00" + phone + "F00"//标志+手机号+版本号
                               + byteToHexStr(TmpCF, TmpCF.Length) //IP地址，端口号
                               + System.DateTime.Now.ToString("yyMMddHHmmss")//时间
                               + byteToHexStr(Tmp, Tmp.Length) //消息类型
                               + msgID//消息ID
                               + byteToHexStr(linebyte, linebyte.Length);//消息内容

            for (int i = 0; i < 114 - linebyte.Length; i++)
            {
                sendMsgx += "00";
            }
            //byte[] Tmpmm = new byte[63];
            //for (int i = 0; i < 63; i++)
            //{
            //    Tmpmm[i] = Convert.ToByte(sendMsgx.Substring(i * 2, 2), 16);
            //}
            //byte xx = CalcCheckSum(Tmpmm, 63);
            byte[] Tmpmm = new byte[139];
            for (int i = 0; i < 139; i++)
            {
                Tmpmm[i] = Convert.ToByte(sendMsgx.Substring(i * 2, 2), 16);
            }
            byte xx = CalcCheckSum(Tmpmm, 139);
            sendMsgx = sendMsgx + xx.ToString("X2");
            return sendMsgx;
        }
        #endregion

        #region 护网监控远程消警报文获取
        public static string GetProtectednetSendUnWarnProtocol(string devicePhoneNo)
        {
            Random ran = new Random();
            int RandKey = ran.Next(1000, 9999);
            string resu = string.Empty;

            string fsphone = GetConvertPhoneNo(devicePhoneNo);//获取反转号
            byte[] byteProtocol = byteToFiveA(toCF("10"), fsphone, RandKey.ToString());
            string tempresu = byteToHexStr(byteProtocol, byteProtocol.Length);
            //截取624(624 为D6 和 校验和 之间)
            tempresu = tempresu.Substring(10, 624);
            //624转312
            tempresu = DoubleConvert(tempresu);
            resu = "D6" + tempresu + "00";//最后00不算校验和，仅站位
            return resu;
        }
        #endregion
    }
}
