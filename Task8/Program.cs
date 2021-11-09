using System;

namespace Task8
{
    //Отсортировать массив по возрастанию алгоритмом вставок (insert).
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());
            int[] massiv = new int[size];

            Random rnd = new Random();

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < size; i++)
            {
                massiv[i] = rnd.Next(-10, 10);
                Console.Write($"{massiv[i]}  ");
            }

            for (int i = 1; i < size; i++)
            {
                for (int j = i; j > 0 && massiv[j - 1] > massiv[j]; j--)
                {
                    int tmp = massiv[j - 1];
                    massiv[j - 1] = massiv[j];
                    massiv[j] = tmp;
                }
            }
                

            Console.WriteLine("\nОтсортированный массив: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{massiv[i]}  ");
            }
        }
    }
}
