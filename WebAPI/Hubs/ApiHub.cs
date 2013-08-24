using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebAPI.Hubs
{
    using System.Web.Http;

    using DTOs;
    using DTOs.API;
    using DTOs.Model;

    public class ApiHub : Hub
    {
        private IFutureStarAPI service;
        public ApiHub()
            : base()
        {
            this.service = GlobalConfiguration.Configuration.DependencyResolver.GetService(typeof(IFutureStarAPI)) as IFutureStarAPI;
        }
        public void Hello()
        {
            Clients.Caller.hello("hello!");
        }

        public TaskDetailResponse GetTask(int id)
        {
            var request = new TaskDetailRequest() { Id = id };
            var response = service.GetTaskDetails(request);
            Clients.Caller.hello(response);
            return response;
        }

        public UserLogonResponse UserLogon(string token)
        {
            var response = service.UserLogon(new UserAuthenticationRequest(){Token = token});
            return response;
        }
        public void GetProjects(string userId, string token)
        {
            
        }
        public void SubmitTask(Task task)
        {

        }
    }
}