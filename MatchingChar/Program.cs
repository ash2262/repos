using System;
using System.Collections.Generic;

namespace MatchingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;
            //var A=int.Parse(Console.ReadKey().KeyChar.ToString());
            string[] input;
            string ip;
            ip = Console.ReadLine().Trim();
            input = ip.Split(' ');
            A = int.Parse( input[0]);
            B= int.Parse(input[1]);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            // Console.WriteLine(MatchingCharacters(Console.ReadLine()));
            if (A >= B)
            {
                Console.WriteLine(A);
            }
            else
            {
                Console.WriteLine(B);
            }
        }
        public static string MatchingCharacters(string str)
        {

            string output;
            HashSet<string> H = new HashSet<string>(); 
            H.Add(str);
            output = H.Count.ToString();
            return str;

        }

    }
}
