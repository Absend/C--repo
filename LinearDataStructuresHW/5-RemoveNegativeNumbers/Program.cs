using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>() { -2, 24, -95, 53, 5, 45, 5, 3, 33, -3, 1, 4, 24, 43, -47 };
        Console.Write("All numbers: ");

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
        Console.Write("Possitive numbers: ");

        numbers.RemoveAll(number => number < 0);

        Console.WriteLine(string.Join(" ", numbers));
    }
}
