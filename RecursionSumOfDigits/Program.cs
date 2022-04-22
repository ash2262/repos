using System;

namespace RecursionSumOfDigits
{
    class Program
    {
        public static int ans = 0;
        static void Main(string[] args)
        {
            Console.WriteLine(solve(1234));
        }
        
        public static int solve(int A)
        {
            if (A == 0)
                return ans;
            return (A % 10 + solve(A / 10));

        }
    }
}
