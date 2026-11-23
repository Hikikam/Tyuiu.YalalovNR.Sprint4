using System;
using Tyuiu.YalalovNR.Sprint4.Task3.V18.Lib;

namespace Tyuiu.YalalovNR.Sprint4.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            
            int[,] array = { { 2, 4, 6, 8 }, { 3, 5, 7, 9 }, { 2, 4, 6, 8 } };

            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            int res = ds.Calculate(array);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Произведение четных элементов = {res}");

            Console.ReadKey();
        }
    }
}