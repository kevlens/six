; (function ($) {

    $.extend($, {
        alertMsg: function (msg,title,funcSuc) {
            if ($.messager) {
                $.messager.alert(title, msg, "info", function () {
                    if (funcSuc) {
                        funcSuc();
                    }
                })
            }
            else {
                alert(title + "\r\n " + msg);
                if (funcSuc) {
                    funcSuc();
                }
            }
        },
        showMsg: function (msg, title) {
            if ($.messager) {
                $.messager.show({
                    showType: 'slide',
                    showSpeed: 5000,
                    width: 500,
                    height: 500,
                    msg: msg,
                    title: title,
                    timeout:0
                });
            }
            else {
                alert(title + "\r\n " + msg);
                if (funcSuc) {
                    funcSuc();
                }
            }
        },
        validateUrl: function (url, funcSuc, funcErr, type) {
            $.ajax({
                type: type,
                url: url,
                data:{page:"0",rows:"0",sort:"",order:"desc"},
                success: function (data) {
                    if (data.Msg) {
                        funcErr(data);
                    } else {
                        funcSuc();
                    }
                }
            });
        },
        IsLimit: function (url,showid,hideid) {
            $.ajax({
                url: url,
                cache: false,
                dataType: 'JSON',
                success: function (result) {
                    if (result.Statu != 4) {//如果登录
                        if (result.Statu == 5) {//如果没权限
                            $('#a_add').linkbutton('disable');
                            $('#a_edit').linkbutton('disable');
                            $('#a_del').linkbutton('disable');
                            if (showid != "") {
                                var showids = showid.split(',');
                                for (var i = 0; i < showids.length; i++) {
                                    $('#' + showids[i]).linkbutton('enable');
                                }
                            }
                            if (hideid != "") {
                                var hideids = hideid.split(',');
                                for (var i = 0; i < hideids.length; i++) {
                                    $('#' + hideids[i]).linkbutton('disable');
                                }
                            }
                        } else {
                            $('#a_add').linkbutton('enable');
                            $('#a_edit').linkbutton('enable');
                            $('#a_del').linkbutton('enable');
                            if (showid != "") {
                                var showids = showid.split(',');
                                for (var i = 0; i < showids.length; i++) {
                                    $('#' + showids[i]).linkbutton('enable');
                                }
                            }
                            if (hideid != "") {
                                var hideids = hideid.split(',');
                                for (var i = 0; i < hideids.length; i++) {
                                    $('#' + hideids[i]).linkbutton('enable');
                                }
                            }
                        }
                    }
                }
            });
        },
        procAjaxMsg: function (data, funcSuc, funcErr) {
            if (!data.Statu) {
                return;
            }
            var state = parseInt(data.Statu);            
            switch (state) {
             
                case 1:
                    if (funcSuc) {
                        funcSuc(data);
                    }
                    break;
                case 2:
                    if (funcErr) {
                        funcErr(data);
                    }
                    break;
                case 4:
                    //是否登录
                    $.alertMsg(data.Msg, '系统提示', function () {
                        if (window != top) {
                            top.location.href = data.BackUrl;
                        }
                        else {
                            window.location.href = data.BackUrl;
                        }
                    });
                    break;
                case 5:
                    //是否有权
                    $.alertMsg(data.Msg, '系统提示',null);
                    break;
            }

        }

    });

})(jQuery);
