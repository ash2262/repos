using System;
using System.Collections.Generic;
namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 10, 2, 1, 5 };
            List<int> A = new List<int>(arr);
            solve(A);
        }
        public static List<int> solve(List<int> A)
        {
            int s = 0; int e = A.Count - 1;
            Qsort(A, s, e);
            return A;
        }
        public static void Qsort(List<int> A, int s, int e)
        {
            if (s >= e) return;

            int p = rearrange(A, s, e);
            Qsort(A, s, p - 1);
            Qsort(A, p + 1, e);
            
        }
        public static List<int> swap(List<int> A, int p1, int p2)
        {
            int temp = A[p1];
            A[p1] = A[p2];
            A[p2] = temp;
            return A;
        }
        public static int rearrange(List<int> A, int s, int e)
        {
            Random r = new Random();
            int ran=r.Next(s, e);
            //int ran = int.Parse(r.ToString());
            swap(A,s, ran);
            int n = A.Count - 1;
            int p1 = s + 1;
            int p2 = e;

            while (p1 <= p2)
            {
                if (A[s] >= A[p1]) p1++;
                else if (A[s] < A[p2]) p2--;
                else
                {
                    swap(A, p1, p2);
                    p1++;
                    p2--;
                }
            }
            swap(A, s, p1-1);
            return p1-1;
        }
    }
}
