var utils = {};
/**
* 格式化字符串
* 用法:
.formatString("{0}-{1}","a","b");
*/
utils.formatString = function () {
    for (var i = 1; i < arguments.length; i++) {
        var exp = new RegExp('\\{' + (i - 1) + '\\}', 'gm');
        arguments[0] = arguments[0].replace(exp, arguments[i]);
    }
    return arguments[0];
};
/**
* 字符串替换为空格
* 用法:
*/
utils.replaceString = function (stringObj) {
    //var reg0 = new RegExp("0", "g"); //创建正则RegExp对象 
    //var reg1 = new RegExp("1", "g"); //创建正则RegExp对象 
    //var reg2 = new RegExp("2", "g"); //创建正则RegExp对象 
    //var reg3 = new RegExp("3", "g"); //创建正则RegExp对象 
    //var reg4 = new RegExp("4", "g"); //创建正则RegExp对象 
    //var reg5 = new RegExp("5", "g"); //创建正则RegExp对象 
    //var reg6 = new RegExp("6", "g"); //创建正则RegExp对象 
    //var reg7 = new RegExp("7", "g"); //创建正则RegExp对象 
    //var reg8 = new RegExp("8", "g"); //创建正则RegExp对象 
    //var reg9 = new RegExp("9", "g"); //创建正则RegExp对象 
    //var newstr = stringObj.replace(reg0, "&nbsp;");
    //newstr = newstr.replace(reg1, "&nbsp;");
    //newstr = newstr.replace(reg2, "&nbsp;");
    //newstr = newstr.replace(reg3, "&nbsp;");
    //newstr = newstr.replace(reg4, "&nbsp;");
    //newstr = newstr.replace(reg5, "&nbsp;");
    //newstr = newstr.replace(reg6, "&nbsp;");
    //newstr = newstr.replace(reg7, "&nbsp;");
    //newstr = newstr.replace(reg8, "&nbsp;");
    //newstr = newstr.replace(reg9, "&nbsp;");
    //var reg = new RegExp("^[0-9]*$");
    //for (var i = 0; i < stringObj.length; i++) {
    //    var newstr = stringObj.replace(reg, "&nbsp;" + stringObj.length);
    //}
    var newstr = "";
    for (var i = 0; i < stringObj.length; i++) {

        newstr += "&nbsp;";
    }
    return newstr;
};


//弹出信息窗口 title:标题 msgString:提示信息 msgType:信息类型 [error,info,question,warning]
utils.msgShow = function (title, msgString, msgType) {
    $.messager.alert(title, msgString, msgType);
}
/*
utils.TimeFormatter = function (value, rec, index) {
    if (value == undefined) {
        return "";
    }
    //json格式时间转js时间格式
    value = value.substr(1, value.length - 2);
    var obj = eval('(' + "{Date: new " + value + "}" + ')');
    var dateValue = obj["Date"];
    if (dateValue.getFullYear() < 1900) {
        return "";
    }
    var val = dateValue.format("yyyy-mm-dd HH:MM");
    return val.substr(11, 5);
}
*/


Date.prototype.format = function (format) {
    if (!format) {
       // format = "yyyy-MM-dd hh:mm:ss";
    }
    var o = {
        "M+": this.getMonth() + 1, // month
        "d+": this.getDate(), // day
        "h+": this.getHours(), // hour
        "m+": this.getMinutes(), // minute
        "s+": this.getSeconds(), // second
        "q+": Math.floor((this.getMonth() + 3) / 3), // quarter
        "S": this.getMilliseconds()
        // millisecond
    };
    if (/(y+)/.test(format)) {
        format = format.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
    }
    for (var k in o) {
        if (new RegExp("(" + k + ")").test(format)) {
            format = format.replace(RegExp.$1, RegExp.$1.length == 1 ? o[k] : ("00" + o[k]).substr(("" + o[k]).length));
        }
    }
    return format;
}
utils.fomatDateTime = function (str) {
    return (new Date(parseInt(str.substring(str.indexOf('(') + 1, str.indexOf(')'))))).format("yyyy-MM-dd hh:mm:ss");
}
utils.fomatDate = function (str) {
    return (new Date(parseInt(str.substring(str.indexOf('(') + 1, str.indexOf(')'))))).format("yyyy-MM-dd");
}
utils.fomatTime = function (str) {
    return (new Date(parseInt(str.substring(str.indexOf('(') + 1, str.indexOf(')'))))).format("hh:mm:ss");
}
utils.fomatNoSecDateTime = function (str) {
    return (new Date(parseInt(str.substring(str.indexOf('(') + 1, str.indexOf(')'))))).format("yyyy-MM-dd hh:mm");
}

utils.toDecimal3 = function(x) {
    var f = parseFloat(x);
    if (isNaN(f)) {
        return '';
    }
    var f = Math.round(x * 1000) / 1000;
    var s = f.toString();
    var rs = s.indexOf('.');
    if (rs < 0) {
        rs = s.length;
        s += '.';
    }
    while (s.length <= rs + 3) {
        s += '0';
    }
    return s;
}
utils.ChangeDateFormat = function (jsondate) {
    if (jsondate.indexOf("Date") > 0) {
        jsondate = jsondate.replace("/Date(", "").replace(")/", "");
        if (jsondate.indexOf("+") > 0) {
            jsondate = jsondate.substring(0, jsondate.indexOf("+"));
        } else if (jsondate.indexOf("-") > 0) {
            jsondate = jsondate.substring(0, jsondate.indexOf("-"));
        }

        var date = new Date(parseInt(jsondate, 10));
        var month = date.getMonth() + 1 < 10 ? "0" + (date.getMonth() + 1) : date.getMonth() + 1;
        var currentDate = date.getDate() < 10 ? "0" + date.getDate() : date.getDate();
        var currentHours = date.getHours() < 10 ? "0" + date.getHours() : date.getHours();
        var currentMinutes = date.getMinutes() < 10 ? "0" + date.getMinutes() : date.getMinutes();
        return date.getFullYear() + "/" + month + "/" + currentDate + " " + currentHours + ":" + currentMinutes;
    } else if (jsondate.indexOf("T") > 0) {
        jsondate = jsondate.replace("T", " ");
        return (new Date(jsondate)).format("yyyy/MM/dd hh:mm");
    } else {
        return (new Date(jsondate)).format("yyyy/MM/dd hh:mm");
    }
}

//参数为字符串
utils.ChangeDateNoSecDateTime = function (jsondate) {
    return (new Date(jsondate)).format("yyyy/MM/dd hh:mm");
}