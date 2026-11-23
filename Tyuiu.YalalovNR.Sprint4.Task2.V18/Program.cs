using System;
using Tyuiu.YalalovNR.Sprint4.Task2.V18.Lib;

namespace Tyuiu.YalalovNR.Sprint4.Task2.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[12];
            Random rnd = new Random();

            Console.Write("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2, 9);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

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