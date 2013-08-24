if (typeof FSDataRetriver == 'undefined') {

    var FSDataRetriver = {
        GetTask: function(taskId) {
            //var url = FSSetting.ServiceUr + '/api/task/' + taskId;
            var dff = $.Deferred();
            //var t = $.ajax({
            //    url: url,
            //    type: 'Post',
            //    dataType: 'jsonp',
            //    contentType: 'application/json',
            //    error: function() {
            //        dff.reject();
            //    },
            //    success: function(data) {
            //        dff.resolve("data");
            //    }
            //});
            var apiProxy = $.connection.apiHub;
            $.connection.hub.url = 'http://localhost:45897/signalr';
            $.connection.hub.start().done(
                function () {
                    apiProxy.server.getTask(taskId).done(function (resp) {
                        console.log('signalr get task done');
                       // console.log(JSON.stringify(resp));
                        dff.resolve(resp);
                        //get task data
                    });

                }).fail(function(resp) {
                    dff.reject(resp);
                });
           
            return dff.promise();
        }
    };
}