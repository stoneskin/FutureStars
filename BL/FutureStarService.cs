using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    using DTOs;
    using DTOs.API;

    public class FutureStarService:DTOs.API.IFutureStarAPI
    {
        public FutureStarService(IFutureStarDAL dal)
        {
            this.futureStarDal = dal;
        }

        private DTOs.API.IFutureStarDAL futureStarDal;

        public UserLogonResponse RegisterNewUser(UserRegistrationRequest request)
        {
            throw new NotImplementedException();
        }

        public UserLogonResponse UserLogon(UserAuthenticationRequest request)
        {
            throw new NotImplementedException();
        }

        public TaskDetailResponse GetTaskDetails(TaskDetailRequest request)
        {
            throw new NotImplementedException();
        }

        public TaskSubmitResponse SubmitTaskAnswerSheet(TaskSubmitRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
