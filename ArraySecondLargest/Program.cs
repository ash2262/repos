

using System;

namespace ArraySecondLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            int TC = int.Parse(Console.ReadLine().Trim());
            for (int i = 0; i < TC; i++)
            {
                string numberStr = Console.ReadLine().Trim(); // "1 2 3 1 2 3 1 2 ...."
                string[] splitted;

                if (numberStr.Contains(","))
                {
                    splitted = numberStr.Split(',');
                }
                else
                {
                    splitted = numberStr.Split(' ');
                }
                //int N = int.Parse(splitted[0]);
                int N = splitted.Length-1;
                int[] arrayInt = new int[N];

                for (int j = 0; j < N; j++)
                {
                    arrayInt[j] = int.Parse(splitted[j + 1]);
                }
                if (arrayInt.Length < 3)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Array.Sort(arrayInt);
                    Console.WriteLine(arrayInt[1]);
                }
            }
        }
    }
}
