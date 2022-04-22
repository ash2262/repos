using System;
using System.Linq;

namespace RotationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


            int B;
            int N = 0;
            
            string inputB;
            
            string numberStr = Console.ReadLine().Trim(); // "1 2 3 1 2 3 1 2 ...."
                string[] splitted;
                if(numberStr.Contains(','))
                {
                     splitted = numberStr.Split(',');
                }
                else
                {
                    splitted = numberStr.Split(' ');
                }
            
            int[] A = new int[splitted.Length-1];

            for (int i = 0; i < splitted.Length-1; i++)
            {
                A[i] = int.Parse(splitted[i+1]);
            }
            
            inputB = Console.ReadLine();

            B = int.Parse(inputB);
           
            N = A.Length-1;
            if(B>N)
            {
                B = B % N;
            }
            reversePart(A, 0, N - 1);
            reversePart(A, 0, B - 1);
            reversePart(A, B, N - 1);

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]+" ");
            }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static int[]  swap(int i, int j, int[] A)
        {
            int temp = A[i];
            A[i]= A[j];
            A[j]= temp;
            return A;
        }
        public static int[] reversePart(int[] A, int start, int end)
        {
            while (start <= end)
            {
               A= swap(start, end, A);
                start++;end--;
            }
            return A;
        }
    }
}
