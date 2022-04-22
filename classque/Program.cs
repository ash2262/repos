using System;
using System.Collections.Generic;
using System.Text;

namespace classque
{

    class Program
    {
        static void Main(string[] args)
        {
            //moore's voting algo

            

            int[] arrA = { 472, 663, 964, 722, 485, 852, 635, 4, 368, 676, 319, 412 };
            List<int> A = new List<int>(arrA);
            Console.WriteLine(LargestNumber(A));
            // List<int> A = new List<int>(arrA);
            Console.WriteLine(ReverseString(" I am as clever as you are "));
            //Console.WriteLine(NobleInteger(A)); 


            int[] arr = { 1000040, 1000459, 1000930, 1000040, 1000040, 1000301, 1000280, 1000106, 1000787, 1000040, 1000696, 1000378, 1000836, 1000040 };
            List<int> a = new List<int>(arr);


            int ele1 = a[0];
            int ele2 = a[0];
            int freq1 = 1;
            int freq2 = 1;

            int count1 = 0;
            int count2 = 0;

            for (int i = 1; i < a.Count; i++)
            {
                if (freq1 == 0 && a[i] != ele2) { ele1 = a[i]; freq1 = 1; }
                else if (a[i] == ele1)
                {

                    freq1++;
                }
                else if (freq2 == 0) { ele2 = a[i]; freq2++; }
                else if (a[i] == ele2) { freq2++; }
                else { freq1--; freq2--; }
            }

            for (int i = 0; i < a.Count; i++)
            {
                if (ele1 == a[i]) { count1++; }
                else if (ele2 == a[i]) { count2++; }
            }
            if (count1 > a.Count / 3)
                Console.WriteLine(ele1);
            else if (count2 > a.Count / 3)
            {
                Console.WriteLine(ele2);
            }
            else
                Console.WriteLine(-1);

        }
        
        public static int EleRemoval(List<int> A)
        {
            
            A.Reverse();
            int cost = 0;
            for (int i = 0; i < A.Count; i++)
            {
                cost += A[i] * (i + 1);
            }
            return cost;
        }
        public static string LargestNumber(List<int> A)
        {

            string output = string.Empty;
            
            A.Sort((x, y) => (x.ToString() + y.ToString()).CompareTo(y.ToString() + x.ToString()));
            

            A.Reverse();
          
            output = string.Join("", A);
            if (long.Parse(output) == 0)
            {
                return "0";
            }

                return output;

        }
        
        public static int AP(List<int> A)
        {
            if (A.Count < 2)
            {
                return 0;
            }
            int[] arrA = A.ToArray();
            Array.Sort(arrA);
            int diff = arrA[1]- arrA[0];
            for (int i = 0; i < arrA.Length-1; i++)
            {
                if (arrA[i + 1] - arrA[i] != diff)
                {
                    return 0;
                }
            }
            return 1;
        }
        public static string ReverseString(string A)
        {
            int i = 0;
            int j = A.Trim().Length - 1;
            string result=string.Empty;
            char[] Achar = new char[j];
            int count = 0;
            //for (int k = 0; k < A.Length; k++)
            //{
            //    Achar[k] = A[k];
            //}
            Achar =A.Trim().ToCharArray() ;
            while (i < j)
            {
               
               Achar= swap(i, j, Achar);
                i++;j--;
            }

            for (int m = 0; m < Achar.Length; m++)
            {
                if(Achar[m]!=' ')
                {
                    count++;
                }
                else
                {
                    Achar = swap(m - (count ), m-1,Achar);
                    count = 0;
                }
                

            }

            for (int k = 0; k < Achar.Length; k++)
            {
                result += A[k].ToString();
                
            }
            result = new string(Achar.ToString());
            return result.Trim();
        }
        public static char[] swap(int i, int j, char[] A)
        {
            char temp = A[i];
            A[i] = A[j];
            A[j] = temp;
            return A;

        }
        public List<int> repeatedNumber(List<int> A)
        {
            long rep_num = 0;
            long miss_num = 0;
            long curr_sum = 0;
            long act_sum = ((long)A.Count)*(A.Count + 1) / 2;
            long curr_sq_sum = 0;
            long act_sq_sum = 0;
            List<int> result = new List<int>();
            for (int j = 0; j < A.Count; j++)
            {
                curr_sum += (long)A[j];
            }

            for (int i = 0; i < A.Count; i++)
            {
                curr_sq_sum += ((long)A[i]) * A[i];
            }

            for (long k = 1; k <= A.Count; k++)
            {
                act_sq_sum += k * k;
            }

            long val1 = (act_sq_sum - curr_sq_sum) / (act_sum - curr_sum);
            long val2 = act_sum - curr_sum;

            miss_num = (val1 + val2) / 2;
            rep_num = miss_num - val2;
            result.Add((int)rep_num);
            result.Add((int)miss_num);

            //return new int[] { (int)rep_num, (int)miss_num };
            return result;


        }

        public string ChangeCase(string S)
        {
            char[] schar = S.ToCharArray();
           // StringBuilder newstr;
            //newstr.Append(S);
            
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] <= 'Z' && S[i] >= 'a')
                {
                    char c = (char)(schar[i] - 32);
                    schar[i] = c;
                }
                else
                {
                    char c = (char)(schar[i] + 32);
                    schar[i] = c;
                }
            }
            return schar.ToString();
        }
        public int solve(int A)
        {

            int pow = 1;
            int cnt = 0;
            int ans = 0;
            // Go through every bit of n

            while (A != 0)
            {
                pow = pow * 5;
                // If last bit of n is set

                if ((int)(A & 1) == 1)
                {
                    ans += pow;
                }

                A >>= 1;
            }
            return ans;
        }
        
        public static int NobleInteger(List<int> A)
        {
            A.Sort();
            int N = A.Count;
            if ((A[0] == 0) && (N == 1))
            {
                return 1;
            }
            for (int i = 0; i < N - 1; i++)
            {
               
                if (A[N - 1] == 0)
                {
                    return 1;
                }
                if ((A.Count - (i + 1) == A[i]) && (A[i + 1] != A[i]))
                    return 1;
            }
            return -1;
        }
    }
}
