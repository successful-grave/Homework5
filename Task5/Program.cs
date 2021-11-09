using System;

namespace Task5
{
    //Циклически двинуть массив вправо на 1 элемент.
    //Например: 1 2 3 4 5 -> 5 1 2 3 4.
    //А после этого сделать циклический сдвиг вправо на N элементов.
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

            int[] secondMassiv = new int[size];
            //cдвиг на 1 элемент вправо
            for (int i = size - 1; i >= 0; i--)
            {
                if (i + 1 >= size)
                {
                    secondMassiv[i + 1 - size] = massiv[i];
                }
                else
                {
                    secondMassiv[i + 1] = massiv[i];
                }
            }
            Console.WriteLine("\nМассив сдвинут на 1 элемент вправо: ");
            for(int i = 0; i < size; i++)
            {
                Console.Write($"{secondMassiv[i]}  ");
            }

            //сдвиг на N элементов вправо
            Console.Write("\nВведите кол-во элементов, на которое необходимо сдвинуть массив: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = size - 1; i >= 0; i--)
            {
                if (i + N >= size)
                {
                    secondMassiv[i + N - size] = massiv[i];
                }
                else
                {
                    secondMassiv[i + N] = massiv[i];
                }
            }
            Console.WriteLine($"\nМассив сдвинут на {N} элемента вправо: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{secondMassiv[i]}  ");
            }
        }
    }
}
