using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockBL
{
    using DTOs;
    using DTOs.Enums;
    using DTOs.Model;

    public class FutureStarService:DTOs.API.IFutureStarAPI
    {
        public UserLogonResponse RegisterNewUser(UserRegistrationRequest request)
        {
            throw new NotImplementedException();
        }
        
        public UserLogonResponse UserLogon(UserAuthenticationRequest request)
        {
            var response = new UserLogonResponse()
                               {
                                   User =
                                       new User()
                                           {
                                               UserType = EnumUserTypes.Guest,
                                               Id = 1,
                                               DisplayName = "Guest",
                                               UserName = "Guest1",
                                               Projects =
                                                   new List<Project>()
                                                       {
                                                           new Project() {Name = "Math",Id = 1,Description = "Math",
                                                               Level = new Level(){Id = 1,Value = 0, LvlGroup = "General",Code = "A1",Text = "Level 0",Description = "Beginner"},
                                                               Tasks = new List<Task>()
                                                                           {
                                                                               new Task(){Id = 1,Description = "Evaluate your math skills"},
                                                                               
                                                                           }
                                                           },
                                                           new Project() {Name = "Reading",Id = 2,Description = "Reading" ,
                                                                Level = new Level(){Id = 1,Value = 0,LvlGroup = "General",Code = "A1",Text = "Level 0",Description = "Beginner"},
                                                                Tasks = new List<Task>()
                                                                       {
                                                                           new Task(){Id = 1,Description = "Evaluate your reading skills"},
                                                                           
                                                                       }}
                                                       }
                                           },
                                   Success = true,
                                   Token = request.Token,
                                   ErrorCode = ErrorCode.None
                               };
            return response;

        }

        public TaskDetailResponse GetTaskDetails(TaskDetailRequest request)
        {
            var response = new TaskDetailResponse()
                               {
                                   ErrorCode = ErrorCode.None,
                                   Success = true,
                                   Task =
                                       new Task()
                                           {
                                               Id = 1,
                                               Description = "First Task",
                                               Items = new List<Item>() { new Item()
                                                                              {
                                                                                  Id = 1,
                                                                                  TagName = "AddToTen",
                                                                                  Question = new Question()
                                                                                                 {
                                                                                                     Id = 1,
                                                                                                     QuestionText = "4 + 3 =",
                                                                                                     QuestionContent = null,
                                                                                                     Answers = new List<Answer>()
                                                                                                                   {
                                                                                                                       new Answer(){Id = 1,Text = "5"},
                                                                                                                        new Answer(){Id = 2,Text = "6"},
                                                                                                                         new Answer(){Id = 3,Text = "7",IsCorrect = true},
                                                                                                                          new Answer(){Id = 4,Text = "8"},
                                                                                                                   },
                                                                                                    CorrectAnswer = "7",
                                                                                                    QuestionType = EnumQuestionTypes.SingleSelectionFourAnswers
                                                                                                 },

                                                                              },
                                                                              new Item()
                                                                              {
                                                                                  Id = 2,
                                                                                  TagName = "AddToTen",
                                                                                  Question = new Question()
                                                                                                 {
                                                                                                     Id = 2,
                                                                                                     QuestionText = "4 + 4 =",
                                                                                                     QuestionContent = null,
                                                                                                     Answers = new List<Answer>()
                                                                                                                   {
                                                                                                                       new Answer(){Id = 5,Text = "4"},
                                                                                                                        new Answer(){Id = 6,Text = "6"},
                                                                                                                         new Answer(){Id = 7,Text = "8",IsCorrect = true},
                                                                                                                          new Answer(){Id = 8,Text = "10"},
                                                                                                                   },
                                                                                                    CorrectAnswer = "8",
                                                                                                    QuestionType = EnumQuestionTypes.SingleSelectionFourAnswers
                                                                                                 },

                                                                              },
                                                                              new Item()
                                                                              {
                                                                                  Id = 3,
                                                                                  TagName = "AddToTen",
                                                                                  Question = new Question()
                                                                                                 {
                                                                                                     Id = 3,
                                                                                                     QuestionText = "2 + 3 =",
                                                                                                     QuestionContent = null,
                                                                                                     Answers = new List<Answer>()
                                                                                                                   {new Answer(){Id = 7,Text = "5",IsCorrect = true},
                                                                                                                         new Answer(){Id = 5,Text = "7"},
                                                                                                                        new Answer(){Id = 6,Text = "6"},
                                                                                                                         
                                                                                                                          new Answer(){Id = 8,Text = "10"},
                                                                                                                   },
                                                                                                    CorrectAnswer = "5",
                                                                                                    QuestionType = EnumQuestionTypes.SingleSelection
                                                                                                 },

                                                                              },
                                                                              new Item()
                                                                              {
                                                                                  Id = 4,
                                                                                  TagName = "AddToTen",
                                                                                  Question = new Question()
                                                                                                 {
                                                                                                     Id = 4,
                                                                                                     QuestionText = "4 + 6 =",
                                                                                                     QuestionContent = null,
                                                                                                     Answers = new List<Answer>()
                                                                                                                   {  new Answer(){Id = 5,Text = "4"},
                                                                                                                        new Answer(){Id = 6,Text = "6"},
                                                                                                                         new Answer(){Id = 7,Text = "8"},
                                                                                                                          new Answer(){Id = 8,Text = "10",IsCorrect = true},
                                                                                                                   },
                                                                                                    CorrectAnswer = "10",
                                                                                                    QuestionType = EnumQuestionTypes.SingleSelection
                                                                                                 },

                                                                              },
                                                                              new Item()
                                                                              {
                                                                                  Id = 5,
                                                                                  TagName = "AddToTen",
                                                                                  Question = new Question()
                                                                                                 {
                                                                                                     Id = 5,
                                                                                                     QuestionText = "7 + 3 =",
                                                                                                     QuestionContent = null,
                                                                                                     Answers = null,
                                                                                                    CorrectAnswer = "10",
                                                                                                    QuestionType = EnumQuestionTypes.SingleSelection
                                                                                                 },

                                                                              },
                                                                             
                                               },
                                               TotalQuestions = 5,
                                               GoalOfTotalCorrect = 5,
                                               GoalSecondsSpend = 35
                                           }
                               };
            return response;
        }

        public TaskSubmitResponse SubmitTaskAnswerSheet(TaskSubmitRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
