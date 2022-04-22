using System;
using System.Collections.Generic;
namespace MinStack
{
    class Program
    {
        //public static List<int> lst = new List<int>();
        public static Stack<int> stack = new Stack<int>();
        public static List<int> lst = new List<int>();
        
        static void Main(string[] args)
        {

            //push(1);
            //push(2);
            //push(-2);
            //Console.WriteLine(getMin());
            //pop();
            //Console.WriteLine(getMin());
            //Console.WriteLine(top());

            Console.WriteLine(getMin());
            pop();
            Console.WriteLine(top());
        }
        public static void push(int x)
        {
            if (stack.Count == 0)
            {
                // minEle = x;
                lst.Add(x);
            }
            if (lst[lst.Count - 1] > x)
            {
                lst.Add(x);
            }
            
            stack.Push(x);
            
            //lst.Add(x);
        }

        public static void pop()
        {
            if (stack.Count > 0) {
                if (stack.Peek() == lst[lst.Count-1])
                {
                    stack.Pop();
                    lst.Remove(lst[lst.Count - 1]);
                    
                }
                else { 
                stack.Pop();
                }
            }
        }

        public static int top()
        {
            if (stack.Count == 0)
                return -1;
            return stack.Peek();
        }

        public static int getMin()
        {
           lst.Sort();
            
            if (stack.Count == 0)
            {
                return -1;
            }
           
            return lst[lst.Count - 1];
        }
    }
}
