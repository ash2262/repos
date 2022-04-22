using System;
using System.Collections.Generic;

namespace MoreThanNK
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] arr = { 3, 1, 2, 2, 1, 2, 3, 3 };
            int n = arr.Length;

            int k = 4;
            MoreThanNK(arr, n, k);

            Console.ReadKey();

        }

        private static void MoreThanNK(int[] arr, int n, int k)
        {
            
            int nk = n / k;
            int count = 0;
            
            Dictionary<int,int> d = new Dictionary<int,int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!d.ContainsKey(arr[i]))
                {
                    d.Add(arr[i], 1);
                }
                else
                    count = d[arr[i]] ;
                d[arr[i]] = count + 1;
            }

            foreach (var value in d)
            {
                if (value.Value > 2)
                    Console.WriteLine(value.Key);
            }
            }

        }
    }

