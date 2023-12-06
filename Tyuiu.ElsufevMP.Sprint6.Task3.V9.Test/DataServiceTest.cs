using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint6.Task3.V9.Lib;

namespace Tyuiu.ElsufevMP.Sprint6.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5]
            {
                { -14, 25, 26, 18, 17 },
                { 28, 10, 6, -2, 4 },
                { 30, 25, -3, 11, -10 },
                { 11, 32, -5, -20, 25},
                { 2, -18, 11, 8, -20}
            };

            int[,] res = ds.Calculate(mas);
            int[,] wait = 
            {
                { -14, 25, 26, 18, -20 },
                { 28, 10, 6, -2, -10 },
                { 30, 25, -3, 11, 4 },
                { 11, 32, -5, -20, 17},
                { 2, -18, 11, 8, 25}
            };

            Assert.AreEqual(wait, res);
        }
    }
}
