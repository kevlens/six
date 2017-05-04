$(function () {
    var hub = window.$.connection.overrangetimehub;
    function init() {
        hub.server.addToGroup("OVERRANGETIME");
    }
    hub.client.updateWarnInfo = function (message) {
        $('#data_grid').datagrid('reload');
    }
    $.connection.hub.start(function () {
        init();
    });
});