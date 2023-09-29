using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PasechnikPA.Sprint1.Task7.V13.Lib;

namespace Tyuiu.PasechnikPA.Sprint1.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double wait = 15.312;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
