using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PasechnikPA.Sprint1.Task5.V4.Lib;

namespace Tyuiu.PasechnikPA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int time = 17999;
            DataService ds = new DataService();
            double res = ds.SecondsToHours(time);

            int result = Convert.ToInt32(res);

            int wait = 4;
            Assert.AreEqual(wait, result);
        }
    }
}
