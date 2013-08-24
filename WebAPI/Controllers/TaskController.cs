using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebAPI.Controllers
{
    using System.Web.Http;
    using DTOs;
    using MockBL;

    public class TaskController : ApiController
    {
        public TaskController( DTOs.API.IFutureStarAPI futureStarAPI)
        {
            apiService = futureStarAPI;
        }

        private readonly DTOs.API.IFutureStarAPI apiService;

        //
        // GET: /Task/
        public TaskDetailResponse Get(int id)
                {
                    return this.GetTask(new TaskDetailRequest(){Id=id});
                }
        public TaskDetailResponse GetTask([FromUri]TaskDetailRequest request)
        {
           // var request = new TaskDetailRequest() { Id = id, Token = token };
           
            var response = apiService.GetTaskDetails(request);
            return response;
        }

    }
}
