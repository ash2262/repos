using System;
using System.Collections.Generic;
namespace DistanceFromOrigin
{
    class Program
    {
        static void Main(string[] args)
        {

            List<List<int>> OutLst = new List<List<int>>();
            int B = 1;
            //int[,] InputMatrix1 = { { 1, 2 }, { 4, 5 }, { 7, 8 } };
            int[,] InputMatrix1 = { { 1, 3 }, { -2, 2 } };
            List<List<int>> A = new List<List<int>>();

            for (int i = 0; i < InputMatrix1.GetLength(0); i++)
            {
                List<int> Row = new List<int>();
                for (int j = 0; j < InputMatrix1.GetLength(1); j++)
                {
                    Row.Add(InputMatrix1[i, j]);
                }
                A.Add(Row);
            }
            A.Sort((first, second) =>
            {
                if (Math.Sqrt( (first[0] * first[0]) + (first[1] * first[1])) > Math.Sqrt((second[0] * second[0]) + (second[1] * second[1])))
                    return 1;
                return 0;
            });
            for (int i = 0; i < B; i++)
            {
                OutLst.Add(A[i]);
            }
            Console.WriteLine("done");
        }
    }
}
