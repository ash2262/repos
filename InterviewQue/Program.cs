using System;

namespace InterviewQue
{
    class Program
    {
        static void Main(string[] args)
        {
            //homework if -1, -1 repeated multiple times then reduce loops
            int[] arr = { -4, - 1, - 1, 0 ,1, 2 };
            int target = 0;
            int previ = 0;
            int prevj = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i+1;int k = arr.Length-1;

                while(j<arr.Length && k>j)
                {

                    int sum = arr[i] + arr[j] + arr[k];
                    if (sum == target)
                    {
                        Console.WriteLine(arr[i] + "," + arr[j] + "," + arr[k]);
                    }
                    else if (sum < target)
                        j++;
                    else
                    {
                        k--;
                    }
                }
                
            }
            
        }
    }
}
