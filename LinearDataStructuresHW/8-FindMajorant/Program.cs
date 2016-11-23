using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // n = 18, majorant = n / 2 + 1 = 10
        var numbers = new List<int>() { 4, 2, 3, 3, 4, 4, 4, 5, 5, 5, 5, 1, 5, 5, 3, 5, 5, 5, 5 }; // 5 -> 10 times

        try
        {
            Console.WriteLine("Majorant: {0}", numbers.First(x => numbers.Count(y => y == x) > numbers.Count / 2));
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("The sequence does not contain a majorant.");
        }
    }
}
