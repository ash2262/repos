
using System;

namespace CountDivisors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 2, 3, 4, 5 };
            int[] ans = new int[A.Length];
            ans = solve(A);
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(ans[i]); 
            }
        }
        public List<int> solve(List<int> A)
        {
            {
            int N = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                N = Math.Max(N, A[i]);
            }

            int[] countOfDivisors = new int[N + 1];
            countOfDivisors[1] = 1;
            for (int i = 2; i <= A.Length; i++)
            {
                countOfDivisors[i] = 2;
            }

            for (int i = 2; i*i < A.Length; i++)
            {
                for (int j = i*i; j <= A.Length; j+=i)
                {
                    countOfDivisors[j] += 2;
                }
                countOfDivisors[i * i]--;
            }

            int[] res = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                res[i] = countOfDivisors[A[i]];
            }
            return res;
        }
    }
}
