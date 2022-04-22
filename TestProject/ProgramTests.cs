using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matrices.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TestMatrixMultiplication()
        {
            //Assert.Fail();

            int[,] InputMatrix1 = { { 1, 2 }, {3,4 } };
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

            int[,] InputMatrix2 = { { 5, 6 }, { 7, 8 } };
            List<List<int>> inputList2 = new List<List<int>>();

            for (int i = 0; i < InputMatrix2.GetLength(0); i++)
            {
                List<int> Row = new List<int>();
                for (int j = 0; j < InputMatrix2.GetLength(1); j++)
                {
                    Row.Add(InputMatrix2[i, j]);
                }
                inputList2.Add(Row);
            }
            var output = Program.MatrixMultiplication(inputList1, inputList2);
            
        }
    }
}