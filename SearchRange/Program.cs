using System;
using System.Collections.Generic;
namespace SearchRange
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 5, 7, 7, 8, 8, 10 };
            int[] arr = { 5, 17, 100, 111 };
            List<int> a = new List<int>(arr);
            searchRange(a, 3);
            
        }
        public static List<int> searchRange(List<int> A, int B)
        {
            List<int> ans = new List<int>();

            ans.Add(firstIndex(A,B));
            ans.Add(lastIndex(A,B));


            return ans;
        }
        public static int firstIndex(List<int> a,int b)
        {

            int ans = -1;
            int l = 0;
            int h = a.Count - 1;

            while (l <= h)
            {
                int m = (l + h) / 2;
                if (a[m] == b)
                { 
                    ans= m;
                    h = m - 1;
                }
                if (a[m] > b)
                    h = m - 1;
                if (a[m] < b)
                {
                    //ans = a[m];
                    l = m + 1;
                }
            }

                return ans;

        }
         static int lastIndex(List<int> a, int b)
        {
            int l = 0;
            int h = a.Count - 1;
            int ans = -1;

            while (l <= h)
            {
                int m = (l + h) / 2;
                if (a[m] == b) { 
                    ans=m;
                    l = m + 1;
                }

                if (a[m] > b)
                    h = m - 1;
                if (a[m] < b)
                {
                    //ans = a[m];
                    l = m + 1;
                }
            }
            return ans;
        }
    }
}
