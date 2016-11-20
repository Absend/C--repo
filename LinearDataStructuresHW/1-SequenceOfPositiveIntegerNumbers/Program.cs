using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var numbersList = new List<int>();
        var sum = 0;

        while (true)
        {
            var input = Console.ReadLine();

            if (input == string.Empty)
            {
                var numbersCount = numbersList.Count;
                var average = (double)sum / numbersCount;

                foreach(var number in numbersList)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
                Console.WriteLine("Sum is {0}", sum);
                Console.WriteLine("Average is {0}", average);

                return;
            }

            var num = int.Parse(input);

            numbersList.Add(num);
            sum += num;
        }
    }
}
