using Tyuiu.AsharabzyanovaAR.Sprint3.Task3.V2.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint3.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "asdzzz vfvfzz v gthvz";
            char chr = 'z';
            int wait = 3;
            int res = ds.GetMaxCharCount(str, chr);
            Assert.AreEqual(wait, res);

        }
    }
}
