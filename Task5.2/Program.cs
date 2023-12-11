// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.
// Пример:
// 4 3 1  =>   4 6 2
// 2 6 9       2 6 9
// 4 6 2       4 3 1

using System;

class Program
{
    static void Main()
    {
        // Генерируем случайный двумерный массив
        int rows = 4;
        int columns = 3;
        int[,] array = GenerateRandomArray(rows, columns);

        // Выводим сгенерированный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Меняем местами первую и последнюю строку массива
        SwapRows(array, 0, rows - 1);

        // Выводим измененный массив
        Console.WriteLine("Массив после замены строк:");
        PrintArray(array);
    }

    // Метод для генерации случайного двумерного массива
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

    // Метод для обмена местами двух строк в двумерном массиве
    static void SwapRows(int[,] array, int row1, int row2)
    {
        int columns = array.GetLength(1);

        for (int j = 0; j < columns; j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
}
