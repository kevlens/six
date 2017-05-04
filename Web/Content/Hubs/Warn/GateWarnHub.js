$(function () {
    var hub = window.$.connection.gatewarnhub;
    function init() {
        hub.server.addToGroup("GATEWARN");
    }
    hub.client.updateWarnInfo = function (message) {
        $('#data_grid').datagrid('reload');
    }
    $.connection.hub.start(function () {
        init();
    });
});

