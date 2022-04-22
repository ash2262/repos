using System;
using System.Collections.Generic;
namespace SumOfSubMatrices
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] InputMatrix1 = { { 1, 1 },{ 1, 1 } };
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
            Console.WriteLine(SumOfSubMatrices(inputList1));
        }
        public static int SumOfSubMatrices(List<List<int>> A)
        {
            int ans = 0;
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A[0].Count; j++)
                {
                    ans += A[i][j] * (i + 1) * (j + 1) * (A.Count - i) * (A[0].Count - j);

                }
            }
            return ans;
        }
    }
}
