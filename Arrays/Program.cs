using System;
using System.Collections.Generic;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int CountElements(int[] nums)
        {
            int cnt = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] != nums[0]) && (nums[i] != nums[nums.Length - 1]))
                {
                    cnt++;
                }
            }
            return cnt;
        }
        public int singleNumber(List<int> A)
        {
            int n = A.Count;
            int i = 0; int j = 0; int B = 0; int mask = 1;
            List<int> ans = new List<int>();
            for (i = 0; i < 32; i++)
            {
                B = 0;
                for (j = 0; j < n; j++)
                {

                    if ((A[j] & (mask)) > 0)
                        B++;
                }
                mask = mask << 1;
                ans.Add[ans + (1 << i) * (B % 3)];
            }
            return ans;
        }

    }
}
