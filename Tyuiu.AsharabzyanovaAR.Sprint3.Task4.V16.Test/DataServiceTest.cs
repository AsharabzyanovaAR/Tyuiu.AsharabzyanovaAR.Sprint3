using System.Transactions;
using Tyuiu.AsharabzyanovaAR.Sprint3.Task4.V16.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint3.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            double wait = 6.719;
            Assert.AreEqual(wait, res);

        }
    }
}
