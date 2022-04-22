using System;
using System.Collections.Generic;
namespace MaximumSatisfaction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 10, 20, 15, 4, 14 };
            List<int> A = new List<int>(Arr);
            Console.WriteLine(solve(A));

        }
        public static int solve(List<int> A)
        {
            int n = A.Count;
            int ans = 0;
            for (int i = 30; i >= 0; --i)
            {
                int temp = ans | (1 << i);
                if (check(temp, A))
                    ans = temp;
            }
            return ans;
        }
        public static bool check(int x, List<int> a)
        {
            int y = 0;
            foreach (int it in a)
                if ((it & x) == x)
                    ++y;
            return (y > 3) ? true : false;
        }
    }
}
