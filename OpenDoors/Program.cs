using System;

namespace OpenDoors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solve(5));
            Console.ReadKey();
        }
        public static int solve(int A)
        {
            int count = 0;
            for (int i = 1; i < A; i=i*i)
            {
                count++;
                i = count + 1;
            }
            return count;
        }
    }
}
