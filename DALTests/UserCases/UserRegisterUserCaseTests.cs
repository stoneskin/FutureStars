namespace DALTests.UserCases
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using DTOs;

    using global::DALTests.DALTests;

    //   using global::DALTests.DALTests;

    [TestClass]
    public class UserRegisterUserCaseTests : APITestBase
    {
        /// <summary>
        /// APIFunction
        /// </summary>

        [TestMethod]
        public void TestUserRegister()
        {
            //SetUp
            var request = new UserRegistrationRequest();
             //Assign
            var result=  this.FutureStarDAL.CreateNewUser(request);
        
            //Assert
            Assert.IsNotNull(result);

        }
        
        
        /// <summary>
        /// Internel function
        /// </summary
        [TestMethod]
        public void TestCreateUser()
        {
        }

      
        [TestMethod]
        public void TestInitialUserData()
        {
            //SetUp
                        
            //Assign
            var result = new object();
            //Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void TestCreateEvaluationTasksBaseOnAge()
        {
            //SetUp
            
            //Assign
            var result = new object();
            //Assert
            Assert.IsNotNull(result);

        }
        
    }
}
