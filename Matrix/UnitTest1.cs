using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Matrices;

namespace Matrix
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCompareMatrix()
        {

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


            int[,] InputMatrix2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            List<List<int>> InputList2 = new List<List<int>>();

            for (int i = 0; i < InputMatrix2.GetLength(0); i++)
            {
                List<int> Row = new List<int>();
                for (int j = 0; j < InputMatrix2.GetLength(1); j++)
                {
                    Row.Add(InputMatrix2[i, j]);
                }
                InputList2.Add(Row);
            }

            
            var output = Program.CompareMatrices(inputList1, InputList2);

            Assert.AreEqual(output, 1);
        }
        [TestMethod]
        public void TestMatrixTranspose()
        {

            int[,] InputMatrix1 = {{21, 62, 16, 44, 55, 100, 16, 86, 29},
  {62, 72, 85, 35, 14, 1, 89, 15, 73},
  {42, 44, 30, 56, 25, 52, 61, 23, 54},
  {5, 35, 12, 35, 55, 74, 50, 50, 80},
  {2, 65, 65, 82, 26, 36, 66, 60, 1},
  {18, 1, 16, 91, 42, 11, 72, 97, 35},
  {23, 57, 9, 28, 13, 44, 40, 47, 98}};
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


            int[,] OutputMatrix = {{ 21, 62, 42, 5, 2, 18, 23, },{ 62,72,44,35,65,1,57,},{ 16,85,30,12,65,16,9,},{ 44,35,56,35,82,91,28,},{ 55,14,25,55,26,42,13,},{ 100,1,52,74,36,11,44,},{ 16,89,61,50,66,72,40,},{ 86,15,23,50,60,97,47,},{ 29,73,54,80,1,35,98,} };
            List<List<int>> ExpOutputList = new List<List<int>>();

            for (int i = 0; i < OutputMatrix.GetLength(0); i++)
            {
                List<int> Row = new List<int>();
                for (int j = 0; j < OutputMatrix.GetLength(1); j++)
                {
                    Row.Add(OutputMatrix[i, j]);
                }
                ExpOutputList.Add(Row);
            }

            var output = Program.MatrixTranspose(inputList1);

            CollectionAssert.AreEqual(ExpOutputList[0], output[0]);

        }
        [TestMethod]
        public void TestMatrixMultiplication()
        {
            int[,] InputMatrix1 = { { 1, 2 }, { 3, 4 } };

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

            int[,] OutputMatrix = { { 19, 22 },{ 43, 50 } };
            List<List<int>> ExpOutputList = new List<List<int>>();

            for (int i = 0; i < OutputMatrix.GetLength(0); i++)
            {
                List<int> Row = new List<int>();
                for (int j = 0; j < OutputMatrix.GetLength(1); j++)
                {
                    Row.Add(OutputMatrix[i, j]);
                }
                ExpOutputList.Add(Row);
            }

            var output = Program.MatrixMultiplication(inputList1,inputList2);

            CollectionAssert.AreEqual(ExpOutputList[0], output[0]);
        }
    }
}
