using System;
using System.Collections.Generic;
namespace MaxChunks
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 0 };
            int[] arr = { 2, 0, 1, 3 };
            List<int> A = new List<int>(arr);
            Console.WriteLine(chunks(A));
        }
        public static int chunks(List<int> A)
        {
            int chunks = 0;
            int curr = -1;
            for (int i = 0; i < A.Count; i++)
            {
                curr=(Math.Max(curr, A[i]));
                if (curr == i) 
                    chunks++;
            }
            return chunks;
        }
    }
}
