using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YalalovNR.Sprint4.Task7.V17.Lib;

namespace Tyuiu.YalalovNR.Sprint4.Task7.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 3;
            string value = "753159864";

            int res = ds.Calculate(n, m, value);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}