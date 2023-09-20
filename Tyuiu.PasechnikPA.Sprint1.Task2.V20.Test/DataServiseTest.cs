using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PasechnikPA.Sprint1.Task2.V20.Lib;

namespace Tyuiu.PasechnikPA.Sprint1.Task2.V20.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 2;
            int valuTwo = 3;
            var res = ds.CalculateSquaresSumm(value, valuTwo);
            Assert.AreEqual(13, res);
        }
    }
}
