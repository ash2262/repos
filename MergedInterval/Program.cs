using System;
using System.Collections.Generic;
namespace MergedInterval
{
    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            // int[,] InputMatrix1 = { { 1, 3 }, { 6,9 } };
            //int[,] InputMatrix1 = { { 1, 2 },{ 3, 6 }, { 5, 10 } };
            //int[,] InputMatrix1 = { { 1, 3 }, { 2, 6 }, { 8, 10 }, { 15, 18 } };
            //int[,] InputMatrix1 = { { 1, 10 }, { 2, 9 }, { 3, 8 }, { 4, 7 }, { 5, 6 }, { 6, 6 } };
            int[,] InputMatrix1 = { { 4, 100 }, { 48, 94 }, { 16, 21 }, { 58, 71 }, { 36, 53 }, { 49, 68 }, { 18, 42 }, { 37, 90 }, { 68, 75 }, { 6, 57 }, { 25, 78 }, { 58, 79 }, { 18, 29 }, { 69, 94 }, { 5, 31 }, { 10, 87 }, { 21, 35 }, { 1, 32 }, { 7, 24 }, { 17, 85 }, { 30, 95 }, { 5, 63 }, { 1, 17 }, { 67, 100 }, { 53, 55 }, { 30, 63 }, { 7, 76 }, { 33, 51 }, { 62, 68 }, { 78, 83 }, { 12, 24 }, { 31, 73 }, { 64, 74 }, { 33, 40 }, { 51, 63 }, { 17, 31 }, { 14, 29 }, { 9, 15 }, { 39, 70 }, { 13, 67 }, { 27, 100 }, { 10, 71 }, { 18, 47 }, { 48, 79 }, { 70, 73 }, { 44, 59 }, { 68, 78 }, { 24, 67 }, { 32, 70 }, { 29, 94 }, { 45, 90 }, { 10, 76 }, { 12, 28 }, { 31, 78 }, { 9, 44 }, { 29, 83 }, { 21, 35 }, { 46, 93 }, { 66, 83 }, { 21, 72 }, { 29, 37 }, { 6, 11 }, { 56, 87 }, { 10, 26 }, { 11, 12 }, { 15, 88 }, { 3, 13 }, { 56, 70 }, { 40, 73 }, { 25, 62 }, { 63, 73 }, { 47, 74 }, { 8, 36 } };
            List <Interval> inputList1 = new List<Interval>();


            for (int i = 0; i < InputMatrix1.GetLength(0); i++)
            {
                Interval Row = new Interval();
               // for (int j = 0; j < InputMatrix1.GetLength(1); j++)
                {
                    Row.start = InputMatrix1[i, 0];
                    Row.end = InputMatrix1[i, 1];
                    
                }
                inputList1.Add(Row);
            }

            List<Interval> output = new List<Interval>();
            
            output = solve(inputList1);   

            for (int j = 0; j < output.Count; j++)
            {
                Console.WriteLine( output[j]);
            }

        }

        public static List<Interval> solve(List<Interval> intervals)
        {
            intervals.Sort((first, second) =>
            {
                return first.start - second.start;
            });
            
            int start = intervals[0].start;
            int end = intervals[0].end;

            //int prevstart = int.MaxValue;
            //int prevend = int.MinValue;
            List<Interval> ans = new List<Interval>();
            int index = 0;  
            
            for (int j = 1; j < intervals.Count; j++)
            {
                Interval I = new Interval();
                if ((intervals[index].end >= intervals[j].start))
                    intervals[j].end = Math.Max(intervals[index].end, intervals[j].end);
                else
                {
                    index++;
                    intervals[index] = intervals[j];
                }
                for (int i = 0; i < index; i++)
                {
                    ans.Add(intervals[i]);
                }
                //    start = Math.Min(intervals[j].start, start);
                //else {
                //    start = int.MaxValue;
                //    start = Math.Min(intervals[j].start, start);
                //}

                
                //end = Math.Max(intervals[j].end, end);
                
                
                //    I.start=start;
                //    I.end = end;
                //if ((end != prevend)&& (start != prevstart))
                //    ans.Add(I);
                //prevstart = start;
                //prevend = end;
                
                    
                
            }

            return ans;

        }
    }
}
