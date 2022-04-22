using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1= {1,3,5,7 };
            int[] arr2 = { 0, 2, 6, 8,9 };
            int[] tracker;
            int len1 = arr1.Length;
            int len2 = arr2.Length;
            //finding the biggest number in both the arrays
            int max=0;
            if(len1>len2)
            {
                max = arr1[len1 - 1];
            }
            else
            {
                max = arr2[len2 - 1];

            }
            tracker = new int[max];
            //initialize tracker
            for (int ij = 0; ij < max; ij++)
            {
                tracker[ij] = 0;

            }
            int i = 0;
            int j = 0;
            while((i<len1) && (j<len2))
//            for (int i = 0; i < len1; i++)
            {
               // if(tracker[arr2[i]] == 0 || tracker[arr2[i]] == 0) 
                { 

                    if ((arr1[i]<arr2[j]) && (tracker[arr1[i]]==0))
                    { 
                        Console.WriteLine(arr1[i]);
                        tracker[arr1[i]] = 1;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine(arr2[j]);
                        tracker[arr2[j]] = 1;
                        j++;
                    }
                }
            }
            while (i < len1)
            {
                Console.WriteLine( arr1[i]);
                i++;
            }
            while (j < len2)
            {
                Console.WriteLine(arr2[j]);
                j++;
            }
            Console.ReadKey();
        }
    }
}
