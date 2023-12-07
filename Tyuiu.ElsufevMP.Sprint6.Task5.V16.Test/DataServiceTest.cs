using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.ElsufevMP.Sprint6.Task5.V16.Lib;

namespace Tyuiu.ElsufevMP.Sprint6.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //12, 5, 12.89, 35, 13.83, 12.76, 8.86
            string path = @"C:\Users\mihal\source\repos\Tyuiu.ElsufevMP.Sprint6\Tyuiu.ElsufevMP.Sprint6.Task5.V16\bin\Debug\InPutFileTask5V16.txt";
            DataService ds = new DataService();

            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 12, 5, 12.89, 35, 13.83, 12.76, 8.86 };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod11()
        {
            string path = @"C:\Users\mihal\source\repos\Tyuiu.ElsufevMP.Sprint6\Tyuiu.ElsufevMP.Sprint6.Task5.V16\bin\Debug\InPutFileTask5V16.txt";
            DataService ds = new DataService();

            double[] wait;
            wait = new double[7];

            wait[0] = 12;
            wait[1] = 5;
            wait[2] = 12.89;
            wait[3] = 35;
            wait[4] = 13.83;
            wait[5] = 12.76;
            wait[6] = 8.86;

            double[] res;
            res = new double[ds.len];
            res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(wait, res);

        }


            [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\mihal\source\repos\Tyuiu.ElsufevMP.Sprint6\Tyuiu.ElsufevMP.Sprint6.Task5.V16\bin\Debug\InPutFileTask5V16.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool Exist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, Exist);
        }
    }
}
