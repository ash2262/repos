using System;

namespace Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine(solve("abobc"));
            Console.WriteLine(occurences("bobob"));
        }
        public static int solve(string A)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A.IndexOf("bob") >= 0)
                {
                    A = A.Substring(i + A.IndexOf("bob") + 2, A.Length - (i + A.IndexOf("bob") + 2));
                    //i = i + A.IndexOf("bob");
                    i = 0;
                    count++;
                }
            }
            return count;
        }
        public static int occurences(string A)
        {

            int occurrences = 0;
            int prev = A.IndexOf("bob");
            while (prev != -1)
            {
                occurrences++;
                prev = A.IndexOf("bob", prev + 1);
            }
            return occurrences;
        }
    }
}
