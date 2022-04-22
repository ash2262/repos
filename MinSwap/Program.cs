using System;
using System.Collections.Generic;
namespace MinSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 0 };
            //int[] arr = { 2, 0, 1, 3 };
            List<int> lst = new List<int>(arr);
            Console.WriteLine(MinSwaps(lst));
        }
        public static int MinSwaps(List<int> A)
        {
            int swap = 0;
            int low = 0, high = A.Count;

            while (low < high)
            {
                if (A[low] == low)
                    low++;
                else
                {

                    int temp = A[low];
                    A[low] = A[temp];
                    A[temp] = temp;
                    swap++;
                }
            }
            //for (int i = 0; i < A.Count; i++)
            //{

            //    if (A[i] != i)
            //    {

            //        int temp = A[i];
            //        A[i] = A[temp];
            //        A[temp] = temp;
            //        swap++;
            //    }
            //}
            return swap;
        }
        
    }
}
