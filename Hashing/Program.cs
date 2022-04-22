using System;

using System.Collections.Generic;
namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 0, 0, 1 };
            //int[] B = { 3, 6, 2, 10, 10 };
            int B = 2;
            int A = 123;


            List<int> lstinput = new List<int>(Arr);
            List<int> lstB = new List<int>(B);

            Console.WriteLine(colorful(A));
            Console.WriteLine(KOccurences(lstinput.Count,B,lstinput));

            List<int> lstans = new List<int>();
            //lstans = CommonEle(lstinput, lstB);
            //lstans=lszero(lstinput);
            //foreach (var item in lstans)
            //{
            //    Console.WriteLine(item);
            //}



            
        }

        public static int colorful(int A)
        {
            int prod = 1;
            int prev = 1;
            string num =A.ToString();
            HashSet<int> hs = new HashSet<int>();
           
            for (int i = 0; i < num.Length; i++)
            {
                int current = num[i]-'0' ;
                //int next = num[i + 1]-'0';
                prod = prev * current;
                if(hs.Contains(prod)||hs.Contains(current))
                {
                    return 0;
                }
                

                hs.Add(prod);
                    hs.Add(current);
                //hs.Add(current * next);
                prev = current;
            }
            return 1;
        }

            public static int KOccurences(int A, int B, List<int> C)
        {
            int ans = -1;
            Dictionary<int, int> hm = new Dictionary<int, int>();

            for (int i = 0; i < C.Count; i++)
            {
                if (hm.ContainsKey(C[i]))
                {
                    hm[C[i]] = hm[C[i]] + 1;
                }
                else
                {
                    hm.Add(C[i], 1);
                }
            }
            if (hm.ContainsValue(B))
            {
                ans = 0;
            }
            else
                return -1;
            foreach(var pair in hm)
            {
                if (pair.Value == B)
                {
                    ans += pair.Key;
                }
            }
            //if (ans == 0)
            //{
            //    return -1;
            //}
            return ans;
        }
        public static List<int> lszero(List<int> A)
        {
            #region "Problem Description"
            /*Q3.Largest Continuous Sequence Zero Sum
             * 

Given an array A of N integers.

Find the largest continuous sequence in a array which sums to zero.
            Problem Constraints

1 <= N <= 106

-107 <= A[i] <= 107



Input Format

Single argument which is an integer array A.



Output Format

Return an array denoting the longest continuous sequence with total sum of zero.

NOTE : If there are multiple correct answers, return the sequence which occurs first in the array.



Example Input

A = [1,2,-2,4,-4]


Example Output

[2,-2,4,-4]


Example Explanation

[2,-2,4,-4] is the longest sequence with total sum of zero.

             */
            #endregion
            int maxcnt = 0;
            List<int> PFSum = new List<int>();
            int startidx = -1;
            int endidx = -1;
            int finalstartidx = -1;
            int finalendidx = -1;
            List<int> Ans = new List<int>();
            PFSum = ConstructPrefixSum(A);
            Dictionary<int,int> hs = new Dictionary<int,int>();
            for (int i = 0; i < PFSum.Count; i++)
            {
                if (hs.ContainsKey(PFSum[i]))
                {
                    startidx = hs[PFSum[i]];
                    int length = i - startidx;

                    int previouscnt = maxcnt;
                    maxcnt = Math.Max(maxcnt, length);
                    if (maxcnt > previouscnt)
                    {
                        finalstartidx = startidx + 1;
                        finalendidx = startidx + length;
                    }

                    // hs[PFSum[i]] = hs[PFSum[i]] + 1;
                }
                else
                    hs.Add(PFSum[i],i);
            }

            //for (int j = 0; j < hs.Count; j++)
            //{
            //    if (hs[PFSum[ j]] > 1)
            //    {
            //     startidx=   PFSum.IndexOf(PFSum[j])+1;
            //        endidx = PFSum.IndexOf(PFSum[j], j + 1);
            //        if (endidx - startidx > maxcnt)
            //        {
            //            maxcnt = endidx - startidx;
            //            finalstartidx = startidx;
            //            finalendidx = endidx;
            //        }
            //    }
            //}
            if (maxcnt > 0)
            {
                for (int a = finalstartidx; a <= finalendidx; a++)
                {
                    Ans.Add(A[a]);
                }
            }
            else
            {
                Ans.Add(0);
            }
            
            return Ans;

            
        }
        private static List<int> ConstructPrefixSum(List<int> A)
        {
            List<int> PFSum = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (i == 0)
                {
                    PFSum.Add(A[i]);
                }
                else
                {
                    PFSum.Add(PFSum[i - 1] + A[i]);
                }
            }
            return PFSum;
        }
        public static List<int>  CommonEle(List<int> A, List<int> B)
        { 
            
            //int count = 0;
                Dictionary<int, int> hm = new Dictionary<int, int>();
            List<int> lstans = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (hm.ContainsKey(A[i]))
                {
                    hm[A[i]] = hm[A[i]] + 1;
                    //count = hm[A[i]];
                    //hm.Remove(A[i]);
                    //count++;
                    //hm.Add(A[i], count);
                }
                else
                {
                    hm.Add(A[i], 1);
                }
            }

            for (int j = 0; j < B.Count; j++)
            {
                if (hm.ContainsKey(B[j])&& hm[B[j]]>0)
                {
                    lstans.Add(B[j]);
                    hm[B[j]] = hm[B[j]] - 1;
                }
            }
            return lstans;
        }
        public static int FirstRepeatingEle(List<int> A)
        {
            int min = int.MaxValue ;
            int num = -1;
            Dictionary<int,int> hs = new Dictionary<int, int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (hs.ContainsKey(A[i]))
                {
                    if (min > hs[A[i]])
                    {
                        min = hs[A[i]];
                        num = A[i];
                    }
                }
                        // return hs;
                else
                    hs.Add(A[i],i);
            }
            return num;
        }
        public static int shaggyandDistances(List<int> A)
        {

            #region "question"
            /*
            Shaggy has an array A consisting of N elements.We call a pair of distinct indices in that array as a special pair if elements at that index in the array are equal.

Shaggy wants you to find a special pair such that distance between that pair is minimum.Distance between two indices is defined as | i - j |.If there is no special pair in the array then return -1.



Problem Constraints

1 <= | A | <= 105



Input Format

First and only argument is the array A.



Output Format

Return one integer corresponding to the minimum possible distance between a special pair.



Example Input

Input 1:

A = [7, 1, 3, 4, 1, 7]
Input 2:

A = [1, 1]
*/
            #endregion
            int ans = -1;
            int distance = 0;
            Dictionary<int, int> Hashmap = new Dictionary<int, int>();
            int minDistance = int.MaxValue;

            for (int i = 0; i < A.Count; i++)
            {
                if (Hashmap.ContainsKey(A[i]))
                {
                    distance = i - Hashmap[A[i]];
                    if (distance < minDistance)
                        minDistance = distance;
                }
                else
                {
                    Hashmap.Add(A[i], i);
                }
            }

            if (minDistance < int.MaxValue)
            {
                ans = minDistance;
            }

            return ans;

        }

    }
}
#region "old code"

// Console.WriteLine(shaggyandDistances(lstinput));
/* Console.WriteLine(shaggyandDistances(lstB));
Console.WriteLine(FirstRepeatingEle(lstinput));
Console.WriteLine(FirstRepeatingEle(lstB));

int count = 0;
Console.WriteLine("Hello World!");
int[] arr = { 2, 3, 4, 5, 2, 3 };
HashSet<int> hs = new HashSet<int>();
for (int j = 0; j < arr.Length; j++)
{
    hs.Add(arr[j]);
}
Console.WriteLine(hs.Count);
Dictionary<int, int> hm = new Dictionary<int, int>();
for (int i = 0; i < arr.Length; i++)
{
    if (hm.ContainsKey(arr[i]))
    {
        count = hm[arr[i]];
        count++;
        hm.Remove(arr[i]);
        hm.Add(arr[i], count);
    }
    else
    {
        hm.Add(arr[i], 1);
    }
}

foreach(var item in hm)
{
    Console.WriteLine("Key = {0}, Value = {1}", item.Key.ToString(),item.Value.ToString());
}
*/
#endregion