using System;
using System.Collections.Generic;
namespace subseqClassque
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5 };
            //int k = 5;
            List<int> A = new List<int>(arr);

            //Console.WriteLine(LittlePonny2("scsecugqsb"));
            Console.WriteLine(SubArrayOR(A));

        }
        public static int SubArrayOR(List<int> a)
        {
            int n = a.Count;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int BitOR= 0;

                for (int j = i; j < n; j++)
                {
                    BitOR = (BitOR | a[j]);
                    sum = sum + BitOR;
                }
            }

            return sum;
        }
        public static string LittlePonny2(string A)
        {
            char[] arrA = A.ToCharArray();
            string output="";
            //Array.Sort(arrA);
            char min1=A[1], min2=A[1];
            for (int i = 0; i < A.Length; i++)
            {
                if (min1 > A[i] && i!=A.Length-1)
                {
                    min1 = A[i];
                }
                else if(min2>A[i])
                {
                    min2 = A[i];
                }
            }

            output +=min1;
            output += min2;

            return output;
        }

        public static int solve(string A)
        {
            int GCount = 0;
            int AGCount = 0;
            for (int i = A.Length-1; i>=0; i--)
            {
                if (A[i] == 'G')
                    GCount++;

                if (A[i] == 'A')
                    AGCount += GCount;
            }
            return AGCount% 1000000007;
        }

        public static string FindSub(string A, string B)
        {
            int i = 0;
            int j = 0;
            while (i < B.Length)
            {
                if (A[j] != B[i] && j < A.Length)
                {
                    i++;

                }
                else
                {
                    i++;
                    j++;
                }

                if (j == A.Length)
                {
                    return "YES";
                }
            }
                return "NO";
            

        }
        public static long solve(List<int> A)
        {
            A.Sort();
            int mod = 1000000007;
            long max = 0;
            long min = 0;
            long diff = 0;
            int pow = 2;
            //double n =Math.Pow(2 , A.Count);
            
            for (int i = 0; i < A.Count; i++)
            {
                //subsum = 0;
               

              min = pow*min+ A[i];
              max = pow*max+A[A.Count-i-1];
                diff = ((max - min) ) % mod;
                pow = pow * 2 % mod;
            }
            
            return (diff+ mod)%mod;
        }
        public static bool CheckBit(int N, int i)
        {
            return ((N >> i) & 1) == 1;
        }
    }
    
}
