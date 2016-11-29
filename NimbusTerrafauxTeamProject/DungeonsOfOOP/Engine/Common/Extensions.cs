namespace Engine.Common
{
    using System.Collections.Generic;
    using System.Xml;

    using Exceptions;
    using Models.Quiz;

    public static class Extensions
    {
        //Populates a list with all questions
        public static IList<Question> GetQuestionsList(this XmlNodeList questionsAsXml)
        {
            var questions = new List<Question>();
            for (var i = 0; i < questionsAsXml.Count; i++)
            {
                questions.Add(questionsAsXml.GetQuestion(i));
            }
            return questions;
        }

        //Populates a list with questionsCount questions
        public static IList<Question> GetQuestionsList(this XmlNodeList questionsAsXml, int questionsCount)
        {
            var questions = new List<Question>();
            for (var i = 0; i < questionsCount; i++)
            {
                var index = RandomGenerator.Return(0, questionsAsXml.Count - 1);
                questions.Add(questionsAsXml.GetQuestion(index));
            }
            return questions;
        }

        private static Question GetQuestion(this XmlNodeList nodes, int index)
        {
            var questionNode = nodes[index];
            var questionText = questionNode.Attributes[Constants.XmlTextTagName].Value;
            var answersDict = new Dictionary<Answer, bool>();

            for (var i = 0; i < questionNode.ChildNodes.Count; i++)
            {
                var answer = questionNode.GetAnswer(i);
                var isCorrect = questionNode.GetAnswerCorrectness(i);
                answersDict.Add(answer, isCorrect);
            }

            var question = new Question(questionText, answersDict);
            return question;
        }

        private static Answer GetAnswer(this XmlNode node, int index)
        {
            var answerNode = node.ChildNodes[index];
            var answerText = answerNode.Attributes[Constants.XmlTextTagName].Value;

            var answer = new Answer(answerText);

            return answer;
        }

        private static bool GetAnswerCorrectness(this XmlNode node, int index)
        {
            var answerNode = node.ChildNodes[index];
            var answerCorrectAsStr = answerNode.Attributes[Constants.XmlCorrectAnswerTagName].Value;

            Validator.ValidateStringIsTrueOrFalse(answerCorrectAsStr);

            var answerCorrectAsBool = answerCorrectAsStr == "true";

            return answerCorrectAsBool;
        }
        //Gets question from List<Question> and removes it so it can't be extracted again
        public static Question ExtractQuestion(this IList<Question> questions, int index)
        {
            var question = questions[index];
            questions.RemoveAt(index);
            return question;
        }
    }
}
