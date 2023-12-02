using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint6.Task2.V11.Lib;

namespace Tyuiu.ElsufevMP.Sprint6.Task2.V11.Test
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

            wait[0] = -15.44;
            wait[1] = -10.93;
            wait[2] = -7.22;
            wait[3] = -5.04;
            wait[4] = 0;
            wait[5] = -0.3;
            wait[6] = 2.57;
            wait[7] = 6.4;
            wait[8] = 10.04;
            wait[9] = 12.72;
            wait[10] = 14.68;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
