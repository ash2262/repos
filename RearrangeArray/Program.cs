using System;
using System.Collections.Generic;
namespace RearrangeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,0 };
            List<int> lst = new List<int>(arr);
            arrange(lst);
        }

        public static void arrange(List<int> A)
        {
            int N = A.Count;

            for (int i = 0; i < N; i++)
            {
                A[i] = A[i] * N;
            }

            for (int i = 0; i < N; i++)
            {
                int ind=A[i]/N;
                int val = A[ind] / N;
                A[i] += val;
            }
            for (int i = 0; i < N; i++)
            {
                A[i] = A[i] % N;
            }
        }
    }
}
