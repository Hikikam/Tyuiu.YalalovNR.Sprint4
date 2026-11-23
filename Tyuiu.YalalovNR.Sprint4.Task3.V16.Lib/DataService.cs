using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YalalovNR.Sprint4.Task3.V16.Lib
{
    public class DataService : ISprint4Task3V16
    {
        public int Calculate(int[,] array)
        {
            int min = array[0, 4];
            for (int i = 1; i < array.GetLength(0); i++)
            {
                if (array[i, 4] < min)
                {
                    min = array[i, 4];
                }
            }
            return min;
        }
    }
}