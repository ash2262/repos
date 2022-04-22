using System;

namespace MaxJumps
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = { 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9 };
            int output=MinJumps(arr);
            Console.WriteLine("Minjumps"+output);
            Console.ReadKey();
        }

        private static int MinJumps(int[] arr)
        {
            int cnt = 0;
            int i = 0;

            if (arr.Length == 0)
            {
                return 0;
            }

            if (arr[1] == 0)
            {
                return int.MaxValue;  
            }

            while (i <= arr.Length)
            {
                i += arr[i];
                cnt++;
                
            }
            return cnt;
        }
    }
}
