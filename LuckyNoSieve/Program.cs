using System;

namespace LuckyNoSieve
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(solve(12));
            Console.ReadKey();
        }
        
        public static bool[] isprime;
        public static int solve(int A)
        {
            sieve();  //create array indicating whether that number is prime or not
            int[] cnt = new int[50001];
            for (int i = 0; i < 50001; i++) cnt[i] = 0;

            for (int i = 1; i <= A; i++)
            {
                for (int j = 1; j * j <= i; j++)
                {
                    // Check to increment count of distinct primes
                    if (i % j == 0)
                    {
                        if (isprime[j])
                        {
                            cnt[i]++;
                        }
                        if ((i / j) != j && isprime[i / j])
                        {
                            cnt[i]++;
                        }
                    }

                }
            }
            int ans = 0;
            for (int i = 1; i <= A; i++)
                if (cnt[i] == 2)               // Increment count for every lucky num
                    ans++;
            return ans;

        }
        public static void sieve()
        {

            //Sieve of Eratosthenes
            isprime = new bool[50001];
            for (int i = 0; i < 50001; i++) isprime[i] = true;
            isprime[1] = false;
            for (long i = 2; i <= 50000; i++)
            {
                if (isprime[(int)i])
                    for (long j = i * i; j <= 50000; j += i)
                        isprime[(int)j] = false;
            }
        }

    }
}
