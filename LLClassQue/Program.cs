using System;

namespace LLClassQue
{
    public class LinkedL
    {
        public static int length;

        public static Node head;
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


        static void Main(string[] args)
        {
              length = 5;
            LinkedL linkl = new LinkedL();

            LinkedL.head = new Node(0);
            var temp = LinkedL.head;
            

            for (int i = 1; i <= length; i++)
            {
                Node NN = new Node(i);
                //LinkedL.head.next = NN;
                temp.next = NN;
                temp = temp.next;
            }

            //Console.WriteLine(temp);
            print_ll();
            insert_node(3,3);
            print_ll();
            delete(6);
            print_ll();
        }
        public static void insert_node(int position, int value)
        {
            // @params position, integer
            // @params value, integer
            if (position > length +1)
            {
                return;
            }
            Node newnode = new Node(value);
            if (position == 1) //insert head
            {
                newnode.next = head;
                head = newnode;
            }
            else
            {
                int counter = 1;
                Node curr = head;
                while (counter < position-1 )
                {
                    curr = curr.next;
                    counter++;
                }
                newnode.next = curr.next;
                curr.next = newnode;

            }
            length++;

        }

        public static void delete(int position)
        {
            if (position > length)
            {
                return;
            }
            if (position == 1)
            {
                head = head.next;
            }
            else { 
            int counter = 1;
            Node curr = head;
            while (counter < position - 1)
            {
                curr = curr.next;
                counter++;
            }
            
                curr.next = curr.next.next;
            }
            length--;
        }

        public static void print_ll()
        {
            if (length == 0)
                return;

            Node curr = head;
            while (curr.next != null)
            {
                Console.Write(curr.data+" ");
                curr = curr.next;
            }
            Console.Write(curr.data);
        }

        }





    }
