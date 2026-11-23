using System;
using Tyuiu.YalalovNR.Sprint4.Task4.V1.Lib;

namespace Tyuiu.YalalovNR.Sprint4.Task4.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = {
                { 2, 5, 1, 7, 5 },
                { 4, 4, 7, 4, 4 },
                { 7, 1, 6, 8, 8 },
                { 8, 1, 5, 8, 4 },
                { 8, 9, 1, 7, 3 }
            };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
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

            Console.WriteLine($"Сумма четных элементов = {res}");

            Console.ReadKey();
        }
    }
}