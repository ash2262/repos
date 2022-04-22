using System;

namespace CyclicallyRotateArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5 };
            Rotate(arr);
            PrintArray(arr);
            Console.ReadKey();
        }

        public static void Rotate(int[] arr)
        {
            int Temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Temp = arr[0];
                arr[0] = arr[i];
                arr[i] = Temp;
            }
        }
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            
        }
    }
}
