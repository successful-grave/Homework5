using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] massive = new int[arraySize];

            Random rnd = new Random();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = rnd.Next(-10, 10);
                Console.Write($"{massive[i]}  ");
            }

            for (int i = 2; i < arraySize; i += 3)
            {
                massive[i] = massive[i - 2] + massive[i - 1];
            }

            Console.WriteLine("\n\nИзменённый массив: ");
            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write($"{massive[i]}  ");
            }
        }
    }
}
