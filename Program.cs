namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");

            Console.WriteLine("\nAdding 30 and 56 to  the Linked List \n");


            LinkedList linked = new LinkedList();
            linked.Add(56);
            linked.Add(30);
            linked.Add(70);

            linked.Display();
        }
    }
}


