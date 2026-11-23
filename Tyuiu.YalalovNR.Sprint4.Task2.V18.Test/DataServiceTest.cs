using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YalalovNR.Sprint4.Task3.V18.Lib;

namespace Tyuiu.YalalovNR.Sprint4.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();

            
            int[,] array = { { 2, 4 }, { 8, 10 } };

            int res = ds.Calculate(array);
            int wait = 640; 

            Assert.AreEqual(wait, res);
        }
    }
}