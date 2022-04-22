using System;
using System.Collections.Generic;
using System.Numerics;

namespace _2sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // int[] arr = { 1, 1000000000 };
            //tc1
            string[] arr = { "hello", "scaler", "interviewbit" };
            string B = "adhbcfegskjlponmirqtxwuvzy";
            //tc2
            //string[] arr = { "fine", "none", "no" };
            //string B = "qwertyuiopasdfghjklzxcvbnm";
            //tc3
            //string[] arr = { "ipial", "qjqgt", "vfnue", "vjqfp", "eghva", "ufaeo", "atyqz", "chmxy", "ccvgv", "ghtow" };
            //string B = "nbpfhmirzqxsjwdoveuacykltg";


            List<string> A = new List<string>(arr);
            int OP;
            OP = twoSum(A,B);

            
                Console.WriteLine(OP);
            
        }
        public static int twoSum(List<string> A, string B)
        {
            Dictionary<char, int> hm = new Dictionary<char, int>();
            for (int i = 0; i < 26; i++)
            {
                hm[B[i]] = i;

            }

            Vector<string> vec ;
            List<string> lst = new List<string>();

            for(int i=1;i<A.Count;i++)
            {
                string item = A[i];
                string s=string.Empty;

                if (item.Length < A[i - 1].Length)
                {
                    return 0;
                }
                else { 
                    for(int k = 0; k < item.Length; k++)
                    {
                       // for (int a = 0; a < lst[j].Length; a++)
                        {
                            var itemkletter = hm[item[k]];
                            var previtemkLetter = hm[A[i - 1][k]];
                            if (itemkletter<previtemkLetter)
                            {
                                return 0;
                            }
                        }

                        // s += hm[item[k]];
                    }
                }
                //lst.Add(s);
                
            }

            //for (int j = 1; j < lst.Count; j++)
            //{

            //    if (lst[j - 1].Length > lst[j].Length)
            //    {
            //        return 0;
            //    }
            //    else
            //    {

            //        for (int a = 0; a < lst[j].Length; a++)
            //        {
            //            if (lst[j][a] < lst[j - 1][a])
            //            {
            //                return 0;
            //            }
            //        }
            //    }

            //}

            return 1;
        }
    }
}
