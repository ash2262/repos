using System;
using System.Collections.Generic;
namespace PairCOunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int>();
            A.Add(1);
            A.Add(2);
            A.Add(3);
            A.Add(2);
            A.Add(1);
            Console.WriteLine("Pair count:" + solve(A, 5));
        }

        private static int solve(List<int> A, int B)
        {
            int pair = 0;
            int secondno = 0;
            HashSet<int> H = new HashSet<int>(A);
            foreach(var item in A)
            {
                secondno = B - item;
                if(H.Contains(secondno))
                {
                    pair++;
                }

            }
            return pair;
        }
    }
}
