using Tyuiu.KalininaMA.Sprint1.Task6.V12.Lib;

namespace Tyuiu.KalininaMA.Sprint1.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string value = "вот так вот";
            DataService ds = new DataService();
            bool res = ds.CheckLastWordRepetiton(value);
            Assert.IsTrue(res);
        }
    }
}
