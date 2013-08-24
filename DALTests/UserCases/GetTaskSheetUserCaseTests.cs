using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DALTests.UserCases
{
    using global::DALTests.DALTests;

    [TestClass]
    public class GetTaskSheetUserCaseTests:APITestBase
    {


        [TestMethod]
        public void TestGetTaskSheetByTaskId()
        {
            //SetUp
            
            //Assign
            var result = new object();
            //Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void TestRetriveTasksWithItemsAndAnswerSheet()
        {
        }


       
    }
}
