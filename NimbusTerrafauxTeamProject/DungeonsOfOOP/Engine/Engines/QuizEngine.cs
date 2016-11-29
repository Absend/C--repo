namespace Engine.Engines
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    using Common;
    using Models.Quiz;
    using Models;
    public class QuizEngine
    {
        private static IList<Question> allQuestions;

        public static IList<Question> AllQuestions
        {
            get
            {
                return allQuestions;
            }
            private set
            {
                allQuestions = value;
            }
        }

        public static XmlNodeList LoadQuestions()
        {
            var reader = new XmlDocument();
            reader.Load(Constants.QuestionBankAddress);
            var questionsList = reader.GetElementsByTagName(Constants.QuestionTagName);
            return questionsList;
        }

        public static void GetQuestionsList()
        {
            var questionsAsXml = LoadQuestions();
            AllQuestions = questionsAsXml.GetQuestionsList();
        }

        public static void HoldExamSample(Trainer trainer)
        {
            while (trainer.Questions.Count > 0)
            {
                var question = trainer.AskQuestion();
                Console.WriteLine(question);

            }
        }
    }
}
