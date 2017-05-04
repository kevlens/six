$(function () {
    var hub = window.$.connection.basedatahub;
    function init() {
        hub.server.addToGroup("BASEDATA");
    }
    hub.client.updateWarnInfo = function (message) {
        $('#data_grid').datagrid('reload');
    }
    $.connection.hub.start(function () {
        init();
    });
});