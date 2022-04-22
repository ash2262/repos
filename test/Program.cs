using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            while(i<100)
            {
                sum = sum + i;
                sum = i + sum;
                i += 1;

            }
            
            Console.WriteLine(sum);
        }

        private static int fun(int a)
        {
            if (a <= 1)
            {
                return a;
            }

            return fun(a - 1) + fun(a - 2);
        }
    }
}
