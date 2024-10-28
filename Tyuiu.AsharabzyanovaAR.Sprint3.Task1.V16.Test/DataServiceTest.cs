﻿using Tyuiu.AsharabzyanovaAR.Sprint3.Task1.V16.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint3.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 0.7;
            int startValue = 1;
            int stopValue = 15;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 15.948;
            Assert.AreEqual(wait, res);

        }
    }
}
