using System;
using System.Collections.Generic;
namespace Ceiling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int ceiling(List<int> lst, int c)
        {

            int l = 0;
            int h = lst.Count - 1;
            int ans = -1;
            while (l <= h)
            {

                if (lst[m] == c)
                {
                    ans = lst[m];
                    return ans;
                }
                if (lst[m] > C)
                {
                    h = m - 1;
                    ans = ar[m];
                }

                if (lst[m] < C)
                {
                    l = m + 1;
                }
            }
            return ans;
        }
    }
}
