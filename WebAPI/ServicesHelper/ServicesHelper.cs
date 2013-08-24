using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.ServicesHelper
{
    public class ServicesHelper
    {
        private DTOs.API.IFutureStarAPI futureStarAPI;
        public ServicesHelper(DTOs.API.IFutureStarAPI  service)
        {
            futureStarAPI = service;
        }

    }
}