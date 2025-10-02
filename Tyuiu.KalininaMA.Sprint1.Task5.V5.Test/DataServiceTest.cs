﻿using Tyuiu.KalininaMA.Sprint1.Task5.V5.Lib;

namespace Tyuiu.KalininaMA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            double x = 32.597;
            var res = ds.Calculate(x);
            Assert.AreEqual(5, res);
        }
    }
}
