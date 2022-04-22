using System;

namespace _3wayPartition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 14, 5, 20, 4, 2, 54,
                    20, 87, 98, 3, 1, 32 };

            threeWayPartition(arr, 10, 20);

            Console.WriteLine("Modified array ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

            }
        }

        private static void threeWayPartition(int[] arr, int lowval, int highval)
        {

        }
    }
}
