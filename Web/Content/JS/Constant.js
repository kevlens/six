//门禁管理 手动权限 状态
var Gate_AuthStateJson = [{ "id": "0", "text": "未下发" }, { "id": "1", "text": "下发成功" }, { "id": "2", "text": "下发失败" }, { "id": "3", "text": "作废" }];
var Gate_AuthState_IsIssuedSucc = "1";
//门禁管理  卡管理
var Gate_CardStateJson = [{ "id": "0", "text": "未绑定" }, { "id": "1", "text": "已绑定" }, { "id": "2", "text": "已废弃" }];
var Gate_CardState_IsDel = "2";
var Gate_CardState_IsBind = "1";
//门禁管理  计划类型
var Gate_WorkPlanTypeJson = [{ "id": "0", "text": "计划" }, { "id": "1", "text": "手动" }];
//门禁管理  门类型
var Gate_StateInoutJson = [{ "id": "0", "text": "入" }, { "id": "1", "text": "出" }];
//门禁管理  门状态
var Gate_StateTypeJson = [{ "id": "0", "text": "关闭" }, { "id": "1", "text": "打开" }];
//门禁管理  授权流程
var Gate_AuthFlowJson = [
    //{ "id": "1", "text": "调度员_确定门号" },
    //{ "id": "2", "text": "调度员_确定门号后，下发计划" },
    //{ "id": "3", "text": "驻站员_增加行车调度命令号" },
    //{ "id": "4", "text": "调度员_分配工务命令号" },
    //{ "id": "5", "text": "调度员_分配工务命令号后，下发计划" },
    //{ "id": "6A", "text": "驻站员_已通知作业负责人" },
    //{ "id": "6B", "text": "调度员_已通知作业负责人" },
    //{ "id": "7", "text": "门控已授权" },
    //{ "id": "8A", "text": "驻站员_确认销点" },
    //{ "id": "8B", "text": "调度员_确认销点" },
    //{ "id": "9", "text": "结束" }
    { "id": "1", "text": "待下发" },
    //{ "id": "2", "text": "待驻站员上传行车调度命令号" },
    { "id": "3", "text": "待分配工务命令号" },
    //{ "id": "4", "text": "待下发" },
    //{ "id": "5", "text": "待与作业负责人核对" },
    //{ "id": "6A", "text": "待驻站员核实通知作业负责人" },
    //{ "id": "6B", "text": "调度员_待与作业负责人核对" },
    { "id": "6A6B", "text": "待授权" },
    //{ "id": "6B6A", "text": "待授权" },
    { "id": "7", "text": "待确认销点" },
    //{ "id": "8A", "text": "待驻站员确认销点" },
    //{ "id": "8B", "text": "待确认销点" },
    { "id": "9", "text": "计划结束" }];
var Gate_AuthFlowNextJson = [
    { "id": "1", "text": "待下发" },
    { "id": "2", "text": "待驻站员上传行车调度命令号" },
    { "id": "3", "text": "待分配工务命令号" },
    { "id": "4", "text": "待下发" },
    { "id": "5", "text": "待与作业负责人核对" },
    { "id": "6A", "text": "待驻站员核实通知作业负责人" },
    { "id": "6B", "text": "调度员_待与作业负责人核对" },
    { "id": "6A6B", "text": "待授权" },
    { "id": "6B6A", "text": "待授权" },
    { "id": "7", "text": "待确认销点" },
    { "id": "8A", "text": "待驻站员确认销点" },
    { "id": "8B", "text": "待确认销点" },
    { "id": "9", "text": "计划结束" }];
var Gate_AuthFlowafgate = "1";
var Gate_AuthFlowafwork = "4";
var Gate_AuthFlowauth1 = "6A6B";
var Gate_AuthFlowauth2 = "6B6A";
var Gate_AuthFlowinputworkno = "3";//状态为“3”的下一步为：分配公务命令号
var Gate_AuthFlownoticeleader1 = "5";//状态为“5”的下一步为：调度员_已通知作业负责人
var Gate_AuthFlownoticeleader2 = "6B";//状态为“6B”的下一步为：调度员_已通知作业负责人
var Gate_AuthFlowclearpoint1 = "7";//状态为“7”的下一步为：调度员_确认销点
var Gate_AuthFlowclearpoint2 = "8B";//状态为“8B”的下一步为：调度员_确认销点
var Gate_AuthFlowEnd = "9";
var Gate_AuthCheck_Issue = "issue";
var Gate_AuthCheck_Auth = "auth";


//工机具管理  工机具库存状态管理
var Tool_ToolStateJson = [
    { "id": "0", "text": "在库" },
    { "id": "1", "text": "领用" },
    { "id": "2", "text": "保养" },
    { "id": "3", "text": "维修" },
    { "id": "4", "text": "丢失" },
    { "id": "9", "text": "报废" }];

//工机具返还时的使用状态，
var Tool_ToolStateJson2 = [
    { "id": "2", "text": "保养" },
    { "id": "3", "text": "维修" },
    { "id": "4", "text": "丢失" },
    { "id": "9", "text": "报废" }];

var Tool_ToolState_IsDel = "报废";
var Tool_ToolState_IsRepair = "维修";
var Tool_ToolState_IsLost = "丢失";
var Tool_ToolState_IsUse = "领用";
//工单状态
var Tool_JobStateJson = [{ "id": "0", "text": "未领用" }, { "id": "1", "text": "全部领用" }, { "id": "2", "text": "全部返还" }, { "id": "3", "text": "部分领用" }, { "id": "4", "text": "部分返还" }, { "id": "5", "text": "上线" }, { "id": "6", "text": "下线" }, { "id": "7", "text": "已获取" }, { "id": "9", "text": "异常" }];
//上下线报警状态
var UpDownLine_AlermJson = [{ "id": "0", "text": "否" }, { "id": "1", "text": "是" }];
//上下线报警状态
var UpDownLine_Json = [{ "id": "0", "text": "上线" }, { "id": "1", "text": "下线" }];

var MACHINETOOL_Json = [{ "id": "0", "text": "全部" }, { "id": "1", "text": "工务机械机具" }, { "id": "2", "text": "工务交通车辆" }, { "id": "3", "text": "工务路用车辆" }, { "id": "4", "text": "工务轨道车" }, { "id": "5", "text": "工务大机设备" }, { "id": "6", "text": "工务对讲机" }];



