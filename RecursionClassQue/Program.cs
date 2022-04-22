using System;

namespace RecursionClassQue
{
    class Program
    {
        static void Main(string[] args)
        {
           // string s;
            //s=Console.ReadLine().Trim();
            //reverseString(s);
            
                Console.WriteLine(solve(2, 2));
            
            
           // Console.WriteLine(findAthFibonacci(0));
            //int N = 10;
            //assumption is to print from 1 to N
            //string A = "racecar";
            //print(N);
           // Console.WriteLine(CheckPalindrom(A, 0, A.Length)); 
            //print1To10(10);
        }
        public static int solve(int A, int B)
        {
            if (A == 1 || B == 1) { return 0; }

            int pre = solve(A - 1, (B + 1) / 2);

            if (pre == 0)
            {
                if ((B & 1) == 1)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                if ((B & 1) == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

        }
        public static long pow(int a, int n,int p)
        {
            if (a == 0)
                return 0;
            if (n == 0)
                return 1;
           
            long he = pow(a, n/2,p);
            long ha = (he%p * he%p)%p;

            if (n % 2 == 0)
            {
                return ha;
            }
            else { 
                long ans = (ha % p * a % p) % p;
            if (ans < 0) return (ans + p) % p;
            else
                return (ha % p * a % p) % p;
            }
        }
        public static int AddDigits(int A)
        {
            if (A == 0)
                return 0;
            if(A>=10)
            {
                A= AddDigits(A % 10 + AddDigits(A / 10));
            }
            
            return A;

        }
        public static void reverseString(string s)
        {
            if (s.Length <= 1 || s == null)
            {
                Console.Write(s);
            }
            else
            {
                Console.Write(s[s.Length-1]);
                reverseString(s.Substring(0, s.Length - 1));
            }
        }
        public static void PrintReverse(string s)
        {
            
        }
        public static int findAthFibonacci(int A)
        {
            if (A == 0)
                return 0;
            if (A == 1 || A == 2)
                return 1;
            else
                return findAthFibonacci(A - 1) + findAthFibonacci(A - 2);
              
        }
        public static int FindFactorial(int A)
        {
            if (A == 1)
            return 1;
            
            else
            return (A* FindFactorial(A-1));
        }
            public static int CheckPalindrom(string str, int start, int end)
        { 
            if ((end == start)||(end-start==1))
            {
                return 1;
            }
            else
            {
                if (str[start] == str[end-1]) { 
                    return CheckPalindrom(str, start + 1, end - 1);
                }
                else
                {
                    return 0;
                }
                
            }

        }
        public static void print1To10(int N)
        {
            if (N>0)
                print1To10(N - 1);
            else
                return;
            Console.WriteLine( N); 
        }
        public static void  print(int N)
        {
            if (N == 0)
            {
                return;
            }
            if (N == 1)
            { 
                Console.WriteLine(1); return; 
            }
           
                Console.WriteLine(N);
            print(N-1);
        }
    }
}
