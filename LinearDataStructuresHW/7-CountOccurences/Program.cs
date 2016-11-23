using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>() { 4, 2, 3, 3, 4, 4, 4, 5, 5, 5, 5, 1, 5, 5, 3, 5, 5, 5, 5 };

        var groups = numbers
              .GroupBy(number => number)
              .Select(group => group.ToArray())
              .OrderBy(group => group[0]);

        foreach (var group in groups)
        {
            Console.WriteLine("{0} -> {1}", group[0], group.Count());
        }
    }
}
