using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012ArrarSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 0, 2, 0, 0, 1, 2, 2, 2, 1, 1, 0 };
            int n = a.Length;
            sort012(a, n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i] + ",");

            }
            Console.ReadKey();
        }
        public static void sort012(int[] a, int n)
        {
            // code here 
            int low = 0;
            int mid = 0;
            int high = n - 1;
            while (mid <= high)
            {
                switch (a[mid])
                {
                    case 0:
                        {
                            int temp = a[low];
                            a[low] = a[mid];
                            a[mid] = temp;
                            mid++;
                            low++;

                            break;
                        }

                    case 1:
                        {
                            mid++;
                            break;
                        }
                    case 2:
                        {
                            int temp1 = a[mid];
                            a[mid] = a[high];
                            a[high] = temp1;
                            high--;
                            break;

                        }
                }
            }
        }
    }
}
