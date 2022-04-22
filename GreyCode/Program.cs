using System;
using System.Collections.Generic;
namespace GreyCode
{
    class Program
    {
        static void Main(string[] args)
        {
            solve(2);
        }
        public static List<int> solve(int A)
        {
            int n = A;
            List<int> result = new List<int>();
            result.Add(0);
            for (int i = 0; i < n; i++)
            {
                int curSize = result.Count;
                // push back all element in result in reverse order
                for (int j = curSize - 1; j >= 0; j--)
                {
                    result.Add(result[j] + (1 << i));
                }
            }
            return result;
        }
        
    }
}
