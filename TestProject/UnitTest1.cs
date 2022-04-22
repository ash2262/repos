using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeparateOddEven;

namespace TestProject
{
    [TestClass]
    public class ConvertStringToArrayTest
    {
        [TestMethod]
        public void ConvertStringToArrayTestReturnsArray()
        {
            //Arrange
            //Program program = new SeparateOddEven.Program();
            string A = "1 2 3 1 2 3 1 2";
            //Act
            int[] arrA = { 1, 2, 3, 1, 2, 3, 1, 2 };
            var Result=Program.ConvertStringToArray(A);
            //Assert.AreEqual(Result.Length, 8);
            CollectionAssert.AreEqual(Result, arrA);
            //Assert.AreEqual(Result, arrA);
            //Assert
        }
    }
}
