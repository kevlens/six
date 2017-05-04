$(function () {
    var hub = window.$.connection.railrecordsamphub;
    function init() {
        hub.server.addToGroup("railrecordsamphub");
    }
    hub.client.updateWarnInfo = function (message) {
        $('#data_grid').datagrid('reload');
    }
    $.connection.hub.start(function () {
        init();
    });
});