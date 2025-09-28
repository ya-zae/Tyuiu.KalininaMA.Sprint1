﻿using Tyuiu.KalininaMA.Sprint1.Task1.V22.Lib;

namespace Tyuiu.KalininaMA.Sprint1.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(3, res);
        }
    }
}
