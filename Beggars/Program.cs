using System;
using System.Collections.Generic;

namespace Beggars
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] B = { { 1, 2, 10 }, { 2, 3, 20 }, { 2, 5, 25 } };

            int[,] InputMatrix1 = { { 1, 2, 10 }, { 2, 3, 20 }, { 2, 5, 25 } };
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
        Console.WriteLine("Hello World!");
            //List<List<int>> lst = new List<List<int>>();
            List<int> outlst = new List<int>();
            outlst=solve(5, inputList1);
            for (int j = 0; j < outlst.Count; j++)
            {
                Console.WriteLine(outlst[j]);
            }
        }
        public static List<int> solve(int A, List<List<int>> B)
        {
            List<int> output = new List<int>();
            for (int i = 0; i < A; i++)
            {
                output.Add(0);
            }
            for (int i = 0; i < B.Count; i++)
            {
                int start = B[i][0]-1;
                int end = B[i][1];

                //for (int j = start; j <= end; j++)
                {
                    output[start]=output[start]+ B[i][2];
                    if(end<A)
                    output[end] = output[end] - B[i][2];
                }
            }
            output = prefixSum(output);


            return output;
        }
        public static List<int> prefixSum(List<int> lst)
        {
           // List<int> output = new List<int>();
            
            for (int i = 1; i < lst.Count; i++)
            {
                lst[i]=(lst[i] + lst[i - 1]);
            }
            return lst;
        }
    }
}
