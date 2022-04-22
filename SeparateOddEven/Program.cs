using System;
using System.IO;
using System.Collections.Generic;
namespace SeparateOddEven
{
   public class Program
    {
        public static void Main(string[] args)
        {
            List<List<int>> OutLst = new List<List<int>>();

            int TC = int.Parse(Console.ReadLine());
            for (int i = 0; i < TC; i++)
            {
                int Length = int.Parse(Console.ReadLine());
                string numberStr = Console.ReadLine().Trim(); // "1 2 3 1 2 3 1 2 ...."

                int[] arrayInt = ConvertStringToArray(numberStr);
                int N = arrayInt.Length;
                List<int> OddLst = new List<int>();
                List<int> EvenLst = new List<int>();

                for (int k = 0; k < N; k++)
                {
                    if (arrayInt[k] % 2 == 0)
                    {
                        EvenLst.Add(arrayInt[k]);
                    }
                    else
                    {
                        OddLst.Add(arrayInt[k]);
                    }
                

                }
                OutLst.Add(OddLst);
                OutLst.Add(EvenLst);
                
            
            }
            Print(OutLst);
        }
        public static void Print(List<List<int>> outlst)
        {
            string output=null;
            for (int i= 0;i < outlst.Count;i++)
            {
                for(int j=0;j<outlst[i].Count;j++)
                {
                    output = output + " " + outlst[i][j];
                    //Console.Write(outlst[i][j]+" ");
                }
                Console.WriteLine(output);
                output = null;
            }
            
        }
        public static int[] ConvertStringToArray(string numberStr)
        {
            
            string[] splitted;
            if (numberStr.Contains(","))
            {
                splitted = numberStr.Split(',');
            }
            else
            {
                splitted = numberStr.Split(' ');
            }
            //int N = int.Parse(splitted[0]);
            //int[] arrayInt = new int[N];
            int[] result = new int[splitted.Length];
            for (int j = 0; j < splitted.Length; j++)
            {
                result[j] = int.Parse(splitted[j]);
            }
            return result;
        }
    }
}
