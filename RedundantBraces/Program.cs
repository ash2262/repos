using System;
using System.Collections.Generic;
namespace RedundantBraces
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "((a+b))";
            Console.WriteLine(braces(A)); 
        }
        public static int braces(string A)
        {
            var stack = new Stack<char>();
            foreach (var ch in A)
            {
                if (ch !=')'){
                    stack.Push(ch);
                }else
                {
                    int token = 0;
                    while (stack.Peek() !='('){
                        stack.Pop();
                        token++;
                    }
                    if (token == 0 || token == 1)
                    {
                        return 1;
                    }
                    stack.Pop();
                }
            }
            return 0;
        }
    }
}
