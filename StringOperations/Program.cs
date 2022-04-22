using System;
using System.Text;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine().Trim());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = rows; j >= i; j--)
                {
                    Console.Write("*");
                }
                //Console.Write("*");//print star
                for (int j = 1; j <= (i - 1) * 2; j++)
                {
                    Console.Write(" ");
                }
                for (int j = rows; j > i; j--)
                {
                    Console.Write("*");
                }
                if (i == 1)
                {
                    Console.Write("*\n");//move to next line
                }
                else
                {
                   
                    Console.Write("*\n");
                }
            }

            for (int i = rows; i >=1; i--)
            {
                for (int j = rows; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.Write("*");//print star
                for (int j = 1; j <= (i - 1) * 2; j++)
                {
                    Console.Write(" ");
                }
                for (int j = rows; j > i; j--)
                {
                    Console.Write("*");//print space
                }
                if (i == 1)
                {
                    Console.Write("*\n");//move to next line
                }
                else
                {

                    Console.Write("*\n");
                }
            }






            //for (int i = 0; i <= n; i++)
            //{
            //    for (int j = 0; j < (n*2 - i); j++)
            //        Console.Write("*");
            //    for (int j = 1; j <= i; j++)
            //        Console.Write(" ");
            //    for (int k = 1; k < i; k++)
            //        Console.Write(" ");
            //    Console.WriteLine();
            //}

            //for (int i = n - 1; i >= 0; i--)
            //{
            //    for (int j = 0; j <= (n*2 - i); j++)
            //        Console.Write("*");
            //    for (int j = 1; j <= i; j++)
            //        Console.Write(" ");
            //    for (int k = 1; k < i; k++)
            //        Console.Write(" ");
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //  Console.WriteLine(CountOccurence("rbobobbobljzjdbobbobpncbobobobadbobvlrrbobmypibobbqiycbobdcpbobybobgjqgbobuccboboybobmbobocdqbobaxrbobbobobyoqibobpenibatdbbobenbobxkabobdbobmbobpcynbobpobobqubobfbabobobbjzkdqbobqbobtubobbobnbobbobobbobbobzgtmrbobjbobbobbobbobrtgzrdvlzuuupvjfnbobobtumxfsysdbobbobobkgbobmijpboburbobfsbbobwwksebobhxbobnybobobobebobzrmbobbobbobjbobobsbobabobbcbobzsrswatwbobbobobvbobbobmrnnbobhbob"));
        }

        public static int CountOccurence(string A)
        {
            //StringBuilder sb = new StringBuilder();
            //sb = A;
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A.IndexOf("bob") >= 0)
                {
                    A = A.Substring(i + A.IndexOf("bob") + 2, A.Length - (i + A.IndexOf("bob") + 2));
                    //i = i + A.IndexOf("bob");
                    i = 0;
                    count++;
                }
            }
            return count;

        }
        public static string solve(string A)
        {
            
            StringBuilder sb = new StringBuilder();
            

            for (int i = 0; i < A.Length; i++)
            {
                if(A[i]>='a'&& A[i] <= 'z')
                {
                    if (A[i] == 'a' || A[i] == 'e' || A[i] == 'i' || A[i] == 'o' || A[i] == 'u' || A[i] == 'A' || A[i] == 'E' || A[i] == 'I' || A[i] == 'O' || A[i] == 'U')
                    {
                        sb.Append('#');
                    }
                    else
                    {
                        sb.Append(A[i]);
                    }
                        
                    
                }
               
            }
            sb.Append(sb);
            return sb.ToString();
        }
    }
}
/*Q4. String operations
            Akash likes playing with strings. One day he thought of applying following operations on the string in the given order:

Concatenate the string with itself.
Delete all the uppercase letters.
Replace each vowel with '#'.
You are given a string A of size N consisting of lowercase and uppercase alphabets. Return the resultant string after applying the above operations.

NOTE: 'a' , 'e' , 'i' , 'o' , 'u' are defined as vowels.



Problem Constraints

1<=N<=100000


Input Format

First argument is a string A of size N.



Output Format

Return the resultant string.



Example Input

A="AbcaZeoB"



Example Output

"bc###bc###"



Example Explanation

First concatenate the string with itself so string A becomes "AbcaZeoBAbcaZeoB".
Delete all the uppercase letters so string A becomes "bcaeobcaeo".
Now replace vowel with '#'.
A becomes "bc###bc###".

*/