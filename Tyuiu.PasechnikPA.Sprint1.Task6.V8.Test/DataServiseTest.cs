using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PasechnikPA.Sprint1.Task6.V8.Lib;

namespace Tyuiu.PasechnikPA.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiseTest 
    {
        [TestMethod]
        public void TestMethod1()
        {
            string value = "hello";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(value);
            string wait = "helloh";
            Assert.AreEqual(wait, res);

        }
    }
}
