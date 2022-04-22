using System;

namespace Kadane_sAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, -2, 5 };
            KadaneAlgo(arr);
            //PrintArray(arr);
            Console.ReadKey();
        }

        private static void KadaneAlgo(int[] arr)
        {
            int MaxSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                MaxSum += arr[i];
            }
            Console.WriteLine("MaxSum:"+MaxSum);
        }
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

        }
    }
}
