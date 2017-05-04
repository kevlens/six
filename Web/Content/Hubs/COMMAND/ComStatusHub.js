$(function () {
    var hub = window.$.connection.gatecomwarn
    function init() {
        hub.server.addToGroup("COMDWARN");
    }

    hub.client.updateInGateInfo = function (message) {
        if ((message.fldept == UseDpt || message.signdept == UseDpt) && message.number > 0) {
            $.ajax({
                url: '/COMMAND/COMMAND_PUBLISH/NumTotal/',
                cache: false,
                type: 'POST',
                success: function (result) {
                    var restol = result.split('-');
                    if ((restol[0] != null && restol[0] != "0") || (restol[1] != null && restol[1] != "0")) {
                        var restl = restol[2];
                        if (restl.indexOf("031801") >= 0) {
                            if (restol[1] > 0) {
                                $('#hdsNum').val("1");
                                $('#wins').dialog('close');
                                document.getElementById('fpid').innerText = restol[1];
                                $('#wins').dialog('open');
                            }
                            else {$('#hdsNum').val("0"); $('#wins').dialog('close'); }
                        }
                        else {
                            if (restol[0] > 0) {
                                $('#hdsNum').val("1");
                                $('#win').dialog('close');
                                document.getElementById('tpid').innerText = restol[0];
                                document.getElementById('lpid').innerText = restol[1];
                                $('#win').dialog('open');
                            }
                            else { $('#hdsNum').val("0"); $('#win').dialog('close');}
                        }
                    }
                    else {
                        var restl = restol[2];
                        if (restl.indexOf("031801") >= 0 && (restol[1] == null || restol[1] == "0"))
                        { $('#wins').dialog('close'); $('#hdsNum').val("0");}
                        else
                        {
                            if (restol[0] == "0") {
                                $('#win').dialog('close');
                                $('#hdsNum').val("0");
                            }
                        }
                    }
                    $('#data_grid').datagrid('reload');
                },
                error: function (result) {
                    alert("数据错误，请重新登录！")
                }
            });
            $('#data_grid').datagrid('reload');
        }
    }
    $.connection.hub.start(function () {
        init();
    });
});