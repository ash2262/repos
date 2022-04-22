using System;
using System.Collections.Generic;

namespace subMatrixSumQueries
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] InputMatrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
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
            
            List<int> B = new List<int>();
            B.Add(1);
            B.Add(2);
            List<int> C = new List<int>();
            C.Add(1);
            C.Add(2);
            List<int> D = new List<int>();
            D.Add(2);
            D.Add(3);
            List<int> E = new List<int>();
            E.Add(2);
            E.Add(3);
            List<int> output = new List<int>();

            output = solve(inputList1, B, C, D, E);
            Console.WriteLine("Hello World!");
        }
        public static List<int> solve(List<List<int>> A, List<int> B, List<int> C, List<int> D, List<int> E)
        {
            int mod = 1000000007;
            List<int> output = new List<int>();
            List<List<int>> PF = new List<List<int>>();
            for (int i = 0; i < A.Count; i++)
            {
                List<int> pfrow = new List<int>();
                
                for (int j = 0; j < A[0].Count; j++)
                {
                    pfrow.Add(0);
                    
                }
                PF.Add(pfrow);

            }

            for (int i = 1; i < A.Count; i++)
            {
                for (int j = 2; j < A[0].Count; j++)
                {
                    PF[i][j] = PF[i][j-1]+ A[i-1][j-1];
                }
            }
            for (int k = 2; k < PF.Count; k++)
            {
                for (int l = 1; l < PF[0].Count; l++)
                {
                    PF[0][k] = PF[l-1][k] + PF[l][k];
                }
                
            }

            for (int i = 0; i < B.Count; i++)
            {
                int a1 = B[i],  b1 = C[i], a2 = D[i],b2 = E[i];
                long ans = PF[a2][b2] - PF[a2][b1 - 1] - PF[a1 - 1][b2] + PF[a1-1][b1-1];
                while (ans < 0)
                    ans += mod;
                ans = ans % mod;
                output.Add((int)ans);
            }
            

            return output;
        }
    }
}
