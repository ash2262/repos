using System;
using System.Collections.Generic;
namespace SingleNum2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 3, 3, 2, 2, 3, 1, 1 };

            List<int> input = new List<int>(arr);
            Console.WriteLine(singleNumber(input));
        }
        public static int singleNumber(List<int> A)
        {
            int ans = 0;
            for (int i = 0; i <=30; i++)
            {
                int c = 0;
                for (int j = 0; j < A.Count; j++)
                {
                    if (checkbit(A[j], i))
                        c++;
                    
                }

                if(c%3==1)
                {
                    c = c % 3;
                    ans = ans | (c << i);
                }
            }
            return ans;
        }
        public static bool checkbit(int input, int i)
        {
            if((input&(1<<i))>0)
                    return true;

            return false;
        }
    }
}
