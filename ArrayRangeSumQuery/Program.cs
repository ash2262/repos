using System;
using System.Collections.Generic;
namespace ArrayRangeSumQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Aarr = { 7, 3, 1, 5, 5, 5, 1, 2, 4, 5 };
            //int[,] Barr =new int[,] { { 1, 4 }, { 2, 3 } };
            List<int> A = new List<int>();
            List<List<int>> B = new List<List<int>>();
            for (int i = 0; i < Aarr.Length; i++)
            {
                A.Add(Aarr[i]);
            }

            List<int> B1 = new List<int>();
            B1.Add(7);
            B1.Add(10);

            List<int> B2 = new List<int>();
            B2.Add(3);
            B2.Add(10);
            List<int> B3 = new List<int>();
            B3.Add(3);
            B3.Add(5);

            List<int> B4 = new List<int>();
            B4.Add(1);
            B4.Add(10);
            // rangeSum(A, B);
            B.Add(B1);
            B.Add(B2);
            B.Add(B3);
            B.Add(B4);

            var list=rangeSum(A, B);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
        public static List<long> rangeSum(List<int> A, List<List<int>> B)
        {

            List<long> PFSum = new List<long>(ConstructPrefixSum(A));
            List<int> Bitem = new List<int>();
            List<long> result = new List<long>();
            int start = 0;
            
            int end = 0;
            for (int i = 0; i < B.Count; i++)
            {
                Bitem = B[i];
                
                    start = Bitem[0];
                    end = Bitem[1];

                if(start==1)
                {
                    result.Add(PFSum[end - 1]);
                }
                    //Console.WriteLine(  PFSum[end-1]);
                    
                else
                    //Console.WriteLine(PFSum[end - 1] - PFSum[start - 2]);
                    result.Add(PFSum[end - 1] - PFSum[start - 2]);
            }
            return result;

        }
        private static List<long> ConstructPrefixSum(List<int> B)
        {
            List<long> PFSum = new List<long>();
            for (int i = 0; i < B.Count; i++)
            {
                if (i == 0)
                {
                    PFSum.Add(B[i]);
                }
                else
                {
                    PFSum.Add(PFSum[i - 1] + B[i]);
                }
            }
            return PFSum;
        }
    }
}
