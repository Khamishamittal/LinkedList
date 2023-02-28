namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");

            Console.WriteLine("\nCreate Linked List by Appending 30 and 70 to 56\n");

            LinkedList linked = new LinkedList();
            linked.Append(56);
            linked.Append(30);
            linked.Append(70);

            linked.Display();
        }
    }
}


