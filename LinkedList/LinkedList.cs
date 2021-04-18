using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {

        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }



        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.head = new Node(56);
            Node second = new Node(30);
            Node third = new Node(70);
            list.head.next = second;
            second.next = third;

        }
    }
}
