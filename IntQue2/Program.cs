using System;

namespace IntQue2
{
    class Program
    {
        static void Main(string[] args)
        {
            //homework 
            string input = "abcd";

            Console.WriteLine(Permutation(input,0,input.Length-1));
            int ip= 630;
            primeFactor(ip);

        }
        public static string  Permutation(string s, int l, int r)
        {
            if (l == r)
                Console.WriteLine( s);
            for (int i = l; i <= r; i++)
            {
                s = swap(s, l, i);
                Permutation(s, l + 1, r);
                s = swap(s, l, i);
            }
            return s.ToString();

        }
        public static string swap(string s, int l, int i)
        {
            
            char[] charArray = s.ToCharArray();
            char temp=charArray[i];

            charArray[i] = charArray[l];
            charArray[l] = temp;
            string str = new string(charArray);
            return str;
        }
        public static void primeFactor(int n)
        {
            for (int i = 2; i < n/2; i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine(i);
                    n = n / i;
                }
            }
        }

    }
}
