using System;
using Tyuiu.YalalovNR.Sprint4.Task5.V19.Lib;
namespace Tyuiu.YalalovNR.Sprint4.Task5.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[5, 5];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rnd.Next(-2, 4);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            int res = ds.Calculate(array);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Количество положительных элементов = {res}");

            Console.ReadKey();
        }
    }
}