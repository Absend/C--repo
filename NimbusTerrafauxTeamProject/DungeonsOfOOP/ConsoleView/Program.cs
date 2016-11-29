namespace ConsoleView
{
    using System;

    using Engine.Common.Exceptions;
    using Engine.Common.Structures;
    using Engine.Engines;
    using Engine.GameRenderers;
    using Engine.Models;

    class Program
    {
        private const byte Size = 5;
        private static Player player = new Player();

        static void Main(string[] args)
        {
            ConsolRenderer.SetConsoleProperties();

            ConsolRenderer.PrintLogo();

            player.Name = ConsolRenderer.AskForUsername();
            player.Position = new Position(0, 0);

            ConsolRenderer.DrawPlayground(Size);

            ConsolRenderer.PlayerAbilities(player.Name);


            while (true)
            {
                player.Position = ConsolRenderer.PlayerMove(player.Position, Size);
                ConsolRenderer.PlayerAtPosition(player.Position);

                Console.SetCursorPosition(0, 21);
                if (player.Position.X == 0 && player.Position.Y == 1)
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


            //Test.TestPlaygroundGeneration();
            //Test.TestFighterEngine();
            //Test.TestBoxOpenengine();
            //Test.TestFriendMeetingEngine();

            //Test.TestDice();

            //Test.TestQuiz();
        }
    }
}
