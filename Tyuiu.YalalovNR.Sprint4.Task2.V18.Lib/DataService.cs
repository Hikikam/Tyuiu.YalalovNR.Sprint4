using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YalalovNR.Sprint4.Task3.V18.Lib
{
    public class DataService : ISprint4Task3V18
    {
        public int Calculate (int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    product = product * array[i];
                }
            }
            return product;
        }
    }
}