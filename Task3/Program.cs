using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер первого массива: ");
            int sizeOfFirstArray = int.Parse(Console.ReadLine());
            Console.Write("Введите размер второго массива: ");
            int sizeOfSecondArray = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            int[] firstArray = new int[sizeOfFirstArray];
            Console.WriteLine("\nПервый массив:");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = rnd.Next(-10, 10);
                Console.Write($"{firstArray[i]}  ");
            }

            int[] secondArray = new int[sizeOfSecondArray];
            Console.WriteLine("\nВторой массив:");
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = rnd.Next(-10, 10);
                Console.Write($"{secondArray[i]}  ");
            }

            int[] thirdArray = new int[sizeOfFirstArray + sizeOfSecondArray];
            firstArray.CopyTo(thirdArray, 0);
            secondArray.CopyTo(thirdArray, sizeOfFirstArray);

            Console.WriteLine("\nОбъединённый массив:");
            for (int i = 0; i < thirdArray.Length; i++)
            {
                Console.Write($"{thirdArray[i]}  ");
            }
        }
    }
}
