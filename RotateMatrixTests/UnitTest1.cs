using Microsoft.VisualStudio.TestTools.UnitTesting;
using RotateMatrix;
using System;
using System.Collections.Generic;
namespace RotateMatrixTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] InputMatrix1 = { {1,2,3},{ 4, 5,6 }, { 7, 8, 9 } };
            int[,] InputMatrix2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

            int[,] ExpectedOutput = { { 10, 10,10 }, { 10,10,10 }, { 10, 10, 10 } };

            var output = Program.RotateMatrix(InputMatrix1, InputMatrix2);

            CollectionAssert.AreEqual(ExpectedOutput,output);
        }
        [TestMethod]
        public void TestRotateMatrixList()
        {

            //int[,] InputMatrix2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

            //int[,] ExpectedOutput = { { 10, 10, 10 }, { 10, 10, 10 }, { 10, 10, 10 } };
            int[,] InputMatrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            List<List<int>> inputList1 = new List<List<int>>();
            
            for(int i = 0; i < InputMatrix1.GetLength(0); i++)
            {
                List<int> Row = new List<int>();
                for (int j = 0; j < InputMatrix1.GetLength(1); j++)
                {
                    Row.Add(InputMatrix1[i, j]);
                }
                inputList1.Add(Row);
            }


            int[,] InputMatrix2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
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


            
            List<List<int>> OutputList = new List<List<int>>();
            OutputList= Program.AddMatrix(inputList1, inputList2);

            int[,] ExpectedarrMatrix = { { 10, 10, 10 }, { 10, 10, 10 }, { 10, 10, 10 } };
            List<List<int>> ExpectedMatrixList = new List<List<int>>();

            for (int i = 0; i < ExpectedarrMatrix.GetLength(0); i++)
            {
                List<int> Row = new List<int>();
                for (int j = 0; j < ExpectedarrMatrix.GetLength(1); j++)
                {
                    Row.Add(ExpectedarrMatrix[i, j]);
                }
                ExpectedMatrixList.Add(Row);
            }

           // int[,] ExpectedOutput = { { 10, 10, 10 }, { 10, 10, 10 }, { 10, 10, 10 } };

            CollectionAssert.AreEqual(ExpectedMatrixList, OutputList);
        }

        [TestMethod]
        public void TestColumnAdd()
        {

            int[,] InputMatrix1 = { { 1, 2, 3,4 }, { 5, 6,7,8 }, { 9,2,3,4 } };
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

           

            int[] Expectedoutput = {  15, 10, 13,16  };

            var Output = Program.AddMatrixColumn(inputList1);

            CollectionAssert.AreEqual(Expectedoutput, Output);
        }

        [TestMethod]
        public void TestMatrixTranspose()
        {

            int[,] InputMatrix1 = {{24, 63, 39, 81, 84, 30},
  {21, 64, 95, 6, 88, 73},
  {33, 6, 63, 96, 86, 66},
  {62, 88, 23, 52, 94, 77},
  {81, 58, 74, 18, 16, 25},
  {26, 40, 88, 64, 72, 23},
  {45, 44, 86, 92, 50, 26},
  {64, 34, 83, 26, 29, 68},
  {43, 42, 7, 17, 45, 52},
  {94, 25, 62, 19, 95, 77},
};
            List<List<int>> A = new List<List<int>>();

            for (int i = 0; i < InputMatrix1.GetLength(0); i++)
            {
                List<int> Row = new List<int>();
                for (int j = 0; j < InputMatrix1.GetLength(1); j++)
                {
                    Row.Add(InputMatrix1[i, j]);
                }
                A.Add(Row);
            }

            var Output = Program.TransposeMatrix(A);

            int[,] ExpectedarrMatrix = { { 24, 21, 33, 62, 81, 26, 45, 64, 43, 94 }, { 63, 64, 6, 88, 58, 40, 44, 34, 42, 25 }, { 39, 95, 63, 23, 74, 88, 86, 83, 7, 62 }, { 81, 6, 96, 52, 18, 64, 92, 26, 17, 19 }, { 84, 88, 86, 94, 16, 72, 50, 29, 45, 95 }, { 30, 73, 66, 77, 25, 23, 26, 68, 52, 77 } } ;
            List<List<int>> ExpectedMatrixList = new List<List<int>>();

            for (int i = 0; i < ExpectedarrMatrix.GetLength(0); i++)
            {
                List<int> Row = new List<int>();
                for (int j = 0; j < ExpectedarrMatrix.GetLength(1); j++)
                {
                    Row.Add(ExpectedarrMatrix[i, j]);
                }
                ExpectedMatrixList.Add(Row);
            }
            CollectionAssert.AreEqual(Output[0], ExpectedMatrixList[0]);
        }

        [TestMethod]
        public void TestRowSumMatrix()
        {

            int[,] InputMatrix1 = { {1,2,3,4} ,{5,6,7,8},{9,2,3,4} };
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

            var output = Program.AddMatrixRows(inputList1);


            int[] ExpectedarrMatrix = { 10, 26, 18 };
            List<int> ExpectedMatrixList = new List<int>();


            for (int j = 0; j < ExpectedarrMatrix.Length; j++)
            {
            ExpectedMatrixList.Add(ExpectedarrMatrix[j]);
            }
            CollectionAssert.AreEqual(output, ExpectedMatrixList);
        }
           
        
    }
}
