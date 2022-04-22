using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrices;
using System;
using System.Collections.Generic;
using System.Text;
using Matrices;

namespace Matrices.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void solveTest()
        {
            int B = 2;
            int[,] InputMatrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            List<List<int>> inputList1 = new List<List<int>>();

            for (int i = 0; i < InputMatrix1.GetLength(0); i++)
            {
                List<int> Row = new List<int>();
                for (int j = 0; j < InputMatrix1.GetLength(1); j++)
                {
                    Row.Add(InputMatrix1[i, j]);
                }
                inputList1.Add(Row);
            }


            int[,] OutputMatrix = { {2, 4, 6}, {8, 10, 12}, {14, 16, 18} };
            List<List<int>> ExpOutputList= new List<List<int>>();

            for (int i = 0; i < OutputMatrix.GetLength(0); i++)
            {
                List<int> Row = new List<int>();
                for (int j = 0; j < OutputMatrix.GetLength(1); j++)
                {
                    Row.Add(OutputMatrix[i, j]);
                }
                ExpOutputList.Add(Row);
            }

            Assert.AreEqual(ExpOutputList[0],Program.solve(inputList1,B));
        }

        [TestMethod]
        public void TestMinorDiagonalSum()
        {

            int[,] InputMatrix1 = { { 1, -2, -3 }, { -4, 5, -6 }, { -7, -8, 9 } };
            List<List<int>> inputList1 = new List<List<int>>();

            for (int i = 0; i < InputMatrix1.GetLength(0); i++)
            {
                List<int> Row = new List<int>();
                for (int j = 0; j < InputMatrix1.GetLength(1); j++)
                {
                    Row.Add(InputMatrix1[i, j]);
                }
                inputList1.Add(Row);
            }

            Assert.AreEqual(-5, Program.MinorDiagonalSum(inputList1));
        }
    }
}