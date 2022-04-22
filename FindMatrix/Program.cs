using System;

namespace FindMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 0;
            int cols = 0;
            int[,] a = new int[3, 4] {
                                       {0, 1, 2, 3} ,   /*  initializers for row indexed by 0 */
                                       {4, 5, 6, 7} ,   /*  initializers for row indexed by 1 */
                                       {8, 9, 10, 11}   /*  initializers for row indexed by 2 */
                                    };
            rows = a.GetLength(0) - 1;
            cols = a.GetLength(1) - 1;
            BinarySearch(a, 2, rows, cols);
            Console.ReadKey();
        }

        private static void BinarySearch(int[,] a, int v, int rows, int cols)
        {
            int low = rows;

            int high = (rows * cols) - 1;



            while (low <= high)
            {
                int Mid = (low + (high - low) / 2);

                if (a[Mid / 4, Mid % 4] == v)
                {
                    Console.WriteLine("the number is at " + a[Mid / 4, Mid % 4]);
                    break;
                }
                else if (a[Mid / 4, Mid % 4] < v)
                {
                    low = Mid + 1;
                }
                else if (a[Mid / 4, Mid % 4] > v)
                {
                    high = Mid - 1;
                }
            }
        }
    }
}
