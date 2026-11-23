using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YalalovNR.Sprint4.Task5.V19.Lib;

namespace Tyuiu.YalalovNR.Sprint4.Task5.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();

            int[,] array = {
                { 1, -2, 3, 0, -1 },
                { 2, 3, -2, 1, 0 },
                { -1, 0, 2, 3, 1 },
                { 3, 1, 0, -2, 2 },
                { 0, -1, 3, 1, 2 }
            };

            int res = ds.Calculate(array);
            int wait = 16;

            Assert.AreEqual(wait, res);
        }
    }
}