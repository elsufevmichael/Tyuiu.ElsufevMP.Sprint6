using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint6.Task4.V29.Lib;

namespace Tyuiu.ElsufevMP.Sprint6.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            int len = stop - start + 1;

            double[] wait;
            wait = new double[len];

            wait[0] = -32.26;
            wait[1] = -27.5;
            wait[2] = -22.8;
            wait[3] = -17.95;
            wait[5] = -9;
            wait[6] = -0.31;
            wait[7] = 3.77;
            wait[8] = 8.57;
            wait[9] = 13.42;
            wait[10] = 18.28;
            wait[4] = -12.97;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
