﻿
using Tyuiu.KalininaMA.Sprint1.Task3.V19.Lib;

namespace Tyuiu.KalininaMA.Sprint1.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 2;
            double x2 = 4;
            double y1 = 3;
            double y2 = 1;
            var res = ds.ElephCanMove(x1, y1, x2, y2);
            Assert.AreEqual(res, true);
        }
    }
}
