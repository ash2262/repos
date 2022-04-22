using System;
using System.Collections.Generic;
namespace TowerOfHanoi
{
    class Program
    {
        public static List<List<int>> output = new List<List<int>>();
        static void Main(string[] args)
        {

            towerOfHanoi(2);
           // towerOfHanoi(3);
            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
        public static List<List<int>> towerOfHanoi(int A)
        {
            
            TOH(A, 1, 2, 3);
            return output;
        }
        public static void  TOH(int n, int s, int h, int d)
        {
            if (n == 0) return;
            TOH(n - 1, s, d, h);
            List<int> lst = new List<int>();
            lst.Add(n);
            lst.Add(s);
            lst.Add(d);
            output.Add(lst);
            
            TOH(n - 1, h, s, d);
        }
    }
}
