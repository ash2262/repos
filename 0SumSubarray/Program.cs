using System;
using System.Collections.Generic;

namespace _0SumSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 4,2,-3, 1, 6 };
            if (subarrayExists(arr))
                Console.WriteLine("Found a subarray with sum 0");
            else
                Console.WriteLine("No subarray with sum 0 exists");
            Console.ReadKey();
        }

        private static bool subarrayExists(int[] arr)
        {
            int sum = 0;
            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                hs.Add(arr[i]);
                sum += arr[i];
                if ((sum == 0) || (arr[i] == 0) || (hs.Contains(sum))|| hs.Contains(-arr[i]))
            {
                    return true;
            }
                hs.Add(sum);

            }
            return false;

        }
    }
}
