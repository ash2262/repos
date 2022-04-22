using System;
using System.Collections.Generic;
namespace IntQue30Mar22_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 5, 3, 4, 3, 5, 6 };
            Console.WriteLine(FindDuplicate(arr,2));
        }
        public static bool FindDuplicate(int[] arr, int n)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
               
                if (hs.Contains(arr[i]))
                    return true;
                else
                    hs.Add(arr[i]);

                if (i >= n)
                    hs.Remove(arr[i - n]);
            
            }
            return false;
        }
    }
}
