using System;

namespace ChocolateDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] arr = { 3, 4, 1, 9, 56, 7, 9, 12 };

			int m = 5; // Number of students

			int n = arr.Length;

			Console.WriteLine("Minimum difference is "
						+ findMinDiff(arr, n, m));
            Console.ReadKey();
		}

        private static int findMinDiff(int[] arr, int n, int m)
        {
            if (m == 0 || n == 0)
            {
                return 0;
            }
            Array.Sort(arr);

            if (n < m)
                return -1;

            int min_diff = int.MaxValue;

            for (int i = 0; i + m - 1 < n; i++)
            {

                int diff = arr[i + m - 1] - arr[i];
                if (diff < min_diff)
                {
                    min_diff = diff;
                }
            }
            return min_diff;


        }
    }
}
