namespace DTOs.Model
{
    using System.Collections.Generic;

    public class Task:EntityBase
    {
        public string Description { get; set; }

        public IList<Item> Items { get; set; }
        public int TotalQuestions { get; set; }
        public int TotalSecondsSpend { get; set; }
        public int TotalCorrectAnswer { get; set; }

        public int  GoalSecondsSpend{ get; set; }
        public int GoalOfTotalCorrect { get; set;}
    }

    public class Item : EntityBase
    {
        public string Name { get; set; }

        public string TagName { get; set; }

        public Question Question { get; set; }
       
        //for TaskItem table

        public string Answer { get; set; }

        public int SecondsSpend { get; set; }

        public bool Correct { get; set; }
    }

    public class QuestionContent:EntityBase
    {
        public string ContentText { get; set; }
    }

    public class Question:EntityBase
    {
        public string QuestionText { get; set; }
        public QuestionContent QuestionContent { get; set; }
        public Enums.EnumQuestionTypes QuestionType { get; set; }
        public List<Answer> Answers { get; set; }
        public string CorrectAnswer { get; set; }


    }

    public class Answer:EntityBase
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }

    public class Tag:EntityBase
    {
        public string Name;

        public string  Description { get; set; }
    }
}