using System;

namespace Task4
{
    //Поменять местами первую и вторую половину массива,
    //например, для массива 1 2 3 4, результат 3 4 1 2,  или для 1 2 3 4 5 - 4 5 1 2 3
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());
            int[] massiv = new int[size];

            Random rnd = new Random();

            Console.WriteLine("Исходный массив: ");
            for(int i = 0; i < size; i++)
            {
                massiv[i] = rnd.Next(-10, 10);
                Console.Write($"{massiv[i]}  ");
            }

            for(int i = 0; i < size/2; i++)
            {
                int tmp = massiv[i];
                massiv[i] = massiv[size / 2 + i];
                massiv[size / 2 + i] = tmp;
            }

            Console.WriteLine("Изменённый массив: ");
            for(int i = 0; i < size; i++)
            {
                Console.Write($"{massiv[i]}  ");
            }
        }
    }
}
