using System;
using System.Collections.Generic;

namespace MaxNoOnes
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] InputMatrix1 = { { 0,0,0,0 }, { 0, 1, 1,1 }, { 1, 1, 1, 1 } };
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
            Console.WriteLine(solve(inputList1));
        }
        public static int solve(List<List<int>> A)
        {
            int cnt = 0;
            int maxcount = 0;
            int ans = int.MaxValue;
            for (int i = 0; i < A.Count; i++)
            {
                
                for (int j  = 0; j < A[i].Count; j++)
                {
                    if ((A[i][j] != 0) &&(j==0))
                         cnt = A[i].Count;
                    else if ((A[i][j]!=0)&&cnt==0)
                    {
                        cnt = A[i].Count - j+1;
                        
                    }

                }
                if (cnt > maxcount)
                {
                    maxcount = cnt;
                    ans = i;
                }

            }
            return ans;
        }
    }
}
