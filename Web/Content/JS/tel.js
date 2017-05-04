/// <reference path="../../../OperatSchedu_DT/WorkJKDJB.aspx" />
/// <reference path="../../../OperatSchedu_DT/WorkJKDJB.aspx" />
var UrlRoot = "http://127.0.0.1:9999/";
var TelManager = {};
//拨出
TelManager.CallOut = function (telNumber) {
    var link = UrlRoot + "?Type=0&Method=0&Params=0," + telNumber;
    //location.href = link;
    window.open(link);
}
//挂断
TelManager.Hangup = function (telNumber) {
    var link = UrlRoot + "?Type=0&Method=1&Params=" + telNumber;
    $.ajax({
        type: "get",
        async: false,
        url: link,
        //url: "/pub/datajson.html",
        dataType: "jsonp",
        jsonp: "callback",
        jsonpCallback: "dataHandler",
        success: function (json) {
            //alert(json.result.Type + '-------' + json.result.Result);
            if (json.result.Result == 1) {
                //    callDlg.content('挂断失败，请检查设备.');
                //} else {
                callDlg.content('电话已挂').time(3);
                callDlg.button({
                    name: '挂断',
                    disabled: true
                });
                TelManager.IsInTalking = false;
                window.clearInterval(TelManager.IntervalSelf);
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            //alert(XMLHttpRequest);
            //alert(textStatus);
            //alert(errorThrown);
            callDlg.content('挂断失败，请检查设备');
        }
    });
}


var callDlg;
TelManager.CallOutAjax = function (telNumber) {
    if (telNumber && telNumber != undefined && telNumber != '') {
        TelManager.IsInTalking = true;
    } else {
        return;
    }
    //alert(clickedInfowindow);
    //clearInterval(TelManager.IntervalSelf);
    callDlg = $.dialog({
        background: '#000', /* 背景色 */
        opacity: 0.5,       /* 透明度 */
        lock: false,
        title: '通话',
        content: '通话号码：' + telNumber + '',
        width: '300px',
        height: '80px',
        left: '98%',
        top: '2%',
        max: false,
        min: false,
        button: [
                    {
                        name: '挂断',
                        focus: false,
                        disabled: true
                    }
        ]
    });
    var link = UrlRoot + "?Type=0&Method=0&Params=" + telNumber;
    $.ajax({
        type: "get",
        async: false,
        url: link,
        //url: "/pub/datajson.html",
        dataType: "jsonp",
        jsonp: "callback",
        jsonpCallback: "dataHandler",
        success: function (json) {
            //alert(json.result.Type + '-------' + json.result.Result);
			TelManager.WaitToRefreshSelf();
            if (json.result.Result == 0) {
                TelManager.Hangup(telNumber);
                callDlg.content('拨号失败，请检查设备并重拨').time(5);
            }
	
            callDlg.button({
                name: '挂断',
                callback: function () {
                    //alert('挂断');
                    //window.location.href = UrlRoot + "?Type=0&Method=1&Params=" + telNumber;
                    this.content('正在挂断，请稍候......');
                    TelManager.Hangup(telNumber);
                    
                    return false;
                },
                disabled: false
            });
            //alert('数据： ' + json.price + ' 元，余票： ' + json.tickets + ' 张。');
            //alert('suss');
            //TelManager.DoWork(json);
            //TelManager.IntervalSelf = setInterval(TelManager.CallInAjaxInSelf, 2000);

            //window.parent.window.parent.$.dialog({
            //    id: 'callintercomID',

            //    content: '与' + telNumber + '通话中......',
            //    button: [
            //        {
            //            name: '挂断',
            //            callback: function () {
            //                window.location.href = UrlRoot + "?Type=0&Method=1&Params=" + telNumber;
            //                this.content('你挂断了').time(2);
            //                return false;
            //            },
            //            focus: true
            //        }
            //    ]
            //});
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            //alert(XMLHttpRequest);
            //alert(textStatus);
            //alert(errorThrown);
            //TelManager.IntervalSelf = setInterval(TelManager.CallInAjaxInSelf, 2000);
            TelManager.Hangup(telNumber);
            alert('拨号出错，请重新拨...');
        }
    });
}

TelManager.IntercomAjax = function (telNumber) {
    //alert(clickedInfowindow);
    //clearInterval(TelManager.IntervalSelf);
    var link = UrlRoot + "?Type=1&Method=0&Params=" + telNumber;
    $.ajax({
        type: "get",
        async: false,
        url: link,
        //url: "/pub/datajson.html",
        dataType: "jsonp",
        jsonp: "callback",
        jsonpCallback: "dataHandler",
        success: function (json) {
            //alert(json.result.Type+'-------'+json.result.Result);
            //alert('数据： ' + json.price + ' 元，余票： ' + json.tickets + ' 张。');
            //alert('suss');
            //TelManager.DoWork(json);
            //TelManager.IntervalSelf = setInterval(TelManager.CallInAjaxInSelf, 2000);
            var dlg = $.dialog({
                time: 8,
                lock: false,
                title: '对讲号码：' + telNumber + '',
                max: false,
                min: false
            });
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            //alert(XMLHttpRequest);
            //alert(textStatus);
            //alert(errorThrown);
            //TelManager.IntervalSelf = setInterval(TelManager.CallInAjaxInSelf, 2000);
            alert('对讲出错，请重新拨...');
        }
    });
}


TelManager.CallInAjax = function () {
    $.ajax({
        type: "get",
        async: false,
        url: UrlRoot + "?Type=0&Method=2&Params=",
        //url: "/pub/datajson.html",
        dataType: "jsonp",
        jsonp: "callback",
        jsonpCallback: "dataHandler",
        success: function (json) {
            //alert(json.result[0].Result);
            TelManager.DoWork(json);

        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert(XMLHttpRequest);
            alert(textStatus);
            alert(errorThrown);
        }
    });
}

var lastInPhone = '';
TelManager.DoWork = function (json) {
    var Phone = json.result[0].Phone;
    var Result = json.result[0].Result;

    setTimeout(function () {
        lastInPhone = '';
    }, 1000 * 60);

    if (lastInPhone == Phone) return;

    var subtitle = '监控登记';
    if (!$('#tabs').tabs('exists', subtitle)) {
        //alert('haha1');
        addTab(subtitle, 'Manager/WorkPlan2015/WorkMonitor.aspx?callin=1&ph=' + Phone, '', 'M1001040402');
    } else {
        //alert('haha2');
    }
}

TelManager.Interval = null;
TelManager.IntervalDH = null;
TelManager.MonitorTabOpened = false;

TelManager.CheckTabIsOpen = function () {
    var subtitle = '监控登记';
    if (!$('#tabs').tabs('exists', subtitle)) {
        TelManager.MonitorTabOpened = false;
    } else {
        TelManager.MonitorTabOpened = true;
    }
}

TelManager.WaitToOpenTab = function () {
    //TelManager.CheckTabIsOpen();
    //alert(TelManager.MonitorTabOpened);
    if (TelManager.MonitorTabOpened == false) {
        TelManager.Interval = setInterval(TelManager.CallInAjaxInDefault, 2000);
    }
}
TelManager.WaitToCallIn = function () {
    TelManager.Interval = setInterval(TelManager.CallInAjaxInDefault, 2000);
	TelManager.IntervalDH = setInterval(TelManager.CallInAjaxInDefaultDH,2000);
}

TelManager.CallInAjaxInDefault = function () {
    //alert('TelManager.CallInAjaxInDefault---aaa');
    $.ajax({
        type: "get",
        async: false,
        url: UrlRoot + "?Type=0&Method=2&Params=",
        //url: "/pub/datajson.html",
        dataType: "jsonp",
        jsonp: "callback",
        jsonpCallback: "dataHandler",
        success: function (json) {
		              var Phone = json.result[0].Phone || json.result[1].Phone;
				var Result = json.result[0].Result;
				if(Phone.length ==5 || Phone.length==7  || Phone.length==8 || Phone.length ==11)
	{
                TelManager.DoWork(json,Result);
            
}
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            //alert(XMLHttpRequest);
            //alert(textStatus);
            //alert(errorThrown);
        }
    });
}
TelManager.CallInAjaxInDefaultDH = function () {
    //alert('TelManager.CallInAjaxInDefault---aaa');
    $.ajax({
        type: "get",
        async: false,
        url: UrlRoot + "?Type=1&Method=2&Params=",
        //url: "/pub/datajson.html",
        dataType: "jsonp",
        jsonp: "callback",
        jsonpCallback: "dataHandler",
        success: function (json) {
              var Phone = json.result[0].Phone || json.result[1].Phone;
				var Result = json.result[0].Result;
				if(Phone.length ==5 || Phone.length==7 || Phone.length==8 || Phone.length ==11)
	{
                TelManager.DoWork(json,Result);
				}
            

        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            //alert(XMLHttpRequest);
            //alert(textStatus);
            //alert(errorThrown);
        }
    });
}
TelManager.DoWork = function (json,flag) {
    var Phone = json.result[0].Phone || json.result[1].Phone;
    var Result = json.result[0].Result;

    setTimeout(function () {
        lastInPhone = '';
    }, 1000 * 60);

    if (lastInPhone == Phone) return;
    if (Phone.length == 12) {
        if (Phone.substring(0, 1) == "0") {
            Phone = Phone.substring(1, Phone.length);
            //TelManager.AnalyzeNumber(phone);
        }
    }
	//var p = AnalyzeNumber(Phone);

    TelManager.moveTop(Phone);

    //var subtitle = '监控登记';
    //if (!$('#tabs').tabs('exists', subtitle)) {
    //    //alert('TelManager.DoWork---haha1---' + Phone);
    //    addTab(subtitle, 'Manager/WorkPlan2015/WorkMonitor.aspx?openfrom=100&callin=1&ph=' + Phone, '', 'M1001040402');
    //    //addTab(subtitle, 'Manager/WorkPlan2015/WorkMonitor.aspx', '', 'M1001040402');
    //} else {
    //    //alert('TelManager.DoWork---haha2');
    //    $('#tabs').tabs('select', subtitle);
    //    $('#mm-tabupdate').click();
    //}
    //TelManager.MonitorTabOpened = true;
    //clearInterval(TelManager.Interval);
}

//------------------------------------------------------------------------
TelManager.IntervalSelf = null;
TelManager.WaitToRefreshSelf = function () {
    //TelManager.CheckTabIsOpen();
    //alert(TelManager.MonitorTabOpened);
    TelManager.MonitorTabOpened = true;
    TelManager.IntervalSelf = setInterval(TelManager.CallInAjaxInSelf, 2000);
}

TelManager.CallInAjaxInSelf = function () {
    //alert('TelManager.CallInAjaxInSelf---bbb');
    $.ajax({
        type: "get",
        async: false,
        url: UrlRoot + "?Type=0&Method=2&Params=",
        //url: "/pub/datajson.html",
        dataType: "jsonp",
        jsonp: "callback",
        jsonpCallback: "dataHandler",
        success: function (json) {
            //alert(json.result[0].Result);
            //alert('数据： ' + json.price + ' 元，余票： ' + json.tickets + ' 张。');
            //alert('suss');
            TelManager.DoWorkSelf(json);

        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            //alert(XMLHttpRequest);
            //alert(textStatus);
            //alert(errorThrown);
        }
    });
}

//Type=1&Method=0&Params=18010282343
//{"Type":1,"Result":1}
//Type=1&Method=2&Params=18010282343
//{"Type":0,"Result":0,"Direction":0,"Phone":""},{"Type":1,"Result":1,"Direction":0,"Phone":"18010282343,"}
//Type=1&Method=2&Params=18010282343
//{"Type":0,"Result":0,"Direction":0,"Phone":""},{"Type":1,"Result":0,"Direction":0,"Phone":""}
//Heart(任国伟) 14:46:35
//http://192.168.2.100:9999/?Type=xxx&Method=xxx&Params=xxx

TelManager.IsInTalking = false;

TelManager.SetIsInTalking = function (b) {
    TelManager.IsInTalking = b;
}

TelManager.DoWorkSelf = function (json) {
    //console.info(json);
    var telJson, intercomJson;
    if (json.result.length > 1) {
        telJson = json.result[0];
        intercomJson = json.result[1];
    }
    //alert(telJson.Result + '-' + telJson.Direction + '-' + telJson.Phone + '@@@@@@@@@' + intercomJson.Result + '-' + intercomJson.Direction + '-' + intercomJson.Phone);

    if (telJson.Result == 1 || intercomJson.Result == 1) {//有电话   或  有对讲 
        if (TelManager.IsInTalking == false) {//没有正在打//打入且电话号码不为空        
            if (telJson.Phone != '' && telJson.Direction == 1) {
                TelManager.RefreshSelf(telJson.Phone);
                TelManager.IsInTalking = true;
            } else if (intercomJson.Phone != '' && intercomJson.Direction == 1) {
                TelManager.RefreshSelf(intercomJson.Phone);
                TelManager.IsInTalking = true;
            }
        }
    }

    if (telJson.Result == 0 && intercomJson.Result == 0) {
        //if (TelManager.IsInTalking == true) {
        TelManager.IsInTalking = false;
        window.clearInterval(TelManager.IntervalSelf);
		callDlg.close();
        //}


        //callDlg.time(1);
    }
}

TelManager.RefreshSelf = function (Phone) {
    //$.alertMsg(Phone, '操作提示', null);
    if (Phone.length == 5 || Phone.length == 8 || Phone.length == 11 || Phone.length == 12) {
        if (Phone.length == 12) {
            if (Phone.substring(0, 1) == "0") {
                Phone = Phone.substring(1, Phone.length);
            }
            TelManager.moveTop(Phone);
        }
    }
}
TelManager.moveLastPhone = "";
TelManager.moveTop = function(phone) {
    if (TelManager.moveLastPhone == phone)
        return;
    TelManager.moveLastPhone = phone;
    var list = [];
    var dt = $('#data_grid');
    var all = dt.datagrid('getData');
    var $view = $('div.datagrid-view');
    if (all.length == 0) {
        $.alertMsg("没有作业监控!", '操作提示', null);
        return false;
    }
    var time = new Date();
    var m = time.getMonth() + 1;
    var currenttime = time.getFullYear() + "-" + m + "-" + time.getDate() + " " + time.getHours() + ":" + time.getMinutes() + ":" + time.getSeconds();
    for (var i = 0; i < all.rows.length; i++) {
        
        var result_start = this.CompareTime(all.rows[i].starttime, currenttime);
        var result_end = this.CompareTime(all.row[i].endtime, currenttime);
        var result = false;
        if ((result_start == 0 || result_start == 2) && (result_end == 1 || result_end == 2)) {
            result = true;
        }
        if (result) {
            if (all.rows[i].phoneno == phone) {
                list.push(i);
            } else if (all.rows[i].stationerno == phone) {
                list.push(i);
            } else if (all.rows[i].CJCONTROL_PHONE == phone) {
                list.push(i);
            }
        }
    }
    if (list.length == 0) {
       // $.alertMsg("作业监控无此手机号!", '操作提示', null);
        return false;
    }
    for (var i = 0; i < list.length; i++) {
        
        for (var j = 0; j <= all.rows.length; j++) {
            var $row = $view.find('tr[datagrid-row-index=' + list[i] + ']');
            $row.css("background-color", "#FFE48D");
            $row.each(function () {
                var prev = $(this).prev();
                prev.length && $(this).insertBefore(prev);
            });
        }
    }
    
    dt.datagrid('selectRow', list[0]);
    
    dt.datagrid('scrollTo', 1);
    
   
    
}
TelManager.CompareTime = function (timea, timeb) {
    timea = timea.replace('/', '-');
    timeb = timeb.replace('/', '-');
    var beginTimes = timea.substring(0, 10).split('-');
    var endTimes = timeb.substring(0, 10).split('-');

    beginTime = beginTimes[1] + '-' + beginTimes[2] + '-' + beginTimes[0] + ' ' + beginTime.substring(10, 19);
    endTime = endTimes[1] + '-' + endTimes[2] + '-' + endTimes[0] + ' ' + endTime.substring(10, 19);

    var a = (Date.parse(endTime) - Date.parse(beginTime)) / 3600 / 1000;
    if (a < 0) { //a<b
        return 0;
    } else if (a > 0) { //a>b
        return 1;
    } else if (a == 0) { //a=b
        return 2;
    } else {
        return 3;
    }
}
//jQuery(document).ready(function () {
//    setInterval(TelManager.CallInAjax, 3000);
//});