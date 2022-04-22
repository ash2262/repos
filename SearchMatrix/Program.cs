using System;
using System.Collections.Generic;
namespace SearchMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] InputMatrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
           // int[,] InputMatrix1 = {{ 2, 8, 8, 8 },{ 2, 8, 8, 8}, { 2, 8, 8, 8} };

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
            Console.WriteLine(solve(inputList1,2));
        }
        public static int solve(List<List<int>> A, int B)
        {
            int output = -1;
            //  int output= BooleanSearch(A, A.Count/2, A[0].Count/2, B);
            int i = 0, j = A[0].Count-1;
            while(( i<A.Count) &&(j>=0))
                {
                //if ((i < 0) || (j < 0))
                //    return -1;

                if (A[i][j] == B)
                { 
                    output=    (((i+1) * 1009) + j+1);
                    j--;
                }

                if (A[i][j] > B)
                {
                    if (j > 0)
                        j--;

                }
                else if (A[i][j] < B)
                    i++;

            }
            return output;

        }
       
        public static int BooleanSearch(List<List<int>> A,int i, int j,int B)
        {
            if ((i < 0)||(j<0))
                return -1;

            if (A[i][j] == B)
                return i * 1009 + j;

            if (A[i][j] > B)
            { 
                if(j>0)
                    BooleanSearch(A, i , j-1,B);
                
            }
            else if (A[i][j] < B)
                BooleanSearch(A, i +1, j, B);

            return -1;
        }
    }
}
