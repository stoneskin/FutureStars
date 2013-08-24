namespace DALTests.DALTests
{
    using System;

    using DTOs.Model;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using DTOs;

    [TestClass]
    public class API_Users_Tests:APITestBase
    {
        

        [TestMethod]
        public void GetUserAuthenticationResponse()
        {
            var request = new UserAuthenticationRequest()
                              {
                                  EmailAddress = "test@test.com",
                                  Password = "password"
                              };
           var response= this.FutureStarDAL.UserAuthentication(request);
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void TestGiveGoodUserNameAndPassword()
        {
            var request = new UserAuthenticationRequest()
                              {
                                  UserName = "test001",
                                  Password = "password"
                              };
            var response = this.FutureStarDAL.UserAuthentication(request);
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.User);
            Assert.IsTrue(response.Success);

        }


        [TestMethod]
        public void TestGiveGoodUserNameAndBadPassword()
        {
            var request = new UserAuthenticationRequest()
            {
                UserName = "test001",
                Password = "wrongpassword"
            };
            var response = this.FutureStarDAL.UserAuthentication(request);
            Assert.IsNotNull(response);
            Assert.IsNull(response.User);
            Assert.IsFalse(response.Success); 
            Assert.AreEqual(response.Message,"Invalid Password");

        }

        [TestMethod]
        public void TestGiveBadUserName()
        {
            var request = new UserAuthenticationRequest()
            {
                UserName = "notexistuser",
                Password = "wrongpassword"
            };
            var response = this.FutureStarDAL.UserAuthentication(request);
            Assert.IsNotNull(response);
            Assert.IsNull(response.User);
            Assert.IsFalse(response.Success) ;
            Assert.AreEqual(response.Message, "User Not Found");

        }

        [TestMethod]
        public void TestGiveUserNameAndToken()
        {
            var request = new UserAuthenticationRequest()
            {
                UserName = "notexistuser",
                Password = "wrongpassword"
            };
            var response = this.FutureStarDAL.UserAuthentication(request);
            Assert.IsNotNull(response);
            Assert.IsNull(response.User);
            Assert.IsFalse(response.Success);
            Assert.AreEqual(response.Message, "User Not Found");

        }


        [TestMethod]
        public void TestGuestAccess()
        {
            //for guest will use  token binding with that device
            var request = new UserAuthenticationRequest()
            {
                UserName = "guest",Token = Guid.NewGuid().ToString()
               
            };
            var response = this.FutureStarDAL.UserAuthentication(request);
            Assert.IsFalse(string.IsNullOrEmpty(response.Token) );

        }


        [TestMethod]
        public void TestRegisterNewUser()
        {
            var request = new UserRegistrationRequest()
            {
                NewUser = new User()
                              {
                                  UserName = "newuser_"+Guid.NewGuid().ToString(),
                                  Password = "pwd"
                              }
                              ,
                              Client = "UnitTest",
                              SoftwareVersion = "-"
            };
            var response = this.FutureStarDAL.CreateNewUser(request);
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.User);
            Assert.IsNotNull(response.User.Projects);
            Assert.IsTrue(response.Success);

        }
    }
}
