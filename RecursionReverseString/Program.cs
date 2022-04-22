using System;
using System.Text;

namespace RecursionReverseString
{
    class Program
    {

        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine().ToString();

            int N = s.Length;

            reverse(s);
        }
        static void reverse(String str)
        {
            if ((str == null) || (str.Length <= 1))
                Console.Write(str);

            else
            {
                Console.Write(str[str.Length - 1]);
                reverse(str.Substring(0, (str.Length - 1)));
            }
        }
    }
}
