using System;
using System.Collections.Generic;
namespace pubg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 6, 4 };
            List<int> ALst = new List<int>(A);
            Console.WriteLine(solve(ALst)); 
        }
        public static int solve(List<int> A)
        {
            int ans = A[0];

            for (int i = 1; i < A.Count; i++)
            {
                ans = gcd(ans, A[i]);
            }

            return ans;
        }
        public static int gcd(int A, int B)
        {
            if (B == 0)
            {
                return A;
            }

            else
            {
                return gcd(B, A % B);
            }
        }
    }
}
