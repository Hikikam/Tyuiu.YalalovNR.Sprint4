using System;
using Tyuiu.YalalovNR.Sprint4.Task7.V17.Lib;

namespace Tyuiu.YalalovNR.Sprint4.Task7.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int n = 3;
            int m = 3;
            string value = "753159864";

            Console.WriteLine($"Строка: {value}");
            Console.WriteLine($"Размерность матрицы: {n}x{m}");

            int res = ds.Calculate(n, m, value);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Количество четных чисел = {res}");

            Console.ReadKey();
        }
    }
}