using System;
using System.Collections.Generic;
namespace FindSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 10, 11, 18, 9 };
            Console.WriteLine(LongestSeq(A));
        }
        public static int LongestSeq(int[] A)
        {
            int cnt = 0;
            int maxcnt = int.MinValue;
            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                hs.Add(A[i]);
            }

            for (int i = 0; i < A.Length; i++)
            {

                if (!hs.Contains(A[i]-1))
                {
                    cnt = 1;
                    int ele = A[i];
                    while (hs.Contains(ele+1))
                    {
                        cnt++;
                        ele++;
                    }
                    maxcnt = Math.Max(maxcnt, cnt);
                }
            }
            return maxcnt;
        }
    }
}
