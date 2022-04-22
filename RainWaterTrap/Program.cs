
using System;
using System.Collections.Generic;
namespace RainWaterTrap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 1, 0, 2 };
            //int[] A = { 2, 0, 2 };
            List<int> lstA = new List<int>(A);
            Console.WriteLine(trap(lstA)); 
        }
        public static int trap(List<int> A)
        {
            int lo = 0;
            int hi = A.Count-1;
            int ans = 0;
           
            int left_max = 0;
            int right_max = 0;
            while (lo <= hi)
            {
                if (A[lo] < A[hi])
                {
                    if (A[lo] > left_max)
                    {
                        //lo = A[lo];
                        left_max = A[lo];

                    }
                    else
                    {
                        ans +=Math.Max( left_max - A[lo],0);
                    }
                    lo++;
                }

                else
                {
                    if (A[hi] > right_max)
                    {
                        right_max = A[hi];
                    }
                    else
                    {
                        ans +=Math.Max( right_max - A[hi],0);
                    }
                    hi--;
                }
                    
                
            }
            return ans;
        }
    }
}
