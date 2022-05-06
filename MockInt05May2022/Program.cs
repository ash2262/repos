using System;

namespace MockInt05May2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //to be done in homework
            int[] A = { 4, 5, 6, 7, 1, 2, 3 };
        }
        public static int FindMin(int[] A, int x)
        {
            int l = 0;
            int r = A.Length;

            while (l < r)
            {
                int m = (l + r) / 2;

                if (A[m] == x)
                    return m;
                if (A[m] > x)
                {
                    
                    r = m - 1;
                }
                else if((A[m] < x)&&(A[l]<x) )
                {
                    l = m + 1;
                }
            }

            return -1;
        }

    }
}
