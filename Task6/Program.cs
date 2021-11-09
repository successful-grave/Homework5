using System;

namespace Task6
{
    //Преобразовать массив так, чтобы на четных позициях стояли элементы с нечетных позиций, и наоборот.
    //Сделать за O(N/2).
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

            for (int i = 0; i < size; i += 2)
            {
                int tmp = massiv[i];
                massiv[i] = massiv[i + 1];
                massiv[i + 1] = tmp;
            }

            Console.WriteLine("\nИзменённый массив: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{massiv[i]}  ");
            }
        }
    }
}
