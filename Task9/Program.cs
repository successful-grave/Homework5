using System;

namespace Task9
{
    //Отсортировать массив по возрастанию алгоритмом выборки (select)
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

            int index;
            for (int i = 0; i < size; i++)
            {
                index = i;
                for (int j = i; j < size; j++)
                {
                    if (massiv[j] < massiv[index])
                    {
                        index = j;
                    }
                }

                if (massiv[index] == massiv[i])
                    continue;

                int temp = massiv[i];
                massiv[i] = massiv[index];
                massiv[index] = temp;
            }

            Console.WriteLine("\nОтсортированный массив: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{massiv[i]}  ");
            }
        }
    }
}
