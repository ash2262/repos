using System;
using System.Collections.Generic;

namespace MaxSumSubmatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[,] matrix = { { 0, -2, -7, 0 },
            //          { 9, 2, -6, 2 },
            //          { -4, 1, -4, 1 },
            //          { -1, 8, 0, -2 } };

            //int[,] InputMatrix1 ={{-6, -21, 27, 19, 19},
            //                      {0, 0, 5, -21, 19},
            //                      {18, -27, -2, -7, 13},
            //                      {-21, -17, -25, -1, 3},
            //                      {0, -9, -6, -16, -5},
            //                      {29, 9, -25, -7, -25}};
            int[,] InputMatrix1 = {{-5,-4,-3},
                                    {-1,2,3},
                                    {2,2,4}};

            List<List<int>> inputList1 = new List<List<int>>();

            for (int i = 0; i < InputMatrix1.GetLength(0); i++)
            {
                List<int> Row = new List<int>();
                for (int j = 0; j < InputMatrix1.GetLength(1); j++)
                {
                    Row.Add(InputMatrix1[i, j]);
                }
                inputList1.Add(Row);
            }

            // Function Call
            Console.WriteLine(maxSubmatrixSum(inputList1));
            

        }
        static int maxSubmatrixSum(List<List<int>> A)
        {
            
            //int[,] A=new int[input.Count,input[0].Count];
            //for (int i = 0; i < input.Count; i++)
            //{
            //    for (int j = 0; j < input[0].Count; j++)
            //    {
            //        A[i, j] = input[i][ j];
            //    }
            //}
            
            // Store the rows and columns
            // of the matrix
            int r = A.Count;
            int c = A[0].Count;

            // Create an auxiliary matrix
            int[,] prefix = new int[r, c];

            // Traverse the matrix, prefix
            // and initialize it will all 0s
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    prefix[i, j] = 0;
                }
            }

            // Calculate prefix sum of all
            // rows of matrix [,]A and
            // store in matrix prefix[]
            for (int i = 0; i < r; i++)
            {

                for (int j = 0; j < c; j++)
                {

                    // Update the prefix[,]
                    if (j == 0)
                        prefix[i, j] = A[i][ j];
                    else
                        prefix[i, j] = A[i][j] + prefix[i, j - 1];
                }
            }

            // Store the maximum submatrix sum
            int maxSum = int.MinValue;

            // Iterate for starting column
            for (int i = 0; i < c; i++)
            {

                // Iterate for last column
                for (int j = i; j < c; j++)
                {

                    // To store current array
                    // elements
                    List<int> v = new List<int>();

                    // Traverse every row
                    for (int k = 0; k < r; k++)
                    {

                        // Store the sum of the
                        // kth row
                        int el = 0;

                        // Update the prefix
                        // sum
                        if (i == 0)
                            el = prefix[k, j];
                        else
                            el = prefix[k, j]
                            - prefix[k, i - 1];

                        // Push it in a vector
                        v.Add(el);
                    }

                    // Update the maximum
                    // overall sum
                    maxSum = Math.Max(maxSum, kadane(v));
                }
            }

            return maxSum;
        }
        static int kadane(List<int> v)
        {

            // Stores current and maximum sum
            int currSum = 0;
            int maxSum = int.MinValue;

            // Traverse the array v
            for (int i = 0;
                 i < (int)v.Count; i++)
            {

                // Add the value of the
                // current element
                currSum += v[i];

                // Update the maximum sum
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                }

                if (currSum < 0)
                {
                    currSum = 0;
                }
            }

            // Return the maximum sum
            return maxSum;
        }

    }
}
