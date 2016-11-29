namespace ConsoleShowExam
{
    using System;

    using Engine.Engines;
    using Engine.Models;
    using Engine.Common.Exceptions;
    class StartUp
    {
        static void Main()
        {
            QuizEngine.GetQuestionsList();
            var cuky = new Trainer("Cuky");
            cuky.PopulateQuestionsList();
            while (cuky.HasMoreQuestions)
            {
                try
                {
                    var question = cuky.AskQuestion();
                    Console.Write(question);
                    var answerStr = Console.ReadLine();
                    Validator.ValidateStringIsIntParsable(answerStr);
                    var answer = int.Parse(answerStr);
                    Console.WriteLine(question.CheckAnswer(answer) ? "Correct" : "Wrong");
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine();
                }
            }
        }
    }
}