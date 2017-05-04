$(function () {
    var hub = window.$.connection.jobdefecthub;
    function init() {
        hub.server.addToGroup("JOBDEFECT");
    }
    hub.client.updateWarnInfo = function (message) {
        $('#data_grid').datagrid('reload');
    }
    $.connection.hub.start(function () {
        init();
    });
});