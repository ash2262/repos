/*
 * Count ways to make sum of odd and even indexed elements equal by removing an array element
 * Problem Description

Given an array, arr[] of size N, the task is to find the count of array indices such that removing an element from these indices makes the sum of even-indexed and odd-indexed array elements equal.



Problem Constraints

1<=n<=1e5
-1e5<=A[i]<=1e5


Input Format

First argument contains an array A of integers of size N


Output Format

Return the count of array indices such that removing an element from these indices makes the sum of even-indexed and odd-indexed array elements equal.



Example Input

Input 1:
A=[2, 1, 6, 4]
Input 2:

A=[1, 1, 1]


Example Output

Output 1:
1
Output 2:

3


Example Explanation

Explanation 1:
Removing arr[1] from the array modifies arr[] to { 2, 6, 4 } such that, arr[0] + arr[2] = arr[1]. 
Therefore, the required output is 1. 
Explanation 2:

 Removing arr[0] from the given array modifies arr[] to { 1, 1 } such that arr[0] = arr[1] 
Removing arr[1] from the given array modifies arr[] to { 1, 1 } such that arr[0] = arr[1] 
Removing arr[2] from the given array modifies arr[] to { 1, 1 } such that arr[0] = arr[1] 
Therefore, the required output is 3.


 * */
using System;
using System.Collections.Generic;


namespace ArraySumofOddEvenIdx
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 7, 1, 2, 3 };
            //int[] arr = { 2,1,6,4};

            List<int> lst = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                lst.Add(arr[i]);
            }
            
            
            Console.WriteLine(solve(lst));
            Console.ReadKey();
        }
        public static int solve(List<int> A)
        {
            List<int> PFEven = new List<int>();
            List<int> PFOdd = new List<int>();
            int TotalEven = 0;
            int TotalOdd = 0;
            int Count = 0;
            PFEven = ConstructPFEven(A);
            PFOdd = ConstructPFOdd(A);

            for (int i = 0; i < A.Count; i++)
            {
                if(i==0)
                {
                    TotalEven = PFEven[i] + (PFOdd[A.Count - 1] - PFOdd[i]);
                    TotalOdd = PFOdd[i] + (PFEven[A.Count - 1] - PFEven[i]);
                }
                else
                {
                    TotalEven = PFEven[i - 1] + (PFOdd[A.Count - 1] - PFOdd[i]);
                    TotalOdd = PFOdd[i - 1] + (PFEven[A.Count - 1] - PFEven[i]);
                }
                

                if (TotalEven == TotalOdd)
                {
                    Count++;
                }
            }
            return Count;

        }

        public static List<int> ConstructPFEven(List<int> A)
        {
            List<int> lst = new List<int>();

            for (int i = 0; i < A.Count; i++)
            {
                if(i==0)
                {
                    lst.Add(A[i]);
                }
               else if (i % 2 == 0)
                    lst.Add(lst[i - 1] + A[i]);
                else
                    lst.Add(lst[i - 1]);
            }
            return lst;

        }
        public static List<int> ConstructPFOdd(List<int> A)
        {
            List<int> lst = new List<int>();

            for (int i = 0; i < A.Count; i++)
            {
                if (i == 0)
                {
                    lst.Add(0);
                }
               else if (i % 2 == 0)
                    lst.Add(lst[i - 1]);
                else
                    lst.Add(lst[i - 1] + A[i]);
        }
        return lst;

    }

}
}
