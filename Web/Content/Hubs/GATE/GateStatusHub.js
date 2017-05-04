$(function () {
    var hub = window.$.connection.gatehub;
    function init() {
        hub.server.addToGroup("GATE");
    }
    hub.client.updateGateInfo_NEW = function (message) {
        //var mjimginfo = $('#mjimg' + message.MODEL.GATE_NO).html();
        $('#mjimg' + message.MODEL.GATE_NO).html("<img src=\"/Scripts/gis/images/mjtb/" + message.MODEL.STATE_FLAG + ".png\"  />");
        
    }
    hub.client.updateInGateInfo_NEW = function (message) {
        var mjnuminfo = $('#mjnum' + message.GATE_NO).html();
        var mjnum_p = mjnuminfo.split('|')[0];
        var mjnum_t = mjnuminfo.split('|')[1];
        if (message.CARDINGATE.CARD_TYPE == "1") {
            mjnum_t = message.TINCOUNT;
        } else {
            mjnum_p = message.PINCOUNT;
        }
        
        $('#mjnum' + message.GATE_NO).html(mjnum_p + '|' + mjnum_t);
        //处理内存数据
        var card_no = message.CARDINGATE.CARD_NO;
        var card_type = message.CARDINGATE.CARD_TYPE;
        var inorout = message.CARDINGATE.INOROUT;
        //INOROUT值为1，当前数据要要移除缓存列表
        for (var i = 0; i < gatedata.length; i++) {
            if (message.GATE_NO == gatedata[i].gatephone) {
                if (card_type != "1") {
                    //门禁卡或数人卡进出门
                    if (inorout == "0") {
                        //var pushgate = { "GATE_NO": phone, "CARD_NO": "0000543A", "INOUT_TIME": intime, "GNAME": "测试人员", "GDEPTNAME": "北京高铁工务段", "INOROUT": inorout, "CARD_TYPE": cardtype };
                        gatedata[i].ingate.push(message.CARDINGATE);
                        gatedata[i].gatenum = parseInt(gatedata[i].gatenum) + 1;

                    } else {
                        for (var j = 0; j < gatedata[i].ingate.length; j++) {
                            if (gatedata[i].ingate[j].CARD_NO == card_no) {
                                gatedata[i].ingate.splice(j, 1);
                                gatedata[i].gatenum = parseInt(gatedata[i].gatenum) - 1;
                            }
                        }
                    }
                    if (tabphone == message.GATE_NO) {
                        $('#inperson').datagrid({ data: gatedata[i].ingate });
                    }
                } else {
                    //机具卡进出门
                    if (inorout == "0") {
                        gatedata[i].toolgate.push(message.CARDINGATE);
                        gatedata[i].gatetoolnum = parseInt(gatedata[i].gatetoolnum) + 1;
                    } else {
                        for (var j = 0; j < gatedata[i].toolgate.length; j++) {
                            if (gatedata[i].toolgate[j].CARD_NO == card_no) {
                                gatedata[i].toolgate.splice(j, 1);
                                gatedata[i].gatetoolnum = parseInt(gatedata[i].gatetoolnum) - 1;
                            }
                        }
                    }
                    if (tabphone == message.GATE_NO) {
                        $('#intool').datagrid({ data: gatedata[i].toolgate });
                    }
                }
            }
        }
    }
    $.connection.hub.start(function () {
        init();
    });
});

