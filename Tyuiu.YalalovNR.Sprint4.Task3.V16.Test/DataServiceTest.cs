using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YalalovNR.Sprint4.Task3.V16.Lib;

namespace Tyuiu.YalalovNR.Sprint4.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();

            int[,] array = {
                { 5, 8, 5, 8, 4 },
                { 2, 3, 4, 6, 3 },
                { 1, 1, 2, 9, 9 },
                { 6, 7, 4, 1, 2 },
                { 5, 7, 1, 8, 7 }
            };

            int res = ds.Calculate(array);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}