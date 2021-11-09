using System;

namespace Task1
{
    class Program
    {
        // Посчитать количества нечетных и четных элементов массива.
        // Не путать с нечетными и четными индексами.
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] massive = new int[arraySize];
            int evenElement = 0;
            int oddElement = 0;
            Random rnd = new Random();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = rnd.Next(-10, 10);
                if(massive[i] % 2 == 0)
                {
                    evenElement++;
                }
                else
                {
                    oddElement++;
                }
                Console.Write($"{massive[i]}  ");
            }
            Console.WriteLine($"\nКолличество чётных элементов: {evenElement}");
            Console.WriteLine($"Колличество нечётных элементов: {oddElement}");
        }
    }
}
