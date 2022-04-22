using System;

namespace maxsatisfaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int solve(ArrayList<Integer> A)
        {
            Collections.sort(A);
            int output = 1;
            int max = 0;
            int count = 0;
            for (int i = 0; i < A.size(); i++)
            {

                if ((GetMSB(A.get(i))) == 1)
                {
                    //max[i]=A.get(count);
                    //count++;

                    output = A.get(i);
                    // if(output>max)
                    // {
                    //     max=output;
                    // }
                    //output=max[i]&A.get(i);
                }
                //output=max;

            }
            return max;
        }
        public static int GetMSB(int intValue)
        {
            int[] binary = new int[35];
            int id = 0;
            //int countOne=1;

            while (intValue > 0)
            {
                binary[id++] = intValue % 2;
                intValue = intValue / 2;
            }
            return binary[31];
        }

    }
}
