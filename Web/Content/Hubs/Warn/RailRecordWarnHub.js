$(function () {
    var hub = window.$.connection.railrecordhub;
    function init() {
        hub.server.addToGroup("railrecordhub");
    }
    hub.client.updateWarnInfo = function (message) {
        $('#data_grid').datagrid('reload');
    }
    $.connection.hub.start(function () {
        init();
    });
});