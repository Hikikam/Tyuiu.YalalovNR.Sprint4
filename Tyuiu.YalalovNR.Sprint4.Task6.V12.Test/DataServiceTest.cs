using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YalalovNR.Sprint4.Task6.V12.Lib;

namespace Tyuiu.YalalovNR.Sprint4.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();

            string[] array = { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };

            string[] res = ds.Calculate(array);
            string[] wait = { "Украина" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}