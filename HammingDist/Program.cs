using System;
using System.Collections.Generic;
namespace HammingDist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 2, 4, 6 };
            List<int> lst = new List<int>(arr);
            Console.WriteLine(hammingDistance(lst));
        }
        public static int hammingDistance(List<int> A)
        {
            int set = 0;
            long count = 0;
            long ans = 0;
            long mod = 1000000007;
            for (int i = 0; i <= 30; i++)
            {
                set = 0;
                for (int j = 0; j < A.Count; j++)
                {
                    if (((A[j]>>i) & 1) == 1)
                        set++;
                }
                count = 2L * set * (A.Count - set) % mod;
                ans += count;
                //if (ans >= mod)
                //    ans = ans - mod;
            }
            return (int)ans;
        }
    }
}
