using System;
using System.Collections.Generic;

namespace AddOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            List<int> num = new List<int>(arr);
            List<int> output = new List<int>();
            output=plusOne(num);
            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine(output);
            }
        }
        public static List<int> plusOne(List<int> A)
        {
            List<int> output = new List<int>();
            for (int i = A.Count; i >0 ; i++)
            {

            }
        }
    }
}
