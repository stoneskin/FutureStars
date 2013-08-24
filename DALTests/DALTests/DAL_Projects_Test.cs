namespace DALTests.DALTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class API_Projects_Test:APITestBase
    {
        

        [TestMethod]
        public void TestGetAvaliableProjects()
        {
            var response = this.FutureStarDAL.GetAvaliableProjects();
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Projects);
            Assert.IsTrue(response.Projects.Count>0);
        }

        [TestMethod]
        public void TestGetUserProjectsWithTasks()
        {
            //SetUp
            var userId = 1;
            //Assign
            var projects = this.FutureStarDAL.GetUserProjects(userId);

            //Assert
            Assert.IsNotNull(projects);
            Assert.IsNotNull(projects.Projects);
            Assert.IsTrue(projects.Projects.Count > 0);
        }
    }
}
