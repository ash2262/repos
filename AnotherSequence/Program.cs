using System;

namespace AnotherSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solve(3));
        }
        public static int ans = 0;
        public static int solve(int A)
        {
            return (A <= 1) ? 1 : (A == 2) ? A :solve(A - 1) + solve(A - 2) + solve(A - 3) + A;
        }
    }
}
