using System;
using System.IO;
using System.Linq;

namespace NationalInstru
{
    class Program
    {
        static void Main(string[] args)
        {

            String line;
            line = Console.ReadLine();
            int N = Convert.ToInt32(line);
            line = Console.ReadLine();
            int[] H = new int[N];
            H = line.Split().Select(str => int.Parse(str)).ToArray();
            line = Console.ReadLine();
            int A = Convert.ToInt32(line);
            line = Console.ReadLine();
            int B = Convert.ToInt32(line);
            line = Console.ReadLine();
            int Q = Convert.ToInt32(line);
            line = Console.ReadLine();
            int[] K = new int[Q];
            K = line.Split().Select(str => int.Parse(str)).ToArray();

            int[] out_ = solve(N, H, A, B, Q, K);
            Console.Out.WriteLine(string.Join(" ", out_.Select(x => x.ToString()).ToArray()));
        }
        static int[] solve(int N, int[] H, int A, int B, int Q, int[] K)
        {

                int[] ans = new int[Q];
            
                for (int i = 0; i < Q; i++)
                {
                    int pos = 0;
                    int count = 0;
                    int k = K[i];
                    int Bflag = 0;
                    while (pos<k)
                    {
                        if ((pos > k)&&(Bflag==0))
                        {
                            pos = pos - B;
                            Bflag = 1;
                        }
                        
                    //int dist = pos + A;
                        //int maxdist = Math.Max(pos + A, pos + B);
                        //int mindist = Math.Min(pos + A, pos + B);
                        if (pos <= k)
                        {
                        if (!H.Contains(pos + A) && (pos + A <= k))
                        {
                            pos = pos + A;
                            count++;
                            Bflag = 0;
                        }
                        else if (Bflag == 0)
                        {
                            //pos = pos + A;
                            pos = pos - B;
                            Bflag = 1;
                        }
                        else { 
                            count = -1;
                            break;
                        }


                    }
                    }
                    if (count == int.MaxValue)
                        count = -1;
                    ans[i] = count;
                }


                return ans;

        }
    }
}

