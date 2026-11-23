using System;
using Tyuiu.YalalovNR.Sprint4.Task1.V3.Lib;
namespace Tyuiu.YalalovNR.Sprint4.Task1.V3
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

            Console.WriteLine("Введите 12 целых чисел (от 2 до 9):");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i + 1}-е число: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
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