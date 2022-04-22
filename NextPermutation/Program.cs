using System;

namespace NextPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = { 1,2,3 };
            Solution soln = new Solution();
            soln.nextPermutation(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadKey();

        }
    }
    public class Solution
    {
        public void nextPermutation(int[] nums)
        {
            int i = nums.Length - 2;
            while (i>=0 && nums[i + 1] <= nums[i])
            {
                i--;
            }
            if (i >= 0)
            {

                int j = nums.Length - 1;
                while (j >= 0 && nums[j] <= nums[i])
                {
                    j--;
                }
                swap(nums, i, j);
            }
            reverse(nums, i + 1);
        }
        private void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
        private void reverse(int[] nums, int start)
        {
            int i = start, j = nums.Length - 1;
                while (i < j)
            {
                swap(nums, i, j);
                i++;
                j--;
            }
        }


    }
}
