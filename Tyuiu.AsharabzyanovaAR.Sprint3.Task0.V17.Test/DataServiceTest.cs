using Tyuiu.AsharabzyanovaAR.Sprint3.Task0.V17.Lib;

namespace Tyuiu.AsharabzyanovaAR.Sprint3.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = -0.709;

            Assert.AreEqual(res, wait);

        }
    }
}
