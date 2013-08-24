using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLayerTests
{
    using DTOs;
    using DTOs.Enums;

    [TestClass]
    public class UserLogonTests:BusinessServiceTestBase
    {
        //Do the GuestUser first
        [TestMethod]
        public void TestUserLogonWithGuestTokenSuccess()
        {
            //SetUp
            var request = new UserAuthenticationRequest()
            {
                UserName = "Guest",
                Password = "",
                Token = "TestDeviceToken"
            };
            //Assign
            var result = this.FutureStarAPI.UserLogon(request);
            //Assert

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.User);
            Assert.IsFalse(string.IsNullOrEmpty(result.Token));

            Assert.IsTrue(result.Success);
            Assert.AreEqual(DTOs.Enums.ErrorCode.None, result.ErrorCode);
            Assert.AreEqual(EnumUserTypes.Guest, result.User.UserType);
            this.VerifyUserObject(result.User);

        }
        [Ignore]
        [TestMethod]
        public void TestUserLogonSuccess()
        {
            //SetUp
            var request = new UserAuthenticationRequest() { UserName = "test123", Password = "password", Token = "" };
            //Assign
            var result = this.FutureStarAPI.UserLogon(request);
            //Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.User);
            Assert.IsFalse(string.IsNullOrEmpty(result.Token));
            Assert.IsTrue(result.Success);
            Assert.AreEqual(ErrorCode.None, result.ErrorCode);
            Assert.AreNotEqual(EnumUserTypes.Guest, result.User.UserType);
            this.VerifyUserObject(result.User);
        }
         [Ignore]
        [TestMethod]
         public void TestUserLogonWrongUsernameFailed()
         {
             //SetUp
             var request = new UserAuthenticationRequest()
             {
                 UserName = "",
                 Password = "password",
                 Token = ""
             };
             //Assign
             var result = this.FutureStarAPI.UserLogon(request);
             //Assert
             Assert.IsNotNull(result);
             Assert.IsNull(result.User);
             Assert.IsTrue(string.IsNullOrEmpty(result.Token));
             Assert.IsFalse(result.Success);
             Assert.AreEqual(DTOs.Enums.ErrorCode.InvalidUserName,result.ErrorCode);
             

         }
         [Ignore]
         [TestMethod]
         public void TestUserLogonWrongPasswordFailed()
         {
             //SetUp
             var request = new UserAuthenticationRequest()
             {
                 UserName = "",
                 Password = "password",
                 Token = ""
             };
             //Assign
             var result = this.FutureStarAPI.UserLogon(request);
             //Assert
             Assert.IsNotNull(result);
             Assert.IsNull(result.User);
             Assert.IsTrue(string.IsNullOrEmpty(result.Token));
             Assert.IsFalse(result.Success);
             Assert.AreEqual(DTOs.Enums.ErrorCode.InvalidPassword, result.ErrorCode);
             

         }
         [Ignore]
         [TestMethod]
         public void TestUserLogonWithTokenSuccess()
         {
             //SetUp
             var request = new UserAuthenticationRequest()
             {
                 UserName = "",
                 Password = "",
                 Token = "TestUserToken"
             };
             //Assign
             var result = this.FutureStarAPI.UserLogon(request);
             //Assert
             
             Assert.IsNotNull(result);
             Assert.IsNotNull(result.User);
             Assert.IsFalse(string.IsNullOrEmpty(result.Token));
             Assert.IsTrue(result.Success);
             Assert.AreEqual(DTOs.Enums.ErrorCode.None, result.ErrorCode);
             Assert.AreNotEqual(EnumUserTypes.Guest, result.User.UserType);
             this.VerifyUserObject(result.User);
         }

         [Ignore]
         [TestMethod]
         public void TestUserLogonWithWrongTokenFailed()
         {
             //SetUp
             var request = new UserAuthenticationRequest()
             {
                 UserName = "",
                 Password = "",
                 Token = "TestWrongToken"
             };
             //Assign
             var result = this.FutureStarAPI.UserLogon(request);
             //Assert

             Assert.IsNotNull(result);
             Assert.IsNull(result.User);
             Assert.IsTrue(string.IsNullOrEmpty(result.Token));
             Assert.IsFalse(result.Success);
             Assert.AreEqual(DTOs.Enums.ErrorCode.TokenExpired, result.ErrorCode);


         }

    

        private void VerifyUserObject(DTOs.Model.User user)
        {
            Assert.IsNotNull(user.Projects);
            Assert.IsTrue(user.Projects.Count>0);
            Assert.IsNotNull(user.Projects[0]);
            Assert.IsNotNull(user.Projects[0].Level);
            Assert.IsNotNull(user.Projects[0].Tasks);
            Assert.IsTrue(user.Projects[0].Tasks.Count > 0);
            Assert.IsNotNull(user.Projects[0].Tasks[0]);
        }
    }
}
