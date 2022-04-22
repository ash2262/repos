using System;
using System.Collections.Generic;

namespace RotateMatrix
{
   public class Program
    {
         static void Main(string[] args)
        {
            int[,] InputMatrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] InputMatrix2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

           // RotateMatrix(InputMatrix1, InputMatrix2);
           
        }

        public static int[,]  RotateMatrix(int[,] inputMatrix1, int[,] inputMatrix2)
        {
            int[,] OutputMatrix=new int[inputMatrix1.GetLength(0),inputMatrix1.GetLength(1)];
            for (int i = 0; i < inputMatrix1.GetLength(0); i++)
            {
                for (int j = 0; j < inputMatrix1.GetLength(1); j++)
                {
                    OutputMatrix[i, j] = inputMatrix1[i, j] + inputMatrix2[i, j];
                }
            }

            return OutputMatrix;

        }

        public static List<List<int>> AddMatrix(List<List<int>> inputMatrix1, List<List<int>> inputMatrix2)
        {
            // throw new NotImplementedException();
            List<List<int>> output = new List<List<int>>();
            
            List<int> Row1 = new List<int>();
            List<int> Row2 = new List<int>();
            int sum=0;
            for (int i = 0; i < inputMatrix1.Count; i++)
            {
                List<int> RowOutput = new List<int>();
                Row1 = inputMatrix1[i];
                Row2 = inputMatrix2[i];
                for (int j = 0; j < Row1.Count; j++)
                {
                    sum = Row1[j] + Row2[j];
                    RowOutput.Add(Row1[j] + Row2[j]);
                }
                output.Add(RowOutput);
            }
            return output;
        }

        public static List<int> AddMatrixColumn(List<List<int>> inputList1)
        {
           
            List<int> sum = new List<int>();
            
            //throw new NotImplementedException();
            for (int i = 0; i < inputList1.Count; i++)
            {
                
                List<int> row = new List<int>();
                row = inputList1[i];
                for (int j = 0; j < row.Count; j++)
                {
                    if (sum.Count < j+1) { sum.Add(0); }
                    
                    sum[j] = sum[j] + row[j];

                }
            }
            return sum;
        }

        public static List<List<int>>  TransposeMatrix(List<List<int>> A)
        {
            for (int i = 0; i < A.Count; i++)
            {
                List<int> row = new List<int>();
                row = A[i];
                for (int j = i+1; j < row.Count; j++)
                {
                    int temp = A[i][j];
                    A[i][j] = A[j][i];
                    A[j][i] = temp;
                }
            }
            return A;
        }

        public static List<int> AddMatrixRows(List<List<int>> A)
        {
            List<int> result=new List<int>();
            int sum = 0;
            for (int i = 0; i <A.Count ; i++)
            {
                 sum = 0;
                List<int> row = new List<int>();
                row = A[i];
                for (int j = 0; j < row.Count; j++)
                {
                    sum = sum + row[j];
                }
                result.Add(sum);
            }
            return result;
        }
    }
}
