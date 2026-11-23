using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YalalovNR.Sprint4.Task5.V19.Lib
{
    public class DataService : ISprint4Task5V19
    {
        public int Calculate(int[,] array)
        {
            int count = 0;
            foreach (int item in array)
            {
                if (item > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}