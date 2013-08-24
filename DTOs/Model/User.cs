namespace DTOs.Model
{
    using System.Collections.Generic;

    public class User:EntityBase
    {
        
        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public string DisplayName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ParentId { get; set; }

        public List<Project> Projects { get; set; }
        public Enums.EnumUserTypes UserType { get; set; }
    }
   
}