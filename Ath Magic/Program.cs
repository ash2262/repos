using System;

namespace Ath_Magic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solve(807414236, 3788, 38141)); 


        }
        public static int solve(int A, int B, int C)
        {
            long lcm = (long)B * C / gcd(B, C);
            long low = Math.Min(B, C), high = (long)Math.Min(B, C) * A, ans = 2;
            while (low <= high)
            {
                long mid = low + ((high - low) / 2);
                long cntb = mid / B;
                long cntc = mid / C;
                long cntbc = mid / lcm;

                if (cntb + cntc - cntbc >= A)
                {
                    ans = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return (int)(ans % 1000000007);
        }

        public int gcd(int B, int C)
        {
            if (B == 0)
                return C;

            return gcd(C % B, B);
        }

        public static int gcd(int B, int C)
        {
            if (B == 0)
                return C;

            return gcd(C % B, B);
        }
    }
}
