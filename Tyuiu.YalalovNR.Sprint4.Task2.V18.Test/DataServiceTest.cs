using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YalalovNR.Sprint4.Task3.V18.Lib;

namespace Tyuiu.YalalovNR.Sprint4.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMultEvenArrElTest()
        {
            DataService ds = new DataService();
            int[] array = { 2, 5, 4, 7, 8, 3, 6, 2, 5, 8, 4, 2 };
            int res = ds.Calculate(array);
            int wait = 24576;
            Assert.AreEqual(wait, res);
        }
    }
}