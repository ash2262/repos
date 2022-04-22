using System;

namespace ArrayFind
{
    class Program
    {
        static void Main(string[] args)
        {
            int tc = 0;
            int min = int.MinValue
            tc = int.Parse(Console.ReadLine().Trim());
            string ArrayStr;
            int x = 0;
            //int[] arrayInt;
            int[] ArrayInt;
            for (int i = 0; i < tc; i++)
            {
                ArrayStr = Console.ReadLine();
                x = int.Parse(Console.ReadLine());
                ArrayInt = ConvertTorray(ArrayStr);
                FindX(x, ArrayInt);
            }
        }
        public static void FindX(int x, int[] ArrayInt)
        {
            for (int i = 0; i < ArrayInt.Length; i++)
            {
                if (ArrayInt[i] == x)
                { 
                    Console.WriteLine(1);
                    return ;
                }
            }
            Console.WriteLine(0);
        }
        public static int[] ConvertTorray(string str)
        {
            int[] arrayInt = Array.ConvertAll<string, int>(str.Split(' '), Convert.ToInt32); 
            return arrayInt;
        }
    }
}
