$(function () {
    var hub = window.$.connection.gishub;
    var index = 10;
    var infowindow;
    function init() {
        hub.server.addToGroup("GIS");
    }
    hub.client.updateDeptsOnlineNumberInfo = function (message) {
        PersonalLocationTree();
    }
    hub.client.updateMobileLasePosInfo = function(message) {
        //debugger;
        var oMarkerManager = new MarkerManager(map);

        //var oChkManager = new CHKManager(map);
        //for (var a = 0; a < message.length; a++) {
        var json = $.parseJSON(message);
        //旧树结构  var nodePerson = $('#PersonalLocationTree').tree('find', json.m);
        var nodePerson = $.fn.zTree.getZTreeObj("PersonalLocationTree").getNodeByParam('id', json.m);
        var nodeRole;
        try {
            nodeRole = $.fn.zTree.getZTreeObj("RoleLocationTree").getNodeByParam('id', json.m);;
        } catch (e) {
            nodeRole = null;
        }
        var nodePos;
        try {
            nodePos = $.fn.zTree.getZTreeObj("PosLocationTree").getNodeByParam('id', json.m);;
        } catch (e) {
            nodePos = null;
        }

        var codearray = [];
        if (json.t == '2') {
            codearray.push(json.locotype);
            codearray.push(json.deptcode);
        } else {
            codearray.push(json.deptcode);
            var ysdeptcode = json.deptcode.length > 4 ? json.deptcode.substr(0, 4) : json.deptcode; //只更新角色树上级
            var number = json.deptcode.length / 2;
            for (var index = 0; index < number; index++) {
                var str = json.deptcode.substr(0, json.deptcode.length - 2);
                json.deptcode = str;
                if (str.length >= 2) {
                    codearray.push(str);
                }
            }
        }

        //人员定位
        if (json.t == "0") {
            if (json.isonline == 1) {
                //number+1;

                if (TreeType == 1) {
                    if (isInitRoleDone) { //角色定位初始化是否完毕
                        if (nodeRole != null && nodeRole.checked) {
                            if (!RoleManager.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    if (isDept(codearray[c]) && codearray[c].length <= 4 && $('#RoleLocationTree').length > 0) {
                                        RoleManager.minusTree(codearray[c], 1, 'RoleLocationTree'); //cwb 新写法
                                        if (codearray[c] == ysdeptcode) {
                                            RoleManager.minusTree(codearray[c] + json.role, 1, 'RoleLocationTree');
                                        }
                                    }
                                }
                            }

                            oMarkerManager.clearMarker(json.m, "角色");
                            RoleManager.addSingleMarker(json);
                            var ozTreeObj = $.fn.zTree.getZTreeObj("RoleLocationTree");
                            if (json.state != "1")
                                nodeRole.iconSkin = "icon-On-line";
                            else
                                nodeRole.iconSkin = "icon-status_busy";
                            ozTreeObj.updateNode(nodeRole);
                            RoleManager.updateResultLocalPsn(message);
                        }
                        
                    }
                } else if (TreeType == 0) {
                    if (isInitPsnDone) { //人员定位初始化是否完毕
                        if (nodePerson != null && nodePerson.checked) {
                            if (!PsnAndPic.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    if (isDept(codearray[c])) {
                                        PsnAndPic.minusTree(codearray[c], 1, 'PersonalLocationTree');
                                    }
                                }
                            }

                            oMarkerManager.clearMarker(json.m, "人员");
                            PsnAndPic.addSingleMarker(json);
                            var ozTreeObj = $.fn.zTree.getZTreeObj("PersonalLocationTree");
                            if (json.state != "1")
                                if (json.icon.indexOf("Mark_0") > -1) {
                                    nodePerson.iconSkin = "icon-On-line";
                                } else {
                                    nodePerson.iconSkin = json.icon.replace("images/", "").replace(".png", "");
                                }
                            else
                                nodePerson.iconSkin = "icon-status_busy";
                            ozTreeObj.updateNode(nodePerson);
                            PsnAndPic.updateResultLocalPsn(message);
                        }
                        
                    }
                } else if (TreeType == 2) {
                    if (isInitPosDone) { //人员定位初始化是否完毕
                        if (nodePos != null && nodePos.checked) {
                            if (!PosManager.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    if (isDept(codearray[c])) {
                                        PosManager.minusTree(codearray[c], 1, 'PosLocationTree');
                                        if (codearray[c] == ysdeptcode) {
                                            PosManager.minusTree(codearray[c] + json.poslevel, 1, 'PosLocationTree');
                                        }
                                    }
                                }
                            }

                            oMarkerManager.clearMarker(json.m, "级别");
                            PosManager.addSingleMarker(json);
                            var ozTreeObj = $.fn.zTree.getZTreeObj("PosLocationTree");
                            if (json.state != "1")
                                nodePos.iconSkin = "icon-On-line";
                            else
                                nodePos.iconSkin = "icon-status_busy";
                            ozTreeObj.updateNode(nodePos);
                            PosManager.updateResultLocalPsn(message);
                        }
                        
                    }
                }

            } else {
                //number-1;
                if (TreeType == 1) {
                    if (isInitRoleDone) { //角色定位初始化是否完毕
                        if (nodeRole) {
                            if (RoleManager.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    if (isDept(codearray[c]) && codearray[c].length <= 4 && $('#RoleLocationTree').length > 0) {
                                        RoleManager.minusTree(codearray[c], -1, 'RoleLocationTree');
                                        if (codearray[c] == ysdeptcode) {
                                            RoleManager.minusTree(codearray[c] + json.role, -1, 'RoleLocationTree');
                                        }
                                    }
                                }
                                RoleManager.updateResultLocalPsn(message);
                            }
                            oMarkerManager.clearMarker(json.m, "角色");

                            var ozTreeObj = $.fn.zTree.getZTreeObj("RoleLocationTree");
                            nodeRole.iconSkin = "icon-Off-line";
                            ozTreeObj.updateNode(nodeRole);
                        }
                    }
                } else if (TreeType == 0) {
                    if (isInitPsnDone) { //人员定位初始化是否完毕
                        
                        if (nodePerson) {
                            if (PsnAndPic.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    if (isDept(codearray[c])) {
                                        PsnAndPic.minusTree(codearray[c], -1, 'PersonalLocationTree');
                                    }
                                }
                                PsnAndPic.updateResultLocalPsn(message);
                            }
                            oMarkerManager.clearMarker(json.m, "人员");
                            var ozTreeObj = $.fn.zTree.getZTreeObj("PersonalLocationTree");
                            nodePerson.iconSkin = "icon-Off-line";
                            ozTreeObj.updateNode(nodePerson);
                        }
                    }
                } else if (TreeType == 2) {
                    if (isInitPosDone) { //人员定位初始化是否完毕
                        if (nodePos) {
                            if (PosManager.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    if (isDept(codearray[c])) {
                                        PosManager.minusTree(codearray[c], -1, 'PosLocationTree');
                                        if (codearray[c] == ysdeptcode) {
                                            PosManager.minusTree(codearray[c] + json.poslevel, -1, 'PosLocationTree');
                                        }
                                    }
                                }
                                PosManager.updateResultLocalPsn(message);
                            }
                            oMarkerManager.clearMarker(json.m, "级别");
                            var ozTreeObj = $.fn.zTree.getZTreeObj("PosLocationTree");
                            nodePos.iconSkin = "icon-Off-line";
                            ozTreeObj.updateNode(nodePos);
                        }
                    }
                }
            }
        }
        //汽车管理
        if (json.t == "1") {
            var nodeCar;
            var ozTreeObj = $.fn.zTree.getZTreeObj("CarTree");
            try {
                if (ozTreeObj != null) {
                    nodeCar = ozTreeObj.getNodeByParam('id', json.m);
                    if (nodeCar != null && nodeCar.checked) {
                        if (json.isonline == 1) {
                            oMarkerManager.clearMarker(json.m, "汽车");
                            Car.addSingleMarker(json);

                            //number+1;
                            if (!Car.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    if (isDept(codearray[c])) {
                                        Car.minusTree(codearray[c], 1, "CarTree");
                                    }
                                }
                            }
                            var node = ozTreeObj.getNodeByParam('id', json.m);
                            if (node) {

                                if (node.checked) {
                                    node.iconSkin = "car-On-line";
                                    ozTreeObj.updateNode(node);
                                }
                            }
                            Car.updateresultlocalCarPsn(message);
                        } else if (json.isonline == 0) {
                            //number-1;
                            if (Car.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    if (isDept(codearray[c])) {
                                        Car.minusTree(codearray[c], -1, "CarTree");
                                    }
                                }
                                Car.updateresultlocalCarPsn(message);
                            }

                            oMarkerManager.clearMarker(json.m, "汽车");

                            var node = ozTreeObj.getNodeByParam('id', json.m);
                            if (node) {
                                node.iconSkin = "car-Off-line";
                                ozTreeObj.updateNode(node);
                            }
                        } else if (json.isonline == 2) {
                            Car.updateresultlocalCarPsn(message);
                            oMarkerManager.clearMarker(json.m, "汽车");
                            oMarkerManager.addSingleMarker(map, json, "汽车");

                            var node = ozTreeObj.getNodeByParam('id', json.m);
                            if (node) {
                                node.iconSkin = "car-Off-line";
                                ozTreeObj.updateNode(node);
                            }
                        }
                    }
                }
            } catch (e) {
                nodeCar = null;
            }
        }
        //机车定位

        if (json.t == "2") {
            var nodeVeh;
            var ozTreeObj = $.fn.zTree.getZTreeObj("VehTree");
            try {
                if (ozTreeObj != null) {
                    nodeVeh = ozTreeObj.getNodeByParam("id", json.m);
                    if (nodeVeh != null && nodeVeh.checked) {
                        if (json.isonline == 1) {

                            oMarkerManager.clearMarker(json.m, "机车定位");
                            Veh.addSingleMarker(json);

                            if (!Veh.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    Veh.minusTree(codearray[c], 1);
                                }
                            }
                            //var nodeVeh = $('#VehTree').tree('find', json.m);
                            //if (nodeVeh) {
                            if (nodeVeh.checked) {

                                nodeVeh.iconSkin = "icon-rail-on";
                                ozTreeObj.updateNode(nodeVeh);
                            }
                            //}
                            Veh.updateresultlocalVeh(message);
                        } else {
                            if (Veh.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    Veh.minusTree(codearray[c], -1);
                                }
                                Veh.updateresultlocalVeh(message);
                            }
                            oMarkerManager.clearMarker(json.m, "机车定位");

                            //var nodeVeh = $('#VehTree').tree('find', json.m);
                            //if (nodeVeh) {

                            nodeVeh.iconSkin = "icon-rail-off";
                            ozTreeObj.updateNode(nodeVeh);
                            //}
                        }
                    }
                }
            } catch (e) {
                nodeVeh = null;
            }
        }
        //电子检查本
        if (json.t == "3") {
            var nodeChk;
            var ozTreeObj = $.fn.zTree.getZTreeObj("CHKTree");
            try {
                if (ozTreeObj != null) {
                    nodeChk = ozTreeObj.getNodeByParam('id', json.m);
                    if (nodeChk != null && nodeChk.checked) {
                        if (json.isonline == 1) {
                            oMarkerManager.clearMarker(json.m, "电子检查本");
                            CHK.addSingleMarker(json);

                            if (!CHK.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    CHK.minusTree(codearray[c], 1);
                                }
                            }
                            if (nodeChk.checked) {

                                nodeChk.iconSkin = "icon-chk-on";
                                ozTreeObj.updateNode(nodeChk);
                            }
                            CHK.updateresultlocalCHK(message);
                        } else {
                            if (CHK.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    CHK.minusTree(codearray[c], -1);
                                }
                                CHK.updateresultlocalCHK(message);
                            }

                            oMarkerManager.clearMarker(json.m, "电子检查本");

                            nodeChk.iconSkin = "icon-chk-off";
                            ozTreeObj.updateNode(nodeChk);
                        }
                    }
                }
            } catch (e) {
                nodeChk = null;
            }
        }

        //涂覆定位
        if (json.t == "4") {
            var nodeOIL;
            var ozTreeObj = $.fn.zTree.getZTreeObj("OILTree");
            try {
                if (ozTreeObj != null) {
                    nodeOIL = ozTreeObj.getNodeByParam("id", json.m);
                    if (nodeOIL != null && nodeOIL.checked) {
                        if (json.isonline == 1) {
                            oMarkerManager.clearMarker(json.m, "涂覆定位");
                            OIL.addSingleMarker(json);

                            if (!OIL.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    OIL.minusTree(codearray[c], 1);
                                }
                            }
                            if (nodeOIL.checked) {
                                nodeOIL.iconSkin = "icon-oil-on";
                                ozTreeObj.updateNode(nodeOIL);
                            }
                            OIL.updateresultlocalOIL(message);
                        } else {
                            if (OIL.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    OIL.minusTree(codearray[c], -1);
                                }
                                OIL.updateresultlocalOIL(message);
                            }

                            oMarkerManager.clearMarker(json.m, "涂覆定位");

                            nodeOIL.iconSkin = "icon-oil-off";
                            ozTreeObj.updateNode(nodeOIL);
                        }
                    }
                }
            } catch (e) {
                nodeOIL = null;
            }
        }


        //作业记录仪
        if (json.t == "5") {
            var nodeEnforcement;
            var ozTreeObj = $.fn.zTree.getZTreeObj("EnforcementTree");
            try {
                if (ozTreeObj != null) {
                    nodeEnforcement = ozTreeObj.getNodeByParam("id", json.m);
                    if (nodeEnforcement != null && nodeEnforcement.checked) {
                        if (json.isonline == 1) {
                            if (nodeEnforcement.iconSkin == "icon-Mark_0J_off") //当前为下线状态，提示上线
                            {
                                parent.updownLine(json);
                            }
                            oMarkerManager.clearMarker(json.m, "作业记录仪");
                            ENFORCEMENT.addSingleMarker(json);

                            if (!ENFORCEMENT.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    ENFORCEMENT.minusTree(codearray[c], 1);
                                }
                            }
                            if (nodeEnforcement.checked) {
                                nodeEnforcement.iconSkin = "icon-Mark_0J";
                                ozTreeObj.updateNode(nodeEnforcement);
                            }
                            ENFORCEMENT.updateresultlocalENFORCEMENTPsn(message);
                        } else {
                            if (ENFORCEMENT.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    ENFORCEMENT.minusTree(codearray[c], -1);
                                }
                                ENFORCEMENT.updateresultlocalENFORCEMENTPsn(message);
                            }
                            if (nodeEnforcement.iconSkin == "icon-Mark_0J") //当前为上线状态，提示下线
                            {
                                parent.updownLine(json);
                            }
                            oMarkerManager.clearMarker(json.m, "作业记录仪");
                            nodeEnforcement.iconSkin = "icon-Mark_0J_off";
                            ozTreeObj.updateNode(nodeEnforcement);
                        }
                    }
                }
            } catch (e) {
                nodeEnforcement = null;
            }
        }

        if (json.t == "6") {
            var nodeRailCar;
            var ozTreeObj = $.fn.zTree.getZTreeObj("RailCarTree");
            try {
                if (ozTreeObj != null) {
                    nodeRailCar = ozTreeObj.getNodeByParam("id", json.m);
                    if (nodeRailCar != null && nodeRailCar.checked) {
                        if (json.isonline == 1) {
                            oMarkerManager.clearMarker(json.m, "轨道车");
                            RailCars.addSingalMarker(json);

                            if (!RailCars.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    RailCars.minusTree(codearray[c], 1);
                                }
                            }
                            if (nodeRailCar.checked) {
                                nodeRailCar.iconSkin = "icon-Mark_0M";
                                ozTreeObj.updateNode(nodeRailCar);
                            }
                            RailCars.updateresultlocalRailCars(message);
                        } else {
                            if (RailCars.isExistsInLocal(message)) {
                                for (var c = 0; c < codearray.length; c++) {
                                    RailCars.minusTree(codearray[c], -1);
                                }
                                RailCars.updateresultlocalRailCars(message);
                            }

                            oMarkerManager.clearMarker(json.m, "轨道车");

                            nodeRailCar.iconSkin = "icon-Mark_0M_off";
                            ozTreeObj.updateNode(nodeRailCar);
                        }
                    }
                }
            } catch (e) {
                nodeRailCar = null;
            }
        }
    }

    hub.client.updateMobileFileInfo = function(message) {
        var json = $.parseJSON(message);
        if (json.FILEINFO.istip == 0) {
            if (isDept(json.DEPT)) {
                PsnAndPic.updateResultLocalPic(json.FILEINFO);
                if (PsnAndPic.picShowFlag >= 1) {
                    PsnAndPic.setupSingleMarkerPic(json.FILEINFO);
                }
            }
        } else {
            PsnAndPic.deleteResultLocalPic(json.FILEINFO.pid);
        }
    }
    //门禁同步
    hub.client.updateGateInfo = function(message) {
        accessManager.updateResultLocal(message);
        var zoomLevel = map.getZoom();
        var mk = accessManager.getMarker(message.MODEL.GATE_NO);
        if (mk != false) {
            var iconurl = "images/mjtb/3.png"; //故障灰色
            if (message.MODEL.STATE_FLAG == 0 && message.AUTHORIZE == 0) {
                iconurl = "images/mjtb/2.png"; //正常关闭蓝色
            } else if (message.MODEL.STATE_FLAG == 0 && message.AUTHORIZE >= 1) {
                iconurl = "images/mjtb/1.png"; //授权关闭绿色
            } else if (message.MODEL.STATE_FLAG == 1 && message.AUTHORIZE == 0) {
                iconurl = "images/mjtb/4.png"; //异常开门红闪
            } else if (message.MODEL.STATE_FLAG == 1 && message.AUTHORIZE >= 1) {
                iconurl = "images/mjtb/8.png"; //正常开门黄闪
            } else if (message.MODEL.STATE_FLAG == 2) {
                iconurl = "images/mjtb/3.png"; //故障灰色
            }
          //  var accessicon = new google.maps.MarkerImage(iconurl, new google.maps.Size(zoomLevel * 8 / 5, zoomLevel * 8 / 5), new google.maps.Point(0, 0), new google.maps.Point(zoomLevel * 8 / 10, zoomLevel * 8 / 10), new google.maps.Size(zoomLevel * 8 / 5, zoomLevel * 8 / 5));

            mk.setIcon(iconurl);
        }
        // var mk = accessManager.createMarker(map, message);
        // accessManager.findWarnMarker(message.PKID, mk);
    }

    hub.client.updateInGateInfo = function(message) {
        accessManager.updateResultLocalInGate(message);
        var zoomLevel = map.getZoom();
        var mk = accessManager.getMarker(message.GATE_NO);
        var str = accessManager.attachInfoNew(message);
        var tab = $('.infowindow_tab')[1];
        if (tab != undefined) {
            tab.innerHTML = str;
        } else {

        }
        // mk.setText(message.INCOUNT);
        if (accessManager.IsWithLabel) {
            accessManager.reload(map, resultlocalAccess);
        } else if (accessManager.IsWithLabel == undefined) {
            accessManager.reload(map, resultlocalAccess);
        } else if (!accessManager.IsWithLabel) {
            accessManager.reloadWithNoLabel(map, resultlocalAccess);
        }

        var jsondata = $.parseJSON(resultlocalAccess);
        var data = jsondata.access;
        var count = 0;
        for (var i = 0; i < data.length; i++) {
            count += data[i].INGATE.length;
        }
        $("#ad")[0].innerHTML = '门禁内施工总人数：' + count;
        //mk.setLabel(message.INCOUNT);
        // mk.labelContent = message.INCOUNT;
        // $('.infowindow_tab').
    }

    hub.client.updateRailHostInfo = function (message) {
    }
    hub.client.updateRailTemperatureInfo = function(message) {

        //var count = temperatureManager.getMarkerCount(message.DEVICE.PHONE);
        var temperature = temperatureManager.getMarker(message.DEVICE.PHONE);
        if (temperature != false) {
            temperatureManager.clearMarker(message.DEVICE.PHONE);
            temperatureManager.createSingalMarker(map, message.DEVICE);
        }

    }
    //断轨监测
    hub.client.updateRailSoundPointInfo = function (message) {
        for (var i = 0; i < pointManager.brokenrail_line; i++) {
            pointManager.brokenrail_line[i].setMap(null);
        }
        var zoomLevel = map.getZoom();
        var color;
        if (message.IsWarn == '1')
            color = '#ff0000';
        else if (message.IsWarn == '3')
            color = '#00fa9a';
        else if (message.IsWarn == '2')
            color = '#ffff00';
        var oMarkerManager = new MarkerManager(map);
        //  var mk = oMarkerManager.getMarker(message.POINT_NO, "断轨监测");
        //var mk = pointManager.getMarker(message.POINT_NO);
        //  if (mk != false) {
        //if (message.IsWarn == "2") {
        //    var iconurl = "images/天津电务图标/断轨/定标器2.gif";  //故障灰色

        //    var accessicon = new google.maps.MarkerImage(iconurl, new google.maps.Size(zoomLevel * 8 / 5, zoomLevel * 8 / 5), new google.maps.Point(0, 0), new google.maps.Point(zoomLevel * 8 / 10, zoomLevel * 8 / 10), new google.maps.Size(zoomLevel * 8 / 5, zoomLevel * 8 / 5));

        //    mk.setIcon(accessicon);
        //}
        //if (message.IsWarn == "3") {
        //    var iconurl = "images/天津电务图标/断轨/定标器.gif";  //正常

        //    var accessicon = new google.maps.MarkerImage(iconurl, new google.maps.Size(zoomLevel * 8 / 5, zoomLevel * 8 / 5), new google.maps.Point(0, 0), new google.maps.Point(zoomLevel * 8 / 10, zoomLevel * 8 / 10), new google.maps.Size(zoomLevel * 8 / 5, zoomLevel * 8 / 5));

        //    mk.setIcon(accessicon);


        //}
        var flag = false;
        var result = $.parseJSON(resultPointData);
        var routeArray = [];
        
        if (message.IsWarn == "1") {
            pointManager.brokenrail_line = [];
            for (var i = 0; i < result.point.length; i++) {
                if (result.point[i].PKID == message.status.POINT_NO) {
                    flag = true;
                    routeArray = result.point[i].ROUTE;
                    result.point[i].WARN_TYPE = "钢轨异常";
                    break;
                }
            }
            pointManager.brokenrail_line.push(oMarkerManager.attachLine(map, routeArray, color, pointManager.pointlineStack));
        }
        else if (message.IsWarn == "2") {
            pointManager.brokenrail_line = [];
            for (var i = 0; i < result.point.length; i++) {
                if (result.point[i].HOSTID == message.status.SECTION_ID) {
                    routeArray = result.point[i].ROUTE;
                    result.point[i].WARN_TYPE = "正在施工";
                    pointManager.brokenrail_line.push(oMarkerManager.attachLine(map, routeArray, color, pointManager.pointlineStack))
                }
            }
        } else {
            pointManager.brokenrail_line = [];
            for (var i = 0; i < result.point.length; i++) {
                if (result.point[i].HOSTID == message.status.SECTION_ID) {
                    routeArray = result.point[i].ROUTE;
                    result.point[i].WARN_TYPE = "正常";
                    pointManager.brokenrail_line.push(oMarkerManager.attachLine(map, routeArray, color, pointManager.pointlineStack))
                }
            }
        }
        resultPointData = JSON.stringify(result);
       // oMarkerManager.attachLine(map, routeArray, color, pointManager.pointlineStack);

        

        if (message.IsWarn == '1') {
            var contentString = "线名：" + message.baseinfo.LINE_NAME + "<br />行别：" + message.baseinfo.LINE_DIR + "<br />里程范围：" + message.status.MILEAGE_START + "<br />状态：" + message.status.SECTION_STATUS;
            pointManager.infowindow = new AMap.InfoWindow({
                // isCustom: true,
                autoMove: true,
                closeWhenClickMap: true,
                content: contentString,
                offset: new AMap.Pixel(0, 0)
            });
            var lineCoordinates = pointManager.brokenrail_line[0].getPath();
            var position = new AMap.LngLat(lineCoordinates[parseInt(lineCoordinates.length / 2)].lng, lineCoordinates[parseInt(lineCoordinates.length / 2)].lat);
            pointManager.infowindow.open(map, position);
            map.setCenter(position);
            map.setZoom(16);
        } else {
            if (pointManager.infowindow != null) {
                pointManager.infowindow.close();
            }
        }
        //var line = pointManager.getMarkerline(message.POINT_NO);
        //if (line != false) {
        //    // if(message.isWarn =
        //    var path = line.getPath();
        //    line.setMap(null);
        //    index++;
        //    line = new google.maps.Polyline({
        //        zIndex: index,
        //        strokeColor: color,
        //        path: path,
        //        map: map
        //    });
        //    line.setMap(map);

        //}
        //}

    }


    hub.client.updateRainInfo = function (message) {
        var MODEL = message.MODEL;
        var rain = rainManager.getMarker(MODEL.PKID);
        if (rain != false) {
            //rainManager.clearMarker(message.MODEL.PKID);
            //rainManager.createSingalMarker(map, message.MODEL);

            //var result = $.parseJSON(rainLocalResult);
            //for (var i = 0; i < result.rain.length; i++) {
            //    if (result.rain[i].PKID == message.MODEL.PKID) {
            //        result.rain[i].WARN_TYPE = message.MODEL.WARNTYPE;
            //        result.rain[i].TIMESTATE = message.MODEL.TIMESTATE;
            //        result.rain[i].Warn = message.MODEL.Warn;
            //    }
            //}
            var result = $.parseJSON(rainLocalResult);
            rainManager.clearMarker(MODEL.PKID);
            if (MODEL.QUDUANWARNLIST.length > 0) {
                for (var i = 0; i < MODEL.QUDUANWARNLIST.length; i++) {
                    var quduanbianhao = MODEL.QUDUANWARNLIST[i].QuDuanID;
                    rainManager.clearquduanline(MODEL.PKID, quduanbianhao);
                }
                rainManager.AddSingle(map, MODEL);
                
                for (var i = 0; i < result.rain.length; i++) {
                    if (result.rain[i].PKID == MODEL.PKID){
                        result.rain[i].QUDUANWARNLIST = MODEL.QUDUANWARNLIST;
                        break;
                    }
                }

                    //var warnList = result.rain[i].QUDUANWARNLIST;
                    //for (var j = 0; j < warnList.length ; j++) {
                    //    if (result.rain[i].PKID == MODEL.PKID && warnList[j].QuDuanID == quduanbianhao) {
                    //        //result.rain[i].WARN_TYPE = message.MODEL.WARNTYPE;
                    //        //result.rain[i].TIMESTATE = message.MODEL.TIMESTATE;
                    //        //result.rain[i].Warn = message.MODEL.Warn;
                    //        /********************************************************/
                    //        result.rain[i].QUDUANWARNLIST[j].WARNVALUE = MODEL.QUDUANWARNLIST[0].WARNVALUE;
                    //        result.rain[i].QUDUANWARNLIST[j].WARNTYPE = MODEL.QUDUANWARNLIST[0].WARNTYPE;
                    //        result.rain[i].QUDUANWARNLIST[j].WARN = MODEL.QUDUANWARNLIST[0].WARN;
                    //        result.rain[i].QUDUANWARNLIST[j].WarnTime = MODEL.QUDUANWARNLIST[0].WarnTime;
                    //        result.rain[i].QUDUANWARNLIST[j].MonitorRang = MODEL.QUDUANWARNLIST[0].MonitorRang;

                    //    }
                    //}
                rainLocalResult = JSON.stringify(result);
            }
        }
    }

    hub.client.updateSnowInfo = function(message) {
        var snow = snowManager.getMarker(message.MODEL.PKID);
        if (snow != false) {
            snowManager.clearMarker(message.MODEL.PKID);
            snowManager.createSingalMarker(map, message.MODEL);

            var result = $.parseJSON(snowLocalResult);
            for (var i = 0; i < result.snow.length; i++) {
                if (result.snow[i].PKID == message.MODEL.PKID) {
                    result.snow[i].WARNID = message.MODEL.WARNID;
                }
            }
            snowLocalResult = JSON.stringify(result);
        }
    }

    hub.client.updateWaterInfo = function(message) {

        var zoomLevel = map.getZoom();
        var mk = pointManager.getMarker(message.POINT.POINT_NO);
        if (mk != false) {

            if (message.MODEL.WARNTYPE == "0") {
                //未报警
            } else if (message.MODEL.WARNTYPE == "1") {
                var iconurl = "images/天津电务图标/断轨/定标器2.gif"; //一级报警
            } else if (message.MODEL.WARNTYPE == "2") {
                var iconurl = "images/天津电务图标/断轨/定标器2.gif"; //二级报警
            } else if (message.MODEL.WARNTYPE == "3") {
                var iconurl = "images/天津电务图标/断轨/定标器2.gif"; //三级报警
            }
            var accessicon = new google.maps.MarkerImage(iconurl, new google.maps.Size(zoomLevel * 8 / 5, zoomLevel * 8 / 5), new google.maps.Point(0, 0), new google.maps.Point(zoomLevel * 8 / 10, zoomLevel * 8 / 10), new google.maps.Size(zoomLevel * 8 / 5, zoomLevel * 8 / 5));

            mk.setIcon(accessicon);


            var line = tempManager.getMarkerline(message.POINT.POINT_NO);
            if (line != false) {
                var path = line.getPath();
                line.setMap(null);
                line = new google.maps.Polyline({
                    zIndex: 10,
                    strokeColor: '#00fa9a',
                    path: path,
                    map: map
                });
                line.setMap(map);

            }
        }


        var count = tempManager.getMarkerCount(message.MODEL.PKID);
        var water = tempManager.getMarker(message.MODEL.PKID);
        if (water != false) {
            tempManager.clearMarker(water, count);
            tempManager.createMarker(map, message.MODEL);
        }
    }

    hub.client.updateBootInfo = function(message) {
        if (message) {

            var codearray = [];
            codearray.push(message.DEPT_CODE);
            var ysdeptcode = message.DEPT_CODE.length > 4 ? message.DEPT_CODE.substr(0, 4) : message.DEPT_CODE; //只更新角色树上级
            var number = message.DEPT_CODE.length / 2;
            for (var index = 0; index < number; index++) {
                var str = message.DEPT_CODE.substr(0, message.DEPT_CODE.length - 2);
                message.DEPT_CODE = str;
                codearray.push(str);
            }

            //var mk = oBOOTManager.getMarker(message.PHONE);
            var mk = oMarkerManager.getMarker(message.PHONE, BOOT.type);

            var ozTreeObj = $.fn.zTree.getZTreeObj("BOOTTree");
            nodeBOOT = ozTreeObj.getNodeByParam("id", message.PHONE);
            try {
                if (nodeBOOT != null) {

                    //在线
                    if (message.BOOT_STATUS != "下道" && message.USER_TIME != null) {

                        //添加地标
                        if (mk != false) {
                            //oBOOTManager.clearMarker(mk, oBOOTManager.getMarkerCount(message.PHONE));
                            oMarkerManager.clearMarker(message.PHONE, BOOT.type);
                        }

                        //oBOOTManager.addSingleMarker(map, message);
                        BOOT.addSingleMarker(message);

                        //更新树
                        if (!BOOT.isExistsInLocal(message)) {
                            for (var i = 0; i < codearray.length; i++) {
                                BOOT.minusTree(codearray[i], 1);
                            }
                        }

                        //更新地标
                        nodeBOOT.iconSkin = "icon-boot_on";
                        ozTreeObj.updateNode(nodeBOOT);

                        //更新缓存
                        BOOT.updateresultlocalBOOT(message);

                    } else {
                        //下线清地标
                        //var mk = oBOOTManager.getMarker(message.PHONE);
                        var mk = oMarkerManager.getMarker(message.PHONE, BOOT.type);

                        if (mk != false) {
                            //oBOOTManager.clearMarker(mk, oBOOTManager.getMarkerCount(message.PHONE));
                            oMarkerManager.clearMarker(message.PHONE, BOOT.type);
                        }

                        //更新树
                        if (BOOT.isExistsInLocal(message)) {
                            for (var i = 0; i < codearray.length; i++) {
                                BOOT.minusTree(codearray[i], -1);
                            }
                        }
                        nodeBOOT.iconSkin = "icon-boot_off";
                        ozTreeObj.updateNode(nodeBOOT);

                        //更新缓存
                        BOOT.updateresultlocalBOOT(message);
                    }
                }
            } catch (e) {
                nodeBOOT = null;
            }
        }
    }

    hub.client.updateWindInfo = function(message) {
        //var count = windManager.getMarkerCount(message.MODEL.PKID);
        var wind = windManager.getMarker(message.MODEL.PKID);
        if (wind != false) {
            windManager.clearMarker(message.MODEL.PKID);
            windManager.addSingleMarker(map, message.MODEL);
            //windManager.clearMarker(wind, count);
            //windManager.createMarker(map, message.MODEL);
        }
    }

    hub.client.updateCZInfo = function(message) {
        //var count = windManager.getMarkerCount(message.MODEL.PKID);
        var title = message.MODEL.线名 + message.MODEL.行别 + message.MODEL.里程;
        var cz = czManager.getMarker(title);
        if (cz != false) {
            czManager.clearMarker(title);
            czManager.createSingalMarker(map, message.MODEL);

        } else {
            czManager.createSingalMarker(map, message.MODEL);
        }
    }

    $.connection.hub.start(function () {
        init();
    });
});
