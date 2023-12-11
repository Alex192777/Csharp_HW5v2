// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Пример:
// 4 3 1 (1,2) => 9
// 2 6 9


using System;


class Program
{
    static void Main()
    {
        // Генерируем случайный двумерный массив
        int rows = 3;
        int columns = 4;
        int[,] array = GenerateRandomArray(rows, columns);

        // Выводим сгенерированный массив
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(array);

        // Запрашиваем у пользователя позицию элемента
        Console.Write("Введите позицию элемента (строка столбец): ");
        string positionInput = Console.ReadLine();
        string[] position = positionInput.Split(' ');

        // Проверяем, что введено два числа
        if (position.Length == 2)
        {
            // Получаем строку и столбец из введенной позиции
            int row = int.Parse(position[0]);
            int column = int.Parse(position[1]);

            // Проверяем, что введенные позиции находятся в допустимом диапазоне
            if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
            {
                // Получаем значение элемента по указанным позициям
                int element = array[row, column];
                Console.WriteLine($"Значение элемента: {element}");
            }
            else
            {
                Console.WriteLine("Указанный элемент не существует.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод позиции элемента.");
        }
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
}