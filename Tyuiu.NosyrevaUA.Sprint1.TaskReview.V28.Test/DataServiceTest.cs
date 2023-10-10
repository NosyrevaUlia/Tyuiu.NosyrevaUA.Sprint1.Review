using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint1.TaskReview.V28.Lib;

namespace Tyuiu.NosyrevaUA.Sprint1.TaskReview.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            double x = 3.5;
            double y = 5.34;
            double res = Math.Round(ds.Calculate(x, y), 3);
            Assert.AreEqual(res, 352.802);
            Assert.AreEqual(-1, Math.Round(ds.Calculate(0, 87), 3));
        }
    }
}
