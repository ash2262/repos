using System;

namespace FirstLast
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 2, 2, 3,
                      4, 7, 8, 8 };
            int x = 8;
            findFirstAndLast(arr, x);
        }


        /* if x is present in arr[] then
        returns the index of FIRST
        occurrence of x in arr[0..n-1],
        otherwise returns -1 */
        static void findFirstAndLast(int[] arr,
                                   int x)
        {
            int n = arr.Length;
            int first = -1, last = -1;

            for (int i = 0; i < n; i++)
            {
                if (x != arr[i])
                    continue;
                if (first == -1)
                    first = i;
                last = i;
            }
            if (first != -1)
            {
                Console.WriteLine("First "
                                  + "Occurrence = " + first);
                Console.Write("Last "
                              + "Occurrence = " + last);
            }
            else
                Console.Write("Not Found");
        }

    }
}
