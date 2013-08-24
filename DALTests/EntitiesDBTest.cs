using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DALTests
{
    using DAL;
    
    [TestClass]
    public class EntitiesDBTest
    {

      public  EntitiesDBTest()
        {
            this.entityes=new FutureStarEntities();
        }

        private readonly DAL.FutureStarEntities entityes;

        [TestMethod]
        public void RetriveUserByUserName()
        {
            var username = "Test001";
            var user =
                entityes.Users.SingleOrDefault(
                    u => u.UserName.Equals(username, StringComparison.CurrentCultureIgnoreCase));
            Assert.IsNotNull(user);

        }

        [TestMethod]
        public void TestGetUserProjects()
        {
            var username = "Test001";
            var user =
                entityes.Users.SingleOrDefault(
                    u => u.UserName.Equals(username, StringComparison.CurrentCultureIgnoreCase));
            Assert.IsNotNull(user);
            Assert.IsNotNull(user.User_Projects);
            Assert.IsTrue(user.User_Projects.Count>0);
            var project = user.User_Projects.First().Project;
            Assert.IsTrue(project.Id>0);
        }

        [TestMethod]
        public void TestGetAllTasksOfProject()
        {
            var projectId = 1;

            var proj = entityes.Projects.SingleOrDefault(x => x.Id == projectId);
            Assert.IsNotNull(proj);

        }
    }
}
