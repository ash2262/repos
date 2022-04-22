using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(pow(-1,1,20));
        }
        public static int pow(int A, int B, int c)
        {
            if (A == 0) return 0;
            if (B == 0) return 1;

            long p = pow(A, B / 2, c);
            long ha = (p % c * p % c) % c;
            if (B % 2 == 0)
            {
                return (int) ha+c%c;
            }
            else
                return (int) (((ha%c * (A%c))%c) + c) % c;
        }
    }
}
