$(function () {
    var hub = window.$.connection.patrolhub;
    function init() {
        hub.server.addToGroup("PATROL");
    }
    hub.client.updateWarnInfo = function (message) {
        $('#data_grid').datagrid('reload');
    }
    $.connection.hub.start(function () {
        init();
    });
});