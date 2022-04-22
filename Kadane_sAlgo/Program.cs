using System;

namespace Kadane_sAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, -2, 5 };
            KadaneAlgo(arr);
            Console.ReadKey();

        }
        private static void KadaneAlgo(int[] arr)
        {
            int max_so_far = int.MinValue,
        max_ending_here = 0, start = 0,
        end = 0, s = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                max_ending_here += arr[i];

                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                    start = s;
                    end = i;
                }

                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                    s = i + 1;
                }
            }

            Console.WriteLine("MaxSum:" + max_so_far);
}

    }
}
