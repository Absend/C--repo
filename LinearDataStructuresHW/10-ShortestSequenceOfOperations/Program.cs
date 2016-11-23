using System;
using System.Collections.Generic;

class ShortestOperationSequence
{
    static void Main()
    {
        int n = 5;
        int m = 16;

        Console.WriteLine(string.Join(" -> ", GetSequence(n, m)));
    }

    private static Stack<int> GetSequence(int n, int m)
    {
        var sequence = new Stack<int>();
        int workingNumber = m;
        sequence.Push(workingNumber);

        while (workingNumber > n)
        {
            if (workingNumber / 2 >= n)
            {
                if (workingNumber % 2 == 0)
                {
                    workingNumber /= 2;
                }
                else
                {
                    workingNumber--;
                }
            }
            else
            {
                if (workingNumber - 2 >= n)
                {
                    workingNumber -= 2;
                }
                else
                {
                    workingNumber--;
                }
            }
            sequence.Push(workingNumber);
        }

        return sequence;
    }
}
