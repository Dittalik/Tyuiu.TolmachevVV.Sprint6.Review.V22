using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint6.Review.V22.Lib;

namespace Tyuiu.TolmachevVV.Sprint6.Review.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataSerivce serivce = new DataSerivce();
        [TestMethod]
        public void MatrixCalculationTest()
        {
            int[,] testMatrix = { { 1, 2, 3 },
                                  { 1, 2, 3 },
                                  { 1, 2, 3 } };
            Assert.AreEqual(2, serivce.CalculateMatrix(testMatrix, -3, 3, 0, 1, 1));
        }
        [TestMethod]
        public void MatrixGetTest()
        {
            int[,] matrix = serivce.GetMatrix(-10, 10, 10, 10);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j % 2 == 0)
                    {
                        Assert.IsTrue(matrix[i, j] > 0);
                    }
                    else
                    {
                        Assert.IsTrue(matrix[i, j] < 0);
                    }
                }
            }
        }
    }
}
