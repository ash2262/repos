using System;

namespace PrimeModulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solve(5,3));   //2
            Console.WriteLine(solve(6, 23)); //4

        }
        public static long solve(int A, int B)
        {
            return power(A, B - 2, B);
        }
        static long power(int a, int n, int m)
        {
            if (n == 0)
            {
                return 1;
            }
            long hp = power(a, n / 2, m);
            long ha = ((hp % m) * (hp % m)) % m;
            if (n % 2 == 0)
            {
                return ha;
            }
            else
            {
                return ((ha % m) * a % m) % m;
            }
        }
    }
}
