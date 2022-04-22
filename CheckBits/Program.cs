using System;
using System.Collections.Generic;
namespace CheckBits
{
    class Program
    {
        static void Main(string[] args)
        {

            // int[,] InputMatrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //int[,] InputMatrix1 = { { -6, -6 }, { -29,-8 }, { 3,-8 }, { -15, 2 }, { 25, 25 }, { 20, -5 } };

            int[,] InputMatrix1 ={{-6, -21, 27, 19, 19},
                                  {0, 0, 5, -21, 19},
                                  {18, -27, -2, -7, 13},
                                  {-21, -17, -25, -1, 3},
                                  {0, -9, -6, -16, -5},
                                  {29, 9, -25, -7, -25}};

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
            Console.WriteLine(MaxSumSubMatrix(inputList1));
            //int N =11;
            //Console.WriteLine(checkBits(N));
            //int[] Arr = { 1, 2, 2, 3, 1 };
            //List<int> lst = new List<int>(Arr);
            //Console.WriteLine(singleNumber(lst)); 
        }
        public static int checkBits(int n)
        {
            int cnt = 0;
            while (n > 0)
            {
                cnt += n & 1;
                n >>= 1;
            }
            return cnt;
        }
        public static int singleNumber(List<int> A)
        {
            int output = A[0];
            for (int i = 1; i < A.Count ; i++)
            {
                output = output ^ A[i];

            }
            return output;
        }
        public static int MaxSumSubMatrix(List<List<int>> A)
        {
            int MaxSum = int.MinValue;
            int[,] prefixsum = new int[A.Count, A[0].Count];
            
            

            for (int Start = 0; Start < A.Count; Start++)
            {
                List<int> row = new List<int>();
                for (int end = Start; end < A.Count; end++)
                {

                    for (int j = 0; j < A[0].Count; j++)
                    {
                        if (j == 0)
                            row.Add(A[end][j]);
                        else
                           row.Add(A[end][j] + row[j - 1]);
                           
                    }
                    int value = MaxSubArraySum(row, A[0].Count);
                    MaxSum = Math.Max(MaxSum, value);
                }
                
                

            }
            return MaxSum;
        }
        public static int MaxSubArraySum(List<int> input, int n)
        {
            int ans = 0;
            int maxsum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                ans += input[i];
                maxsum = Math.Max(maxsum, ans);
                if (ans < 0)
                    ans = 0;
            }
            return maxsum;
        }
    }
}
