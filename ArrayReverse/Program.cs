using System;
using System.Collections.Generic;
namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int>();
            A.Add(1);
            A.Add(2);
            A.Add(3);
            A.Add(2);
            A.Add(1);
            int i = 0;
            int j = A.Count-1;
            int[] Swapped;
            while (i < j)
            {
               Swapped= swap(i, j,A.ToArray());
                
                i++; j--;
            }
            //return A;
        }
        public static int[] swap(int i, int j, int[] A)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
            return A;
        }
    }
}
