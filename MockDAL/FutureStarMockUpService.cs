namespace MockDAL
{
    using System;

    using DTOs;
    using DTOs.API;

    public class FutureStarMockUpService : IFutureStarDAL
    {

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


