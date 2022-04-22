using System;
using System.Collections.Generic;
namespace PrimeSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] Arr = { 1, 2, 3 };
            int[] Arr = { 9, 4, 9, 1, 5 };
            List<int> A = new List<int>(Arr);
            Console.WriteLine(solve(A));
        }

        public static int solve(List<int> A)
        {
            int count = 0;
            int mod = 1000000007;
            int num = 1;
            
            for (int i = 0; i < A.Count; i++)
            {
                if(isPrime(A[i]))
                {
                    count = count % mod + num % mod;
                    count = count % mod;
                    num = num % mod + num % mod;
                    num = num % mod;

                }
            }
            return count;
        }

        public static bool isPrime(int N)
        {
            if (N < 2)
                return false;
            for (int i = 2; i*i <= N; i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }
    }
}
