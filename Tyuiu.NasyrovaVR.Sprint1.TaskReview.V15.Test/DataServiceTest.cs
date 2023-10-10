using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NasyrovaVR.Sprint1.TaskReview.V15.Lib;

namespace Tyuiu.NasyrovaVR.Sprint1.TaskReview.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            double x = 2;
            var res = ds.Calculate(x);
            Assert.AreEqual(5.266, res);
        }
    }
}
