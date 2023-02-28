using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public  class LinkedList
    {

        public Node head;

        public void AddAtPosition(int position, int data)
        {
            Node newNode = new Node(data);

            if (position < 1)
            {
                Console.WriteLine("Invalid position");
            }
            //If we want node to be inserted at first position
            if (position == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                //Declaring count to count starting from 2 the position
                int currentPosition = 1;
                //Declaring temporary head tempHead to parse throu the list
                Node tempHead = head;
                //while count does not get to the entered position where we want to add our node
                while (currentPosition++ != position)
                {
                    //If our count variable is at entered position
                    if (currentPosition == position)
                    {
                        //Assigning newNode's next to tempHead's next, the position at which we want to insert node
                        newNode.next = tempHead.next;

                        //Assigning previous node's (here tempHead) next to newNode
                        tempHead.next = newNode;
                        Console.WriteLine(newNode.data + " is added at position " + position);
                        break;
                    }
                    //Moving the position of tempHead to the next node
                    tempHead = tempHead.next;
                }
                if (currentPosition != position)
                {
                    Console.WriteLine("Position is out of range");
                }
            }
        }

        public void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Added to linked list ", node.data);
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
