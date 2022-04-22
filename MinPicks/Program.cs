using System;
using System.Collections.Generic;
namespace MinPicks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int>();
            A.Add(1);
            A.Add(2);
            A.Add(2);
            A.Add(1);

            List<int> B = new List<int>();
            B.Add(2);
            B.Add(3);
            B.Add(1);
            B.Add(2);
            
            List<int> result = new List<int>();
            result = solve(A, B);
            foreach (var item in result)
                Console.Write(item);
        }
        public static List<int>  solve(List<int> A, List<int> B)
        {

            HashSet<int> h = new HashSet<int>(A);

            List<int> result = new List<int>();
            foreach (var item in B)
            {
               
                if(h.Contains(item)&&(!result.Contains(item)))
                {
                    result.Add(item);
                }

                
            }
            return result;
        }
    }
}
