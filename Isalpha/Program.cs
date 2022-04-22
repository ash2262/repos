using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
namespace Isalpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //char[] A = { 'S', 'c', 'a', 'L', 'e', 'R', '#', '2', '0', '2', '0' };
            //List<char> lst = new List<char>(A);
            //List<char> op = new List<char>();
            //op = to_upper(lst);
            //foreach(var item in op) { 
            string input = "scaler";
            Console.WriteLine(ReverseString(input));
            Console.ReadKey();
            //}
        }

        public static string ReverseString(string A)
        {
            StringBuilder sb = new StringBuilder();
            char[] arr = A.ToCharArray();
            int n = arr.Length - 1;
            for (int i = 0; i <= n / 2; i++)
            {
                char c = arr[i];
                arr[i] = arr[n -  i];
                arr[n - i ] = c;
            }
            
            return new string(arr);
        }
            public static List<char> to_upper(List<char> A)
        {
            int ascii = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if(A[i]<='Z' && A[i] >= 'A')
                {
                    ascii = A[i];
                    char c=(char) (ascii + 32);
                    A[i] =c;
                }
            }
            return A;
        }
        public static int solve(List<char> A)
        {
            for (int i = 0; i < A.Count; i++)
            {
                    if (!Regex.IsMatch(A[i].ToString(), @"^[a-zA-Z0-9]+$"))
                {
                    return 0;
                }
            }


            return 1;
        }
    }
}
