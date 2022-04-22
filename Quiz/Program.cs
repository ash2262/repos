using System;
using System.Collections.Generic;
namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 7,3,1 };
            //int[] arr = { 5,10,15,20 };
            //int[] arr = { 2,4,1,3,1};
            //int[] arr = { 35,141362081,503160225,987689206,272772571,588167877,403361933,141362075,141362070,141362075,141362081,141362081,141362082,141362082,141362076,141362082,141362082,141362081,141362081,141362084,141362085,141362091,141362091,141362095,141362091,141362094,141362098,141362096,141362102,141362107,141362101,141362100,141362100,141362096,141362093,141362092};
            //List<int> lst = new List<int>(arr);
            //int[] arr = { 1, 0, 2, 3, 2 };
            int[] arr = { 1, 2,3,4,5 };
            List<int> lst = new List<int>(arr);
             List<int> result = new List<int>();
            result=Robot(lst);
            foreach(int item in result) { 
             Console.WriteLine(item);
        }
            //int[] arr = { 0, 2, 9 };
            //List<int> lst = new List<int>(arr);

            //Console.WriteLine(solve(lst));

            //int[] arr = { 2,4,3,1,5};
            //List<int> lst = new List<int>(arr);
            //int[] arr = { 1,4,2 };
            //List<int> lst = new List<int>(arr);
            //Console.WriteLine(LittlePonnyMaxEle(lst,3));

            // int[] arr = { 2,8,9 };
            //int[] arr = {77,66,43,25,84,81,93,82,96,96,96};
            // List<int> lst = new List<int>(arr);

            // List<int> result = new List<int>();
            // foreach(int item in lst) { 
            // Console.WriteLine(GenArray(lst));
            //Console.WriteLine(A[i + 1] - A[i]);
        }
        public static List<int> Robot(List<int> A)
        {
            int[] arrResult = new int[A.Count];
           
            List<int> result ;

            for (int i = 0; i < A.Count; i++)
            {
                for (int j = i-A[i]; j <=i+A[i]; j++)
                {
                   if((j>=0)&&(j<A.Count))
                    {
                        arrResult[j]++;
                    }
                }
            }
            result  = new List<int>(arrResult);
            return result;
        }
        public static int RemovingArr(List<int> A, int B)
        {
            int cnt = 0;
            A.Sort();
            for (int i = A.Count-2; i >0; i--)
            {
                if (A[i+1] - A[i] >= B)
                {
                    cnt++;
                }
            }
            if (cnt == A.Count)
                return A.Count - 1;

            return cnt;
        }
        public static int solve(List<int> A)
        {
            int maxeven = int.MinValue;
            int minodd = int.MaxValue;

            for (int i = 0; i <A.Count; i++)
            {
                if (A[i] % 2 == 0)
                {
                    maxeven = Math.Max(A[i], maxeven);
                }
                else
                {
                    minodd=Math.Min(A[i],minodd);
                }
            }
            return Math.Max(maxeven, minodd) - Math.Min(maxeven, minodd);
        }
        public static int LittlePonnyMaxEle(List<int> A, int B)
        {
            int biggercnt = 0;
            if (A.Contains(B)) { 
                
                for (int i = 0; i < A.Count; i++)
                {
                    if (A[i] > B)
                        biggercnt++;
                }
            }
            if (biggercnt > 0)
            {
                return biggercnt;
            }
            else
                return -1;
            
        }
        public static List<int> GenArray(List<int> A)
        {
            List<int> B = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                for (int j=1; j <= A[i]; j++)
                {
                    if ((A[i] & j) > 0)
                    {
                        B.Add(j);
                        break;
                    }
                    if (A.Count == B.Count)
                        return B;
                }
                
            }
            return B;
        }
    }
}
