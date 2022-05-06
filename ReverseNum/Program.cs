using System;

namespace ReverseNum
{
    class Program
    {
        static void Main(string[] args)
        {
            //to do: return the num
            int A= 123;
            ReverseNum(A);
        }
        public static void ReverseNum(int num)
        {

            while (num > 0) { 
            int output= num % 10;
            Console.Write(output);
            num = num / 10;
            }

        }
    }
}
