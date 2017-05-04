$.extend($.fn.datagrid.methods, {
    editCell: function (jq, param) {
        return jq.each(function () {
            var opts = $(this).datagrid('options');
            var fields = $(this).datagrid('getColumnFields', true).concat($(this).datagrid('getColumnFields'));
            for (var i = 0; i < fields.length; i++) {
                var col = $(this).datagrid('getColumnOption', fields[i]);
                col.editor1 = col.editor;
                if (fields[i] != param.field) {
                    col.editor = null;
                }
            }
            $(this).datagrid('beginEdit', param.index);
            for (var i = 0; i < fields.length; i++) {
                var col = $(this).datagrid('getColumnOption', fields[i]);
                col.editor = col.editor1;
            }

        });
    }
});

////#reion 解决数据序列号大于4位显示不全的 
//$.extend($.fn.datagrid.methods, {
//    fixRownumber: function (jq) {
//        return jq.each(function () {
//            var panel = $(this).datagrid("getPanel");
//            //获取最后一行的number容器,并拷贝一份
//            var clone = $(".datagrid-cell-rownumber", panel).last().clone();
//            //由于在某些浏览器里面,是不支持获取隐藏元素的宽度,所以取巧一下
//            clone.css({
//                "position": "absolute",
//                left: -1000
//            }).appendTo("body");
//            var width = clone.width("auto").width();
//            //默认宽度是25,所以只有大于25的时候才进行fix
//            if (width > 25) {
//                //多加5个像素,保持一点边距
//                $(".datagrid-header-rownumber,.datagrid-cell-rownumber", panel).width(width + 5);
//                //修改了宽度之后,需要对容器进行重新计算,所以调用resize
//                $(this).datagrid("resize");
//                //一些清理工作
//                clone.remove();
//                clone = null;
//            } else {
//                //还原成默认状态
//                $(".datagrid-header-rownumber,.datagrid-cell-rownumber", panel).removeAttr("style");
//            }
//        });
//    }
//});
////#endregion

String.prototype.replaceAll = function (s1, s2) {
    return this.replace(new RegExp(s1, "gm"), s2);
}
var viewModel = function (data) {
    var self = this;

    self.showHideColumns = [];
    self.Permission = ko.mapping.fromJS(data.Permission);
    self.resx = ko.mapping.fromJS(data.resx);
    self.urls = ko.mapping.fromJS(data.urls);

    self.searchForm = ko.mapping.fromJS(data.searchForm);
    self.addForm = ko.mapping.fromJS(data.addForm);
    self.extForm = ko.mapping.fromJS(data.extForm);
    if (typeof loadInit == "function") {//存在且是function
        loadInit(self, "afterInit");//加载页面
    }

    //self.extone = ko.observableArray(data.extForm.extone);

    for (var extName in data.extForm) {
        var extValue = ko.observableArray(data.extForm[extName])
        switch (extName) {
            case "extA":
                self.extA = extValue;
                break;
            case "extB":
                self.extB = extValue;
                break;
            case "extC":
                self.extC = extValue;
                break;
            case "extD":
                self.extD = extValue;
                break;
            case "extE":
                self.extE = extValue;
                break;
            case "extF":
                self.extF = extValue;
                break;
            case "extG":
                self.extG = extValue;
                break;
            case "extH":
                self.extH = extValue;
                break;
            case "extI":
                self.extI = extValue;
                break;
            case "extJ":
                self.extJ = extValue;
                break;
            case "extK":
                self.extK = extValue;
                break;
            case "extL":
                self.extL = extValue;
                break;
            case "extM":
                self.extM = extValue;
                break;
            case "extN":
                self.extN = extValue;
                break;
            case "extO":
                self.extO = extValue;
                break;
            case "extP":
                self.extP = extValue;
                break;
            case "extQ":
                self.extQ = extValue;
                break;
            case "extR":
                self.extR = extValue;
                break;
            case "extS":
                self.extS = extValue;
                break;
            case "extT":
                self.extT = extValue;
                break;
            case "extU":
                self.extU = extValue;
                break;
            case "extV":
                self.extV = extValue;
                break;
            case "extW":
                self.extW = extValue;
                break;
            case "extX":
                self.extX = extValue;
                break;
            case "extY":
                self.extY = extValue;
                break;
            case "extZ":
                self.extZ = extValue;
                break;
            case "extAA":
                self.extAA = extValue;
                break;
            case "extAB":
                self.extAB = extValue;
                break;
            case "extAC":
                self.extAC = extValue;
                break;
            case "extAD":
                self.extAD = extValue;
                break;
            case "extAE":
                self.extAE = extValue;
                break;
            case "extAF":
                self.extAF = extValue;
                break;
            case "extAG":
                self.extAG = extValue;
                break;
            case "extAH":
                self.extAH = extValue;
                break;
            case "extAI":
                self.extAI = extValue;
                break;

            default:

        }

    }
    delete self.Permission.__ko_mapping__;
    delete self.resx.__ko_mapping__;
    delete self.urls.__ko_mapping__;

    delete self.extForm.__ko_mapping__;
    delete self.searchForm.__ko_mapping__;
    delete self.addForm.__ko_mapping__;

    //是否启用行编辑
    if (data.urls.dataGgridEditId == "true") {
        $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]({
            onDblClickCell: function (index, field, value) {
                $(this).datagrid('editCell', { index: index, field: field });
                data.urls.dataGgridEditId = index;
            },
            onClickCell: function (index, field, value) {
                var editIndex = data.urls.dataGgridEditId;
                if (editIndex != "true") {
                    $(this).datagrid('endEdit', editIndex);
                    data.urls.dataGgridEditId = "true";
                }
            },
            onAfterEdit: function (rowIndex, rowData, changes) {
                if (JSON.stringify(changes) != "{}") {
                    var editcellname = JSON.stringify(changes).split('"')[1];
                    rowData.editcellname = editcellname;
                    rowData.rows = rowIndex;
                    //self.saveEditRow(rowData);
                    $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('loading');
                    $.ajax({
                        url: data.urls.editcell,
                        data: rowData,
                        type: 'post',
                        success: function succEditCallback(result, textStatus) {
                            $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('loaded');
                            $.procAjaxMsg(result, function () {
                                if (result.Data != null) {
                                    $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('updateRow', result.Data);
                                } else {
                                    //if (typeof loadExt == "function") {//存在且是function
                                    //    loadExt(self, "afterEditCellSucc");//扩展
                                    //}
                                    $.alertMsg(result.Msg, '修改成功', null);
                                }
                            }, function () {
                                $.alertMsg(result.Msg, '修改失败', null);
                            });
                        }
                    }).fail(
                    function (xhr, textStatus, err) {
                        $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('loaded');
                        $.alertMsg('修改失败，原因如下: ' + err, '操作提示', null);
                    });
                }
            }
        });
    }

    //$('#' + data.urls.dataGgridName)[data.urls.dataGgridType]({
    //    onLoadSuccess: function (data) {
    //        $('#' + data.urls.dataGgridName)[data.urls.dataGgridType].datagrid("fixRownumber");
    //    }
    //});
    //身份验证
    self.isLogin = function (funcSuc) {
        $.ajax({
            url: '/api/Base/IsLogin',
            data: {},
            type: "Post",
            success: function (result, textStatus) {
                $.procAjaxMsg(result, function () {
                    funcSuc();
                }, function () {
                    $.alertMsg(result.Msg, '操作提示', null);
                });
            }
        }).fail(
        function (xhr, textStatus, err) {
            $.alertMsg('提交失败，原因如下: ' + err, '操作提示', null);
        });
    }
    //加载权限
    self.loadHandle = function () {
        if (data.Permission.a_list) {
            if (typeof loadExt == "function") {//存在且是function
                self.isLogin(function () { loadExt(self, "afterLoad"); });//加载页面
            }

            for (var butName in data.Permission) {
                if (butName != "a_list") {
                    $('#' + butName).css("display", "");
                    if (data.Permission[butName])
                    { $('#' + butName).linkbutton('enable') }
                    else
                    {
                        $('#' + butName).linkbutton('disable');
                        $('#' + butName).attr("data-bind", "");
                    };
                }
            }
            $('#s-toolbar').html($('#searchTemplate').html());
            $('#z-toolbar').html($('#buttonTemplate').html());
            $('#v-toolbar').html($('#saveTemplate').html());
        } else {
            $('.easyui-layout').html("");
            $.alertMsg(data.resx.listTitle, '操作提示', null);
        }

    };
    //新增加
    self.addHandle = function () {
        if (data.Permission.a_add) {
            delete self.addForm.__ko_mapping__;
            $.each(self.addForm, function () { this(''); });
            if (typeof loadExt == "function") {//存在且是function
                loadExt(self, "beforeAdd");//扩展
            }
            if (data.urls.titleName != undefined) {
                $('#' + data.urls.dataAddName).window('open').window('setTitle', data.urls.titleName);
            } else {
                $('#' + data.urls.dataAddName).window('open');
            }
        } else {
            $.alertMsg(data.resx.addTitle, '操作提示', null);
        }
    };
    //保存
    self.saveHandle = function () {
        if ($("#v-toolbar a[id='saveBut']").attr("class").indexOf("l-btn-disabled") == "-1") {//重复提交
            $('#' + data.urls.dataFormName).form('submit', {
                onSubmit: function () {
                    if (typeof loadExt == "function") {//存在且是function
                        loadExt(self, "beforeSubmit");//扩展
                    }
                    if ($(this).form('validate')) {
                        $("#v-toolbar a[id='saveBut']").addClass("l-btn-disabled");
                        //$('#saveBut').linkbutton('disable');//禁用
                        //$('#saveBut').linkbutton({ iconCls: 'icon-ok', text: "保存中" });
                        if (typeof loadExt == "function") {//存在且是function
                            loadExt(self, "beforeSave");//扩展
                        }
                        $.ajax({
                            url: data.urls.save,
                            data: self.addForm,
                            type: "POST",
                            success: self.saveSuccfunc//回调成功
                        }).fail(
                        function (xhr, textStatus, err) {
                            //$('#saveBut').linkbutton('enable');
                            //$('#saveBut').linkbutton({ iconCls: 'icon-ok', text: "保 存" });
                            $("#v-toolbar a[id='saveBut']").removeClass("l-btn-disabled");
                            $.alertMsg('提交失败，原因如下: ' + err, '操作提示', null);
                        });
                        return false;
                    }
                    else {
                        return false;
                    }
                }
            });
        }
    }
    self.saveSuccfunc = function succCallback(result, textStatus) {
        $("#v-toolbar a[id='saveBut']").removeClass("l-btn-disabled");
        //$('#saveBut').linkbutton('enable');
        //$('#saveBut').linkbutton({ iconCls: 'icon-ok', text: "保 存" });
        $.procAjaxMsg(result, function () {
            if (result.Data != null) {//不刷新
                $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('updateRow', result.Data);
            } else {//刷新
                $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('reload');
            }
            $('#' + data.urls.dataAddName).window('close');
            delete self.addForm.__ko_mapping__;
            $.each(self.addForm, function () { this(''); });
            if (typeof loadExt == "function") {//存在且是function
                loadExt(self, "afterSave");//扩展
            }
            $.alertMsg(result.Msg, '操作提示', null);
        }, function () {
            $.alertMsg(result.Msg, '操作提示', null);
        });
    };
    //修改编辑
    self.updateHandle = function () {
        if (self.Permission.a_edit()) {
            var row = $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('getSelected');
            if (row) {
                var index = $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('getRowIndex', row);
                row.rows = index;
                if (typeof loadExt == "function") {//存在且是function
                    loadExt(self, "beforeEdit");//扩展
                }
                $.ajax({
                    url: data.urls.edit,
                    data: row,
                    type: 'post',
                    success: self.editSuccupfunc
                }).fail(
                function (xhr, textStatus, err) {
                    $.alertMsg('提交失败，原因如下: ' + err, '操作提示', null);
                });
            } else {
                $.alertMsg("请先选择要编辑的行！", '操作提示', null);
            }
        } else {
            $.alertMsg(data.resx.editTitle, '操作提示', null);
        }
    };
    self.editSuccupfunc = function succupCallback(result, textStatus) {
        if (result.Statu != "1") {
            $.procAjaxMsg(result, function () { $.alertMsg(result.Msg, '操作提示', null); }, function () { $.alertMsg(result.Msg, '操作提示', null); });
        } else {
            delete self.addForm.__ko_mapping__;
            ko.mapping.fromJS(result.Data, {}, self.addForm);
            delete self.addForm.__ko_mapping__;
            if (typeof loadExt == "function") {//存在且是function
                loadExt(self, "afterEdit");//扩展
            }
            if (data.urls.titleName != undefined) {
                $('#' + data.urls.dataAddName).window('open').window('setTitle', data.urls.titleName);
            } else {
                $('#' + data.urls.dataAddName).window('open');
            }
        }
    };

    //单行导出
    self.singleExcelHandle = function () {
        if (data.Permission.a_single) {
            var row = $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('getSelected');
            if (row) {
                var index = $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('getRowIndex', row);
                row.rows = index;
                if (typeof loadExt == "function") {//存在且是function
                    loadExt(self, "beforeSingle");//扩展
                }
                $.ajax({
                    url: data.urls.single,
                    data: row,
                    type: 'post',
                    success: self.singleSuccupfunc
                }).fail(
                function (xhr, textStatus, err) {
                    $.alertMsg('提交失败，原因如下: ' + err, '操作提示', null);
                });
            } else {
                $.alertMsg("请先选择要导出的行！", '操作提示', null);
            }
        } else {
            $.alertMsg(data.resx.singleTitle, '操作提示', null);
        }
    };
    self.singleSuccupfunc = function succupCallback(result, textStatus) {
        $.procAjaxMsg(result, function () {
            if (typeof loadExt == "function") {//存在且是function
                loadExt(self, "afterSingle");//扩展
            }
            window.location.href = result.BackUrl; 0
        }, function () {
            $.alertMsg(result.Msg, '导出失败', null);
        });
    };
    //删除
    self.deleteHandle = function () {
        if (data.Permission.a_del) {
            var row = $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('getSelected');
            if (row) {
                if (typeof loadExt == "function") {//存在且是function
                    loadExt(self, "beforeDel");//扩展
                }

                $.messager.confirm('请确认', '您确定要删除选择的行吗！', function (b) {
                    if (b) {
                        $.ajax({
                            url: data.urls.del,
                            data: row,
                            type: 'post',
                            success: self.delSuccupfunc
                        }).fail(
                        function (xhr, textStatus, err) {
                            $.alertMsg('删除失败，原因如下: ' + err, '操作提示', null);
                        });
                    }
                });

            } else {
                $.alertMsg("请先选择要删除的行！", '操作提示', null);
            }
        } else {
            $.alertMsg(data.resx.deleteTitle, '操作提示', null);
        }
    }
    self.delSuccupfunc = function succupCallback(result, textStatus) {
        $.procAjaxMsg(result, function () {
            $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('reload');
            $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('unselectAll');
            if (typeof loadExt == "function") {//存在且是function
                loadExt(self, "afterDel");//扩展
            }
            $.alertMsg(result.Msg, '操作提示', null);
        }, function () {
            $.alertMsg(result.Msg, '操作提示', null);
        });
    };

    //多选删除
    self.deleteSelectHandle = function () {
        if (data.Permission.a_selectdel) {
            var checkedItems = $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('getChecked');
            var names = [];
            $.each(checkedItems, function (index, item) {
                item.idField
                names.push(item[data.urls.dataGgridDelId]);
            });
            var PKID = names.join(",");

            self.isLogin(function () {
                if (PKID != "") {

                    if (typeof loadExt == "function") {//存在且是function
                        loadExt(self, "beforeSelectDel");//扩展
                    }
                    $.messager.confirm('请确认', '您确定要删除选中的行吗？', function (b) {
                        if (b) {
                            $.ajax({
                                url: data.urls.selectdel,
                                data: { "": PKID },
                                cache: false,
                                type: 'post',
                                success: self.selectdelSuccupfunc
                            }).fail(
                            function (xhr, textStatus, err) {
                                $.alertMsg('删除失败，原因如下: ' + err, '操作提示', null);
                            });
                        }
                    });

                } else {
                    $.alertMsg("请先选择要删除的行！", '操作提示', null);
                }

            });
        } else {
            $.alertMsg(data.resx.deleteTitle, '操作提示', null);
        }
    }
    self.selectdelSuccupfunc = function succupCallback(result, textStatus) {
        $.procAjaxMsg(result, function () {
            $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('reload');
            $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('unselectAll');
            if (typeof loadExt == "function") {//存在且是function
                loadExt(self, "afterSelectDel");//扩展
            }
            $.alertMsg(result.Msg, '操作提示', null);
        }, function () {
            $.alertMsg(result.Msg, '操作提示', null);
        });
    };
    //查询删除
    self.deleteSearchHandle = function () {
        if (data.Permission.a_searchdel) {
            self.isLogin(function () {
                var param = ko.toJS(self.searchForm);
                if (typeof loadExt == "function") {//存在且是function
                    loadExt(self, "beforeSearchDel");//扩展
                }
                $.messager.confirm('请确认', '您确定要删除查询到的记录吗？', function (b) {
                    if (b) {
                        $.ajax({
                            url: data.urls.searchdel,
                            data: param,
                            cache: false,
                            type: 'POST',
                            success: self.searchdelSuccupfunc
                        }).fail(
                        function (xhr, textStatus, err) {
                            $.alertMsg('删除失败，原因如下: ' + err, '操作提示', null);
                        });
                    }
                });
            });
        } else {
            $.alertMsg(data.resx.deleteTitle, '操作提示', null);
        }
    }
    self.searchdelSuccupfunc = function succupCallback(result, textStatus) {
        $.procAjaxMsg(result, function () {
            $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('reload');
            $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('unselectAll');
            if (typeof loadExt == "function") {//存在且是function
                loadExt(self, "afterSearchDel");//扩展
            }
            $.alertMsg(result.Msg, '操作提示', null);
        }, function () {
            $.alertMsg(result.Msg, '操作提示', null);
        });
    };
    //查询
    self.searchHandle = function () {
        if (data.Permission.a_list) {
            self.isLogin(function () {
                if (typeof loadExt == "function") {//存在且是function
                    loadExt(self, "beforeSearch");//扩展
                }
                var opts = $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('options');
                var pager = $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('getPager');
                opts.pageNumber = 1;
                opts.pageSize = opts.pageSize;
                pager.pagination('refresh', {
                    pageNumber: 1,
                    pageSize: opts.pageSize
                });
                var param = ko.toJS(self.searchForm);
                $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]({ queryParams: param });
                $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('unselectAll');
            });
        } else {
            $('.easyui-layout').html("");
            $.alertMsg(data.resx.listTitle, '操作提示', null);
        }
    }
    //清空
    self.clearHandle = function () {
        if (data.Permission.a_list) {
            self.isLogin(function () {
                if (typeof loadExt == "function") {//存在且是function
                    loadExt(self, "initClear");//扩展
                }
                $.each(self.searchForm, function () { this(''); });
                if (typeof loadExt == "function") {//存在且是function
                    loadExt(self, "beforeClear");//扩展
                }
                var param = ko.toJS(self.searchForm);
                $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]({ queryParams: param });
                $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('unselectAll');
            });
        } else {
            $('.easyui-layout').html("");
            $.alertMsg(data.resx.listTitle, '操作提示', null);
        }
    }
    //刷新
    self.refreshHandle = function () {
        self.isLogin(function () {
            $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('reload');
            $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('unselectAll');

        });
    };
    //关闭
    self.closeHandle = function () {
        $('#' + data.urls.dataAddName).window('close');
    };
    //导出EXCEL
    self.outExcelHandle = function () {
        if (data.Permission.a_excelout) {
            self.isLogin(function () {
                if (typeof loadExt == "function") {//存在且是function
                    loadExt(self, "beforeOutExcel");//扩展
                }
                var param = ko.toJS(self.searchForm);
                $.messager.confirm('请确认', '您确定要导出数据吗？', function (b) {
                    if (b) {
                        $.ajax({
                            url: data.urls.writexls,
                            data: param,
                            cache: false,
                            type: 'POST',
                            success: self.outExcelfunc
                        }).fail(
                        function (xhr, textStatus, err) {
                            $.alertMsg('导出失败，原因如下: ' + err, '操作提示', null);
                        });
                    }
                });
            });
        } else {
            $.alertMsg("您没有导出权限！", '操作提示', null);
        }
    }
    self.outExcelfunc = function succupCallback(result, textStatus) {
        $.procAjaxMsg(result, function () {
            if (typeof loadExt == "function") {//存在且是function
                loadExt(self, "afterOutExcel");//扩展
            }
            window.location.href = result.BackUrl;0
        }, function () {
            $.alertMsg(result.Msg, '导出失败', null);
        });
    };

    //导入EXCEL
    self.inExcelHandle = function () {
        if (data.Permission.a_excelin) {
            self.isLogin(function () {
                if (typeof loadExt == "function") {//存在且是function
                    loadExt(self, "beforeInExcel");//扩展
                }
                if (navigator.userAgent.indexOf("MSIE") > 0) {
                    //console.info("MSIE");
                    //$('#imgurl').filebox('destroy');
                    $('#excelurl').filebox('destroy');
                } else {
                    // 非 IE
                    //$("#imgurlie").css('display', 'none');
                    $("#excelurlie").css('display', 'none');
                }
                $('#excelurl').filebox('clear');
                var result = $.parseJSON('{"total":0,"rows":[]}');
                self.errorLoad(result);
                if (typeof loadExt == "function") {//存在且是function
                    loadExt(self, "afterInExcel");//扩展
                }
                $('#InExcel').window('open').window('setTitle', '导入EXCEL');

            });
        } else {
            $.alertMsg("您没有导入权限！", '操作提示', null);
        }
    }

    self.selectExcelHandle = function () {

        $('#excelBut').linkbutton('disable');//禁用
        $('#excelBut').linkbutton({
            iconCls: 'icon-page_excel',
            text: "导入中.."
        });
        $('#InExcelForm').form('submit', {
            url: data.urls.readxls.replace("/api", ""),
            cache: false,
            onSubmit: function (param) {
                if ($(this).form('validate')) {
                    var result = $.parseJSON('{"total":0,"rows":[]}');
                    self.errorLoad(result);
                    param.notStation = $('#notstation').val();//忽略不对应车站
                    param.syindate = $('#syindate').datebox('getValue');//忽略不对应车站
                    return true;
                } else {
                    $('#excelBut').linkbutton('enable');
                    $('#excelBut').linkbutton({ iconCls: 'icon-page_excel', text: "导 入" });
                    return false;
                }
            },
            success: function (result) {
                $('#excelBut').linkbutton('enable');
                $('#excelBut').linkbutton({ iconCls: 'icon-page_excel', text: "导 入" });
                //console.info(result);
                var result = $.parseJSON(result);
                //console.info(result);
                $.procAjaxMsg(result, function () {
                    if (navigator.userAgent.indexOf("MSIE") > 0) {
                        var file = $("#excelurlie")
                        file.after(file.clone().val(""));
                        file.remove();
                    } else {
                        $('#excelurl').filebox('clear');
                    }
                    $('#notstation').val("");//清除忽略不对应车站
                    $('#InExcel').window('close');
                    $('#data_grid').datagrid('reload');
                    $.alertMsg(result.Msg, '操作提示', null);
                }, function () {
                    if (result.Data == null) {
                        $.alertMsg(result.Msg, '操作提示', null);
                    } else {
                        $('#data_grid').datagrid('reload');
                        self.errorLoad(result.Data);
                    }
                });
            }
        });
    }
    self.showHideColumnHandle = function () {
        if (self.showHideColumns.length == 0) {
            var columns = $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('getColumnFields');
            var frozencolumns = $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('getColumnFields', true);
            columns = columns.concat(frozencolumns);
            for (var i = 0; i < columns.length; i++) {
                var options = $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('getColumnOption', columns[i]);
                if (options.hasOwnProperty("hidden") && options.hidden) {
                    self.showHideColumns.push(columns[i]);
                }
            }
        }
        if ($('#a_showhide').linkbutton().text().trim() == "显示列") {
            for (var i = 0; i < self.showHideColumns.length; i++) {
                $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('showColumn', self.showHideColumns[i]);
            }
            $('#a_showhide').linkbutton('enable');
            $('#a_showhide').linkbutton({ iconCls: 'icon-shield_silver', text: "隐藏列" });
        } else {
            for (var i = 0; i < self.showHideColumns.length; i++) {
                $('#' + data.urls.dataGgridName)[data.urls.dataGgridType]('hideColumn', self.showHideColumns[i]);
            }
            $('#a_showhide').linkbutton('enable');
            $('#a_showhide').linkbutton({ iconCls: 'icon-shield', text: "显示列" });
        }
    }
    self.errorLoad = function (result) {
        $('#error_grid').datagrid({
            data: result,
            //pagination: true,
            //pageSize: 20,
            //pageList: [10, 20, 30, 40, 50],
            fit: true,
            fitColumns: true,
            nowrap: false,
            rownumbers: true,
            singleSelect: true,
            border: 0,
            idField: 'rowIndex',
            rowStyler: function (index, row) {
                if (row.errorInfo == "导入成功") {
                    return 'background-color:#ffee00;color:red;';
                }
            },
            columns: [[
         {
             title: '行数',
             field: 'rowIndex',
             width: 40,
             align: 'center',
             halign: 'center'
         }
         //, {
         //    title: '错误列',
         //    field: 'columnIndex',
         //    width: 40,
         //    align: 'center',
         //    formatter: function (value) {
         //        if (value) {
         //            return value == "0" ? "" : value;
         //        }
         //    }
         //}
         , {
             title: '原因备注',
             field: 'errorCause',
             width: 300,
             align: 'left'
         }
         //,
         //{
         //    title: '操作',
         //    field: 'station',
         //    width: 100,
         //    align: 'center',
         //    formatter: function (value) {
         //        if (value != null && value != "" && value != "null") {
         //            var str = "<a href=\"javascript:void(0);\" title=\"匹配站名\"  onclick=\"stationMapHandle('" + value + "')\">匹配站名</a>";
         //            str += "&nbsp;&nbsp;<a href=\"javascript:void(0);\" title=\"忽略匹配\"  onclick=\"stationNoMapHandle('" + value + "')\">忽略匹配</a>";
         //            return str;
         //        }
         //    }
         //}
            ]]
        });
    }
    self.loadHandle();
}

function stationNoMapHandle(station) {
    var nostation = $('#notstation').val();
    $('#notstation').val(nostation + "|" + station + "|");
    $.alertMsg(station + '--忽略匹配站点设置成功', '操作提示', null);
}
function stationMapHandle(station) {
    $('#ReStation').window('open').window('setTitle', station);
    $('#restation_grid').datagrid({
        url: '/api/JOB/T_CUSTOM_STATION/List',
        queryParams: { "CUSTOM_STATION": station },
        //pagination: true,
        //pageSize: 20,
        //pageList: [10, 20, 30, 40, 50],
        fit: true,
        fitColumns: true,
        nowrap: false,
        rownumbers: true,
        singleSelect: true,
        border: 0,
        idField: 'station',
        columns: [[
     {
         title: '标准站名',
         field: 'station',
         width: 100,
         align: 'center',
         halign: 'center',
         styler: function (value, row, index) {
             if (value.indexOf(station.substr(0, 1)) > -1) {
                 return 'background-color:#ffee00;color:red;';
             }
         }

     }
     ,
     {
         title: '操作',
         field: 'ck',
         width: 60,
         align: 'center',
         formatter: function (value, row, index) {
             return "<a href=\"javascript:void(0);\"title=\"匹配\"  onclick=\"stationMap('" + row.station + "','" + station + "')\">匹配</a>";
         }
     }
        ]]
    });
}
function stationMap(CRITERION_STATION, CUSTOM_STATION) {

    $.messager.confirm('请确认', '您确定要与站名 ' + CRITERION_STATION + ' 匹配吗？', function (b) {
        if (b) {
            $.ajax({
                url: '/api/JOB/T_CUSTOM_STATION/Save',
                data: { "CRITERION_STATION": CRITERION_STATION, "CUSTOM_STATION": CUSTOM_STATION },
                cache: false,
                type: 'POST',
                success: mapStationfunc
            }).fail(
            function (xhr, textStatus, err) {
                $.alertMsg('匹配失败，原因如下: ' + err, '操作提示', null);
            });
        }
    });
}

function mapStationfunc(result, textStatus) {
    $.procAjaxMsg(result, function () {
        $.alertMsg(result.Msg, '操作提示', null);
        $('#ReStation').window('close');
    }, function () {
        $.alertMsg(result.Msg, '操作提示', null);
    });
};

function showError(result) {
    var aa = result.replaceAll("{", "{\"").replaceAll("}", "\"}").replaceAll(":", "\":\"").replaceAll(",", "\",\"").replaceAll("}{", "},{").replaceAll(" ", "");

    var bb = "[" + aa.replaceAll("▲", ":").replaceAll("◆", ",").replaceAll("●", "}").replaceAll("★", "{").replaceAll("null", "") + "]";

    var resultjson = JSON.parse(bb);
    $('#ErrorHelp').window('open').window('setTitle', '原因提示');
    $('#errorhelp_grid').datagrid({
        data: resultjson,
        fit: true,
        fitColumns: true,
        nowrap: false,
        rownumbers: true,
        singleSelect: true,
        border: 0,
        columns: [[
     {
         title: '表头',
         field: 'titleName',
         width: 150,
         align: 'center',
         halign: 'center'
     }, {
         title: '原因',
         field: 'errorCause',
         width: 150,
         align: 'left'
     }, {
         title: '备注',
         field: 'content',
         width: 200,
         align: 'left'
     }
        ]]
    });
}

