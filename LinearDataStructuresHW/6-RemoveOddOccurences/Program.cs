using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
        Console.Write("All numbers: ");

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
        Console.Write("Odd occurences removed numbers: ");

        for (var ind = 0; ind < numbers.Count; ind++)
        {
            var num = numbers[ind];
            if (numbers.Count(number => number == num) % 2 == 1)
            {
                numbers.RemoveAll(number => number == num);
                ind--;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
