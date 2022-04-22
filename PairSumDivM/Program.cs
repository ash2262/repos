using System;
using System.Collections.Generic;
namespace PairSumDivM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 1, 2, 3, 4, 5 };
            int B = 2;
            List<int> A = new List<int>(Arr);
            Console.WriteLine(solve(A,B));

            int[] Brr = { 5, 17, 100, 11 };
            int C = 28;
            List<int> AList = new List<int>(Brr);
            Console.WriteLine(solve(AList,C));
        }
        public static int solve(List<int> A, int B)
        {
            int mod = 1000000007;
            Dictionary<int, int> hm = new Dictionary<int, int>();
            for (int i = 0; i < A.Count; i++)
            {
                int X = A[i] % B;

                if (hm.ContainsKey(X))
                {
                    hm[X]++;
                }
                else
                {
                    hm.Add(X, 1);
                }
            }
            int x;
            int c=0;
            if (hm.ContainsKey(0)) 
            { 
                 x = hm[0];
                c = c + ((x * (x - 1)) / 2);
            }
            if (B % 2 == 0)
            {
                if (hm.ContainsKey(B / 2)) { 
                x = hm[B / 2];
                c = c + ((x * (x - 1)) / 2);
                }
            }
            for (int i = 1; i < (B+1)/2; i++)
            {
                if ((hm.ContainsKey(i))&& (hm.ContainsKey(B - i)))
                c = c + (hm[i] * hm[B - i]);
            }
            if (c < 0)
            {
                return (int)(c + mod) % mod;
            }
            return (int)c % mod;
        }
    }
}
