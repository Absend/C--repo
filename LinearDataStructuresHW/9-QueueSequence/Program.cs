using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var sequence = GetSequence(2, 50);
        Console.WriteLine(string.Join(", ", sequence));
    }

    private static List<int> GetSequence(int starNum, int length)
    {
        var sequence = new List<int>() { starNum };
        var queue = new Queue<int>();
        queue.Enqueue(starNum);
        int steps = 0;
        int workingNum = starNum;

        while (steps < length - 1)
        {
            switch (steps % 3)
            {
                case 0:
                    workingNum = queue.Dequeue();
                    queue.Enqueue(workingNum + 1);
                    sequence.Add(workingNum + 1);
                    break;
                case 1:
                    queue.Enqueue(2 * workingNum + 1);
                    sequence.Add(2 * workingNum + 1);
                    break;
                case 2:
                    queue.Enqueue(workingNum + 2);
                    sequence.Add(workingNum + 2);
                    break;
            }

            ++steps;
        }

        return sequence;
    }
}