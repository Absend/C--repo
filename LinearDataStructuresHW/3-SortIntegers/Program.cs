using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var numbersList = new List<int>();

        while (true)
        {
            var input = Console.ReadLine();

            if (input == string.Empty)
            {
                Console.WriteLine("Ascending sort:");
                numbersList = SortAscending(numbersList);
                PrintNumbers(numbersList);

                Console.WriteLine("Decending sort:");
                numbersList = SortDescending(numbersList);
                PrintNumbers(numbersList);

                return;
            }

            var num = int.Parse(input);

            numbersList.Add(num);
        }
    }

    static void PrintNumbers(List<int> numbersList)
    {
        foreach(var number in numbersList)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static List<int> SortDescending(List<int> numbersList)
    {
        for (int i = 0; i < numbersList.Count - 1; i++)
        {
            for (int j = i + 1; j < numbersList.Count; j++)
            {
                if (numbersList[i] < numbersList[j])
                {
                    int swap = numbersList[i];
                    numbersList[i] = numbersList[j];
                    numbersList[j] = swap;
                }
            }
        }

        return numbersList;
    }

    static List<int> SortAscending(List<int> numbersList)
    {
        for (int i = 0; i < numbersList.Count - 1; i++)
        {
            for (int j = i + 1; j < numbersList.Count; j++)
            {
                if (numbersList[i] > numbersList[j])
                {
                    int swap = numbersList[i];
                    numbersList[i] = numbersList[j];
                    numbersList[j] = swap;
                }
            }
        }

        return numbersList;
    }
}
