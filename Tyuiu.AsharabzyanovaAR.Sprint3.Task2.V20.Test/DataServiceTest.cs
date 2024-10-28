using Tyuiu.AsharabzyanovaAR.Sprint3.Task2.V20.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint3.Task2.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stopValue = 6;

            double wait = 914700.94;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(wait, res);
            
        }
    }
}
