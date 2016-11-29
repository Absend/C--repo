namespace ConsoleView.Tests
{
    using System;
    using Engine.Models;
    using Engine.Common.Structures;
    using Engine.Engines;
    using System.Threading;
    public static class Test
    {
        public static void TestFighterEngine()
        {

            int count = 1;
            //Testin FightEngine
            Console.WriteLine("Start battle simulations with same params");
            Console.WriteLine(new string('-', 100));
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Battle {0}", count);
                FightEngine.Start(new Player("Paskov", 1, 100), new Fighter("Org", 1));
                Console.WriteLine();
                Console.WriteLine(new string('-', 100));
                count++;
            }
            Console.WriteLine("End battle simulation");
            Console.WriteLine(new string('-', 100));
        }

        public static void TestPlaygroundGeneration()
        {
            Console.WriteLine("Loading... please wait");
            Playground field = new Playground(new Size(5, 5));
            Console.Clear();
            int count = 0;


            foreach (var room in field.Rooms)
            {
                Console.WriteLine("Room {0} content", count);
                if (room.GameObj is Box)
                {
                    Console.WriteLine(room.GameObj.GetType().Name);
                }
                else
                {
                    if (room.GameObj is Trainer)
                    {
                        Console.WriteLine((room.GameObj as Trainer).Name + '-' + room.GameObj.GetType().Name);
                    }
                    else if (room.GameObj is Friend)
                    {
                        Console.WriteLine((room.GameObj as Friend).Name + '-' + room.GameObj.GetType().Name);
                    }
                    else
                    {
                        Console.WriteLine((room.GameObj as Fighter).Name + '-' + room.GameObj.GetType().Name);
                    }
                }
                Console.WriteLine(new string('-', 100));
                count++;
            }

            Console.WriteLine(new string('-', 100));
        }

        public static void TestBoxOpenengine()
        {
            Player player = new Player("Paskov", 10, 25);
            player.hitPoints = 30;
            bool isBonus = true;


            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Player HP {0}", player.hitPoints);
            Console.WriteLine("Player Intellect {0}", player.Intellect);
            Console.WriteLine(new string('-', 100));
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Box content is Bonus: {0}", isBonus);
                BoxOpenEngine.Start(player, new Box(isBonus));
                isBonus = !isBonus;
                Console.WriteLine("New player HP {0}", player.hitPoints);
                Console.WriteLine("New player Intellect {0}", player.Intellect);
                Console.WriteLine(new string('-', 100));
            }

            Console.WriteLine(new string('-', 100));
        }

        public static void TestFriendMeetingEngine()
        {
            Player player = new Player("Paskov", 10, 25);
            player.hitPoints = 30;
            Friend friend = new Friend("Suzane");



            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Player HP {0}", player.hitPoints);
            Console.WriteLine("Player Intellect {0}", player.Intellect);
            Console.WriteLine(new string('-', 100));

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Meeting with friend");
                switch (friend.Name)
                {
                    case "Suzane":
                        FriendMeetingEngine.Start(player, friend);
                        friend.Name = "Ivet";
                        break;
                    case "Ivet":
                        FriendMeetingEngine.Start(player, friend);
                        friend.Name = "Suzane";
                        break;
                }
                Console.WriteLine("New player HP {0}", player.hitPoints);
                Console.WriteLine("New player Intellect {0}", player.Intellect);
                Console.WriteLine(new string('-', 100));
            }
        }

        // Orlin's test from the old solution
        public static void TestQuiz()
        {
            QuizEngine.GetQuestionsList();

            var cuky = new Trainer("Cuky");

            cuky.PopulateQuestionsList();

            while (cuky.Questions.Count > 0)
            {
                var question = cuky.AskQuestion();
                Console.WriteLine(question);

                var answer = int.Parse(Console.ReadLine());
                question.CheckAnswer(answer);
            }
        }

        public static void TestDice()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Press ENTER for playing dice ...");

            var pos = new Position(Console.CursorLeft, Console.CursorTop);
            
            Console.ReadKey();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    break;
                }

                Console.SetCursorPosition(pos.X, pos.Y);
                Console.CursorVisible = false;

                Console.WriteLine(Dice.Play());
                Thread.Sleep(2);
            }
        }
    }
}

