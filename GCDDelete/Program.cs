using System;
using System.Collections.Generic;
namespace GCDDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] Arr = { 12, 15, 18 };
            int[] Arr = {89,208610688,48106344,135402124,34168992,95013776,35218040,117231114,172905590,66652014,45970782,222323244,203402914,35292972,159829956,154584716,107190226,71335264,42786172,203327982,3484338,28062034,64179258,210993,94938844,155858560,123562868,223447224,116744056,55711942,88082566,45671054,16072914,165299992,136601036,44659472,219063702,202953322,188341582,116931386,127759060,131318330,49867246,92278758,40875406,218314382,135889182,6893744,97111872,56236466,96662280,52340002,195010530,44884268,167435554,155746162,201679478,54138370,103481092,25814074,186093622,208498290,31883566,122101694,128058788,133566290,55749408,178675354,186056156,155071774,35180574,82050540,7755462,29448276,100333948,130156884,67850926,44509608,17084496,216703344,197295956,174479162,18058612,51290954,173917172,51815478,218426780,184032992,148140564,108951128,
};
            List<int> A = new List<int>(Arr);
            Console.WriteLine(solve(A));
            Console.ReadKey();
        }
        public static int solve(List<int> A)
        {
            int maxgcd = 0;

            List<int> PFSumGCD = new List<int>();
            PFSumGCD.Add(A[0]);
            for (int i = 1; i < A.Count; i++)
            {

                int gcd = GCD(A[i-1], A[i]);
                PFSumGCD.Add(gcd);
            }

            List<int> SFGCD = new List<int>();

            for (int i = 0; i < A.Count; i++)
            {
                SFGCD.Add(0);
            }
            SFGCD[A.Count - 1] = A[A.Count - 1];
            
            for (int i = A.Count - 2; i >=0 ; i--)
            {
                SFGCD[i] = GCD(SFGCD[i + 1], A[i]);
            }
            maxgcd = SFGCD[1];
            int left = 0, right=0;
            for (int i = 1; i < A.Count; i++)
            {
                if (i == A.Count - 1)
                {
                    maxgcd = Math.Max(maxgcd, PFSumGCD[A.Count - 2]);
                }
                else{
                    left = PFSumGCD[i - 1];
                    right = SFGCD[i + 1];
                    maxgcd = Math.Max(maxgcd, GCD(left, right));
                }
                
            }

            return maxgcd;
        }

        public static int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
    }
}
