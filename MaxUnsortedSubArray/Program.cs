using System;
using System.Collections.Generic;
namespace MaxUnsortedSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 3, 2, 4, 5 };
            //int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr = { 4, 15, 4, 4, 15, 18, 20 };
            List<int> A = new List<int>(arr);
            subUnsort(A);
        }
        public static List<int> subUnsort(List<int> A)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                temp.Add(A[i]);
            }
            temp.Sort();
            int p1 = 0;
            int p2 = A.Count - 1;
            int idx1 = -1;
            int idx2 = -1;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] != temp[i])
                {
                    idx1 = i;
                    break;
                }
            }
            for (int i = A.Count-1; i > 0; i--)
            {
                if (A[i] != temp[i])
                {
                    idx2 = i;
                    break;
                }
            }
            
            List<int> ans = new List<int> ();
            if (idx1 == -1 && idx2 == -1)
                ans.Add(-1);
            else
            {
                ans.Add(idx1);
                ans.Add(idx2);
            }

            return ans;
        }
    }
}
