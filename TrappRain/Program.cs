using System;

namespace TrappRain
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 0, 0, 2, 0, 4 };
            int n = arr.Length;

            Console.Write(maxWater(arr, n));

        }

        private static int maxWater(int[] arr, int n)
        {
            int res = 0;
            int left = arr[0];
            int right = arr[n-1];

            for (int i = 1; i < arr.Length-1; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    left = Math.Max(left, arr[j]);
                }
                for (int k = i+1; k < n; k++)
                {
                    right = Math.Max(right, arr[k]);
                }
                res += Math.Min(left, right)-arr[i];
            }
            return res;
        }
    }
}
