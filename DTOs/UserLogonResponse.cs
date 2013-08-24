using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace DTOs
    {
        using DTOs.Model;

        public class UserLogonResponse:BasicResponse
        {
            public User User { get; set; }
          
            public string Token { get; set; }
        }
    }
