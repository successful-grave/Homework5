using System;

namespace Task7
{
    //В массиве из целочисленных элементов (включая отрицательные) вычислить:
    //а) минимальный по модулю элемент массива;
    //б) сумму элементов, расположенных после первого нулевого элемента (элемента, равного нулю).
    //Сделать одним проходом цикла!
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

            int minAbsoluteValueElement = massiv[0];
            int sum = 0;
            bool flag = false;
            for(int i = 0; i < size; i++)
            {
                if(Math.Abs(massiv[i]) < Math.Abs(minAbsoluteValueElement))
                {
                    minAbsoluteValueElement = massiv[i];
                }
                if(massiv[i] == 0)
                {
                    flag = true;
                }
                if(flag)
                {
                    sum += massiv[i];
                }
            }
            Console.WriteLine($"\nМинимальный по модулю элемент массива: {minAbsoluteValueElement}");
            Console.WriteLine($"Сумма элементов после первого нулевого элемента: {sum}");
        }
    }
}
