using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Constant
    {
        //当用户未设置默认打开子系统，默认打开的系统menuid
        public const string defuOneMenuParID = "02";

        //子系统父级id
        public const string systemParID="0";
        public const int MyMenuLevel = 100;
        ////人员定位GIS MENUID 
        //public const string PersonLocationMenuID = "0103";
        ////GIS system menu ID
        //public const string GISMenuID = "02,03";
        ////GIS 左侧菜单
        public const string GISOneMenu = "0202,0404,0504,0604,0303,2004,1004,1303,0203";
        ////GIS二级菜单
        //public const string GISTwoMenu = "020101";
        //隐藏超级用户登陆名
        public const string SystemSuperAdminName = "Admin";
        public const string SystemSuperAdminPsd = "isAdmin";
        //部门表-局数据的父ID
        public const string highestDeptParID = "0";
        //三级菜单menu_level
        public const decimal threeMenuLevel = 3;

        /// <summary>
        /// 字典表中计划执行状态对应的类别ID
        /// </summary>
        public const string GateDicForGetFlowParentID = "1";
        /// <summary>
        /// 字典表中获取线对应的类型ID
        /// </summary>
        public const string GateDicForGetLineParentID = "2";
        /// <summary>
        /// 字典表中获取线别对应的类型ID
        /// </summary>
        public const string GateDicForGetLineDirParentID = "3";
        /// <summary>
        /// B端给C端msg标示头
        /// </summary>
        public const string GatesendBToCFlag = "Gate_";
        /// <summary>
        /// 卡状态
        /// </summary>
        public struct Gate_CardState
        {
            /// <summary>
            /// 0：未绑定
            /// </summary>
            public const string UnDelUnBindValue = "0";
            public const string UnDelUnBindText = "未绑定";

            /// <summary>
            /// 1：已绑定
            /// </summary>
            public const string UnDelIsBindValue = "1";
            public const string UnDelIsBindText = "已绑定";

            /// <summary>
            /// 2：已废弃
            /// </summary>
            public const string IsDelValue = "2";
            public const string IsDelText = "已废弃";
        }
        /// <summary>
        /// 手动授权状态
        /// </summary>
        public struct Gate_AuthState
        {
            /// <summary>
            /// 0:未下发
            /// </summary>
            public const string UnIssuedValue = "0";
            public const string UnIssuedText = "未下发";

            /// <summary>
            /// 1：下发成功
            /// </summary>
            public const string IsIssuedSuccValue = "1";
            public const string IsIssuedSuccText = "下发成功";

            /// <summary>
            ///2：下发失败
            /// </summary>
            public const string IsIssuedFailValue = "2";
            public const string IsIssuedFailText = "下发失败";

            /// <summary>
            /// 3：作废
            /// </summary>
            public const string UnAbledValue = "3";
            public const string UnAbledText = "作废";
        }
        /// <summary>
        /// 门出入
        /// </summary>
        public struct Gate_GateInOut
        {
            /// <summary>
            /// 0：入
            /// </summary>
            public const string InFlag = "0";
            public const string InFlagText = "入";
            /// <summary>
            /// 1：出
            /// </summary>
            public const string OutFlag = "1";
            public const string OutFlagText = "出";
            /// <summary>
            /// 1：是负责人
            /// </summary>
            public const string IsLeader = "1";
        }
        /// <summary>
        /// 刷卡标志
        /// </summary>
        public struct Gate_ReadCardFlag
        {
            /// <summary>
            /// 0：正常
            /// </summary>
            public const string nomalValue = "0";
            public const string nomalText = "正常";
            /// <summary>
            /// 1：开门刷卡记录
            /// </summary>
            public const string openValue = "1";
            public const string openText = "开门刷卡记录";
            /// <summary>
            /// 2：进出门刷卡记录
            /// </summary>
            public const string opencloseValue = "2";
            public const string opencloseText = "进出门刷卡记录";
        }
        /// <summary>
        /// 记录类型
        /// </summary>
        public struct Gate_InoutState
        {
            /// <summary>
            /// 0：正常
            /// </summary>
            public const string nomalValue = "0";
            public const string nomalText = "正常,可以开门";
            /// <summary>
            /// 1：不在时间段内
            /// </summary>
            public const string noInTimeValue = "1";
            public const string noInTimeText = "不在时间段内";
            /// <summary>
            /// 2：未找到卡号
            /// </summary>
            public const string noFindCardValue = "2";
            public const string noFindCardText = "未找到卡号";
            /// <summary>
            /// 3:手动清除人数
            /// </summary>
            public const string handClearValue = "3";
            public const string handClearText = "手动清除人数";
        }
        
        /// <summary>
        /// 计划类型
        /// </summary>
        public struct Gate_WorkPlanType
        {
            /// <summary>
            /// 0：计划
            /// </summary>
            public const string PlanValue = "0";
            public const string PlanText = "计划";
            /// <summary>
            /// 1：手动
            /// </summary>
            public const string HandValue = "1";
            public const string HandText = "手动";
        }
        /// <summary>
        /// 门禁流程
        /// </summary>
        public struct Gate_AuthFlow
        {
            /// <summary>
            /// 1：调度员_确定门号
            /// </summary>
            public const string confirmGateNoValue = "1";
            public const string confirmGateNoText = "调度员_确定门号";
            /// <summary>
            /// 2:调度员_确定门号后，下发计划
            /// </summary>
            public const string IssueAfterConGateNoValue = "2";
            public const string IssueAfterConGateNoText = "调度员_确定门号后，下发计划";
            /// <summary>
            /// 3:驻站员_增加行车调度命令号
            /// </summary>
            public const string confirmTrainNoValue = "3";
            public const string confirmTrainNoText = "驻站员_增加行车调度命令号";
            /// <summary>
            /// 4:调度员_分配公务命令号
            /// </summary>
            public const string confirmWorkNoValue = "4";
            public const string ConfirmWorkNoText = "调度员_分配工务命令号";
            /// <summary>
            /// 5:调度员_分配公务命令号后，下发计划
            /// </summary>
            public const string IssueAfterConWorkNoValue = "5";
            public const string IssueAfterConWorkText = "调度员_分配工务命令号后，下发计划";
            /// <summary>
            /// 6A:调度员_已通知作业负责人
            /// </summary>
            public const string NoticeLeaderByStationValue = "6A";
            public const string NoticeLeaderBystationText = "调度员_已通知作业负责人";
            /// <summary>
            /// 6B:驻站员_已通知作业负责人
            /// </summary>
            public const string NoticeLeaderByHanderValue = "6B";
            public const string NoticeLeaderByHanderText = "驻站员_已通知作业负责人";

            /// <summary>
            /// 6A6B:下一步为门禁授权
            /// </summary>
            public const string NextAuthValue1 = "6A6B";

            /// <summary>
            /// 6B6A:下一步为门禁授权
            /// </summary>
            public const string NextAuthValue2 = "6B6A";
            /// <summary>
            /// 7:门控已授权
            /// </summary>
            public const string AuthedValue = "7";
            public const string AuthedText = "门控已授权";
            /// <summary>
            /// 8A:调度员_确认销点
            /// </summary>
            public const string ClearPointByStationValue = "8A";
            public const string ClearPointByStationText = "调度员_确认销点";
            /// <summary>
            /// 8B;驻站员_确认销点
            /// </summary>
            public const string ClearPointByHanderValue = "8B";
            public const string ClearPointByHanderText = "驻站员_确认销点";
            /// <summary>
            /// 9:结束
            /// </summary>
            public const string EndValue = "9";
            public const string EndText = "结束";
        }

        /// <summary>
        /// 计划作废时给C端MSG 
        /// </summary>
        public const string Gate_UnablePlanToCMsg = "del";

        /// <summary>
        /// 授权管理中判断是否有待下发，授权时URLFLag
        /// </summary>
        public struct Gate_AuthCheck
        {
            /// <summary>
            /// 判断下发Flag
            /// </summary>
            public const string IsIssue = "issue";
            /// <summary>
            /// 判断授权Flag
            /// </summary>
            public const string IsAuth = "auth";
        }
        /// <summary>
        /// 有流程变化的计划，通知service端，其返回值告知是否已成功告诉c端
        /// </summary>
        public struct Gate_serviceResuFlag
        {
            /// <summary>
            /// succ:告知成功
            /// </summary>
            public const string IsSuccNotice = "succ";
            /// <summary>
            /// fail:告知失败
            /// </summary>
            public const string IsFailNotice = "fail";
        }
        /// <summary>
        /// 门禁下发报文类型
        /// </summary>
        public struct Gate_authprotocolType
        {
            /// <summary>
            /// 白名单
            /// </summary>
            public const string whiteList = "whitelist";
            /// <summary>
            /// 索要门禁状态
            /// </summary>
            public const string getGateState = "getGateState";
            /// <summary>
            /// 远程开门
            /// </summary>
            public const string openGate = "openGate";
            /// <summary>
            /// 清除名单
            /// </summary>
            public const string clearGate = "clearGate";
            /// <summary>
            /// 索要白名单
            /// </summary>
            public const string getList = "getList";
        }
        /// <summary>
        /// 门磁状态
        /// </summary>
        public struct Gate_GateMagnetsType 
        {
            /// <summary>
            /// 0：关闭
            /// </summary>
            public const string closeValue = "0";
            public const string closeText = "关闭";
            /// <summary>
            /// 1：打开
            /// </summary>
            public const string openValue = "1";
            public const string openText = "打开";
        }
        /// <summary>
        /// 门锁状态
        /// </summary>
        public struct Gate_GateLockType
        {
            /// <summary>
            /// 0：关闭
            /// </summary>
            public const string closeValue = "0";
            public const string closeText = "关闭";
            /// <summary>
            /// 1：打开
            /// </summary>
            public const string openValue = "1";
            public const string openText = "打开";
        }
        /// <summary>
        /// 读卡器状态
        /// </summary>
        public struct Gate_ReadCardType
        {
            /// <summary>
            /// 0：正常
            /// </summary>
            public const string nomalValue = "0";
            public const string nomalText = "正常";
            /// <summary>
            /// 1：异常
            /// </summary>
            public const string abnomalValue = "1";
            public const string abnomalText = "异常";
        }

        /// <summary>
        /// 密码锁状态
        /// </summary>
        public struct Gate_CodeLockType
        {
            /// <summary>
            /// 0：正常
            /// </summary>
            public const string nomalValue = "0";
            public const string nomalText = "正常";
            /// <summary>
            /// 1：异常
            /// </summary>
            public const string abnomalValue = "1";
            public const string abnomalText = "异常";
        }
        /// <summary>
        /// 时间段是否启用标志
        /// </summary>
        public struct Gate_TimeEnableType 
        {
            /// <summary>
            /// 0：不启用
            /// </summary>
            public const string unenableValue = "0";
            public const string unenableText = "不启用";
            /// <summary>
            /// 1：启用
            /// </summary>
            public const string enableValue = "1";
            public const string enableText = "启用";
        }
        /// <summary>
        /// 作业计划_特殊地段标志
        /// </summary>
        public struct Job_PlanSpecialSectionFlag 
        {
            /// <summary>
            /// 0：否
            /// </summary>
            public const string isSpecialValue = "0";
            public const string isSpecialText = "否";
            /// <summary>
            /// 1：是
            /// </summary>
            public const string unSpecialValue = "1";
            public const string unSpecialText = "是";
        }
        /// <summary>
        /// 作业计划_站段管理标志
        /// </summary>
        public struct Job_PlanStationMNGFlag
        {
            /// <summary>
            /// 0：否
            /// </summary>
            public const string isMNGValue = "0";
            public const string isMNGText = "否";
            /// <summary>
            /// 1：是
            /// </summary>
            public const string unMNGValue = "1";
            public const string unMNGText = "是";
        }
        /// <summary>
        /// 工机具库存状态
        /// </summary>
        public struct Tool_ToolInOut
        {
            /// <summary>
            /// 0：在库
            /// </summary>
            public const string InFlag = "0";
            /// <summary>
            /// 1：领用
            /// </summary>
            public const string OutFlag = "1";
            /// <summary>
            /// 2：保养
            /// </summary>
            public const string IsVehicle = "2";
            /// <summary>
            /// 3：维修
            /// </summary>
            public const string IsRepair = "3";
            /// <summary>
            /// 4：丢失
            /// </summary>
            public const string IsLost = "4";
            /// <summary>
            /// 9：报废
            /// </summary>
            public const string IsUse = "9";
        }

        /// <summary>
        /// 工机具工单状态
        /// 工单状态(0：未领用；1：领用；2；返还；9：异常（维修、保养、报废））
        /// </summary>
        public struct Tool_JobPlanState
        {
            /// <summary>
            /// 0：未领用
            /// </summary>
            public const string InFlag = "0";
            /// <summary>
            /// 1：全部领用
            /// </summary>
            public const string OutFlag = "1";
            /// <summary>
            /// 2：全部返还
            /// </summary>
            public const string IsReturn = "2";
            /// <summary>
            /// 3：部分领用
            /// </summary>
            public const string OutFlagBf = "3";
            /// <summary>
            /// 4：部分返还
            /// </summary>
            public const string IsReturnBf = "4";
            /// <summary>
            /// 5：上线
            /// </summary>
            public const string UpLine = "5";
            /// <summary>
            /// 6：下线
            /// </summary>
            public const string DownLine = "6";
            /// <summary>
            /// 7：已获取
            /// </summary>
            public const string IsVehicle = "7";
            /// <summary>
            /// 9：异常
            /// </summary>
            public const string IsUse = "9";
        }

        /// <summary>
        /// 字典表中计划执行状态对应的类别ID
        /// </summary>
        public const string ToolDicForGetFlowParentID = "0001";

        /// <summary>
        /// 手部响应状态
        /// </summary>
        public struct PHONE_RESPONSE_STATE
        {
            /// <summary>
            /// 成功
            /// </summary>
            public const string SUCCESS = "SUCCESS";
            /// <summary>
            /// 失败
            /// </summary>
            public const string FAIL = "FAIL";
            /// <summary>
            /// 错误
            /// </summary>
            public const string ERROR = "ERROR";
            /// <summary>
            /// 注册手机不存在
            /// </summary>
            public const string NOPHONE_NUMBER = "NOPHONE_NUMBER";
            /// <summary>
            /// 该用户未注册
            /// </summary>
            public const string ERROE_LOGIN_NOUSER = "ERROE_LOGIN_NOUSER";
            /// <summary>
            /// 用户名或密码错误
            /// </summary>
            public const string ERROE_LOGIN_PWD_WRONG = "ERROE_LOGIN_PWD_WRONG";

            /// <summary>
            /// 没有工单
            /// </summary>
            public const string ERROR_WORK_TOOLS_NO = "ERROR_WORK_TOOLS_NO";
            /// <summary>
            ///  工机具其它错误
            /// </summary>
            public const string ERROR_WORK_TOOLS_OTHER = "ERROR_WORK_TOOLS_OTHER";

            //上线状态
            //上线与出库一致
            /// <summary>
            /// 上线比出库工机具多
            /// </summary>
            public const string ERROR_UP_LINE_MORE = "ERROR_UP_LINE_MORE";
            /// <summary>
            /// 上线比出库工机具少
            /// </summary>
            public const string ERROR_UP_LINE_LESS = "ERROR_UP_LINE_LESS";
            /// <summary>
            /// 上线时上传参数不正确
            /// </summary>
            public const string ERROR_UP_LINE_PARAM = "ERROR_UP_LINE_PARAM";
            /// <summary>
            /// 上线时发生的其他错误
            /// </summary>
            public const string ERROR_UP_LINE_OTHER = "ERROR_UP_LINE_OTHER";

            /// <summary>
            /// 上线与出库不一致
            /// </summary>
            public const string SUCCESS_UNSAME = "SUCCESS_UNSAME";


            //下线状态
            //下线与上线一致 
            /// <summary>
            /// 下线比上线工机具多
            /// </summary>
            public const string ERROR_DOWN_LINE_MORE = "ERROR_DOWN_LINE_MORE";
            /// <summary>
            /// 下线比上线工机具少
            /// </summary>
            public const string ERROR_DOWN_LINE_LESS = "ERROR_DOWN_LINE_LESS";
            /// <summary>
            /// 下线时上传参数不正确
            /// </summary>
            public const string ERROR_DOWN_LINE_PARAM = "ERROR_DOWN_LINE_PARAM";
            /// <summary>
            ///下线时发生的其他错误
            /// </summary>
            public const string ERROR_DOWN_LINE_OTHER = "ERROR_DOWN_LINE_OTHER";
            
            // 工机具更新状态
            /// <summary>
            /// 工机具库更新时上传参数不正确
            /// </summary>
            public const string ERROR_TOOLS_UPDATE_PARAM = "ERROR_TOOLS_UPDATE_PARAM";
            /// <summary>
            /// 工机具库更新时发生的其他错误
            /// </summary>
            public const string ERROR_TOOLS_UPDATE_OTHER = "ERROR_TOOLS_UPDATE_OTHER";

            /// <summary>
            /// 工单作废出错
            /// </summary>
            public const string ERROR_TOOLS_WORK_CANCEL = "ERROR_TOOLS_WORK_CANCEL";
            /// <summary>
            /// 工机具补传出错
            /// </summary>
            public const string ERROR_TOOLS_REBACK  = "ERROR_ TOOLS_REBACK ";

            /// <summary>
            /// 上线
            /// </summary>
            public const string UP_LINE = "UP_LINE";
            /// <summary>
            /// 下线
            /// </summary>
            public const string DOWN_LINE = "DOWN_LINE";
            /// <summary>
            ///  虚拟工单上线
            /// </summary>
            public const string VIRTUAL_UP_LINE = "VIRTUAL_UPLINE";
            /// <summary>
            /// 虚拟工单下线
            /// </summary>
            public const string VIRTUAL_DOWN_LINE = "VIRTUAL_DOWNLINE";
            /// <summary>
            /// 下线补传
            /// </summary>
            public const string REDOWN_LINE = "REDOWN_LINE";
            /// <summary>
            /// 虚拟工单下线补传 
            /// </summary>
            public const string VIRTUAL_REDOWN_LINE = "VIRTUAL_REDOWNLINE";
            /// <summary>
            /// 虚拟工单人工结束
            /// </summary>
            public const string VIRTUAL_TOOLS_WORK_CANCEL = "VIRTUAL_TOOLS_WORK_CANCEL";

            /// <summary>
            /// 正式工单人工结束
            /// </summary>
            public const string TOOLS_WORK_CANCEL = "TOOLS_WORK_CANCEL";
            /// <summary>
            /// 一样
            /// </summary>
            public const string same = "SAME";
            /// <summary>
            /// 不一样
            /// </summary>
            public const string unsame = "UNSAME";
           
        }
        /// <summary>
        /// 手部提示信息
        /// </summary>
        public struct PHONE_MSG
        {
            public const string LoginSuccess = "登录成功";
            public const string LoginFail = "登录失败";
            public const string LoginERROE_LOGIN_NOUSER = "该用户未注册";
            public const string LoginERROE_LOGIN_PWD_WRONG = "用户名或密码错误";
            

            public const string ModPwdSuccess = "修改密码成功";
            public const string ModPwdFail = "修改密码失败";
            public const string OldPwdError = "原密码错误";

            public const string RegUserSuccess = "注册用户成功";
            public const string RegUserFail = "注册用户失败";
            public const string RegUserNoIn = "注册手机不存在";
            public const string RegUserIn = "该手机已注册";
            
            //请求工单及工机具信息
            public const string GetJobSuccess = "获取工单成功";
            public const string GetJobFail = "获取工单无效";

            public const string GetToolSuccess = "获取工单及工机具成功";
            public const string GetToolFail = "获取工单及工机具失败";
            public const string GetNoneJob = "没有工单";
            public const string GetJobNumNull = "请求的工单号为空";

            //上线状态
            public const string UPLINE_Success = "上线成功";
            public const string UPLINE_Fail = "上线失败";
            public const string DOWNLINE_Success = "下线成功";
            public const string DOWNLINE_Fail = "下线失败";
            public const string REDOWNLINE_Success = "补传成功";
            public const string REDOWNLINE_Fail = "补传失败";
            public const string NOTNET_Success = "断网重传成功";
            public const string NOTNET_Fail = "断网重传失败";
            /// <summary>
            /// 上线与出库一致
            /// </summary>
            public const string UPLINE_SAME = "上线与出库一致";
            /// <summary>
            /// 上线比出库工机具多
            /// </summary>
            public const string UPLINE_MORE = "上线比出库工机具多";
            /// <summary>
            /// 上线比出库工机具少
            /// </summary>
            public const string UPLINE_LESS = "上线比出库工机具少";
            /// <summary>
            /// 上线时上传参数不正确
            /// </summary>
            public const string UPLINE_PARAM = "上线时上传参数不正确";
            /// <summary>
            /// 上线时发生的其他错误
            /// </summary>
            public const string UPLINE_OTHER = "上线时发生的其他错误";
            /// <summary>
            /// 上线与出库不一致
            /// </summary>
            public const string UPLINE_UNSAME = "上线与出库不一致";

            //下线状态
            /// <summary>
            /// 下线与上线一致
            /// </summary>
            public const string DOWNLINE_SAME = "下线与上线一致";
            /// <summary>
            /// 下线比上线工机具多
            /// </summary>
            public const string DOWNLINE_MORE = "下线比上线工机具多";
            /// <summary>
            /// 下线比上线工机具少
            /// </summary>
            public const string DOWNLINE_LESS = "下线比上线工机具少";
            /// <summary>
            /// 下线时上传参数不正确
            /// </summary>
            public const string DOWNLINE_PARAM = "下线时上传参数不正确";
            /// <summary>
            ///下线时发生的其他错误
            /// </summary>
            public const string DOWNLINE_OTHER = "下线时发生的其他错误";
            /// <summary>
            /// 下线与上线不一致
            /// </summary>
            public const string DOWNLINE_UNSAME = "下线与上线不一致";

            //
            /// <summary>
            /// 工机具处理成功
            /// </summary>
            public const string RIGHT_TOOLS_UPDATE_PARAM = "工机具处理成功";
            /// <summary>
            /// 没有要更新的工机具
            /// </summary>
            public const string RIGHT_TOOLS_UPDATE_NULL = "无最新数据";
            /// <summary>
            /// 工机具库更新时上传参数不正确
            /// </summary>
            public const string ERROR_TOOLS_UPDATE_PARAM = "工机具库更新时上传参数不正确";
            /// <summary>
            /// 工机具库更新时发生的其他错误
            /// </summary>
            public const string ERROR_TOOLS_UPDATE_OTHER = "工机具库更新时发生的其他错误";

            /// <summary>
            /// 工单作废成功
            /// </summary>
            public const string SUCCESS_JOB_ISUSE = "工单作废成功";
            /// <summary>
            /// 工单作废出错
            /// </summary>
            public const string ERROR_TOOLS_WORK_CANCEL = "工单作废失败";

            /// <summary>
            /// 工机具补传成功
            /// </summary>
            public const string SUCCESS_TOOL_REBACK = "工机具补传成功";
            /// <summary>
            /// 工机具补传成功
            /// </summary>
            public const string ERROR_TOOLS_REBACK = "工机具补传出错";

            /// <summary>
            /// 命令号请求成功
            /// </summary>
            public const string SUCCESS_CMDNO = "命令号请求成功";
            /// <summary>
            /// 命令号请求失败
            /// </summary>
            public const string ERROR_CMDNO = "命令号请求失败";

            

        
        }

         /// <summary>
        /// 工作计划审批状态
        /// </summary>
        public struct Job_PlanStatu
        {
            /// <summary>
            /// 0：未通过
            /// </summary>
            public const string NoTongGuo = "0";
            /// <summary>
            /// 1：通过
            /// </summary>
            public const string TongGuo = "1";
            /// <summary>
            /// 2：已驳回
            /// </summary>
            public const string BoHui = "2";
        }
        
        //上下线状态
        /// <summary>
        /// 0代表上线
        /// </summary>
        public const short  UpLineStatu = 0;
        /// <summary>
        /// 1代表下线
        /// </summary>
        public const short DownLineStatu = 1;
        /// <summary>
        /// 材料字典表中材料类别对应的类别ID
        /// </summary>
        public const string MatreialDicForGetFlowParentID = "0001";
        /// <summary>
        /// 材料字典表中单位名称对应的类别ID
        /// </summary>
        public const string MatreialDicForGetPiecesID = "0002";
        /// <summary>
        /// 材料字典表中生产厂家对应的类别ID
        /// </summary>
        public const string MatreialDicForGetMfrsID = "0003";

        ///数据是否有效
        /// <summary>
        /// Y代表数据有效
        /// </summary>
        public const string RuleEffFlag = "Y";
        /// <summary>
        /// 制度字典
        /// </summary>
        public const string RuleCatNote = "制度分类";
        /// <summary>
        /// 断轨_定标器是否为末端（0：否 1：是）
        /// </summary>
        public static string Rail_PointIsNoraml = "0";
         /// <summary>
        /// 断轨_主机是否为区间（0：否 1：是）
        /// </summary>
        public static string Rail_HostIsSection = "0";
        /// <summary>
        /// 断轨正常
        /// </summary>
        public static string Rail_Normal = "0";
        /// <summary>
        /// 断轨AC电压状态
        /// </summary>
        public static string Rail_ACPowerType = "1";


        public static Dictionary<string, List<JOB_PLAN_CONTROL>> phonePlanList = new Dictionary<string, List<JOB_PLAN_CONTROL>>();

        public static Dictionary<string, List<JOB_PLAN_ICON>> phoneIconPlanList = new Dictionary<string, List<JOB_PLAN_ICON>>();

        public static List<Gate_AuthWarn> gateAuthList = new List<Gate_AuthWarn>();

        public static IQueryable<T_GIS_LINE> allLine = null;

        public static object GateObject = null;
        public static object JobObject = null;
        public static object FileObject = null;
        public static object PosObject = null;
        public static object RailObject = null;
        public static object RainObject = null;
        public static object WarnObject = null;

        public static object mointorSync = new object();


        public static Dictionary<string, Dictionary<string, List<T_MOBILEFILE>>> DownList =
            new Dictionary<string, Dictionary<string, List<T_MOBILEFILE>>>();
        public static object downSync = new object();

        public static Dictionary<string, string> railPointStatus = new Dictionary<string, string>();

        /// <summary>
        /// 上道命令号
        /// key 工务段
        /// value { key:计划类型 va
        /// </summary>
        public static Dictionary<string, Dictionary<string, COMMANDTIME>> planUpCommand = new Dictionary<string, Dictionary<string, COMMANDTIME>>();
        /// <summary>
        /// 下道命令号
        /// key 工务段
        /// value { key:计划类型 va
        /// </summary>
        public static Dictionary<string, Dictionary<string, COMMANDTIME>> planDownCommand = new Dictionary<string, Dictionary<string, COMMANDTIME>>();

        public static object commandSync = new object();

        public static List<string> warnList = new List<string>();
        public static object warnListSync = new object();
    }
}
public class COMMANDTIME
{
    public decimal? commandValue { get; set; }
    public DateTime commandDate { get; set; }
}

public class JOB_PLAN_ICON
{
        public string PLAN_TYPE { get; set; }
        public string DEPT_CODE { get; set; }
        public string DEPT_CJNAME { get; set; }
        public string LEADER_PHONE { get; set; }
        public string PHONE_LIST { get; set; }
        public string ICON { get; set; }
        public string OTHERICON { get; set; }
        public Nullable<System.DateTime> PLANTIME_BEGIN { get; set; }
        public Nullable<System.DateTime> PLANTIME_END { get; set; }
}

public class Gate_AuthWarn 
{
    public string GATE_DEPTCODE { get; set; }
    public string GATE_NO { get; set; }
    public string AUTH_ID { get; set; }
    public string CARD_NO { get; set; }
    public string DEPTSECTION { get; set; }
    public Nullable<DateTime> AUTHTIME_BEGIN { get; set; }
    public Nullable<DateTime> AUTHTIME_END { get; set; }
    public Nullable<DateTime> WARNLOWTIME_BEGIN { get; set; }
    public Nullable<DateTime> WARNLOWTIME_END { get; set; }
    public Nullable<DateTime> WARNHIGHTIME_BEGIN { get; set; }
    public Nullable<DateTime> WARNHIGHTIME_END { get; set; }
}