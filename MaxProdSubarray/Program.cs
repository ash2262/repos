using System;

namespace MaxProdSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, -3, -10, 0, 2 };
            int n = arr.Length;

            Console.WriteLine("Maximum Subarray " +
                                    "product is " +
                            maxProduct(arr, n));
            Console.ReadKey();
        }

        private static int maxProduct(int[] arr, int n)
        {
            
            int maxProduct = arr[0];

            int minVal = arr[0];
            int maxVal = arr[0];
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    int temp = maxVal;
                    maxVal = minVal;
                    minVal = temp;

                }

                maxVal = Math.Max(arr[i],
                            maxVal * arr[i]);
                minVal = Math.Min(arr[i],
                                minVal * arr[i]);

                maxProduct = Math.Max(maxProduct, maxVal);

            }

            return maxProduct;

            
        }
    }
}
