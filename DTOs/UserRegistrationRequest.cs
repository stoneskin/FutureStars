namespace DTOs
{
    using DTOs.Model;

    public class UserRegistrationRequest:BasicRequest
    {
        public User NewUser { get; set; }
        //other info collect from user
        public string Client { get; set; }
        public string IpAddress { get; set; }
        public string SoftwareVersion { get; set; }
        // public string VerifyCode { get; set; } //make sure it is human not machine
            
    }
}