using System;
using System.Collections.Generic;

namespace ArrPickBothSides
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrA = { -533, -666, -500, 169, 724, 478, 358, -38, -536, 705, -855, 281, -173, 961, -509, -5, 942, -173, 436, -609, -396, 902, -847, -708, -618, 421, -284, 718, 895, 447, 726, -229, 538, 869, 912, 667, -701, 35, 894, -297, 811, 322, -667, 673, -336, 141, 711, -747, -132, 547, 644, -338, -243, -963, -141, -277, 741, 529, -222, -684, 35 };
            int B = 48;

            //int[] arrA = { 5, -2, 3, 1, 2 };
            //int B = 3;
            //int[] arrA = { 1, 2 };
            //int B = 1;

            List<int> A = new List<int>();
            for (int i = 0; i < arrA.Length; i++)
            {
                A.Add(arrA[i]);
            }
            Console.WriteLine(solve(A,B));
        }
        public static int solve(List<int> A, int B)
        {
            //Declare variables
            int MaxSum = int.MinValue;
            int Sum = int.MinValue;
            //Calculate the Prefix Sum Left and right
            List<int> PFLeft = new List<int>();
            PFLeft = CalculatePFLeft(A);
            List<int> PFRight = new List<int>(CalculatePFRight(A));
            if (PFRight[B-1] > PFLeft[B-1])
                MaxSum = PFRight[B-1];
            else
                MaxSum = PFLeft[B-1];
            if (B < 2)
            {
                return MaxSum;
            }

            int RightSumLength = PFRight.Count-1;
            for (int i = 0; i < B; i++)
            {
                if (i == 0)
                {
                    Sum = PFLeft[i] + PFRight[(B-2)];
                }
                else 
                { 
                    Sum = PFLeft[i] + PFRight[(B-1)-i];
                }
                if (Sum > MaxSum)
                {
                    MaxSum = Sum;
                }

            }

            return MaxSum;
        }

        public static List<int> CalculatePFLeft(List<int> A)
        {
            List<int> PFLeft = new List<int>();
            for (int i = 0; i < A.Count; i++)
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
        public static List<int> CalculatePFRight(List<int> A)
        {
            List<int> PFRight = new List<int>();
            for (int i = A.Count; i >0; i--)
            {
                if (i == A.Count)
                {
                    PFRight.Add(A[i-1]);
                }
                else
                {
                    PFRight.Add(PFRight[A.Count-(i+1)] + A[i-1]);
                }
            }
            return PFRight;
        }

    }
}
