using System;
using System.Collections.Generic;

namespace Matrices
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int CompareMatrices(List<List<int>> inputList1, List<List<int>> inputList2)
        {
            for (int i = 0; i < inputList1.Count; i++)
            {
                for (int j = 0; j < inputList1[i].Count; j++)
                {
                    if (inputList1[i][j] != inputList2[i][j])
                    {
                        return 0;
                    }
                }
            }

            return 1;
        }
        public static List<List<int>> solve(List<List<int>> A, int B)
        {
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < A.Count; i++)
            {
                List<int> row = A[i];
                for (int j = 0; j < row.Count; j++)
                {
                    row[j] = row[j] * B;
                }
                result.Add(row);
            }
            return result;
        }

        public static int MinorDiagonalSum(List<List<int>> A)
        {
            int sum = 0;

            int i = 0;
            int j = A.Count - 1;
            while (i <= j)
            {
                //for(int i=0;i<A.Count;i++){
                if (i != j) { 
                List<int> row = new List<int>();
                row = A[i];
                sum += row[j];
                row = A[j];
                sum += row[i];
                i++; j--;
                }
                else
                {
                    List<int> row = new List<int>();
                    row = A[i];
                    sum += row[j];
                    i++;j--;
                }
            }
            return sum;
        }
        public static List<List<int>> MatrixTranspose( List<List<int>> A)
        {
            int N=0;
            List<List<int>> B = new List<List<int>>();

            for (int k = 0; k < A[0].Count; k++)
            {
                List<int> row = new List<int>();
                for (int l = 0; l < A.Count; l++)
                {
                    row.Add(0);
                }
                B.Add(row);

            }

           // N = Math.Max(A.Count, A[0].Count);

            for (int j = 0; j < A.Count; j++)
                
            {
                for (int i = 0; i < A[0].Count; i++)
                {
                    B[i][j]= A[j][i];
                    
                }
            }
            return B;
        }

        public static List<List<int>> MatrixMultiplication(List<List<int>> A, List<List<int>> B)
        {
            int r1 = A.Count;
            int c1 = A[0].Count;
            int r2 = B.Count;
            int c2 = B[0].Count;
            List<List<int>> output = new List<List<int>>();

            for (int i = 0; i < A.Count; i++)
            {
                List<int> outrow = new List<int>();
                for (int j = 0; j < B[0].Count; j++)
                {
                    outrow.Add(0);
                }
                output.Add(outrow);
            }

            List<int> Row1 = new List<int>();
            List<int> Row2 = new List<int>();
            
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    for (int k = 0; k < r2; k++)
                    {
                        output[i][j] += (A[i][k] * B[k][j]);
                    }
                }
            }
            return output;
        }
    }
}
