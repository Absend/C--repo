using System;
using System.Threading;

using Engine.Common.Structures;
using Engine.Contracts;
using Engine.Models;

namespace Engine.GameRenderers
{
    public static class ConsolRenderer
    {
        public static void SetConsoleProperties()
        {
            Console.Title = "Dungeons of OOP";
            Console.BackgroundColor = ConsoleColor.White;
            Console.BufferWidth = Console.WindowWidth = 90;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.CursorVisible = false;
        }

        public static void PrintLogo()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 8, 1);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Dungeons of OOP");
            Console.WriteLine();
        }

        public static string AskForUsername()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("OOP hero, ");
                Console.Write("Enter your username: ");

                Console.ForegroundColor = ConsoleColor.Red;
                var name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Username could not be empty!");
                }
                else if (name.Length > 20)
                {
                    Console.WriteLine("Username could be less then 20 charachters!");
                }
                else
                {
                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hello, {0}!", name);
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue ...");

                    if (Console.ReadKey() != null)
                    {
                        Console.Clear();
                    }
                    return name;
                }
            }
        }

        public static void DrawPlayground(int size)
        {
            Console.CursorVisible = false;

            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            for (int i = 0; i <= 4 * size; i++)
            {
                for (int j = 0; j <= 8 * size; j++)
                {
                    if (i % 4 == 0 && j == 0)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.WriteLine(new string(' ', 8 * size + 2));
                    }
                    if (i % 4 != 0 && j % 8 == 0)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.WriteLine("  ");
                    }
                }
            }
        }

        public static void PlayerAtPosition(Position pos)
        {
            Console.BackgroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(8 * pos.Y + 4, 4 * pos.X + 2);
            Console.WriteLine((char)1);
            Thread.Sleep(700);
            Console.SetCursorPosition(8 * pos.Y + 4, 4 * pos.X + 2);
            Console.WriteLine(" ");

            Console.SetCursorPosition(8 * pos.Y + 5, 4 * pos.X + 2);
            Console.WriteLine((char)1);
            Thread.Sleep(700);
            Console.SetCursorPosition(8 * pos.Y + 5, 4 * pos.X + 2);
            Console.WriteLine(" ");
        }

        public static void PlayerAbilities(string username)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(53, 1);
            Console.WriteLine(username);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(45, 3);
            Console.WriteLine("Power:");
            Console.SetCursorPosition(45, 5);
            Console.WriteLine("Intellect:");
            Console.SetCursorPosition(45, 7);
            Console.WriteLine("Money:");
            Console.SetCursorPosition(45, 9);
            Console.WriteLine("Chance:");
            Console.CursorVisible = false;
        }

        public static void IntAtPosition(int value, Position pos)
        {
            Console.SetCursorPosition(pos.X, pos.Y);
            Console.WriteLine(value);
            Console.CursorVisible = false;
        }

        public static void StringAtPosition(string value, Position pos)
        {
            Console.SetCursorPosition(pos.X, pos.Y);
            Console.WriteLine(value);
            Console.CursorVisible = false;
        }

        public static Position PlayerMove(Position pos, int playgroundSize)
        {
            Console.CursorVisible = false;

            DrawPlayground(5);

            while (Console.KeyAvailable)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow:
                        ClearAtPosition(pos, 1);
                        pos.Y--;
                        if (pos.Y < 0)
                        {
                            pos.Y = 0;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        ClearAtPosition(pos, 1);
                        pos.Y++;
                        if (pos.Y == playgroundSize)
                        {
                            pos.Y = playgroundSize - 1;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        ClearAtPosition(pos, 1);
                        pos.X--;
                        if (pos.X < 0)
                        {
                            pos.X = 0;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        ClearAtPosition(pos, 1);
                        pos.X++;
                        if (pos.X == playgroundSize)
                        {
                            pos.X = playgroundSize - 1;
                        }
                        break;
                    default: break;
                }
            }

            return pos;
        }

        public static void ClearAtPosition(Position pos, byte length)
        {
            Console.SetCursorPosition(pos.X, pos.Y);
            Console.WriteLine(new string(' ', length));
        }

    }
}
