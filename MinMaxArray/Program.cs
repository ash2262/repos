using System;

namespace MinMaxArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int min = int.MaxValue;
            int max = int.MinValue;
            int i = 1;
            while (i <= arrayInt.Length-1)
            {
                if (arrayInt[i] > max)
                {
                    max = arrayInt[i];
                }
                if (arrayInt[i] < min)
                {
                    min = arrayInt[i];
                }
                i++;
            }
            Console.WriteLine(max + " " + min);
        }
    }
}
