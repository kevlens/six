//以下数据用于电子检查本超限速度数字与文字描述转换
var CHK_SpeedDescJson = [{ "id": "0", "text": "其他站线" }, { "id": "1", "text": "Vmax≤120Km/h正线及到发线" },
                         { "id": "2", "text": "160Km/h≥Vmax>120Km/h正线" }, { "id": "3", "text": "Vmax>160Km/h正线" }, { "id": "4", "text": "专用线" }];
//以下用于电子检查本线路检查类型数字与文字描述转换
var CHK_lineItemDescJson = [{ "id": "0", "text": "直线" }, { "id": "1", "text": "缓和曲线" }, { "id": "2", "text": "圆曲线" }];
//以下用于电子检查本线路检查位置数字与文字描述转换
var CHK_lineItemPosJson = [{ "id": "0", "text": "接头" }, { "id": "1", "text": "小腰" }, { "id": "2", "text": "中间" }, { "id": "3", "text": "后小腰" }];
//以下用于电子检查本线路检查是否复查转换
//var CHK_IsRecheckFlag = [{ "id": "0", "text": "" }, { "id": "1", "text": "复检" }];
////以下用于电子检查本线路检查是否增转换
//var CHK_IsAddFlag = [{ "id": "0", "text": "" }, { "id": "1", "text": "增" }];
//以下用于电子检查本曲线正矢检查类型数字与文本描述转换
var CHK_curveDescJson = [{ "id": "0", "text": "正线及到发线" }, { "id": "1", "text": "其他站线" }, { "id": "2", "text": "专用线" }, { "id": "3", "text": "附带曲线" }];
//以下用于电子检查本曲线正矢字表检查类型数字与文本描述转换
var CHK_curveItemDescJson = [{ "id": "H", "text": "缓和曲线" }, { "id": "HY", "text": "缓圆点" }, { "id": "Y", "text": "圆曲线" }, { "id": "YH", "text": "圆缓点" }];
//以下用于电子检查本曲线正矢速度范围数据与文本描述转换
var CHK_curveSpeedDescJson = [{ "id": "0", "text": "Vmax≤120Km/h" }, { "id": "1", "text": "160Km/h≥Vmax>120Km/h" }, { "id": "2", "text": "Vmax>160Km/h" }];
//以下用于电子检查本曲线正矢曲线半径数据与文本描述转换
var CHK_curveRadiusDescJson = [{ "id": "0", "text": "R≤250" }, { "id": "1", "text": "250＜R≤350" }, { "id": "2", "text": "350＜R≤450" }, { "id": "3", "text": "450＜R≤800" }, { "id": "4", "text": "R＞800" }];
////以下数据用于电子检查本 道岔检查 支距值 正常值 字体颜色
//var CHK_
//以下数据用于电子检查本超限值背景色显示
var CHK_DiscBgColor = [{ "id": "0", "text": "#F4E156" }, { "id": "1", "text": "#D1773B" }, { "id": "2", "text": "#E10C08" }, { "id": "3", "text": "#CA01CB" }];
//以下数据用于电子检查本显示子表数据时主表重点字段颜色显示
var CHK_MainDataFontColor = 'green';//#084B91
var bgcolor_curveHdiff = '#EE4A1D';//缓和曲线现场正矢与计算正矢差背景色为枚红色"#E1256F"
var bgcolor_curveYcondiff = '#E10C08';//圆曲线正矢连续差背景色为红色
var bgcolor_curveYmaxmin = '#33FF02';//圆曲线正矢最大最小差背景色为橘红色"#EE4A1D""#0C93D1"
//以下数据用于电子检查本线路检查曲线轨距加宽值中的曲线半径范围
var CHK_lineWiddenRadius = [{ "id": "0", "text": "R≥295" }, { "id": "1", "text": "295＞R≥245" }, { "id": "2", "text": "245＞R≥195" }, { "id": "3", "text": "R＜195" }];
//以下数据用于电子检查本各检查线路类别
var CHK_lineTypeJson = [{ "id": "0", "text": "客车通道" }, { "id": "1", "text": "其他正线" }, { "id": "2", "text": "到发线" }, { "id": "3", "text": "站专线" }];
var CHK_lineCheckPos = [{ "id": "0", "text": "正线线路" }, { "id": "1", "text": "站线线路" }];
var CHK_turnoutCheckPos = [{ "id": "0", "text": "正线道岔" }, { "id": "1", "text": "站线道岔" }];
var CHK_visualCheckPos = [{ "id": "0", "text": "正线线路" }, { "id": "1", "text": "站线线路" }, { "id": "2", "text": "正线道岔" }, { "id": "3", "text": "站线道岔" }];
//var line_guiju_0_on_3 = 10;//其他站线_正值_临时补修
//var line_guiju_0_off_3 = -4;//其他站线_负值_临时补修

//var line_guiju_1_on_3 = 9;//<120_正值_临时补修
//var line_guiju_1_off_3 = -4;//<120_负值_临时补修

//var line_guiju_2_on_3 = 8;//>120_正值_临时补修
//var line_guiju_2_off_3 = -4;//>120_负值_临时补修

//var line_guiju_3_on_3 = 6;//>160_正值_临时补修
//var line_guiju_3_off_3 = -4;//>160_正值_临时补修

//线路_轨距
//var line_guiju_on_3 = [{ "id": "0", "text": 10 }, { "id": "1", "text": 9 },
//                         { "id": "2", "text": 8 }, { "id": "3", "text": 6 }];
//var line_guiju_off_3 = [{ "id": "0", "text": -4 }, { "id": "1", "text": -4 },
//                         { "id": "2", "text": -4 }, { "id": "3", "text": -4 }];
////线路_水平
//var line_shuiping_on_3 = [{ "id": "0", "text": 11 }, { "id": "1", "text": 10 },
//                         { "id": "2", "text": 8 }, { "id": "3", "text": 8 }];
//var line_shuiping_off_3 = [{ "id": "0", "text": -11 }, { "id": "1", "text": -10 },
//                         { "id": "2", "text": -8 }, { "id": "3", "text": -8 }];
////线路_轨向
//var line_guixiang_on_3 = [{ "id": "0", "text": 11 }, { "id": "1", "text": 10 },
//                         { "id": "2", "text": 8 }, { "id": "3", "text": 7 }];
//var line_guixiang_off_3 = [{ "id": "0", "text": -11 }, { "id": "1", "text": -10 },
//                         { "id": "2", "text": -8 }, { "id": "3", "text": -7 }];
////线路_高低
//var line_gaodi_on_3 = [{ "id": "0", "text": 11 }, { "id": "1", "text": 10 },
//                         { "id": "2", "text": 8 }, { "id": "3", "text": 8 }];
//var line_gaodi_off_3 = [{ "id": "0", "text": -11 }, { "id": "1", "text": -10 },
//                         { "id": "2", "text": -8 }, { "id": "3", "text": -8 }];
////线路_三角坑
////直线和圆曲线
//var line_sanjiaokeng_on_3 = [{ "id": "0", "text": 10 }, { "id": "1", "text": 9 },
//                         { "id": "2", "text": 8 }, { "id": "3", "text": 6 }];
//var line_sanjiaokeng_off_3 = [{ "id": "0", "text": -10 }, { "id": "1", "text": -9 },
//                         { "id": "2", "text": -8 }, { "id": "3", "text": -6 }];
////缓和曲线
//var line_sanjiaokenghe_on_3 = [{ "id": "0", "text": 8 }, { "id": "1", "text": 7 },
//                         { "id": "2", "text": 6 }, { "id": "3", "text": 6 }];
//var line_sanjiaokenghe_off_3 = [{ "id": "0", "text": -8 }, { "id": "1", "text": -7 },
//                         { "id": "2", "text": -6 }, { "id": "3", "text": -6 }];
////道岔_轨距
//var turnout_guiju_on_3 = [{ "id": "0", "text": 6 }, { "id": "1", "text": 6 },
//                         { "id": "2", "text": 6 }, { "id": "3", "text": 5 }];
//var turnout_guiju_off_3 = [{ "id": "0", "text": -3 }, { "id": "1", "text": -3 },
//                         { "id": "2", "text": -2 }, { "id": "3", "text": -2 }];
////道岔_水平
//var turnout_shuiping_on_3 = [{ "id": "0", "text": 10 }, { "id": "1", "text": 9 },
//                         { "id": "2", "text": 8 }, { "id": "3", "text": 7 }];
//var turnout_shuiping_off_3 = [{ "id": "0", "text": -10 }, { "id": "1", "text": -9 },
//                         { "id": "2", "text": -8 }, { "id": "3", "text": -7 }];
//////道岔_轨向
////var turnout_guixiang_on_3 = [{ "id": "0", "text": 10 }, { "id": "1", "text": 9 },
////                         { "id": "2", "text": 8 }, { "id": "3", "text": 6 }];
////var turnout_guixiang_off_3 = [{ "id": "0", "text": -10 }, { "id": "1", "text": -9 },
////                         { "id": "2", "text": -8 }, { "id": "3", "text": -6 }];
//////道岔_高低
////var turnout_gaodi_on_3 = [{ "id": "0", "text": 10 }, { "id": "1", "text": 9 },
////                         { "id": "2", "text": 8 }, { "id": "3", "text": 7 }];
////var turnout_gaodi_off_3 = [{ "id": "0", "text": -10 }, { "id": "1", "text": -9 },
////                         { "id": "2", "text": -8 }, { "id": "3", "text": -7 }];

//var turnout_czjg_on_3 = 91;//道岔 查照间隔
//var turnout_hbjl_on_3 = 48;//道岔 护背距离

////交分道岔_轨距
//var slip_guiju_on_3 = [{ "id": "0", "text": 6 }, { "id": "1", "text": 6 },
//                         { "id": "2", "text": 6 }, { "id": "3", "text": 5 }];
//var slip_guiju_off_3 = [{ "id": "0", "text": -3 }, { "id": "1", "text": -3 },
//                         { "id": "2", "text": -2 }, { "id": "3", "text": -2 }];
////交分道岔_水平
//var slip_shuiping_on_3 = [{ "id": "0", "text": 10 }, { "id": "1", "text": 9 },
//                         { "id": "2", "text": 8 }, { "id": "3", "text": 7 }];
//var slip_shuiping_off_3 = [{ "id": "0", "text": -10 }, { "id": "1", "text": -9 },
//                         { "id": "2", "text": -8 }, { "id": "3", "text": -7 }];

//var slip_czjg_on_3 = 91;// 交分道岔 查照间隔
//var slip_hbjl_on_3 = 48;// 交分道岔 护背距离

////菱形道岔_轨距
//var diamond_guiju_on_3 = [{ "id": "0", "text": 6 }, { "id": "1", "text": 6 },
//                         { "id": "2", "text": 6 }, { "id": "3", "text": 5 }];
//var diamond_guiju_off_3 = [{ "id": "0", "text": -3 }, { "id": "1", "text": -3 },
//                         { "id": "2", "text": -2 }, { "id": "3", "text": -2 }];
////菱形道岔_水平
//var diamond_shuiping_on_3 = [{ "id": "0", "text": 10 }, { "id": "1", "text": 9 },
//                         { "id": "2", "text": 8 }, { "id": "3", "text": 7 }];
//var diamond_shuiping_off_3 = [{ "id": "0", "text": -10 }, { "id": "1", "text": -9 },
//                         { "id": "2", "text": -8 }, { "id": "3", "text": -7 }];

//var diamond_czjg_on_3 = 91;//菱形道岔 查照间隔
//var diamond_hbjl_on_3 = 48;//菱形道岔 护背距离


////曲线_缓和曲线/正线及到发线 (0:R<=250,1:250<R<=350;2:350<R<=450,3:450<R<=800,4:R>800)
//var curve_hz_on_3 = [{ "id": "0", "text": 7 }, { "id": "1", "text": 6 },
//                         { "id": "2", "text": 5 }, { "id": "3", "text": 4 }, { "id": "4", "text": 3 }];
////var curve_hz_off_3 = [{ "id": "0", "text": -7 }, { "id": "1", "text": -6 },
////                         { "id": "2", "text": -5 }, { "id": "3", "text": -4 }, { "id": "4", "text": -3 }];
////曲线_缓和曲线/其他站线 (0:R<=250,1:250<R<=350;2:350<R<=450,3:450<R<=800,4:R>800)
//var curve_hq_on_3 = [{ "id": "0", "text": 8 }, { "id": "1", "text": 7 },
//                         { "id": "2", "text": 6 }, { "id": "3", "text": 5 }, { "id": "4", "text": 4 }];
////var curve_hq_off_3 = [{ "id": "0", "text": -8 }, { "id": "1", "text": -7 },
////                         { "id": "2", "text": -6 }, { "id": "3", "text": -5 }, { "id": "4", "text": -4 }];

////曲线_附带曲线连续差
//var curve_fc_on_3 = 2;
////曲线_附带曲线最大最小差
//var curve_fm_on_3 = 4;

////曲线_圆曲线/正线及到发线 (0:R<=250,1:250<R<=350;2:350<R<=450,3:450<R<=800,4:R>800)连续差
//var curve_yzc_on_3 = [{ "id": "0", "text": 14 }, { "id": "1", "text": 12 },
//                         { "id": "2", "text": 10 }, { "id": "3", "text": 8 }, { "id": "4", "text": 6 }];
////曲线_圆曲线/正线及到发线 (0:R<=250,1:250<R<=350;2:350<R<=450,3:450<R<=800,4:R>800)最大最小差
//var curve_yzm_on_3 = [{ "id": "0", "text": 21 }, { "id": "1", "text": 18 },
//                         { "id": "2", "text": 15 }, { "id": "3", "text": 12 }, { "id": "4", "text": 9 }];
////曲线_圆曲线/其他站线 (0:R<=250,1:250<R<=350;2:350<R<=450,3:450<R<=800,4:R>800)连续差
//var curve_yqc_on_3 = [{ "id": "0", "text": 16 }, { "id": "1", "text": 14 },
//                         { "id": "2", "text": 12 }, { "id": "3", "text": 10 }, { "id": "4", "text": 8 }];
////曲线_圆曲线/其他站线 (0:R<=250,1:250<R<=350;2:350<R<=450,3:450<R<=800,4:R>800)最大最小差
//var curve_yqm_on_3 = [{ "id": "0", "text": 24 }, { "id": "1", "text": 21 },
//                         { "id": "2", "text": 18 }, { "id": "3", "text": 15 }, { "id": "4", "text": 12 }];


