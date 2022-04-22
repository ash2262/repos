using System;
using System.Collections.Generic;
namespace MatrixSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[,] InputMatrix1 = { { 1, 3, 5, 7 }, { 10, 11, 16, 20 }, { 23, 30, 34, 50 } };
            // int[,] InputMatrix1 = { { 3 }, { 29}, { 36},{ 63} };
            int[,] InputMatrix1 = { { 1 } };
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
            Console.WriteLine(searchMatrix(inputList1,1));
        }
        public static int searchMatrix(List<List<int>> A, int B)
        {
            int n = A.Count, m = A[0].Count;
            //assume all elements are added to a list and after that it is sorted
            //last index will be n * m - 1
            int low = 0, high = n * m - 1, ans = -1;
            while (low <= high)
            {
                int mid = (high - low) / 2 + low;
                int row = mid / m, col = mid % m;
                if (A[row][col] > B)
                    high = mid - 1;
                else
                {
                    ans = mid;
                    low = mid + 1;
                }
            }
             if(ans == -1 || A[ans / m][ans % m] != B) 
                return 0;

            return 1;
        }
        public static int BinarySearch(List<int> A, int b, int l, int r)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;
                if (A[mid] == b) return mid;

                if (A[mid] > b)
                    BinarySearch(A, b, l, mid - 1);

                return BinarySearch(A, b, mid + 1, r);
            }
            return r ;
        }
    }
}
