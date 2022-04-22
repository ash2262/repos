using System;

namespace FindPariMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;

            int[,] mat = {{ 1, 2, -1, -4, -20 },
                    { -8, -3, 4, 2, 1 },
                    { 3, 8, 6, 1, 3 },
                    { -4, -1, 1, 7, -6 },
                    { 0, -4, 10, -5, 1 }};
            Console.Write("Maximum Value is " +
                            findMaxValue(N, mat));
        }

        private static int findMaxValue(int n, int[,] mat)
        {
            
            //throw new NotImplementedException();

        }
    }
}
