using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeights
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 8, 10 };
            int k = 2;
            int N = 4;

            FindMinHeights(arr, k, N);
        }

        private static void FindMinHeights(int[] arr, int k, int N)
        {
            int output;
            int max = 0;
            int min = 0;
           
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > k)
                {
                    
                    output = arr[i] - k;
                }
                else
                {
                    output = arr[i] + k;
                }

                if (output > max)
                    max = output;
                if (output < min)
                    min = output;
            }
            Console.WriteLine("difference:"+ (max-min));
            Console.ReadKey();
        }
    }
}
