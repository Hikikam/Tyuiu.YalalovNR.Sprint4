using System;
using Tyuiu.YalalovNR.Sprint4.Task6.V12.Lib;

namespace Tyuiu.YalalovNR.Sprint4.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] array = { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };

            Console.WriteLine(string.Join(", ", array));

            string[] res = ds.Calculate(array);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            foreach (string item in res)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}