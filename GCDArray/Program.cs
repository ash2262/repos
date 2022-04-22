using System;

namespace GCDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(solve("1", "3")); 
            Console.WriteLine(solve("678728391838182039102", "678728391838182039103"));
        }
        public static string solve(string A, string B)
        {
            long ans = 0;
            long X = int.Parse(A);
            long Y = int.Parse(B);

            for (long i = X; i < Y; i++)
            {
                ans = GCD(ans, i);
            }

            return ans.ToString();
        }

        public static long GCD(long x, long y)
        {
            if (y == 0)
            {
                return x;
            }
            return GCD(y , x%y);
        }
    }

}
