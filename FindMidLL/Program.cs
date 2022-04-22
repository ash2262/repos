using System;

namespace FindMidLL
{
    class Program
    {
        public static LinkedList ll = new LinkedList();
        static void Main(string[] args)
        {

            ll.head = new LinkedList.Node(1);
            ll.head.next = new LinkedList.Node(2);
            ll.head.next.next = new LinkedList.Node(3);
            ll.head.next.next.next = new LinkedList.Node(4);
            ll.head.next.next.next.next = new LinkedList.Node(5);
            ll.head.next.next.next.next.next = new LinkedList.Node(6);
            Console.WriteLine(MiddleNode(ll.head).data);
        }
        public static LinkedList.Node MiddleNode(LinkedList.Node head)
        {
            LinkedList.Node ptr1 = head;
            LinkedList.Node ptr2 = head;
            if (head != null)
            {
                while ((ptr2 != null && ptr2.next != null))
                {
                    ptr2 = ptr2.next.next;
                    ptr1 = ptr1.next;
                }
            }
            return ptr1;

        }
    }

    public class LinkedList
    {
        public Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

    }
}
