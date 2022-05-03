using System;
using System.Collections.Generic;
namespace SpecialInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(solve(lst,10));
            Console.WriteLine(solve1(lst, 10));
        }
        public static int solve1(List<int> A, int B)
        {
            int N = A.Count;
            int l = 0, ans = N;
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += A[i];
                while (sum > B)
                {
                    sum -= A[l++];
                    if (ans > i - l)
                    {
                        ans = i - l;
                    }
                }
                if (sum == 0)
                {
                    return 0;
                }
            }
            return Math.Min(ans + 1, N);
        }
        public static int solve(List<int> A, int B)
        {
            int N = A.Count;
            int l = 0;
            int ans = N;
            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                sum += A[i];

                while (sum > B)
                {
                    sum -= A[l++];
                    if (ans > i - l)
                        ans = i - l;
                }
                if (sum == 0)
                    return 0;
            }

            return Math.Min(ans + 1, N);

        }
        

    }

}
