using System;
using System.Collections.Generic;
namespace LongestConseqSubseq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int[] arr = { -5, -2, 5, 2, 4, 7, 1, 8, 0, -8 };
            //int[] arr = { 2,6,1,9,4,5,3 };
            int[] arr = { 1, 9, 3, 10, 4, 20, 2 };
            int n = arr.Length;


            int ct = FindLongestConseqSubseq(arr, n);

            Console.WriteLine("Longest consecutive subsequence count is: " + ct);
            printArray(arr, n);
            Console.ReadKey();

        }

        private static void printArray(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
        }

        private static int FindLongestConseqSubseq(int[] arr, int n)
        {
            int maxcount = 0;
            HashSet<int> hs = new HashSet<int>();
            int subseqCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                hs.Add(arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (!hs.Contains(arr[i]-1))
                {
                    subseqCount = 0;
                    int substart = arr[i];
                    while (hs.Contains(substart+1))
                    {
                        subseqCount++;
                        substart++;
                    }
                
                }
                if(maxcount<subseqCount)
                {
                    maxcount = subseqCount;
                }
            }

            return maxcount+1;
        }
    }
}
