using Tyuiu.KalininaMA.Sprint1.Task7.V20.Lib;

namespace Tyuiu.KalininaMA.Sprint1.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1, y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(4.129, res);
        }
    }
}
