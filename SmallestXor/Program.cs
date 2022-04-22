using System;

namespace SmallestXor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solve(3, 3));
        }
        public static int solve(int A, int B)
        {
            int X = A, a = A;
            int setBitsA = 0;
            //count the set bits of A
            while (a > 0)
            {
                if ((a & 1) == 1)
                    setBitsA++;
                a = a >> 1;
            }
            // if setBits of A greater than B
            if (B < setBitsA)
            {
                int i = 0;
                while (B != setBitsA)
                {
                    if (((A >> i) & 1) == 1)
                    {
                        X = X - (1 << i);
                        setBitsA--;
                    }
                    i++;
                }
                return X;
            }
            // if setBits of A less than B
            else if (B > setBitsA)
            {
                int i = 0;
                while (B != setBitsA)
                {
                    if ((A & (1 << i)) == 0)
                    {
                        X = X + (1 << i);
                        setBitsA++;
                    }
                    i++;
                }
                return X;
            }
            else return X;

        }
    }
}
