using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLayerTests
{
    using DTOs;
    using DTOs.Model;

    [TestClass]
    public class UserRegisterTests:BusinessServiceTestBase
    {
         [Ignore]
        [TestMethod]
        public void TestRegisterNewUser()
        {
            var request = new UserRegistrationRequest()
                              {
                                  NewUser = new User()
                                                {
                                                    UserName = "NewUser",
                                                    DisplayName = "New User",
                                                    EmailAddress = "newuser@test.com",
                                                    Password = "password",
                                                    FirstName = "Firstname",
                                                    LastName = "lastname"
                                                },
                                                Token = "DeviceToken",
                                                Client = "UnitTest",

                              };
           var result= this.FutureStarAPI.RegisterNewUser(request);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.User);
            Assert.IsNotNull(result.Token);
            Assert.AreNotEqual(request.Token,result.Token);
            
            Assert.AreEqual(request.NewUser.UserName,result.User.UserName);

            Assert.IsNotNull(result.User.Projects);
            Assert.IsTrue(result.User.Projects.Count>0);
            Assert.IsNotNull(result.User.Projects[0]);
            Assert.IsNotNull(result.User.Projects[0].Tasks);
            Assert.IsTrue(result.User.Projects[0].Tasks.Count>0);
            Assert.IsNotNull(result.User.Projects[0].Tasks[0]);
        }
    }
}
