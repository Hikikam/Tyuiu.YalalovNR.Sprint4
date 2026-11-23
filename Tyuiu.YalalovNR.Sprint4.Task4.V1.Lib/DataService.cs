using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YalalovNR.Sprint4.Task4.V1.Lib
{
    public class DataService : ISprint4Task4V1
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
    }
}