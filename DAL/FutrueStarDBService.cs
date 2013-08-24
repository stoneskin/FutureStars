using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    using DTOs;
    using DTOs.API;

    public class FutrueStarDBService:IFutureStarDAL
    {

        public UserLogonResponse UserAuthentication(UserAuthenticationRequest request)
        {
            throw new NotImplementedException();
        }

        public ProjectsResponse GetAvaliableProjects()
        {
            throw new NotImplementedException();
        }

        public ProjectsResponse GetUserProjects(int userId)
        {
            throw new NotImplementedException();
        }

        public UserLogonResponse CreateNewUser(UserRegistrationRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
