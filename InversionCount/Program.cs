using System;
using System.Collections.Generic;
namespace InversionCount
{
    class Program
    {
		public static int mod = (int)Math.Pow(10, 9) + 7;
		static void Main(string[] args)
        {
			
			int[] A = { 1, 2, 3 };
			List<int> lst = new List<int>(A);
			
            Console.WriteLine(solve(lst));
        }
        public static int solve(List<int> A)
        {
			return inver(A, 0, A.Count - 1);
        }
        public static int inver(List<int> A, int s, int e)
        {
            if (s == e)
            {
                return 0;
            }

            int m = (s + e) / 2;
            int L = inver(A, s, m);
            int R = inver(A, m+1, e);
            int C = merge(A, s, m, e);
            return L + R + C;
        }
		public static int merge(List<int> A, int s, int m, int e)
		{

			// create a temp array
			int[] temp = new int[e - s + 1];
			int count = 0;
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
					count = (count+(m - p1 + 1))%mod;
					if (count < 0) count = 0;
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
			return count;
		}
	}
}
