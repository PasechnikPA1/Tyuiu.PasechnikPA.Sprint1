using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PasechnikPA.Sprint1.Task3.V13.Lib;

namespace Tyuiu.PasechnikPA.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double number = 123;
            double wait = 6;
            var res = ds.MultiplyOfDigits(number);
            Assert.AreEqual(wait, res);
        }
    }
}
