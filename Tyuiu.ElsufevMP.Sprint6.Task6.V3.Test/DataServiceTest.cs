using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint6.Task6.V3.Lib;

namespace Tyuiu.ElsufevMP.Sprint6.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\mihal\Desktop\Sprint6Task6\Sprint6Task6\InPutFileTask6V3";

            string res = ds.CollectTextFromFile(path);
            string wait = "rdRibhX swrfhvUjC raHsMtQF jiUFMDjMsEervIz";
            Assert.AreEqual(wait, res);
        }
    }
}
