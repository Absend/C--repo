namespace _11_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.FirstElement = new ListItem<int>(12);
            list.FirstElement.NextItem = new ListItem<int>(13);
            list.FirstElement.NextItem.NextItem = new ListItem<int>(14);
            list.FirstElement.NextItem.NextItem.NextItem = new ListItem<int>(15);

            var current = list.FirstElement;
            while (current != null)
            {
                System.Console.WriteLine(current.Value);
                current = current.NextItem;
            }
        }
    }
}
