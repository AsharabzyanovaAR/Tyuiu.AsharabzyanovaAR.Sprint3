using Tyuiu.AsharabzyanovaAR.Sprint3.Task6.V13.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint3.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 8;
            int stopValue = 17;
            int wait = 117;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
