using System;

namespace PowerFunction
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(getpowwer(2,3,3));       //2
            Console.WriteLine(getpowwer(-1, 1, 20));  //19
            Console.WriteLine(getpowwer(-1, 2, 20));  //1
        }
        public static int getpowwer(int A, int B, int C)
        {
            if (A == 0) return 0;
            long ans = power(A, B, C);
            if (ans < 0) return (int)(ans + C) % C;
            else return (int)ans;
        }


        // actual  power computation method
        private static long power(long A, long B, long C)
        {
            if (B == 0) return 1;
            long p = power(A, B / 2, C) % C;
            if (B % 2 == 0) return (p*p) % C;
             return ((p*p) % C * A) % C;
        }
    }
}
