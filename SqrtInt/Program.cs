using System;

namespace SqrtInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int sqrt(int A)
        {
            long l = 1;
            long h = A;
            long ans = 0;

            while (l <= h)
            {
                long m = (l + h) / 2;
                if ((m * m) == A)
                    return (int)(m);

                if ((m * m) < A)
                {
                    ans = m;
                    l = m + 1;
                }
                if ((m * m) > A)
                {
                    h = m - 1;
                }

            }
            return (int)(ans%1000000007);
        }
    }
}
