using System;

namespace TimeComplexity3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(foo(3,5));
            Console.ReadKey();
        }

        private static int foo(int x, int y)
        {
            if (y == 0) return 1;

            return bar(x , foo(x, y-1));
        }

        private static int bar(int x, int y)
        {
            if (y == 0) return 0;
            return (x + bar(x, y - 1));
        }
    }
}
