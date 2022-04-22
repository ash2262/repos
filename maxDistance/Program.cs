using System;
using System.Collections.Generic;
namespace maxDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 4, 2 };
            List<int> lst = new List<int>(arr);
            Console.WriteLine(maximumGap(lst));
        }
        public static int maximumGap(List<int> A)
        {
            List<List<int>> listofLists = new List<List<int>>();
            for (int i = 0; i < A.Count; i++)
            {
                listofLists.Add(new List<int> { A[i], i });
            }

            listofLists.Sort((first, second) =>
            {
                if (first[0] < second[0])
                    return -1;
                if (first[0] == second[0] && first[1] < second[1])
                    return -1;
                return 1;

            });
            int maxIndex = -1, ans = 0;
            for (int i = listofLists.Count-1; i >=0 ; i--)
            {
                int currIndex = listofLists[i][1];
                maxIndex = Math.Max(maxIndex, currIndex);
                ans = Math.Max(ans, maxIndex - currIndex);
            }
            return ans;
        }
    }
}
