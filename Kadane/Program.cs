using System;
using System.Collections.Generic;

namespace Kadane
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] A = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int[] A = { -500 };
            List<int> lstA = new List<int>(A);
            Console.WriteLine(maxSubArray(lstA));
        }
        public static int maxSubArray(List<int> A)
        {
            int maxTillNow = int.MinValue;

            int sum = 0;
            for (int j = 0; j < A.Count; j++)
            {


                sum += A[j];


                maxTillNow = Math.Max(sum, maxTillNow);
                if (sum < 0)
                    sum = 0;


            }
            return maxTillNow;
        }
    }
}
