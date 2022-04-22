using System;
using System.Collections.Generic;

namespace PairsWithXor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int[] arr = { 5, 4, 10, 15, 7, 6 };
            int[] arr = { 3, 6, 8, 10, 15, 50 };
            List<int> A = new List<int>(arr);
            Console.WriteLine(solve(A,5));
        }
        public static int solve(List<int> A, int B)
        {
            int count = 0;
            Dictionary<int, int> hm = new Dictionary<int, int>();
            for (int i = 0; i < A.Count; i++)
            {
                int curr_xor = B ^ A[i];

                if (hm.ContainsKey(curr_xor))
                {
                    count += hm[curr_xor];
                }
                if (hm.ContainsKey(A[i]))
                {
                    hm[A[i]]++;
                }
                else
                {
                    hm.Add(A[i], 1);
                }
            }
            return count;
        }
    }
}
