using System;
using Tyuiu.YalalovNR.Sprint4.Task3.V16.Lib;

namespace Tyuiu.YalalovNR.Sprint4.Task3.V16
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
                { 5, 8, 5, 8, 4 },
                { 2, 3, 4, 6, 3 },
                { 1, 1, 2, 9, 9 },
                { 6, 7, 4, 1, 2 },
                { 5, 7, 1, 8, 7 }
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

            Console.WriteLine($"Минимальный элемент в последнем столбце = {res}");

            Console.ReadKey();
        }
    }
}