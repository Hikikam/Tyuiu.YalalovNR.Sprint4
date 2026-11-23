using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YalalovNR.Sprint4.Task1.V3.Lib;

namespace Tyuiu.YalalovNR.Sprint4.Task0.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMultEvenArrElTest()
        {
            DataService ds = new DataService();

            int[] array = { 4, 8, 8, 9, 6, 5, 3, 2, 9, 7, 7, 7 };

            int res = ds.Calculate(array);
            int wait = 3072; 

            Assert.AreEqual(wait, res);
        }
    }
}