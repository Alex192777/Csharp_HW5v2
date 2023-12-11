// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
// Пример:
// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2 

using System;

class Program
{
    static void Main()
    {
        // Генерируем случайный прямоугольный двумерный массив
        int rows = 4;
        int columns = 3;
        int[,] array = GenerateRandomArray(rows, columns);

        // Выводим сгенерированный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Находим строку с наименьшей суммой элементов
        int minRowIndex = FindRowWithMinSum(array);

        // Выводим результат
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex}");
    }

    // Метод для генерации случайного прямоугольного двумерного массива
    static int[,] GenerateRandomArray(int rows, int columns)
    {
        Random random = new Random();
        int[,] array = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(10);
            }
        }

        return array;
    }


    // Метод для вывода двумерного массива на экран
    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    } 
 

    // Метод для нахождения строки с наименьшей суммой элементов
    static int FindRowWithMinSum(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        int minRowSum = int.MaxValue;
        int minRowIndex = -1;

        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;

            for (int j = 0; j < columns; j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minRowSum)
            {
                minRowSum = rowSum;
                minRowIndex = i;
            }
        }

        return minRowIndex;
    }
}
