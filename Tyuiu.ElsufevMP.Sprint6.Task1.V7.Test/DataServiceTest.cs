using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint6.Task1.V7.Lib;

namespace Tyuiu.ElsufevMP.Sprint6.Task1.V7.Test
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

            wait[0] = 7.76;
            wait[1] = 7.36;
            wait[2] = 7.26;
            wait[3] = 7.90;
            wait[4] = 15.88;
            wait[5] = 2;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
