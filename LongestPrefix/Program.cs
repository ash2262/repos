using System;
using System.Collections.Generic;
namespace LongestPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] arr = { "abab", "ab", "abcd" };
            List<string> A = new List<string>(arr);
            Console.WriteLine(longestCommonPrefix(A));
        }
        public static string longestCommonPrefix(List<string> A)
        {
            string prefix = A[0];
            for (int i = 0; i < A.Count; i++)
            {
                while (!A[i].Contains(prefix))
                {
                    
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }
            return prefix;
        }
    }
}
