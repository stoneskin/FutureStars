namespace DTOs
{
    public class UserAuthenticationRequest:BasicRequest
    {
        public string UserName { get; set; }

        public string EmailAddress  { get; set; }

        public string Password { get; set; }
        
            
    }
}