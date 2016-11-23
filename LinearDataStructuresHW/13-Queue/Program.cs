namespace _13_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }

            System.Console.WriteLine("Count: " + queue.Count);

            while (queue.Count > 0)
            {
                System.Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
