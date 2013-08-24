using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.API
{
   public interface IFutureStarDAL
    {
       DTOs.UserLogonResponse UserAuthentication(DTOs.UserAuthenticationRequest request);
       ProjectsResponse GetAvaliableProjects();
       ProjectsResponse GetUserProjects(int userId);

       UserLogonResponse CreateNewUser(UserRegistrationRequest request);
    }
}
