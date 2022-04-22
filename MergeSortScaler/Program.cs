using System;
using System.Collections.Generic;
namespace MergeSortScaler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int> { 1, 4, 10, 2, 1, 5 };
            int n = A.Count-1;
            mergeSort(A, 0, n);
        }
        public static void mergeSort(List<int> A, int s, int e)
        {
			if (s < e)
			{
				int m = (s + e) / 2;
				mergeSort(A, s, m);
				mergeSort(A, m + 1, e);
				merge(A, s, m, e);
			}


		}
        public static void merge(List<int> A, int s, int m, int e)
        {

			// create a temp array
			int[] temp = new int[e - s + 1];

			// crawlers for both intervals and for temp
			int p1 = s, p2 = m + 1, p3 = 0;

			// traverse both arrays and in each iteration add smaller of both elements in temp 
			while (p1 <= m && p2 <= e)
			{
				if (A[p1] <= A[p2])
				{
					temp[p3] = A[p1];
					p3 += 1; p1 += 1;
				}
				else
				{
					temp[p3] = A[p2];
					p3 += 1; p2 += 1;
				}
			}

			// add elements left in the first interval 
			while (p1 <= m)
			{
				temp[p3] = A[p1];
				p3 += 1; p1 += 1;
			}

			// add elements left in the second interval 
			while (p2 <= e)
			{
				temp[p3] = A[p2];
				p3 += 1; p2 += 1;
			}

			// copy temp to original interval
			for (p1 = s; p1 <= e; p1 += 1)
			{
				A[p1] = temp[p1 - s];
			}

		}
	}
}
