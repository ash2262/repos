using System;
using System.Collections.Generic;
namespace MockInterview2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(OneWayEdit("Edit", "Edot"));
            //Console.WriteLine(OneWayEdit("Edit", "Edt"));
            //Console.WriteLine(OneWayEdit("Edit", "Editr"));
            //Console.WriteLine(CheckDivisibility("12346456345654634634563456464946"));
            //Console.WriteLine(CheckDivisibility("3030300"));
            //Console.WriteLine(CheckDivisibility("2311"));
            Console.WriteLine(MatchWords("waterbottle","bottlewater"));
            Console.WriteLine(MatchWords("waterbottle", "bottlewator"));
            Console.WriteLine(MatchWordsImprovised("waterbottle", "bottlewater"));
            Console.WriteLine(MatchWordsImprovised("waterbottle", "bottlewator"));
        }
        public static bool OneWayEditImprovised(string Originalstr, string EditStr)
        {

        }
            public static bool MatchWordsImprovised(string Originalstr, string RotatedStr)
        {
            string concatStr = Originalstr + Originalstr;
            if (concatStr.Contains(RotatedStr))
                return true;
            else
                return false;
        }
        public static bool MatchWords(string Originalstr, string RotatedStr)
        {
            if (Originalstr.Length != RotatedStr.Length)
            {
                return false;
            }

            char[] originalchar = Originalstr.ToCharArray();
            Dictionary<char, int> dictOriginal = new Dictionary<char, int>();

            for (int i = 0; i < originalchar.Length; i++)
            {
               if( dictOriginal.ContainsKey(originalchar[i]))
                {
                    dictOriginal[originalchar[i]] = dictOriginal[originalchar[i]] + 1;
                }
                else
                {
                    dictOriginal.Add(originalchar[i] , 1);
                }
            }

            for (int i = 0; i < RotatedStr.Length; i++)
            {
                if (!dictOriginal.ContainsKey(RotatedStr[i]))
                {
                    return false;
                }
                else
                {
                    dictOriginal[RotatedStr[i]]= dictOriginal[RotatedStr[i]]-1;
                    if (dictOriginal[RotatedStr[i]] == 0)
                    {
                        dictOriginal.Remove(RotatedStr[i]);
                    }
                }
            }
            return true;
        }

        public static bool OneWayEdit(string Originalstr, string EditStr)
        {
            int ChangCount = 0;
            if (Originalstr.Length > EditStr.Length+1)
            {
                return false;
            }
            if (Originalstr.Length < EditStr.Length - 1)
            {
                return false;
            }
            if (Originalstr.Length < EditStr.Length )
            {
                ChangCount--;
            }
            if (Originalstr.Length == EditStr.Length - 1)
            {
                ChangCount++;
            }
            char[] originalchar = Originalstr.ToCharArray();
            Dictionary<char, int> dictOriginal = new Dictionary<char, int>();

            for (int i = 0; i < originalchar.Length; i++)
            {
                if (dictOriginal.ContainsKey(originalchar[i]))
                {
                    dictOriginal[originalchar[i]] = dictOriginal[originalchar[i]] + 1;
                }
                else
                {
                    dictOriginal.Add(originalchar[i], 1);
                }
            }

            for (int i = 0; i < EditStr.Length; i++)
            {
               
                if (!dictOriginal.ContainsKey(EditStr[i]))
                {
                    ChangCount++;
                    
                }
                if (ChangCount > 1)
                {
                    return false;
                }
                //else
                //{
                //    dictOriginal[RotatedStr[i]] = dictOriginal[RotatedStr[i]] - 1;
                //    if (dictOriginal[RotatedStr[i]] == 0)
                //    {
                //        dictOriginal.Remove(RotatedStr[i]);
                //    }
                //}

            }
            return true;
        }
        public static int CheckDivisibility(string A)
        {
            //codex

            
            string lastdigit = A.Substring(A.Length - 1, 1);
            int SumOfDigits = 0;

           

            if (int.Parse(lastdigit) != 0)
            {
                return 0;
            }
            else
            {
                
                for (int i = 1; i < A.Length; i++)
                {
                    SumOfDigits += int.Parse(A.Substring(A.Length - i, 1));

                }
                if (SumOfDigits % 3 != 0)
                {
                    return 0;
                }

            }
            return 1;
        }
    }
}
