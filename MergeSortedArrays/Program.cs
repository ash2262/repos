using System;
using System.Collections.Generic;

namespace MergeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A=new List<int>{ -4,3};
            List<int> B = new List<int> { -2, -2 };
            solve(A, B);
            
            Console.WriteLine("Hello World!");
        }
        public static List<int> solve(List<int> A, List<int> B)
        {
            List<int> c = new List<int>();

            int n = A.Count;
            int m = B.Count;

            int p1 = 0, p2 = 0, p3 = 0;
            while (p1 < n && p2 < m)
            {
                if (A[p1] < B[p2])
                {
                    c.Add(A[p1]);
                    p1++;

                }
                else
                {
                    c.Add(B[p2]);
                    p2++;
                }
            }
            while (p1 < n)
            {
                c.Add(A[p1]);
                p1++;
            }
            while (p2 < m)
            {
                c.Add(B[p2]);
                p2++;
            }
            return c;
        }
    }
}
