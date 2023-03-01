namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LL List Problems");

            Console.WriteLine("\nInserting 30 between 56 and 70\n");

            LinkedList LL = new LinkedList();
            //LL.Add(56);
            //LL.Add(30);
            //LL.Add(40);
            //LL.Add(70);
            //LL.Display();

            //Console.WriteLine("\n------------Deleting first element--------------");
            //LL.Pop();
            //Console.WriteLine("After Poping First element..");



            //Console.WriteLine("\n------------Deleting last node--------------");
            //LL.PopLast();
            //LL.Display();

            //Console.WriteLine("\n------------finding node in LL list --------------");
            //LL.Search(30);

            //Console.WriteLine("\n------------Insert 40 after 30 --------------");
            //LL.InsertAfter(30, 40);
            //LL.Display();


            //Console.WriteLine("\n------------Deleting 40 From LL list and showing size --------------");
            //LL.DeleteValue(40);
            //LL.Display();
            //LL.Size();

            Console.WriteLine("\n------------Ordered LL list--------------");
            LL.OrderedList(56);
            LL.OrderedList(30);
            LL.OrderedList(40);
            LL.OrderedList(70);
            Console.WriteLine("\n------------After sorting:--------------");

            LL.Display();

        }
    }
}





