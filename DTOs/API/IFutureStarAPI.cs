namespace DTOs
{
}

namespace DTOs.API
{
    using DTOs;

    public interface IFutureStarAPI
    {
        

        UserLogonResponse RegisterNewUser(UserRegistrationRequest request);
        UserLogonResponse UserLogon(UserAuthenticationRequest request);

        TaskDetailResponse GetTaskDetails(TaskDetailRequest request);

        TaskSubmitResponse SubmitTaskAnswerSheet(TaskSubmitRequest request);

    }
}


