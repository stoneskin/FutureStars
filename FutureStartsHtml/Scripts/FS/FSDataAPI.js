if (typeof FSDataAPI == 'undefined') {
    FSDataAPI = {
        GetTask: function (taskId) {
            
            var dff1 = $.Deferred();
            FSDataRetriver.GetTask(taskId).done(
                function (data) {
                    dff1.resolve(data);
                }).fail(
                function() {
                    dff1.reject(data);
                });
            return dff1.promise();
        },
        UserLogon: function(userName, password) {

        },
        SubmitTask: function() {

        },
        GetUserData: function(token) {

        }
    };

}