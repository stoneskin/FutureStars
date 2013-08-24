using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLayerTests
{
    using DTOs.Enums;

    [TestClass]
    public class TaskRetrieveTests:BusinessServiceTestBase
    {
        [TestMethod]
        public void TestRetriveTaskByTaskId()
        {
            var request = new DTOs.TaskDetailRequest() { Id = 1, Token = "TestToken" };
           var response= this.FutureStarAPI.GetTaskDetails(request);
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Task);
            Assert.IsTrue(response.Success);
            Assert.AreEqual(ErrorCode.None,response.ErrorCode);
            Assert.IsTrue(response.Task.Id==request.Id);
            Assert.IsNotNull(response.Task.Items);
            Assert.IsTrue(response.Task.Items.Count==5);
            var question = response.Task.Items[0].Question;
            Assert.IsTrue(question!=null);
            
            Assert.IsTrue(question.QuestionType==EnumQuestionTypes.SingleSelectionFourAnswers);
            Assert.IsTrue(question.Answers.Count==4);
            var question5 = response.Task.Items[4].Question;
            Assert.IsTrue(question5 != null);

            Assert.IsTrue(question5.QuestionType == EnumQuestionTypes.SingleSelection);
           // Assert.IsTrue(question.Answers.Count == 0);

        }
    }
}
