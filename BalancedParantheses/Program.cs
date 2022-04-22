using System;
using System.Collections.Generic;

namespace BalancedParantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solve("))((()(())"));
            Console.WriteLine(solve("(()())"));
            Console.WriteLine(solve("(()"));
            Console.WriteLine(solve("({)}"));
            //Console.WriteLine(solve("{ ([])}"));
            //Console.WriteLine(solve("(){"));
            //Console.WriteLine(solve("()[]"));
            //Console.WriteLine(solve("}}}}}}}}}}}}}}}}}}"));
        }
        public static int solve(string A)
        {
            //int count = 0;
            string x;
            Stack<char> st=new Stack<char>();
            
            for (int i = 0; i < A.Length; i++)
            {
                if (st.Count == 0)
                {
                    st.Push(A[i]);
                }
                else
                {
                    x = st.Peek().ToString();
                    if(x+A[i]=="{}"|| x + A[i] == "[]"|| x + A[i] == "()")
                    {
                        st.Pop();
                    }
                    else
                    {
                        st.Push(A[i]);
                    }
                }
               
            }

            if (st.Count== 0)
                return 1;
            else
            {

                return 0;
            }
        }
    }
}
