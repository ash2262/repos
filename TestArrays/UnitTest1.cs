using Microsoft.VisualStudio.TestTools.UnitTesting;
using Arrays;

namespace TestArrays
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStrictlySmallGreat()
        {
            int[] nums = { -3,3,3,90 };
            Assert.AreEqual( 2, Program.CountElements(nums));
        }
    }
}
