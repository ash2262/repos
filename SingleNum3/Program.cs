using System;
using System.Collections.Generic;
namespace SingleNum3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 1, 2, 4 };
            int[] arr = { 1, 2};
            List<int> lst = new List<int>(arr);
            foreach (var item in solve(lst))
            {
                Console.WriteLine(item);
            }
        }
        public static List<int> solve(List<int> A)
        {
            int v = 0;
            int pos = 0;
            int set = 0;
            int unset = 0;
            List<int> ans = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                v = v ^ A[i];

            }
            for (int i = 0; i < 32; i++)
            {
                if ((v & (1 << i)) > 0)
                {
                    pos = i;
                }
            }
            for (int i = 0; i < A.Count; i++)
            {
                if ((A[i] & (1 << pos)) > 0)
                {
                    set = set ^ A[i];
                }
                else
                    unset = unset ^ A[i];
            }
            ans.Add(unset);
            ans.Add(set);
            
            return ans;
        }
    }
}
