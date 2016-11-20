using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>() { 2, 2, 5, 5, 5, 5, 5, 3, 3, 3, 1, 4, 4, 4, 4 };

        Console.Write("Sequence: ");

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();

        List<int> longestSubsequence = GetLongestSubsequence(numbers);
        Console.WriteLine("Longest subsequence: {0}, count: {1}",
            string.Join(" ", longestSubsequence), longestSubsequence.Count);
    }

    private static List<int> GetLongestSubsequence(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            throw new ArgumentException("List cannot be null or empty");
        }

        int bestCount = 1;
        int bestElement = numbers[0];
        int count = 1;

        for (var ind = 1; ind < numbers.Count; ind++)
        {
            while (ind < numbers.Count && numbers[ind] == numbers[ind - 1])
            {
                ++count;
                ++ind;
            }

            if (count > bestCount)
            {
                bestCount = count;
                bestElement = numbers[ind - 1];
            }

            count = 1;
        }

        return Enumerable.Repeat(bestElement, bestCount).ToList();
    }
}
