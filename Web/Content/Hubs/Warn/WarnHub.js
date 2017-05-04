$(function () {
    var hub = window.$.connection.warnhub;
    function init() {
        hub.server.addToGroup("WARN");
    }
    hub.client.updateWarnInfo = function (message) {

        reLoadPlanWain(message.TYPE);
        //$('#mytabWarn').tabs('select', message.TYPE);

        //var $tab = $("#mytabWarn");
        //var currentTab = $tab.tabs('getTab',message.TYPE);
        //var src = $(currentTab.panel('options').content).attr('src');
        //$tab.tabs('update', { tab: currentTab, options: { content: createFrameName(src, message.TYPE) }})
        //setSoundOpen(message.TYPE);
    }
    $.connection.hub.start(function () {
        logininit();
        init();

    });

    var login = window.$.connection.loginhub;
    login.client.xxx = function (str) {
        $.alertMsg("您的用户名已经在其他地方登录，请重新登录！", '系统提示', function () {
            if (window != top) {
                top.location.href = "/Home/Login";
            }
            else {
                window.location.href = "/Home/Login";
            }
        });
    }
    function logininit() {
        login.server.addToGroup($('#usr').text());
    }
});