using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var stack = new Stack<int>();
        var queue = new Queue<int>();
        var inputCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < inputCount; i++)
        {
            var number = int.Parse(Console.ReadLine());
            stack.Push(number);
            queue.Enqueue(number);
        }
        Console.WriteLine();
        Console.WriteLine("Dequeued with queue: ");
        for (int i = 0; i < inputCount; i++)
        {
            Console.Write(queue.Dequeue() + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Poped with stack (reversed): ");
        for (int i = 0; i < inputCount; i++)
        {
            Console.Write(stack.Pop() + " ");
        }
    }
}

