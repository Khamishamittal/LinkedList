namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");


            Console.WriteLine("\nInserting 30 between 56 and 70\n");

            LinkedList linked = new LinkedList();
            linked.Add(56);
            linked.Add(70);
            linked.Display();


            Console.WriteLine("After Poping First element..");

            linked.Pop();
            linked.Display();
        }
    }
}


