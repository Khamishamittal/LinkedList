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
            linked.Add(30);
            linked.Add(70);
            linked.Display();

            //Console.WriteLine("\n------------Deleting first element--------------");
            //linked.Pop();
            //Console.WriteLine("After Poping First element..");



            //Console.WriteLine("\n------------Deleting last node--------------");
            //linked.PopLast();
            //linked.Display();

            //Console.WriteLine("\n------------finding node in linked list --------------");
            //linked.Search(30);

            //Console.WriteLine("\n------------Insert 40 after 30 --------------");
            linked.InsertAfter(30, 40);
            linked.Display();

        }
    }
}
    
