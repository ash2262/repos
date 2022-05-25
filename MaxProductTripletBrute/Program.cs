using System;
using System.Collections.Generic;
namespace MaxProductTripletBrute
{
    class Program
    {
        static void Main(string[] args)
        {
            //int testcase = int.Parse(Console.ReadLine());
            //for (int i = 0; i < testcase; i++)
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    string[] str = Console.ReadLine().Split();
            //    int[] A = Array.ConvertAll(str, int.Parse);

            //    Console.WriteLine(max_valid_triplet(A, n));
            //}

            //int[] A = new int[] { 7, 9, 3, 8, 11, 10 };
            int[] A = new int[] { 7, 4, 9, 10, 3 };
            //int[] A = new int[] { 6, 9, 3, 4, 8 };
            int n = A.Length;
            Console.WriteLine(max_valid_triplet(A, n));

        }
        static int max_valid_triplet(int[] A, int n)
        {
            int ans = -1;

            
            int second = int.MinValue;
            int first = int.MinValue;
            int thirdidx = n-1;
            int secondidx = -1;
            int firstidx = -1;
            // Generate all triplets
            Dictionary<int, int> hm = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                hm.Add(A[i], i);
            }
            
            Array.Sort(A);
            int third = 0;
            for (int i = n - 1; i >1; i--)
            {
                third = A[i];
                second = -1;
                first = -1;
                for (int j = i-1; j >=1; j--)
                {
                    if (hm[A[j ]] < hm[A[i]])
                    {
                        second =  A[ j];
                        for (int k = j-1; k >=0; k--)
                        {
                            if (hm[A[k]] < hm[A[i]])
                            {
                                first = A[k];
                                ans = Math.Max(ans, first * second * third);
                            }
                        }
                    }
                }
                
                
                   
                    
                
                
                
            }

            if (ans == 0)
                ans = -1;
            return ans;
        }
        }
}
