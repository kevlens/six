// #region 解决数据序列号大于4位显示不全的（已测试） 
$.extend($.fn.datagrid.methods, {
    fixRownumber: function (jq) {
        return jq.each(function () {
            var panel = $(this).datagrid("getPanel");
            //获取最后一行的number容器,并拷贝一份
            var clone = $(".datagrid-cell-rownumber", panel).last().clone();
            //由于在某些浏览器里面,是不支持获取隐藏元素的宽度,所以取巧一下
            clone.css({
                "position": "absolute",
                left: -1000
            }).appendTo("body");
            var width = clone.width("auto").width();
            //默认宽度是25,所以只有大于25的时候才进行fix
            if (width > 25) {
                //多加5个像素,保持一点边距
                $(".datagrid-header-rownumber,.datagrid-cell-rownumber", panel).width(width + 5);
                //修改了宽度之后,需要对容器进行重新计算,所以调用resize
                $(this).datagrid("resize");
                //一些清理工作
                clone.remove();
                clone = null;
            } else {
                //还原成默认状态
                $(".datagrid-header-rownumber,.datagrid-cell-rownumber", panel).removeAttr("style");
            }
        });
    }
});
// #endregion 
var editIndex, nodid;
var vpage = "";
var curr_time = new Date(), strDate, repairRes = "", unrepairRes = "";
var y = curr_time.getFullYear();
var m = curr_time.getMonth() + 1;
var d = curr_time.getDate();
var speedOption = [
    { "text": "0-120", "value": "0" },
    { "text": "120-160", "value": "1" },
    { "text": "大于160", "value": "2" },
    { "text": "其它站线", "value": "-1" }
    ];
var Common = {
    DateFormatter: function (value, rec, index) {
        if (value == undefined) {
            return "";
        }
        value = value.substr(1, value.length - 2);
        var obj = eval('(' + "{Date: new " + value + "}" + ')');
        var dateValue = obj["Date"];
        if (dateValue.getFullYear() < 1900) {
            return "";
        }
        var date = new Date(dateValue);
        var year = date.getFullYear().toString();
        var month = (date.getMonth() + 1);
        var day = date.getDate().toString();

        if (month < 10) {
            month = "0" + month;
        }
        if (day < 10) {
            day = "0" + day;
        }
        return year + "-" + month + "-" + day;
    }
};
$(function () {
    //$("#DATE_CHECK_DATE").datebox("setValue", setDate('LastWeekOfDay'));
    //$("#DATE_END_DATEQ").datebox('setValue', setDate('CurrentDay'));
    strDate = y + "-";
    strDate += (m < 10 ? '0' + m : m) + "-";
    strDate += (d < 10 ? '0' + d : d);
    initMyTree();
//    getProblemDictData();
});

//#region 基础数据
function getProblemDictData() {
    //线别、行别、车站、病害类型、股道号、道岔号、线名、病害位置、病害项目
    var url = 'ashx/RwEvaHandler.ashx?cmd=getProblemDictData&r=' + Math.random() + '';
    $.ajax({
        url: url,
        dataType: 'json',
        type: 'POST',
        async: false,
        data: { op: "2" },
        error: function (err) {
            alert(err);
        },
        success: function (data) {
            if (data) {
                //线别
                jqData = data.linecat;
                //行别
                jqData_Dir = data.linedir;
                //车站
                jqData_Sta = data.station;
                //病害类型
                jqData_Type = data.probtype;
                //股道号
                //....
                //道岔号
                //....

                //线名
                jqData_bound = data.line;
                line = jqData_bound;
                //病害位置
                jqData_place = data.place;
                //病害项目
                jqData_Item = data.item;

                //工务段
                jqData_Gwd = data.gwd;
                //工区
                jqData_Gq = data.gq;

            }
        }
    });

}
//#endregion
//结束编辑
function endEdit() {
    var rows = $('#data_grid').datagrid('getRows');
    for (var i = 0; i < rows.length; i++) {
        $('#data_grid').datagrid('endEdit', i);
    }
};
function endEditing() {
    if (editIndex == undefined) { return true }
    if ($('#data_grid').datagrid('validateRow', editIndex)) {
        $('#data_grid').datagrid('endEdit', editIndex);
        editIndex = undefined;
        return true;
    } else {
        return false;
    }
};
//编辑
function Edit() {
    var row = $('#data_grid').datagrid('getSelected');
    if (row) {
        endEdit();
        var rowIndex = $('#data_grid').datagrid('getRowIndex', row);
        $('#data_grid').datagrid('updateRow', { index: rowIndex, row: { D_REPAIR_DATE: strDate} });
        $('#data_grid').datagrid('beginEdit', rowIndex);
        $('#data_grid').datagrid('clearSelections');
    }
    else {
        $.messager.alert("系统提示", "请选择要消号的问题数据！", "warning");
    }
}
//撤销
function reject() {
    $('#data_grid').datagrid('rejectChanges');
    //$('#data_grid').datagrid('reload');
    editIndex = undefined;
    $('#data_grid').datagrid('clearSelections').datagrid('clearChecked');
};
function onDbClickRow(rowIndex, rowData) {
    $('#data_grid').datagrid('selectRow', index).datagrid('beginEdit', index);
}
//双击编辑行事件
function onDblClickCellold(index, field) {
    $('#data_grid').datagrid('selectRow', index)
                        .datagrid('beginEdit', index);
};

function onDblClickCell(index, field) {
    var row = $('#data_grid').datagrid('getSelected');
    $('#data_grid').datagrid('cancelEdit', index)
    $('#data_grid').datagrid('updateRow', {
        index: index,
        row: {
            D_REPAIR_DATE: strDate,
            C_REPAIR_RES:"良好"

        }
    });
    $('#data_grid').datagrid('selectRow', index)
                        .datagrid('beginEdit', index);
    editIndex = index;

};

function checkInsert(rowIndex, rowData) {
    $('#data_grid').datagrid('selectRow', rowIndex)
                     .datagrid('beginEdit', rowIndex);
    if ($('#data_grid').datagrid('validateRow', rowIndex)) {
        //$('#data_grid').datagrid('endEdit', rowIndex)
    }
    else {
        $('#data_grid').datagrid('cancelEdit', rowIndex)
        $('#data_grid').datagrid('updateRow', {
            index: rowIndex,
            row: {
                D_REPAIR_DATE: strDate,
                C_REPAIR_RES:"良好"
            }
        });
        $('#data_grid').datagrid('selectRow', rowIndex)
                .datagrid('beginEdit', rowIndex);
    }

}
function onUncheck(rowIndex, rowData) {
    $('#data_grid').datagrid('updateRow', {
        index: rowIndex,
        row: {
            D_REPAIR_DATE: "",
            C_REPAIR_RES: "",
            C_REPAIR_MAN: ""
        }

    });
    $('#data_grid').datagrid('cancelEdit', rowIndex)
}
function onCheckAll(rows) {
    if (rows.length > 0) {
        for (var i = 0; i < rows.length; i++) {
            $('#data_grid').datagrid('selectRow', i)
                                    .datagrid('beginEdit', i);
           // if ($('#data_grid').datagrid('validateRow', i)) {
           //     $('#data_grid').datagrid('endEdit', i)
           // }
           // else {
                $('#data_grid').datagrid('cancelEdit', i)
                $('#data_grid').datagrid('updateRow', {
                    index: i,
                    row: {
                        D_REPAIR_DATE: strDate,
                        C_REPAIR_RES:"良好"
                    }
                });
                $('#data_grid').datagrid('selectRow', i)
                                   .datagrid('beginEdit', i);
           // }
        }
    }
}
function onUncheckAll(rows) {
   $('#data_grid').datagrid('reload');
    //if (rows.length > 0) {
    //    for (var i = 0; i < rows.length; i++) {
    //        $('#data_grid').datagrid('updateRow', {
    //           index: i,
    //            row: {
    //                D_REPAIR_DATE: "",
    //                C_REPAIR_RES: "",
    //                C_REPAIR_MAN: ""
    //            }
    //         });
    //        $('#data_grid').datagrid('cancelEdit', i)
    //    }
    // }
}


//撤销
function reject() {
    $('#data_grid').datagrid('reload');
    editIndex = undefined;
    $('#data_grid').datagrid('clearSelections').datagrid('clearChecked');
};

//问题消号
function ProClear() {
    $('#a_save').linkbutton({
        iconCls: 'icon-part',
        text: "问题消号中"
    });
    endEdit();
    if ($('#data_grid').datagrid('getChecked').length) {
        var getchecked = $('#data_grid').datagrid('getChecked');
        var effectRow = new Object();
        var isValidate = true;
        var checkedRows = $('#data_grid').datagrid('getChecked');
        if (checkedRows.length > 0) {
            for (var m = 0; m < checkedRows.length; m++) {
                if (checkedRows[m].D_REPAIR_DATE == null || checkedRows[m].D_REPAIR_DATE == '') {
                    $.messager.alert("系统提示", "整修日期不能为空！", "warning");
                    isValidate = false;
                    $('#a_save').linkbutton({
                        iconCls: 'icon-delete',
                        text: "问题消号"
                    });
                    return;
                }
                if (checkedRows[m].C_REPAIR_RES == null || checkedRows[m].C_REPAIR_RES == '') {
                    $.messager.alert("系统提示", "整修结果不能为空！", "warning");
                    isValidate = false;
                    $('#a_save').linkbutton({
                        iconCls: 'icon-delete',
                        text: "问题消号"
                    });
                    return;
                }
                if (checkedRows[m].C_REPAIR_MAN == null || checkedRows[m].C_REPAIR_MAN == '') {
                    $.messager.alert("系统提示", "整修人不能为空！", "warning");
                    isValidate = false;
                    $('#a_save').linkbutton({
                        iconCls: 'icon-delete',
                        text: "问题消号"
                    });
                    return;
                }
                if (checkedRows[m]["D_REPAIR_DATE"] != null)
                    checkedRows[m]["D_REPAIR_DATE"] = checkedRows[m]["D_REPAIR_DATE"]+ " 00:00:00"
            }
            effectRow["getchecked"] = JSON.stringify(getchecked);
        }
        else {
            $.messager.alert("系统提示", "请勾选要消号的问题数据！", "warning");
        }

        if (isValidate) {
            $.ajax({
                url: "ashx/AssProClear.ashx?cmd=ProClearData",
                dataType: 'json',
                type: 'POST',
                async: false,
                data: effectRow,
                error: function (err) {
                    $.messager.alert("系统提示", "问题消号失败！", "warning");
                },
                success: function (rsp) {
                    switch (rsp) {
                        case 0:
                            $.messager.show({ title: '系统提示', msg: '问题消号成功 ', timeout: 5000, showType: 'slide' });
                            $('#data_grid').datagrid('clearChecked');
                            $("#data_grid").datagrid('reload');
                            break;
                        default:
                            $.messager.alert("系统提示", "问题消号失败！", "warning");
                            break;
                    }
                }
            });
        }
        else {
            $.messager.alert("系统提示", "请勾选要消号的问题数据！", "warning");
        }
    }
    else {
        $.messager.alert("系统提示", "请勾选要消号的问题数据！", "warning");
    }
    $('#a_save').linkbutton({
        iconCls: 'icon-delete',
        text: "问题消号"
    });

}

function setDate(d) {
    var date = new Date();
    var nowdate = new Date(date);
    nowdate.setDate(date.getDate() - 6);
    var year = date.getFullYear();
    var month = date.getMonth() + 1;
    var day = date.getDate();
    var lastyear = nowdate.getFullYear();
    var lastmonth = nowdate.getMonth() + 1;
    var lastday = nowdate.getDate();
    if (month < 10) { month = '0' + month; }
    if (day < 10) { day = '0' + day; }
    if (lastmonth < 10) { lastmonth = '0' + lastmonth; }
    if (lastday < 10) { lastday = '0' + lastday; }
    switch (d) {
        case 'FirstDayOfYear':
            return year + "-01-01";
            break;
        case 'LastDayOfYear':
            return year + "-12-31";
            break;
        case 'FirstDayOfMonth':
            return year + "-" + month + "-01";
            break;
        case 'LastDayOfYear':
            return year + "-12-31";
            break;
        case "CurrentDay":
            return year + "-" + month + "-" + day;
            break;
        case "LastWeekOfDay":
            return lastyear + "-" + lastmonth + "-" + lastday;
            break
        default:
            return year + "-" + month + "-" + day;
            break;
    }
}
//#region 组织结构树联动数据
function GetAssProClear(node) {
    $('#hdDeptCode').val(node.id);
    $('#hdDeptName').val(node.name);
    $('#hdDeptNameDecode').val(escape(node.name));
    $('#hdDeptLevel').val(node.plev);
    //数据类型
    $('#selline').combobox({
        url: 'ashx/RwEvaHandler.ashx?cmd=getLineByGwd&gwdcode=' + $('#hdDeptCode').val(),
        valueField: 'C_LINE_CODE',
        textField: 'C_LINE_NAME',
        editable: false,
        onLoadSuccess: function () {
        }
    });
    initAssProblemGrid(node);

    //$(".datagrid-header-check input[type=checkbox]:eq(0)").css('display', 'none');
}

function SearchPro() {
    getProblemDictData();
    $('#data_grid').datagrid('load', {
        cmd: 'AssClearProblem',
        id: $('#hdDeptCode').val(),
        datefrom: $('#DATE_CHECK_DATE').datebox("getValue"),
        dateto: $('#DATE_END_DATEQ').datebox("getValue"),
        strinspector: $('#STR_INSPECTOR').val(),
        linecode: $('#selline').combobox("getValue"),
        r: Math.random()
    });
}

function initAssProblemGrid(node) {
    getProblemDictData();
    $('#data_grid').datagrid({
        url: 'ashx/AssProClear.ashx',
        queryParams: {
            cmd: 'AssClearProblem',
            id: $('#hdDeptCode').val(),
            datefrom: $('#DATE_CHECK_DATE').datebox("getValue"),
            dateto: $('#DATE_END_DATEQ').datebox("getValue"),
            strinspector: $('#STR_INSPECTOR').val(),
            linecode: $('#selline').combobox("getValue"),
            r: Math.random()
        },
        pagination: true,
        pageSize: 20,
        pageList: [10, 20, 30, 40, 50],
        fit: true,
        fitColumn: false,
        nowrap: false,
        rownumbers: true,
        singleSelect: true,
        selectOnCheck: false,
        checkOnSelect: false,
        border: 0,
        idField: 'PKID',
        sortName: 'PKID',
        sortOrder: 'desc',
        onCheck: checkInsert,
        onCheckAll: onCheckAll,
        onUncheck: onUncheck,
        onUncheckAll: onUncheckAll,
        onDbClickRow: onDbClickRow,
        onDblClickCell: onDblClickCell,
        frozenColumns: [[
                {
                    title: '选择',
                    field: 'ck',
                    checkbox: true,
                    width: 30,
                    align: 'center'
                },
                {
                    title: 'PKID',
                    field: 'PKID',
                    width: 120,
                    sortable: true,
                    hidden: true,
                    align: 'center'
                },
                {
                    title: '工务段',
                    field: 'C_GWD_CODE',
                    width: 120,
                    hidden: false,
                    formatter: function (value) {
                        for (var i = 0; i < jqData_Gwd.length; i++) {
                            if (jqData_Gwd[i].C_DPT_CDE == value) return jqData_Gwd[i].C_DPT_ABR;
                        }
                        return value;
                    },
                    align: 'center'
                },
                {
                    title: '工区编码',
                    field: 'C_DEP_CODE',
                    width: 120,
                    hidden: true,
                    align: 'center'
                },
                {
                    title: '工区',
                    field: 'C_DEP_NAME',
                    width: 120,
                    align: 'center'
                },
                {
                    title: '线编号',
                    field: 'C_LINE_CODE',
                    width: 80,
                    hidden:true,
                    align: 'center'
                },
                {
                    title: '线名',
                    field: 'C_LINE_NAME',
                    width: 80,
                    align: 'center'
                },
                 {
                     title: '行别',
                     field: 'C_LINE_DIR',
                     width: 80,
                     //sortable: true,
                     align: 'center'
                 }]],
        columns: [
                [{
                    title: '线别',
                    field: 'C_LINE_CAT',
                    width: 80,
                    align: 'center'
                },
                {
                    title: '车站',
                    field: 'C_STATION_CODE',
                    width: 80,
                    formatter: function (value) {
                        for (var i = 0; i < jqData_Sta.length; i++) {
                            if (jqData_Sta[i].C_STATION_CODE == value) return jqData_Sta[i].C_STATION_NAME;
                        }
                        return value;
                    },
                    align: 'center'
                },
                {
                    title: '股道',
                    field: 'C_TRACK_CODE',
                    width: 80,
                    align: 'center'
                },
                {
                    title: '道岔',
                    field: 'C_TURNOUT_CODE',
                    width: 80,
                    align: 'center'
                },
                {
                    title: '项目',
                    field: 'C_PRO_ITEM',
                    width: 120,
                    formatter: function (value) {
                        for (var i = 0; i < jqData_Item.length; i++) {
                            if (jqData_Item[i].PKID == value) return jqData_Item[i].C_ITEM;
                        }
                        return value;
                    },
                    align: 'center'
                },
                {
                    title: '病害类型',
                    field: 'C_PRO_CODE',
                    width: 150,
                    formatter: function (value) {
                        for (var i = 0; i < jqData_Type.length; i++) {
                            if (jqData_Type[i].C_TYPE_CODE == value) return jqData_Type[i].C_TYPE;
                        }
                        return value;
                    },
                    align: 'center'
                },
                {
                    title: '病害里程',
                    field: 'N_PRO_MILE',
                    width: 80,
                    formatter: function (value) {
                        if (value)
                            return value.toFixed(5);
                    },
                    align: 'center'
                },
                {
                    title: '病害位置',
                    field: 'C_PRO_PLACE',
                    width: 150,
                    align: 'center'
                },
                {
                    title: '病害详情',
                    field: 'C_PRO_DETAIL',
                    width: 150,
                    align: 'center'
                },
                {
                    title: '病害峰值',
                    field: 'N_PRO_PEAK',
                    width: 80,
                    align: 'center'
                },
                {
                    title: '超限等级',
                    field: 'N_OVERRUN_LEVEL',
                    width: 80,
                    align: 'center'
                },
                {
                    title: '速度范围',
                    field: 'N_SPEED',
                    width: 80,
                    align: 'center',
                    formatter: function (value) {
                        for (var i = 0; i < speedOption.length; i++) {
                            if (speedOption[i].value == value)
                                return speedOption[i].text;
                        }
                        return value;
                    }
                },
                {
                    title: '检查人',
                    field: 'C_INSPECTOR',
                    width: 100,
                    align: 'center'
                },
                {
                    title: '检查人职务',
                    field: 'C_POST',
                    width: 80,
                    align: 'center'
                },
                {
                    title: '检查日期',
                    field: 'D_CHECK_DATE',
                    width: 120,
                    // formatter: Common.DateFormatter,
                    align: 'center'
                },
                {
                    field: 'D_REPAIR_DATE', title: '整修日期', width: 120, align: 'center', sortable: true,
                 editor: { type: "datebox", options: { editable: false, required: true} }
                },
               {
                   field: 'C_REPAIR_RES', title: '整修结果', width: 200, align: 'center', sortable: true
                , editor: { type: "validatebox", options: { validType: { length: [0, 100] }, required: true} }
               },
    {
        field: 'C_REPAIR_MAN', title: '整修人', width: 120, align: 'center', sortable: true
                , editor: { type: "validatebox", options: { validType: { length: [0, 50] }, required: true} }
    },
       {
           title: '检查类型',
           field: 'C_CHECK_TYPE',
           width: 80,
           align: 'center'
       }, {
           title: '检查设备',
           field: 'C_CHECK_DEV',
           width: 80,
           align: 'center'
       }
     ]],
     onLoadSuccess: function (data) {
         var options = $('#data_grid').datagrid('getPager').data("pagination").options;
            vpage = options.pageNumber; //当前页
     },
     onBeforeLoad: function (e) {
        var checkedRows = $('#data_grid').datagrid('getChecked');
        if (checkedRows.length > 0) {
        $.messager.alert('系统提示', '请先反馈消号选中的数据！', 'warning');
        var pg = $('#data_grid').datagrid('getPager');
        $(pg).pagination({
            pageNumber: vpage
        });

        return false;
    }
}
    });

    $(".datagrid-header-check input[type=checkbox]:eq(0)").css('display', 'none');
    $(".datagrid-header-check input[type=checkbox]:eq(1)").css('display', 'none');
}