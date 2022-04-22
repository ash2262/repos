using System;
using System.Collections.Generic;
namespace subArrayOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 2, 5, 6 };
            int[] arr = { 2, 2, 2, 2, 2, 2 };
            //int k = 5;
            List<int> A = new List<int>(arr);
            Console.WriteLine(solve(A));
        }
        public static int SubArrayOR(List<int> A)
        {
            long sum = 0;
            int m = 0;
            int recent_one = 0;
            int k = 0;
            for (int i = 0; i < A.Count; i++)
            {
                int sum2 = 0;
                int ele=
                for (int j = 0; j < 32; j++)
                {
                    long ele = (1 << j);
                }

            }
        }
        public static int solve(List<int> A)
        {// This approach is good, but it won't work for large testcases.

            int n = a.Count;
            long sum = 0;
            int mod = 1000000007;
            for (int i = 0; i < n; i++)
            {
                int BitOR = 0;

                for (int j = i; j < n; j++)
                {
                    BitOR = (BitOR | a[j]) % mod;
                    sum = (sum % mod + BitOR % mod) % mod;
                }
            }

            return (int)sum % mod;
        }
    }
}
