using System;
using System.Collections.Generic;
namespace MaxProductTriplet
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

            // Function call

        }
        
            static int max_valid_triplet(int[] A, int n)
            {
            Dictionary<int, int> hm = new Dictionary<int, int>();

            for (int i = A.Length; i >=0; i--)
            {
                hm.Add(1, A[i]);
            }


                int ans = -1;



                ////Declarations
                //int[] l = new int[n];
                //int[] r = new int[n];

                ////Initialize
                //int max = A[n - 1];

                
                //for (int i = n - 2; i >= 0; i--)
                //{

                //    // If present is less the maximum
                //    // update the right[i] with
                //    // previous maximum
                //    if (max > A[i])
                //        r[i] = max;

                //    else
                //        r[i] = -1;

                //    //update max
                //    if (max < A[i])
                //        max = A[i];
                //}

                //SortedSet<int> sortedSet = new SortedSet<int>();
                //for (int i = 1; i < n; i++)
                //{
                    
                //    sortedSet.Add(A[i - 1]);

                //    int result = sortedSet.Min;

                //    // Search for maximum element
                //    // which is < present element

                
                //    if (result == 0)
                //        l[i] = -1;

                //    // Else store the result
                //    else
                //        l[i] =Math.Max(l[i-1], result);
                //}

                
                //for (int i = 1; i < n - 1; i++)
                //{
                ////int first = l[i];
                ////int second = A[i];
                ////int third = r[i];
                //    // Condition for valid triplet
                //    if (l[i] != -1 &&
                //       r[i] != -1 && (l[i]<A[i]&&A[i]<r[i]))

                //        //calculate the max product
                //        ans = Math.Max(ans,
                //                       l[i] *
                //                          A[i] *
                //                      r[i]);
                //}
            if (ans == 0)
                ans = -1;

                return ans;
            }
            }
    }

