using System;

namespace SortedPermutationRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findRank("acb"));
        }
        public static int findRank(string A)
        {
            int n = A.Length;
            long count = 0;
            long ans = 0;
            int mod = 1000003;
            for (int i = 0; i < n; i++)
            {
                count = 0;
                for (int j = i + 1; j < n; j++)
                {
                    if (A[j] < A[i])
                    {
                        count++;
                    }
                }
                ans += (count * fact(n - i - 1)) % mod;
            }
            return (int)(ans + 1) % mod;

        }
        public static long fact(int n)
        {
            if (n == 0) return 1;
            int mod = 1000003;
            return (n * fact(n - 1)) % mod;
        }
    }
}
