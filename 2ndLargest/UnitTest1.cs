using Microsoft.VisualStudio.TestTools.UnitTesting;
using Find2ndLargest;

namespace _2ndLargest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSecondMax()
        {
            int[] input = { 2, 3, 4, 5, 1, 10, 19, 21 };
            int ExpectedOutput = 19;

            var output = Program.FindSecondLargest(input);
            Assert.AreEqual(ExpectedOutput, output);
        }

        [TestMethod]
        public void TestDuplicate()
        {
            string input = "abcdefghija";
            // bool ExpectedOutput = false;

            Assert.IsFalse(Program.FindDuplicate(input));
        }

        [TestMethod]

        public void TestFindLongestSubseq()
        {
            int[] input = { 1, 11, 4, 5, 6, 7, 8, 9, 10, 45, 46, 47 };
            int ExpectedOutput = 8;

            var output = Program.FindLongestSubseq(input);
            Assert.AreEqual(ExpectedOutput, output);
        }

    }
}
