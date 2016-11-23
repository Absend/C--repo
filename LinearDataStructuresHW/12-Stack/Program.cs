namespace _12_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>(2);

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            System.Console.WriteLine("Count: " + stack.Count);

            while (stack.Count > 0)
            {
                System.Console.WriteLine(stack.Pop());
            }
        }
    }
}
