using System;
using System.Collections.Generic;
using System.Linq;

namespace Find2ndLargest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int FindSecondLargest(int[] A)
        {
            int Max = int.MinValue;
            int SencondMax = int.MinValue;
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i]>Max)
                {
                    SencondMax = Max;
                    Max = A[i];
                }
            }
            return SencondMax;
        }

        public static bool FindDuplicate(string input)
        {//homework
            List<char> lst = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!lst.Contains(input[i])) { 
                lst.Add(input[i]);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static int FindLongestSubseq(int[] A)
        {

            //can use DP
            int maxcount = int.MinValue;
             Array.Sort(A);
            int count=1;
            for (int i = 0; i < A.Length-1; i++)
            {
                if (A[i + 1] == A[i] + 1)
                {
                    count++;
                    
                }
                else
                {
                    count = 1;
                }
                if (count > maxcount)
                {
                    maxcount = count;
                }
            }

            return maxcount;
        }

        public static string  ChangeURL(string inputString)
        {
            //HW
            if (inputString != null)
            {
                //Find out the length of the given string    
                int inputStringLength = inputString.Length;
                //Convert the given string into an array of type character    
                char[] inputCharacterSet = inputString.ToCharArray();

                //Find out the count of spaces within the input string     
                int spaceInStringCount = 0;
                for (int indexCount = 0; indexCount < inputStringLength; indexCount++)
                {
                    if (inputCharacterSet[indexCount] == ' ')
                    {
                        spaceInStringCount++;
                    }
                }

                // multiply the number of spaces with 2 to find out the extra space required to replace ' ' with '%20'    
                // for example if there is one ' ' space then we need two extra places     
                // the given string to add '%20'    
                int extraSpacesRequired = (spaceInStringCount * 2);
                //add extra spaces required to shift characters and replace ' ' with '%20'    
                inputCharacterSet = inputCharacterSet.Concat(new char[extraSpacesRequired]).ToArray();
                int inputCharacterSetCurrentIndex = inputStringLength - 1 + extraSpacesRequired;

                //iterate through the given string but note that start from the end and working backwards because    
                //we have added an extra buffer at the end, which allows us to change characters without worrying about what we're overwriting.    
                for (int inputIndex = inputStringLength - 1; inputIndex >= 0; inputIndex--)
                {
                    //if ' ' space found then replace ' ' with '%20'    
                    if (inputCharacterSet[inputIndex] == ' ')
                    {
                        inputCharacterSet[inputCharacterSetCurrentIndex--] = '0';
                        inputCharacterSet[inputCharacterSetCurrentIndex--] = '2';
                        inputCharacterSet[inputCharacterSetCurrentIndex--] = '%';
                    }
                    else
                    {
                        //if not found then shift current character by 2 places    
                        inputCharacterSet[inputCharacterSetCurrentIndex--] = inputCharacterSet[inputIndex];
                    }
                }
                Console.Write("Modified string is :");
                Console.WriteLine(inputCharacterSet);
                return inputCharacterSet.ToString();
            }
            return "";

        }


    }
    class GFG
    {
        //FindDuplicate HW

        static int NO_OF_CHARS = 256;

        /* Fills count array with
           frequency of characters */
        static void fillCharCounts(String str,
                                     int[] count)
        {
            for (int i = 0; i < str.Length; i++)
                count[str[i]]++;
        }

        /* Print duplicates present in
        the passed string */
        static void printDups(String str)
        {

            // Create an array of size 256 and
            // fill count of every character in it
            int[] count = new int[NO_OF_CHARS];
            fillCharCounts(str, count);

            for (int i = 0; i < NO_OF_CHARS; i++)
                if (count[i] > 1)
                    Console.WriteLine((char)i + ", " +
                                  "count = " + count[i]);
        }

        // Driver Method
        public static void Main()
        {
            String str = "test string";
            printDups(str);
        }
    }

}
