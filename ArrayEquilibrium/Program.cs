using System;
using System.Collections.Generic;

namespace ArrayEquilibrium
{
    class Solution
    {
        public static void Main()
        {


            List<int> lst = new List<int>();
            lst.Add(-7);
            lst.Add(1);
            lst.Add(5);
            lst.Add(2);
            lst.Add(-4);
            lst.Add(3);
            lst.Add(0);
            Console.WriteLine(solve(lst));
            Console.ReadKey();
         }
        public static int solve(List<int> A)
        {
            List<int> PFSum = new List<int>();
            PFSum = ConstructPrefixSum(A);
            int Left = 0;
            int Right = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (i == 0)
                {
                    Left = PFSum[0];
                }
                else
                {
                    Left = PFSum[i - 1];
                }
                Right = PFSum[A.Count - 1] - PFSum[i];
                if (Left == Right)
                    return i;

            }
            return -1;
        }
        private static List<int> ConstructPrefixSum(List<int> B)
        {
            List<int> PFSum = new List<int>();
            for (int i = 0; i < B.Count; i++)
            {
                if (i == 0)
                {
                    PFSum.Add(B[i]);
                }
                else
                {
                    PFSum.Add(PFSum[i - 1] + B[i]);
                }
            }
            return PFSum;
        }
        public List<int> CalculatePFLeft(A)
        {
            List<int> PFLeft = new List<int>();
            for (int i = 0; i < B.Count; i++)
            {
                if (i == 0)
                {
                    PFLeft.Add(A[i]);
                }
                else
                {
                    PFLeft.Add(PFLeft[i - 1] + A[i]);
                }
            }
            return PFLeft;
        }
    }

}
