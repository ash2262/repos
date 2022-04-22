using System;
using System.Collections.Generic;
namespace ArrayLeftRotations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrA = { 1, 2, 3, 4, 5 };
            int[] arrB = { 2, 3 };
            List<int> A = new List<int>();
            List<int> B = new List<int>();

            A = ConvertArrToList(arrA);
            B = ConvertArrToList(arrB);

            solve(A, B);
            
        }
        public static List<List<int>> solve(List<int> A, List<int> B)
        {

            List<List<int>> result = new List<List<int>>();
            for (int k = 0; k < B.Count; k++)
            {
                result.Add(leftRotate(A, A.Count, B[k]));
            }
            return result;
        }
        public static List<int> leftRotate(List<int> arr, int n, int k)
        {
            List<int> lstresult = new List<int>();
            for (int i = k; i < k + n; i++)
            {
                lstresult.Add(arr[(i % n)]);
                //Console.Write(arr[i % n] + " ");
            }
            return lstresult;
        }

        public static List<int> ConvertArrToList(int[] arr)
        {
            List<int> lst = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                lst.Add(arr[i]);
            }
            return lst;
        }
    }
}
