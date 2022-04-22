using System;

namespace ArmstrongNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();

            for (int i = 0; i <= int.Parse(input); i++)
            {
                //int i= int.Parse(input);
                isArmStrong(i);
            }
            Console.ReadKey();    
        }
        public static void isArmStrong(int i)
        {
            char[] ip;
            int size=0;
            int sum = 0;
            int temp = 1;
            ip = i.ToString().ToCharArray();
            size = ip.Length;
            sum = 0;
            foreach(char num in ip)
            {
                temp = 1;
                int x = int.Parse(char.ToString(num));
                for (int j = 0; j < size; j++)
                {
                    temp *= x;
                }
                sum += temp;
            }
            if (sum == i)
            {
                Console.WriteLine(i);
            }
        }
    }
    
}
