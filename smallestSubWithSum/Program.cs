using System;

namespace smallestSubWithSum
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] arr1 = {1, 4, 45,
					6, 0, 19};
			int x = 51;
			int n1 = arr1.Length;
			int res1 = smallestSubWithSum(arr1,
										n1, x);
			if (res1 == n1 + 1)
				Console.WriteLine("Not Possible");
			else
				Console.WriteLine(res1);
			Console.ReadKey();
		}

        private static int smallestSubWithSum(int[] arr, int n, int x)
        {
			int curr_sum = 0;
			
			int min_len = n+1;
            for (int start = 0; start < arr.Length; start++)
            {
				 curr_sum = arr[start];

				if (arr[start] > x)
					return 1;
                for (int end = start+1; end < arr.Length; end++)
                {
					curr_sum += arr[end];
					if ((curr_sum > x) && (end - start < min_len))
					{
						min_len = end - start + 1;
					}
                }
            }
			return min_len;
        }
    }
}
