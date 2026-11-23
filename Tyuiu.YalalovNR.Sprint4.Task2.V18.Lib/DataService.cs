using System;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.YalalovNR.Sprint4.Task3.V18.Lib
{
    public class DataService : ISprint4Task3V18
    {
        public int Calculate(int[,] array)
        {
            int product = 1;
            foreach (int item in array)
            {
                if (item % 2 == 0) product *= item;
            }
            return product; 
        }
    }
}