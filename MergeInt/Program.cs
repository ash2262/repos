using System;
using System.Collections.Generic;
namespace MergeInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public List<Interval> merge(List<Interval> intervals)
        {
            List<int> ans = new List<int>();
            intervals.Sort((first, second) =>
            {
               return first.start - second.start;
            });
            for (int i = 1; i < intervals.Count; i++)
            {
                if (intervals[i - 1].end > intervals[i].start)
                {
                    Interval inter = new Interval();
                    inter.start = Math.Min(intervals[i].start, intervals[i - 1].start);
                    inter.end = Math.Max(intervals[i].end, intervals[i - 1].end);

                }
            }
        }
    }
    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }

}
