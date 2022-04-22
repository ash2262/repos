using System;
using System.Collections.Generic;
namespace RepeatAndMissingNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 3, 1, 2, 5, 3 };
            List<int> input = new List<int>(Arr);
            List<int> output = new List<int>();
            output = repeatedNumber(input);
            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
        public static List<int> repeatedNumber(List<int> A)
        {
            int N = A.Count;
            int sum = 0;
            int var = 0;
            for (int i = 0; i < N; i++)
            {
                int val = A[i];

                sum ^= Math.Abs(A[i]) ^ (i + 1);

                int ind = Math.Abs(val) - 1;

                if (A[ind] < 0)
                {
                    var = Math.Abs(val);
                }

                A[ind] = -A[ind];
            }
            int second = sum ^ var;
            return new List<int> { var, second };
            
        }
    }
}
