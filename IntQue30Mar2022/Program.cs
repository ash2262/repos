using System;

namespace IntQue30Mar2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hi! Please reverse me word by word";
            Console.WriteLine(ReverseString(str));
        }
        public static string ReverseString(string str)
        {
            char[] strToChar=str.ToCharArray();
            Array.Reverse(strToChar);

            

            for (int i = 0; i < strToChar.Length; i++)
            {
                int endindex
                char[] word=str.Substring(i,)
            }
            //string reversedstr = reverse(strToChar).ToString();
            //return reversedstr;
        }
        public static string reverse(char[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                char temp = str[i];
                str[i] = str[str.Length - i];
                str[str.Length - i] = temp;
            }
            return str.ToString();
        }
    }
}
