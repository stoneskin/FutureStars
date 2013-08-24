if (typeof FSDataRetriver == 'undefined') {

   var FSDataRetriver = {
        Retrive:function(url) {
            var dff = $.Deferred();
            var t = $.ajax({
                url: url,
                type: 'Post',
                data: 'token=112233',
                dataType: 'jsonp',
                contentType: 'application/json',
                error: function () {
                    dff.reject();
                },
                success: function (data) {
                    dff.resolve(data);
                }
            });
            return dff.promise();
        },
        GetTask: function (taskId) {
            //http://localhost:45897/jsonp/task/id/1
          //  var url = FSSetting.ServiceUr + '/api/task/' + taskId;
           // var url = FSSetting.ServiceUr + '/math/taskJsonP/' + taskId;
            var url = FSSetting.ServiceUr + '/jsonp/task/id/' + taskId;
            var re = FSDataRetriver.Retrive(url);
            return re;
        }
        ,
        GetUserInfoByToken:function(token) {
            //http://localhost:45897/Jsonp/User/token/12234
            var url = FSSetting.ServiceUr + '/jsonp/User/token/' + token;

            var re = FSDataRetriver.Retrive(url);
            return re;
        },
        GetUserInfoByCred:function(user, password) {
            
            //http://localhost:45897/jsonp/User/Logon/user/tttt
            var url = FSSetting.ServiceUr + '/jsonp/User/Logon/' + user + "/" + password;
       
            var re = FSDataRetriver.Retrive(url);
            return re;
        }
    };
}