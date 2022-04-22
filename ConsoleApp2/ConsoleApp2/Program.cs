using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "sunday";
            string t = "saturday";
            EditDistance(s, t);
            Console.ReadKey();

        }
        static void EditDistance(string s, string t)
        {
            int n = 0;
            int count = 0;
            if (s.Length > t.Length)
            {
                n = s.Length-1;
            }
            else
            {
                n = t.Length-1;
            }

            for (int i = 0; i < n; i++)
            {
                if (s[i] != t[i + count])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

