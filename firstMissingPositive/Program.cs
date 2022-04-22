using System;
using System.Collections.Generic;
namespace firstMissingPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int[] arrA = { 1,2,0};
            // int[] arrA = { 3,4,-1,1};
            //int[] arrA = { -8,-7,-6};
            int[] arrA = { 1,1};
            List<int> A = new List<int>(arrA);
            Console.WriteLine(firstMissingPositive(A));

        }
        public static int firstMissingPositive(List<int> A)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < A.Count; i++)
            {
                hs.Add(A[i]);
            }
            for (int j = 1; j < A.Count+1; j++)
            {
                if (!hs.Contains(j))
                    return j;
            }
            return 1;
        }

    }
}
