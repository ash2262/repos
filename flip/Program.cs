using System;
using System.Collections.Generic;
namespace flip
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "010";
            List<int> lstout = new List<int>();
            lstout = flip(input);
            foreach( var item in lstout)
                {
                Console.WriteLine(item);
            }
        }
        public static List<int> flip(string A)
        {
            int maxSoFar = 0;
            int sum = 0;
            char[] charA = A.ToCharArray();
            List<int> output = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                int num = int.Parse(A[i].ToString());
                sum += num;

                maxSoFar = Math.Max(maxSoFar, sum);
                if (sum <= 0)
                    output.Clear();
                else
                    output.Add(i);



            }

            return output;


        }
    }
}
