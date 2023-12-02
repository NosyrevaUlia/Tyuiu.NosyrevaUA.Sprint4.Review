using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint4.TaskReview.V27.Lib;

namespace Tyuiu.NosyrevaUA.Sprint4.TaskReview.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            string str = "583197256891";
            DataService ds = new DataService();
            int res = ds.Calculate(4, 3, str);
            Assert.AreEqual(4, res);
        }
    }
}
