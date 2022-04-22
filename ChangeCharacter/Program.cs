using System;
using System.Collections.Generic;
namespace ChangeCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "qghumeaylnlfdxfircvscxggbwkfnqduxwfnfozvsrtkjprepggxrpnrvystmwcysyycqpevikeffmznimkkasvwsrenzkycxfxtlsgypsfadpooefxzbcoejuvpvaboygpoeylfpbnpljvrvipyamyehwqnqrqpmxujjloovaowuxwhmsncbxcoksfzkvatxdknlyjyhfixjswnkkufnuxxzrzbmnmgqooketlyhnkoaugzqrcddiuteiojwayyzpvscmpsajlfvgubfaaovlzylntrkdcpwsrtesjwhdizcobzcnfwlqijtvdwvxhrcbldvgylwgbusbmborxtlhcsmpxohgmgnkeufdxotogbgxpeyanfetcukepzshkljugggekjdqzjenpevqgxiepjsrdzjazujllchhbfqmkimwzobiwybxduunfsksrsrtekmq";

            Console.WriteLine(solve(A,119));
        }
        public static int solve(string A, int B)
        {
            
            Dictionary<char,int> hm= new Dictionary<char, int>();
            int min = int.MaxValue;
            for (int i = 0; i < A.Length; i++)
            {
                if (hm.ContainsKey(A[i]))
                {
                    hm[A[i]]++;
                }
                else
                {
                    hm.Add(A[i], 1);
                }
            }

            while (B > 0) {
                var minkey=char.MinValue;
                foreach(var item in hm)
                {
                    if (min > item.Value)
                    {
                        min = item.Value;
                        minkey = item.Key;
                    }

                }

               
                if ((min > 0)&& (B - min >= 0)){
                   
                    B = B - min;
                    hm.Remove(minkey);
                    min = int.MaxValue;
                }
            }

            return hm.Count ;
        }
    }
}
